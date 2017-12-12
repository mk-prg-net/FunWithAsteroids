//<unit_header>
//----------------------------------------------------------------
//
// Martin Korneffel: IT Beratung/Softwareentwicklung
// Stuttgart, den 12.12.2017
//
//  Projekt.......: Asteroids.UI.Pattern.Presenter
//  Name..........: PresenterTest.cs
//  Aufgabe/Fkt...: Presenter mit Mockup View testen
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
using Microsoft.VisualStudio.TestTools.UnitTesting;

// Linq erfordet immer die Einbindung von System.Linq mittels using
using System.Linq;
using System.Diagnostics;

using System.Threading.Tasks;
using AsteroidsBL;
using AsteroidsDAL.CSV;



namespace Asteroids.UI.Pattern.Presenter.Test
{
    [TestClass]
    public class PresenterTest
    {
        [TestMethod]
        public void AsteroidsDAL_CSV_ReadCSV()
        {
            // 1. Stufe: Einlesen der Asteroiden aus der CSV- Datei 
            //    und erfassen im Sammler  
            AsteroidsBL.IAsteroidsCollector collector = new AsteroidsCollector();
            try
            {
                var reader = new AsteroidsCSVReader("Asteroids.csv", 2);
                while (!reader.EOF)
                {
                    var asteroid = reader.Read();
                    collector.Add(asteroid);
                }

                Assert.IsTrue(collector.Count > 0);

                var repo = collector.CreateRepository();

                var view = new Impl.ViewMockUp();
                var presenter = new Impl.PresenterV1(view, repo);

                presenter.BtnNewClick();

                Assert.IsFalse(view.EnableNewBtn);
                Assert.IsTrue(view.EnableDiameterMaxInKm);
                Assert.IsTrue(view.EnableDiameterMinInKm);
                Assert.IsTrue(view.EnableOrbitSunRadiusMaxInAU);
                Assert.IsTrue(view.EnableOrbitSunRadiusMinInAU);
                Assert.IsFalse(view.EnableFilterBtn);

                view.DiameterMinInKm = 100.0;
                //view.OrbitSunRadiusMinInAU = 3.0;

                presenter.BtnDefSortClick();

                Assert.IsFalse(view.EnableSortBtn);
                Assert.IsFalse(view.EnableDiameterMaxInKm);
                Assert.IsFalse(view.EnableDiameterMinInKm);
                Assert.IsFalse(view.EnableOrbitSunRadiusMaxInAU);
                Assert.IsFalse(view.EnableOrbitSunRadiusMinInAU);
                Assert.IsTrue(view.EnableFilterBtn);

                Assert.IsTrue(view.EnableSortByDiameterAsc);
                Assert.IsTrue(view.EnableSortByOrbitSunRadiusAsc);
                
                view.SortByDiameterAsc = false;

                presenter.BtnFilterClick();


                Assert.IsTrue(view.AsteroidSelection.Any());
                var res = view.AsteroidSelection.Get();

            }
            catch (Exception ex)
            {
                Assert.Fail();
            }
        }
    }
}
