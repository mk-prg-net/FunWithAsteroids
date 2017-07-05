//<unit_header>
//----------------------------------------------------------------
//
// Martin Korneffel: IT Beratung/Softwareentwicklung
// Stuttgart, den 3.7.2017
//
//  Projekt.......: AsteroidsBL
//  Name..........: ISortOrderBuilder.cs
//  Aufgabe/Fkt...: Schnittstelle, welche die Sortierreihenfolge
//                  eine Menge definiert
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
    public interface ISortOrderBuilder : MkPrgNet.Pattern.Repository.ISortOrderBuilder<IAsteroid>
    {
        /// <summary>
        /// Sortiert absteigend bezüglich des Durchmessers, wenn 
        /// auf true gesetzt wird, und aufsteigend, wenn auf false
        /// gesetzt wird.
        /// Wird kein Wert zugewiesen, dann findet eine Sortierung
        /// bezüglich des Durchmessers nicht statt.
        /// </summary>
        bool OrderByDiameterAsc { set; }

        /// <summary>
        /// Sortiert absteigend bezüglich des Sonnenabstandes, wenn 
        /// auf true gesetzt wird, und aufsteigend, wenn auf false
        /// gesetzt wird.
        /// Wird kein Wert zugewiesen, dann findet eine Sortierung
        /// bezüglich des Sonnenabstandes nicht statt.
        /// </summary>
        bool OrderByDistanceSunInAU { set; }

    }
}
