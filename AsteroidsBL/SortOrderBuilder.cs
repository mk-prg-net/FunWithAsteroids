using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsteroidsBL
{
    public class SortOrderBuilder : ISortOrderBuilder
    {
        IEnumerable<Asteroid> _asteroids;
        public SortOrderBuilder(IEnumerable<Asteroid> filteredAsteroids)
        {
            _asteroids = filteredAsteroids;
        }

        IOrderedEnumerable<Asteroid> orderBy;

        public bool OrderByDiameterAsc
        {
            set
            {
                DefOrderBy(r => r.DiameterInKm, value);
            }
        }

        /// <summary>
        /// Erweitert orderBy um 
        /// </summary>
        /// <typeparam name="TCol"></typeparam>
        /// <param name="selector"></param>
        /// <param name="descending"></param>
        private void DefOrderBy<TCol>(Func<Asteroid, TCol> selector, bool descending)
        {
            if (orderBy == null)
            {
                if (descending)
                    orderBy = _asteroids.OrderByDescending(selector);
                else
                    orderBy = _asteroids.OrderBy(selector);
            }
            else
            {
                if (descending)
                    orderBy = orderBy.ThenByDescending(selector);
                else
                    orderBy = orderBy.ThenBy(selector);
            }
        }

        public bool OrderByDistanceSunInAU
        {
            set
            {
                DefOrderBy(r => r.DistanceSunInAU, value);
            }
        }

        public IEnumerable<IAsteroid> GetFilteredSortedSet()
        {            
            if (orderBy == null)
                // Default- Sortierreihenfolge
                return _asteroids.OrderBy(r => r.DistanceSunInAU);
            else
                // Systematisch aufgebaute Sortierreihenfolge
                return orderBy;
        }
    }
}
