using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsteroidsBL
{
    public class Asteroid : AsteroidsBL.IAsteroid
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="DistanceSunInAU">Bahnradius in astronimischen Einheiten</param>
        /// <param name="E">Bahnexentrizität</param>
        /// <param name="OrbitalTime">Dauer eines Jahres in Erdjahren</param>
        /// <param name="Albedo"></param>
        /// <param name="DiamterInKm"></param>
        public Asteroid(
                string Name,
                double DistanceSunInAU,
                double E,
                double OrbitalTime,
                double Albedo,
                double DiameterInKm
            )
        {
            _Name = Name;
            _Diameter = DiameterInKm;
            _DistanceSun = DistanceSunInAU;
            _Albedo = Albedo;
            _E = E;
            _OrbitalTime = OrbitalTime;
        }


        public Asteroid(IAsteroid src)
            : this(
                  Name: src.Name,
                  DistanceSunInAU: src.DistanceSunInAU,
                  DiameterInKm: src.DiameterInKm,
                  E: src.E,
                  OrbitalTime: src.OrbitalTimeInEarthYears,
                  Albedo: src.Albedo) {}

        public double Albedo
        {
            get
            {
                return _Albedo;
            }
        }
        double _Albedo;

        public double DiameterInKm
        {
            get
            {
                return _Diameter;
            }
        }
        double _Diameter;

        public double DistanceSunInAU
        {
            get
            {
                return _DistanceSun;
            }
        }
        double _DistanceSun;

        public double E
        {
            get
            {
                return _E;
            }
        }
        double _E;

        public string Name
        {
            get
            {
                return _Name;
            }
        }
        string _Name;

        public double OrbitalTimeInEarthYears
        {
            get
            {
                return _OrbitalTime;
            }
        }
        double _OrbitalTime;
    }
}
