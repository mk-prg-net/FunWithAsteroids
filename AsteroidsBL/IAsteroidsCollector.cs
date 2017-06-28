//<unit_header>
//----------------------------------------------------------------
//
// Martin Korneffel: IT Beratung/Softwareentwicklung
// Stuttgart, den 28.6.2017
//
//  Projekt.......: AsteroidsBL
//  Name..........: IAsteroidsCollector.cs
//  Aufgabe/Fkt...: Erfassen einer großen Anzahl
//                  von Asteroiden. Nach abgeschlossener
//                  Erfassung können die Asteroiden als
//                  Repository, welches für Analysen 
//                  optimiert ist, bereitgestellt werden
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
    /// <summary>
    /// Erfassen einer großen Anzahl von Asteroiden. Nach abgeschlossener
    /// Erfassung können die Asteroiden als Repository, welches für Analysen 
    /// optimiert ist, bereitgestellt werden.
    /// </summary>
    public interface IAsteroidsCollector
    {
        /// <summary>
        /// Erfassen eines Asteroiden.
        /// Sollte Multithread- resistent sein
        /// </summary>
        /// <param name="asteroid"></param>
        void Add(IAsteroid asteroid);

        /// <summary>
        /// Gibt die Anzahl aktuell erfasster Asteroiden 
        /// zurück. Sollte multithread- resistent sein
        /// </summary>
        long Count { get; }

        /// <summary>
        /// Liefert die letzten n erfassten Asteroiden.
        /// Sollte multithread- resistent sein
        /// </summary>
        /// <param name="countAsteroids"></param>
        /// <returns></returns>
        IEnumerable<IAsteroid> GetLast(int countAsteroids);

        /// <summary>
        /// Erzeugt für die Menge zuvor erfasseter Asteroiden 
        /// ein Repository
        /// </summary>
        /// <returns></returns>
        IAsteroidsRepository CreateRepository();

    }
}
