using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// Linq erfordet immer die Einbindung von System.Linq mittels using
using System.Linq;
using System.Diagnostics;

using System.Threading.Tasks;
using System.Collections.Concurrent;

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
            //while(!queue.IsEmpty)
            //{
            //    AsteroidsBL.IAsteroid a;
            //    queue.TryDequeue(out a);
            //}

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
            var repository = new AsteroidsRepository(2000);
            int i = 0;
            try
            {
                var reader = new AsteroidsCSVReader("Asteroids.csv", 2);
                while (!reader.EOF)
                {
                    var asteroid = reader.Read();
                    repository.Add(asteroid);
                    i++;
                }

                Assert.IsTrue(repository.All.Count() > 0);

                var qbld = repository.GetNewQueryBuilder();

                qbld.MinDiameterInKm = 10.0;
                qbld.MaxDiameterInKm = 50.0;

                var res = qbld.GetFilteredSortedSet();
                Assert.IsTrue(res.All(r => r.DiameterInKm >= 10.0 && r.DiameterInKm <= 50.0));

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
