using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AsteroidsBL;
using AsteroidsDAL;

namespace Asteroids.UI.Pattern.MVVM.WPF
{
    public class AsteroidsCollectorMVVM 
    {

        public AsteroidsCollectorMVVM()
        {
            _collector = new AsteroidsCollector();
        }

        IAsteroidsCollector _collector;

        public IAsteroidsCollector Collector => _collector;


        public IEnumerable<IAsteroid> Asteroids => _collector.GetLast(20);        


        public void StartCollect()
        {
            _collector = new AsteroidsBL.AsteroidsCollector();
        }

        

    }
}
