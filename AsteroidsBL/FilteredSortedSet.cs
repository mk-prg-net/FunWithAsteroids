using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsteroidsBL
{
    public class FilteredSortedSet : MkPrgNet.Pattern.Repository.IFilteredSortedSet<IAsteroid>
    {

        OrderedParallelQuery<Asteroid> orderedQuery;
        internal FilteredSortedSet(OrderedParallelQuery<Asteroid> orderedQuery)
        {
            this.orderedQuery = orderedQuery;
        }

        public bool Any()
        {
            return orderedQuery.Any();
        }

        public long Count()
        {
            if(_count == -1)
                _count = orderedQuery.Count();
            return _count;
        }

        int _count = -1;

        public IEnumerable<IAsteroid> Get(int skip = 0, int take = -1)
        {
            
            if (skip > 0)
            {
                var q = orderedQuery.Skip(skip);
                if(take > -1)
                {
                    q = q.Take(take);                
                }
                return q.ToArray();
            } else if(take > -1)
            {
                var q = orderedQuery.Take(take);
                return q.ToArray();
            } else
            {
                return orderedQuery.ToArray();
            }                
        }
    }
}
