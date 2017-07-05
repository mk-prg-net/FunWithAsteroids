using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// Linq erfordet immer die Einbindung von System.Linq mittels using
using System.Linq;
using System.Diagnostics;

using System.Threading.Tasks;
using System.Collections.Concurrent;

using AsteroidsBL;

namespace AsteroidsDAL.CSV.Test
{
    [TestClass]
    public class AsteroidsDAL_CSV
    {
        ConcurrentQueue<AsteroidsBL.IAsteroid> queue = new ConcurrentQueue<AsteroidsBL.IAsteroid>();
        System.Threading.EventWaitHandle Ampel = new System.Threading.EventWaitHandle(false, System.Threading.EventResetMode.AutoReset);

        [TestInitialize]
        public void Init()
        {
            queue = new ConcurrentQueue<AsteroidsBL.IAsteroid>();

            // Startet Task, der regelmäßig die gefilterten 
            // Asteroiden aus einer mulithrad- resistenten Queue
            // abruft.
            Task.Run(() =>
            {
                AsteroidsBL.IAsteroid a;
                while (!queue.TryDequeue(out a))
                {
                    Debug.Write(".");
                    System.Threading.Thread.Sleep(200);
                }
                    
                Debug.WriteLine("1. Asteroid eingelesen");

                while (!queue.TryDequeue(out a))
                {
                    Debug.Write(".");
                    System.Threading.Thread.Sleep(200);
                }                    
                Debug.WriteLine("2. Asteroid eingelesen");

                Ampel.Set();

            });
        }

        [TestMethod]
        public async Task AsteroidsDAL_CSV_ReadCSV()
        {
            // 1. Stufe: Einlesen der Asteroiden aus der CSV- Datei 
            //    und erfassen im Sammler  
            var collector = new AsteroidsCollector();
            try
            {
                var reader = new AsteroidsCSVReader("Asteroids.csv", 2);
                while (!reader.EOF)
                {
                    var asteroid = reader.Read();
                    collector.Add(asteroid);                    
                }

                Assert.IsTrue(collector.Count > 0);

                // 2. Stufe: Aus gesammelten Asteroiden ein
                //           Repository formen.
                var repository = collector.CreateRepository();

                // 3. Abfragen auf dem Repository formulieren und ausführen
                var qbld = repository.GetNewQueryBuilder();

                qbld.MinDiameterInKm = 10.0;
                qbld.MaxDiameterInKm = 50.0;

                var res = qbld.GetFilteredSortedSet();
                Assert.IsTrue(res.All(r => r.DiameterInKm >= 10.0 && r.DiameterInKm <= 50.0));

                var SortBld = qbld.GetSortOrderBuilder();

                SortBld.OrderByDiameterAsc = true;

                var resSorted = SortBld.GetFilteredSortedSet();

                Assert.IsTrue(resSorted.First().DiameterInKm > resSorted.Last().DiameterInKm);


                var resSorted2 = qbld.GetFilteredSortedSet(sb => sb.OrderByDiameterAsc = true);

                var resAsync = await qbld.GetFilteredSortedSetAsync();
                Assert.IsTrue(resAsync.All(r => r.DiameterInKm >= 10.0 && r.DiameterInKm <= 50.0));

                await qbld.EnqueueFilteredInAsync(queue);

                Ampel.WaitOne();

            }
            catch (Exception ex)
            {
                Assert.Fail();
            }
        }
    }
}
