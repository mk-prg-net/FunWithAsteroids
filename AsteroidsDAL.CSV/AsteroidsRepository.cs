using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsteroidsBL;

namespace AsteroidsDAL.CSV
{
    public class AsteroidsRepository : AsteroidsBL.IAsteroidsRepository
    {
        /// <summary>
        /// Hier werden die Asteroiden, eingelesen aus einer CSV, 
        /// tatsächlich abgespeichert
        /// </summary>
        List<Asteroid> _Asteroids;

        public AsteroidsRepository(int MaxAnzAsteroiden)
        {
            _Asteroids = new List<Asteroid>(MaxAnzAsteroiden);
        }

        public AsteroidsRepository(IEnumerable<IAsteroid> Asteroiden)
        {
            _Asteroids = new List<Asteroid>(Asteroiden.Count());

            // Kopieren der Asteroiden in die Liste
            // klassisch mit Schleife
            //foreach (var asteroid in Asteroiden)
            //{
            //    _Asteroids.Add(new Asteroid(
            //        Name: asteroid.Name,
            //        DiamterInKm: asteroid.DiameterInKm,
            //        Albedo: asteroid.Albedo,
            //        DistanceSunInAU: asteroid.DistanceSunInAU,
            //        E: asteroid.E,
            //        OrbitalTime: asteroid.OrbitalTimeInEarthYears
            //        ));
            //}

            // Modern mittels LINQ
            _Asteroids.AddRange(
                    Asteroiden.Select(asteroid =>
                        new Asteroid(
                                Name: asteroid.Name,
                                DiameterInKm: asteroid.DiameterInKm,
                                Albedo: asteroid.Albedo,
                                DistanceSunInAU: asteroid.DistanceSunInAU,
                                E: asteroid.E,
                                OrbitalTime: asteroid.OrbitalTimeInEarthYears)
                        )
                );
        }




        public IEnumerable<IAsteroid> All
        {
            get
            {
                return _Asteroids;
            }
        }

        public IAsteroid GetAsteroid(string NameOfAsteroid)
        {
            // Gibt es den Asteroiden mit dem gegebenen Namen ?
            if (_Asteroids.Any(asteroid => asteroid.Name == NameOfAsteroid))
            {
                // sonst: zugreifen und ausliefern
                return _Asteroids.First(asteroid => asteroid.Name == NameOfAsteroid);
            }
            else
            {
                // Wenn nicht, dann einen Fehler melden
                throw new ArgumentException(string.Format(Properties.Resources.AsteroidsRepository_Get_NotExists, NameOfAsteroid));
            }

        }

        public IEnumerable<IAsteroid> Query(int Skip, int Take, double minDiameter, double maxDiameter)
        {
            return _Asteroids.Where(a => minDiameter <= a.DiameterInKm && a.DiameterInKm <= maxDiameter)
                             .Skip(Skip)
                             .Take(Take);
        }


        // Zusätzliche Funktion zum Einfügen einzelner Datensätze

        public void Add(
                string Name,
                double DistanceSunInAU,
                double E,
                double OrbitalTime,
                double Albedo,
                double DiameterInKm
            )
        {

            if (!_Asteroids.Any(a => a.Name == Name))
            {
                _Asteroids.Add(
                    new Asteroid(
                        Name: Name,
                        DiameterInKm: DiameterInKm,
                        Albedo: Albedo,
                        DistanceSunInAU: DistanceSunInAU,
                        E: E,
                        OrbitalTime: OrbitalTime));
            } else
            {
                throw new ArgumentException("Der Asteroid mit dem Namen " + Name + " ist bereits erfasst");
            }
        }

        public bool Exists(string NameOfAsteroid)
        {
            return _Asteroids.Any(a => a.Name == NameOfAsteroid);
        }

        public void Add(IAsteroid a)
        {
            if (!_Asteroids.Any(ast => ast.Name == a.Name))
            {
                _Asteroids.Add(
                    new Asteroid(
                        Name: a.Name,
                        DiameterInKm: a.DiameterInKm,
                        Albedo: a.Albedo,
                        DistanceSunInAU: a.DistanceSunInAU,
                        E: a.E,
                        OrbitalTime: a.OrbitalTimeInEarthYears));
            }
            else
            {
                throw new ArgumentException("Der Asteroid mit dem Namen " + a.Name + " ist bereits erfasst");
            }
        }

        public IQueryBuilder GetNewQueryBuilder()
        {
            return new QueryBuilder(_Asteroids);
        }
    }
}
