using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AsteroidsBL;
using AsteroidsDAL;

using System.ComponentModel;

namespace Asteroids.UI.Pattern.MVVM.WPF
{
    public class AsteroidsRepoMVVM  : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string Name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Name));
        }

        IAsteroidsRepository _repo;

        public IAsteroidsRepository Repo
        {
            get
            {
                return _repo;
            }

            set
            {
                _repo = value;
            }
        }

        public AsteroidsRepoMVVM()
        {
            _repo = new AsteroidsBL.AsteroidsRepository(10);
        }

        IQueryBuilder QueryBuilder;

        public void NewFilter()
        {
            MinDia = MinDist = 0.0;
            MaxDia = 1000;
            MaxDist = 10;
            QueryBuilder = _repo.GetNewQueryBuilder();                      

        }


        public double MinDia
        {
            get
            {
                return _MinDia;
            }
            set
            {
                if (QueryBuilder != null)
                {
                    QueryBuilder.MinDiameterInKm = value;
                }
                _MinDia = value;
                OnPropertyChanged("MinDia");
            }
        }
        double _MinDia = 0;

        public double MaxDia
        {
            get
            {
                return _MaxDia;
            }
            set
            {
                if (QueryBuilder != null)
                {
                    QueryBuilder.MinDiameterInKm = value;
                }
                _MaxDia = value;
                OnPropertyChanged("MaxnDia");
            }
        }
        double _MaxDia = 0;

        public double MinDist
        {
            get
            {
                return _MinDist;
            }
            set
            {
                if (QueryBuilder != null)
                {
                    QueryBuilder.MinDistanceSunInAU = value;
                }
                _MinDist = value;
                OnPropertyChanged("MinDist");
            }
        }
        double _MinDist = 0;

        public double MaxDist
        {
            get
            {
                return _MaxDist;
            }
            set
            {
                if (QueryBuilder != null)
                {
                    QueryBuilder.MaxDistanceSunInAU = value;
                }
                _MaxDist = value;
                OnPropertyChanged("MaxnDist");

            }
        }
        double _MaxDist = 0;



        ISortOrderBuilder SortOrderBuilder;
        public void NewSortOrderBuilder()
        {
            SortOrderBuilder = QueryBuilder.GetSortOrderBuilder();
        }

        public bool SortDia
        {
            get
            {
                return _SortDia;
            }
            set
            {
                if (SortOrderBuilder != null)
                {
                    SortOrderBuilder.OrderByDiameterAsc = value;
                }
                _SortDia = value;
                OnPropertyChanged("SortDia");
            }
        }
        bool _SortDia = false;

        public bool SortDist
        {
            get
            {
                return _SortDist;
            }
            set
            {
                if (SortOrderBuilder != null)
                {
                    SortOrderBuilder.OrderByDistanceSunInAU = value;
                }
                _SortDist = value;
                OnPropertyChanged("SortDist");

            }
        }
        bool _SortDist = false;

        public void NewFilteredSortedSet()
        {
            fss = SortOrderBuilder.GetFilteredSortedSet();
        }

        MkPrgNet.Pattern.Repository.IFilteredSortedSet<IAsteroid> fss;

        public long AsteroidsCount
        {
            get
            {
                if(fss != null)
                {
                    return fss.Count();
                } else
                {
                    return 0;
                }
            }
        }

        public IEnumerable<IAsteroid> Get
        {
            get
            {
                if(fss!= null)
                {
                    return fss.Get();
                } else
                {
                    return new IAsteroid[] { };
                }
            }
            
        }       

    }
}
