//<unit_header>
//----------------------------------------------------------------
//
// Martin Korneffel: IT Beratung/Softwareentwicklung
// Stuttgart, den 27.6.2017
//
//  Projekt.......: AsteroidsBL
//  Name..........: IQueryBuilder.cs
//  Aufgabe/Fkt...: Definieren von Filter und Sortierkriterien,
//                  aus denen schließlich eine Abfrage erzeugt wird.
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
    public interface IQueryBuilder : MkPrgNet.Pattern.Repository.IQueryBuilder<IAsteroid, ISortOrderBuilder>
    {
        /// <summary>
        /// Schränkt auf Asteroiden mit einem Mindestdurchmesser ein
        /// </summary>
        double MinDiameterInKm { set; }

        /// <summary>
        /// Schränkt auf Asteroiden mit einem Maximaldurchmesser ein
        /// </summary>
        double MaxDiameterInKm { set; }

        /// <summary>
        /// Schränkt auf Asteroiden mit einem Mindestabstand von der Sonne ein
        /// </summary>
        double MinDistanceSunInAU { set; }

        /// <summary>
        /// Schränkt auf Asteroiden mit einem maximalabstand von der Sonne ein
        /// </summary>
        double MaxDistanceSunInAU { set; }


        /// <summary>
        /// Filtert parallel und stellt unmittelbar alle gefilterten in einer Queue bereit
        /// </summary>
        /// <param name="queue"></param>
        Task EnqueueFilteredInAsync(System.Collections.Concurrent.ConcurrentQueue<IAsteroid> queue);
    }
}
