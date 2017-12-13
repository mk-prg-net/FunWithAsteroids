using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using MkPrgNet.Pattern.Repository;
using AsteroidsBL;



// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Asteroids.UI.Pattern.MVC.Controllers
{
    public class FilterSortController : Controller
    {
        IAsteroidsRepository repo;        

        public FilterSortController(IAsteroidsRepository repo)
        {
            this.repo = repo;
        }

        // GET: /<controller>/
        public IActionResult Index(int skip = 0, string minDia="", string maxDia="", string minDst="", string maxDst="", string sortDia="", string sortDst="")
        {
            var qbld = repo.GetNewQueryBuilder();
            SetRestrictionDbl(qbld, (q, v) => q.MinDiameterInKm = v, minDia);
            SetRestrictionDbl(qbld, (q, v) => q.MaxDiameterInKm = v, maxDia);
            SetRestrictionDbl(qbld, (q, v) => q.MinDistanceSunInAU = v, minDst);
            SetRestrictionDbl(qbld, (q, v) => q.MaxDistanceSunInAU = v, maxDst);

            var sbld = qbld.GetSortOrderBuilder();
            SetSort(sbld, (s, v) => s.OrderByDiameterAsc = v, sortDia);
            SetSort(sbld, (s, v) => s.OrderByDistanceSunInAU = v, sortDst);

            var fss = sbld.GetFilteredSortedSet();
            
            return View(new Models.FilterSort.Index() {
                fss= fss,
                SKIP = skip,
                minDia = minDia,
                maxDia = maxDia,
                minDst = minDst,
                maxDst = maxDst
            });
        }

        private void SetRestrictionDbl(IQueryBuilder qbld, Action<IQueryBuilder, double> setter, string strVal)
        {
            if (!string.IsNullOrWhiteSpace(strVal))
            {
                double v;
                if (double.TryParse(strVal, out v))
                {
                    setter(qbld, v);
                }
                else
                {
                    ModelState.AddModelError("minDia", "min. Dia ist kein num. Wert !");
                }
            }
        }

        private void SetSort(ISortOrderBuilder sbld, Action<ISortOrderBuilder, bool> setter, string strVal)
        {
            if (!string.IsNullOrWhiteSpace(strVal))
            {
                bool v;
                if (bool.TryParse(strVal, out v))
                {
                    setter(sbld, v);
                }
                else
                {
                    ModelState.AddModelError("minDia", "min. Dia ist kein num. Wert !");
                }
            }
        }
    }
}
