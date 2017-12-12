//<unit_header>
//----------------------------------------------------------------
//
// Martin Korneffel: IT Beratung/Softwareentwicklung
// Stuttgart, den 12.12.2017
//
//  Projekt.......: Asteroids.UI.Pattern.Presenter
//  Name..........: IView.cs
//  Aufgabe/Fkt...: View- Struktur eine Presenters
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

namespace Asteroids.UI.Pattern.Presenter
{
    public interface IView
    {   
        bool EnableNewBtn { get; set; }

        // Filter and sort settings
        double? DiameterMinInKm { get; set; }
        bool EnableDiameterMinInKm { get; set; }

        double? DiameterMaxInKm { get; set; }
        bool EnableDiameterMaxInKm { get; set; }        

        double? OrbitSunRadiusMinInAU { get; set; }
        bool EnableOrbitSunRadiusMinInAU { get; set; }

        double? OrbitSunRadiusMaxInAU { get; set; }
        bool EnableOrbitSunRadiusMaxInAU { get; set; }


        bool EnableSortBtn { get; set; }

        bool? SortByDiameterAsc { get; set; }
        bool EnableSortByDiameterAsc { get; set; }

        bool? SortByOrbitSunRadiusAsc { get; set; }
        bool EnableSortByOrbitSunRadiusAsc { get; set; }

        bool EnableFilterBtn { get; set; }
        IFilteredSortedSet<IAsteroid> AsteroidSelection { get; set; }

    }
}
