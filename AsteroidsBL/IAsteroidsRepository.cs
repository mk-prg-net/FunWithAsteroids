using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsteroidsBL
{
    /// <summary>
    /// Verwaltet eine Menge von Asteroiden
    /// </summary>
    public interface IAsteroidsRepository
    {
        /// <summary>
        /// Liefert den Asteroiden mit dem gegebenen Namen aus.
        /// Wirft eine Ausnahme, falls zum Namen kein Asteroid existiert.
        /// </summary>
        /// <param name="NameOfAsteroid"></param>
        /// <returns></returns>
        IAsteroid GetAsteroid(string NameOfAsteroid);

        /// <summary>
        /// Liefert true, falls ein Asteroid mit dem Namen enthalten ist
        /// </summary>
        /// <param name="NameOfAsteroid"></param>
        /// <returns></returns>
        bool Exists(string NameOfAsteroid);

        /// <summary>
        /// Fügt einen neuen Asteroiden dem Repository hinzu
        /// </summary>
        /// <param name=""></param>
        void Add(IAsteroid a);

        /// <summary>
        /// Liefert alle Asteroiden aus
        /// </summary>
        IEnumerable<IAsteroid> All {get;}

        /// <summary>
        /// Eine Untermeng der Asteroiden ausliefern
        /// </summary>
        /// <param name="Skip"></param>
        /// <param name="Take"></param>
        /// <param name="minDiameter"></param>
        /// <param name="maxDiameter"></param>
        /// <returns></returns>
        IEnumerable<IAsteroid> Query(int Skip, int Take, double minDiameter, double maxDiameter);

        /// <summary>
        /// Erzeugt einen neuen Querybuilder, mit dem eine neue Abfrage formuliert
        /// und ausgeführt werden kann 
        /// </summary>
        /// <returns></returns>
        IQueryBuilder GetNewQueryBuilder();
        

    }
}
