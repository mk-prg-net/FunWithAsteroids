using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MkPrgNet.Pattern.Repository;
using AsteroidsBL;


namespace Asteroids.UI.Pattern.MVC.Models.FilterSort
{
    public class Index
    {
        public IFilteredSortedSet<IAsteroid> fss { get; set; }
        public int SKIP { get; set; }
        public string minDia { get; set; }
        public string maxDia { get; set; }
        public string minDst { get; set; }
        public string maxDst { get; set; }        
    }
}
