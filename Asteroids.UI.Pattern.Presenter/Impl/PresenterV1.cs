//<unit_header>
//----------------------------------------------------------------
//
// Martin Korneffel: IT Beratung/Softwareentwicklung
// Stuttgart, den 12.12.2017
//
//  Projekt.......: Asteroids.UI.Pattern.Presenter
//  Name..........: PresenterV1.cs
//  Aufgabe/Fkt...: Implementierung des MVP Presenters
//                  
//
//
//
//
//<unit_environment>
//------------------------------------------------------------------
//  Zielmaschine..: PC 
//  Betriebssystem: Windows 7 mit .NET 4.5
//  Werkzeuge.....: Visual Studio 2013
//  Autor.........: Martin Korneffel (mko)
//  Version 1.0...: 
//
// </unit_environment>
//
//<unit_history>
//------------------------------------------------------------------
//
//  Version.......: 1.1
//  Autor.........: Martin Korneffel (mko)
//  Datum.........: 
//  Änderungen....: 
//
//</unit_history>
//</unit_header>        

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsteroidsBL;
using MkPrgNet.Pattern.Repository;

namespace Asteroids.UI.Pattern.Presenter.Impl
{
    public class PresenterV1 : IPresenter
    {
        IView _view;
        IAsteroidsRepository _repo;

        public PresenterV1(IView view, IAsteroidsRepository repo)
        {
            _view = view;
            _repo = repo;

            _view.EnableNewBtn = true;          
            
        }

        void EnableFltGroup(bool v)
        {
            _view.EnableDiameterMaxInKm = v;
            _view.EnableDiameterMinInKm = v;
            _view.EnableOrbitSunRadiusMaxInAU = v;
            _view.EnableOrbitSunRadiusMinInAU = v;
            _view.EnableSortBtn = v;
        }

        private void ResetFilterParams()
        {
            // Zurücksetzen der Werte
            _view.DiameterMaxInKm = null;
            _view.DiameterMinInKm = null;
            _view.OrbitSunRadiusMaxInAU = null;
            _view.OrbitSunRadiusMinInAU = null;
        }

        void EnableSortGroup(bool v)
        {
            _view.EnableSortByDiameterAsc = v;
            _view.EnableSortByOrbitSunRadiusAsc = v;
            _view.EnableFilterBtn = v;

        }

        private void ResetSortParams()
        {
            // Zurücksetzen der Werte
            _view.SortByDiameterAsc = null;
            _view.SortByOrbitSunRadiusAsc = null;
        }

        public void BtnNewClick()
        {
            ResetFilterParams();
            ResetSortParams();
            EnableFltGroup(true);
            EnableSortGroup(false);
            _view.EnableNewBtn = false;
        }

        ISortOrderBuilder<IAsteroid> sbld;

        public void BtnFilterClick()
        {
            EnableSortGroup(false);
            _view.AsteroidSelection = sbld.GetFilteredSortedSet();
            _view.EnableNewBtn = true;

            sbld = null;

        }

        public void BtnDefSortClick()
        {
            EnableFltGroup(false);

            var qbld = _repo.GetNewQueryBuilder();
            if (_view.DiameterMaxInKm.HasValue)
                qbld.MaxDiameterInKm = _view.DiameterMaxInKm.Value;
            if (_view.DiameterMinInKm.HasValue)
                qbld.MinDiameterInKm = _view.DiameterMinInKm.Value;
            if (_view.OrbitSunRadiusMaxInAU.HasValue)
                qbld.MaxDistanceSunInAU = _view.OrbitSunRadiusMaxInAU.Value;
            if (_view.OrbitSunRadiusMinInAU.HasValue)
                qbld.MinDistanceSunInAU = _view.OrbitSunRadiusMinInAU.Value;

            sbld = qbld.GetSortOrderBuilder();

            EnableSortGroup(true);

        }
    }
}
