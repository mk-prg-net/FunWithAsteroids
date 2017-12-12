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
            // Asteroiden aus einer mulithread- resistenten Queue
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
            AsteroidsBL.IAsteroidsCollector collector = new AsteroidsCollector();
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

                // 4. Definition der Sortierreihenfolgen
                var SortBld = qbld.GetSortOrderBuilder();

                SortBld.OrderByDiameterAsc = true;

                // Gefilterte und Sortierte Menge als IFilteredSortedSet Objekte abrufen
                var fsSet = SortBld.GetFilteredSortedSet();
                Assert.IsTrue(fsSet.Any());

                // Zugrif auf die einzelnen Elemente
                var elems = fsSet.Get();
                Assert.IsTrue(elems.First().DiameterInKm > elems.Last().DiameterInKm);


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
