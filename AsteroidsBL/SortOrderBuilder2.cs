//<unit_header>
//----------------------------------------------------------------
//
// Martin Korneffel: IT Beratung/Softwareentwicklung
// Stuttgart, den 5.7.2017
//
//  Projekt.......: Projektkontext
//  Name..........: Dateiname
//  Aufgabe/Fkt...: Kurzbeschreibung
//                  
//
//
//
//
//<unit_environment>
//------------------------------------------------------------------
//  Zielmaschine..: PC 
//  Betriebssystem: Windows 7 mit .NET 4.5
//  Werkzeuge.....: Visual Studio 2013
//  Autor.........: Martin Korneffel (mko)
//  Version 1.0...: 
//
// </unit_environment>
//
//<unit_history>
//------------------------------------------------------------------
//
//  Version.......: 1.1
//  Autor.........: Martin Korneffel (mko)
//  Datum.........: 
//  Änderungen....: 
//
//</unit_history>
//</unit_header>        

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsteroidsBL
{
    public class SortOrderBuilder2 : ISortOrderBuilder
    {
        ParallelQuery<Asteroid> query;
        OrderedParallelQuery<Asteroid> orderedQuery;

        bool first = true;

        public SortOrderBuilder2(ParallelQuery<Asteroid> query)
        {
            this.query = query;
        }

        /// <summary>
        /// Erweitert orderBy um 
        /// </summary>
        /// <typeparam name="TCol"></typeparam>
        /// <param name="selector"></param>
        /// <param name="descending"></param>
        private void DefOrderBy<TCol>(Func<Asteroid, TCol> selector, bool descending)
        {
            if (first)
            {
                first = false;
                if (descending)
                    orderedQuery = query.OrderByDescending(selector);
                else
                    orderedQuery = query.OrderBy(selector);
            }
            else
            {
                if (descending)
                    orderedQuery = orderedQuery.ThenByDescending(selector);
                else
                    orderedQuery = orderedQuery.ThenBy(selector);
            }
        }


        public bool OrderByDiameterAsc
        {
            set
            {
                DefOrderBy(r => r.DiameterInKm, value);
            }
        }

        public bool OrderByDistanceSunInAU
        {
            set
            {
                DefOrderBy(r => r.DistanceSunInAU, value);
            }
        }

        /// <summary>
        /// Liefert die gefilterte und sortierte Menge
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IAsteroid> GetFilteredSortedSet()
        {
            if (first)
            {
                DefOrderBy(r => r.DistanceSunInAU, false);
            }
            return orderedQuery.ToArray();
        }
    }
}
