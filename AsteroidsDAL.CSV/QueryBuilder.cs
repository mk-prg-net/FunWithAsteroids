using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsteroidsBL;

namespace AsteroidsDAL.CSV
{
    public class QueryBuilder : AsteroidsBL.IQueryBuilder
    {
        ParallelQuery<Asteroid> query;

        public QueryBuilder(IEnumerable<Asteroid> asteroids)
        {
            query = asteroids.AsParallel(); //.Where(r => r.DiameterInKm >= 20.0);
        }

        public double MaxDiameterInKm
        {
            set
            {
                query = query.Where(r => r.DiameterInKm <= value);
            }
        }

        public double MinDiameterInKm
        {
            set
            {
                query = query.Where(r => r.DiameterInKm >= value);
            }
        }

        public bool OrderByDiameterAsc
        {
            set
            {
                throw new NotImplementedException();
            }
        }

        public int Skip
        {
            set
            {
                query = query.Skip(value);
            }
        }
        

        public int Take
        {
            set
            {
                query = query.Take(value);
            }
        }        

        /// <summary>
        /// Starte die parallelisierte Filterung. Sortiert anschliessend sequentiell.
        /// Kehrt erst zurück, wenn alle Aufgaben erledigt sind
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IAsteroid> GetFilteredSortedSet()
        {
            var filtered = query.ToArray();
            return filtered.OrderBy(r => r.DistanceSunInAU);
        }

        /// <summary>
        /// Starte die parallelisierte Filterung asynchron. Sortiert anschliessend sequentiell.
        /// Kehrt sofort nach dem asynchronen Start der parallelisierten Filterung zurück
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<IAsteroid>> GetFilteredSortedSetAsync()
        {
            var filtered = await Task.Run(() => query.ToArray());
            return await Task.Run(()=> filtered.OrderBy(r => r.DistanceSunInAU).AsParallel());
        }

        /// <summary>
        /// Filtert parallel und stellt unmittelbar alle gefilterten in einer Queue bereit
        /// </summary>
        /// <param name="queue"></param>
        public async Task EnqueueFilteredInAsync(System.Collections.Concurrent.ConcurrentQueue<IAsteroid> queue)
        {
            await Task.Run(() => query.ForAll(a =>
                queue.Enqueue(a)));
        }
    }
}
