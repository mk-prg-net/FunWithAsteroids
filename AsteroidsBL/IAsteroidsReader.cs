using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsteroidsBL
{
    public interface IAsteroidsReader
    {
        /// <summary>
        /// Liset den nächsten Asteroiden ein
        /// </summary>
        /// <returns></returns>
        IAsteroid Read();

        /// <summary>
        /// solange false, kann noch ein weiterer Asteroid gelesen werden
        /// </summary>
        bool EOF { get; }
    }
}
