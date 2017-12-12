using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsteroidsBL;
using MkPrgNet.Pattern.Repository;

namespace Asteroids.UI.Pattern.Presenter.Impl
{
    public class ViewMockUp : IView
    {
        public IFilteredSortedSet<IAsteroid> AsteroidSelection
        {
            get;
            set;
        }

        public double? DiameterMaxInKm
        {
            get;
            set;
        }

        public double? DiameterMinInKm
        {
            get;
            set;
        }

        public bool EnableDiameterMaxInKm
        {
            get;
            set;
        }

        public bool EnableDiameterMinInKm
        {
            get;
            set;
        }

        public bool EnableFilterBtn
        {
            get;
            set;
        }

        public bool EnableNewBtn
        {
            get;
            set;
        }

        public bool EnableOrbitSunRadiusMaxInAU
        {
            get;
            set;
        }

        public bool EnableOrbitSunRadiusMinInAU
        {
            get;
            set;
        }

        public bool EnableSortBtn
        {
            get;
            set;
        }

        public bool EnableSortByDiameterAsc
        {
            get;
            set;
        }

        public bool EnableSortByOrbitSunRadiusAsc
        {
            get;
            set;
        }

        public double? OrbitSunRadiusMaxInAU
        {
            get;
            set;
        }

        public double? OrbitSunRadiusMinInAU
        {
            get;
            set;
        }

        public bool? SortByDiameterAsc
        {
            get;
            set;
        }

        public bool? SortByOrbitSunRadiusAsc
        {
            get;
            set;
        }
    }
}
