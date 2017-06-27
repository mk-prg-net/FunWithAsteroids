using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsteroidsBL
{
    /// <summary>
    /// Struktur eines Asteroiden- Himmelskörpers
    /// </summary>
    public interface IAsteroid
    {
        string Name { get; }

        double DiameterInKm { get; }

        /// <summary>
        /// Exzentrizität
        /// </summary>
        double E { get; }

        double DistanceSunInAU { get; }

        double OrbitalTimeInEarthYears { get; }

        double Albedo { get; }
    }
}
