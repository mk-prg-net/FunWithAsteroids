//<unit_header>
//----------------------------------------------------------------
//
// Martin Korneffel: IT Beratung/Softwareentwicklung
// Stuttgart, den 12.12.2017
//
//  Projekt.......: Asteroids.UI.PAttern.Presenter
//  Name..........: IPresenter
//  Aufgabe/Fkt...: Presenter- Komponente aus dem MVP
//                  Pattern. Definiert Aktionen zum 
//                  Erzeugen einer gefilterten und 
//                  sortierten Menge aus Asteroiden.    
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
    interface IPresenter
    {
        void BtnNewClick();

        void BtnDefSortClick();

        void BtnFilterClick();
    }
}
