//<unit_header>
//----------------------------------------------------------------
//
// Martin Korneffel: IT Beratung/Softwareentwicklung
// Stuttgart, den 28.6.2017
//
//  Projekt.......: AsteroidsDAL.CSV
//  Name..........: AsteroidsCollector.cs
//  Aufgabe/Fkt...: Aus einer Datenquelle eingelesene
//                  Asteroidendaten können hier erfasst
//                  werden. Am Ende der Erfa
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
    public class AsteroidsCollector : IAsteroidsCollector
    {
        LinkedList<Asteroid> _AsteroidCollection = new LinkedList<Asteroid>();

        object lockHandle = new object();

        public long Count
        {
            get
            {
                lock (lockHandle)
                {
                    return _Count;
                }
            }
        }
        long _Count;

        public void Add(IAsteroid asteroid)
        {
            lock (lockHandle)
            {
                _AsteroidCollection.AddFirst(new Asteroid(asteroid));
                _Count++;
            }
        }

        /// <summary>
        /// Erzeugt aus der Liste der erfassten Asteroiden ein Repository
        /// </summary>
        /// <returns></returns>
        public IAsteroidsRepository CreateRepository()
        {
            lock (lockHandle)
            {
                var repo = new AsteroidsRepository(_AsteroidCollection);
                return repo;
            }
        }

        /// <summary>
        /// Liefert die letzten n erfassten Asteroiden
        /// </summary>
        /// <param name="countAsteroids"></param>
        /// <returns></returns>
        public IEnumerable<IAsteroid> GetLast(int countAsteroids)
        {
            lock (lockHandle)
            {
                return _AsteroidCollection.Take(countAsteroids).ToArray();
            }
        }
    }
}
