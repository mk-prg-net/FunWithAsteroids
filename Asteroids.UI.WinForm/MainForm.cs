//<unit_header>
//----------------------------------------------------------------
//
// Martin Korneffel: IT Beratung/Softwareentwicklung
// Stuttgart, den 29.6.2017
//
//  Projekt.......: Asteroids.UI.WinForm
//  Name..........: 
//  Aufgabe/Fkt...: Graphische Benutzeroberfläche mit asynchronen Funktionen
//                  zum lesen und analysieren der Asteroidendaten
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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
namespace Asteroids.UI.WinForm
{
    public partial class MainForm : Form
    {
        mko.Log.LogServer log = new mko.Log.LogServer();

        AsteroidsBL.IAsteroidsCollector collector;
        AsteroidsBL.IAsteroidsRepository repo;

        public MainForm()
        {
            InitializeComponent();

            var lbxHnd = new mko.Log.WinFormListBoxLogHnd(lbxLog);
            log.registerLogHnd(lbxHnd);

            //var lbxLbl = new mko.Log.WinFormStatusStripLogHnd(statusStrip1);

            log.Log(mko.Log.RC.CreateStatus("Initialisierung beendet"));

            EnableTbx(false);
            EnableGrpSort(false);
            btnGetSortOrderBuilder.Enabled = false;
            btnGetResult.Enabled = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabPageImport;

            if(openAsteroidsCsv.ShowDialog() == DialogResult.OK)
            {
                // Erfassung vorbereiten
                mko.TraceHlp.ThrowArgExIfNot(File.Exists(openAsteroidsCsv.FileName), "Die Datei " + openAsteroidsCsv.FileName + " existiert nicht");

                collector = new AsteroidsBL.AsteroidsCollector();

                //UpdateCollectorCounterTimer.Enabled = true;
                UpdateCollectorCounterTimer.Start();

                log.Log(mko.Log.RC.CreateStatus("Einlesevorgang gestartet"));
                                
                await Task.Run(() =>
                {
                    var reader = new AsteroidsDAL.CSV.AsteroidsCSVReader(openAsteroidsCsv.FileName, 2);

                    // geht nicht aus einem anderen Thread
                    //lblImportCsvCountAsteroids.Text = "HAllo";

                    while (!reader.EOF)
                    {
                        collector.Add(reader.Read());
                    }                    
                });

                UpdateCollectorCounterTimer.Stop();

                UpdateCollectorCounterTimer_Tick(null, null);

                repo = collector.CreateRepository();

                log.Log(mko.Log.RC.CreateStatus("Einlesen erfolgreich beendet"));
                                
            }

        }

        private void UpdateCollectorCounterTimer_Tick(object sender, EventArgs e)
        {
            lblImportCsvCountAsteroids.Text = collector.Count.ToString("D10");

            CollectedAsteroidsBindingSource.DataSource = collector.GetLast(20);
            CollectedAsteroidsBindingSource.ResetBindings(false);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new About();
            about.ShowDialog();
        }

        AsteroidsBL.IQueryBuilder queryBld;

        private void btnNewQuery_Click(object sender, EventArgs e)
        {
            queryBld = repo.GetNewQueryBuilder();

            cbxMaxDiameter.Checked = false;
            cbxMaxDistanceSun.Checked = false;
            cbxMinDiameter.Checked = false;
            cbxMinDistanceSun.Checked = false;
            cbxSortDiameter.Checked = false;
            cbxSortDistanceSun.Checked = false;

            EnableTbx(true);
            EnableGrpSort(false);

            btnGetSortOrderBuilder.Enabled = true;
            btnGetResult.Enabled = false;
        }

        private void EnableGrpSort(bool enable)
        {
            grpSortDiameter.Enabled = enable;            
            grpSortDistanceSun.Enabled = enable;

            if (enable)
            {
                rbtDiameterDown.Checked = false;
                rbtDiameterUp.Checked = false;
                rbtDistanceSunDown.Checked = false;
                rbtDistanceSunUp.Checked = false;
            }
        }

        private void tbxMinDiameter_Leave(object sender, EventArgs e)
        {
            double diameter;
            if(double.TryParse(tbxMinDiameter.Text, out diameter))
            {
                queryBld.MinDiameterInKm = diameter;

                cbxMinDiameter.Checked = true;
                tbxMinDiameter.Enabled = false;
            } else
            {
                tbxMinDiameter.Text = "";
            }
        }

        private void tbxMaxDiameter_Leave(object sender, EventArgs e)
        {
            double diameter;
            if (double.TryParse(tbxMaxDiameter.Text, out diameter))
            {
                queryBld.MaxDiameterInKm = diameter;

                cbxMaxDiameter.Checked = true;
                tbxMaxDiameter.Enabled = false;
            }
            else
            {
                tbxMaxDiameter.Text = "";
            }
        }

        AsteroidsBL.ISortOrderBuilder sortOrderBld;

        private void btnGetSortOrderBuilder_Click(object sender, EventArgs e)
        {
            EnableTbx(false);
            EnableGrpSort(true);
            
            sortOrderBld = queryBld.GetSortOrderBuilder();

            btnGetSortOrderBuilder.Enabled = false;
            btnGetResult.Enabled = true;

        }

        private void EnableTbx(bool enable)
        {
            tbxMaxDiameter.Enabled = enable;
            tbxMaxDistanceSun.Enabled = enable;
            tbxMinDiameter.Enabled = enable;
            tbxMinDistanceSun.Enabled = enable;

            if (enable)
            {
                tbxMaxDiameter.Text = "";
                tbxMaxDistanceSun.Text = "";
                tbxMinDiameter.Text = "";
                tbxMinDistanceSun.Text = "";
            }
        }

        private void rbtDiameterUp_CheckedChanged(object sender, EventArgs e)
        {
            sortOrderBld.OrderByDiameterAsc = false;
            lockSortDiameter();
        }

        private void rbtDiameterDown_CheckedChanged(object sender, EventArgs e)
        {
            sortOrderBld.OrderByDiameterAsc = true;
            lockSortDiameter();
        }

        private void lockSortDiameter()
        {
            cbxSortDiameter.Checked = true;
            grpSortDiameter.Enabled = false;
        }

        private void rbtDistanceSunUp_CheckedChanged(object sender, EventArgs e)
        {
            sortOrderBld.OrderByDistanceSunInAU = false;
            lockSortDistanceSun();
        }

        private void lockSortDistanceSun()
        {
            cbxSortDistanceSun.Checked = true;
            grpSortDistanceSun.Enabled = false;
        }

        private void rbtDistanceSunDown_CheckedChanged(object sender, EventArgs e)
        {
            sortOrderBld.OrderByDistanceSunInAU = true;
            lockSortDistanceSun();
        }

        private void btnGetResult_Click(object sender, EventArgs e)
        {
            var fsSet = sortOrderBld.GetFilteredSortedSet();

            statusLabelMain.Text = "# " + fsSet.Count();

            QueryResultBindingSource.DataSource = fsSet.Get();
            QueryResultBindingSource.ResetBindings(false);

            tabControlMain.SelectedTab = tabPageResult;
        }

        private void tbxMinDistanceSun_Leave(object sender, EventArgs e)
        {
            double d;
            if (double.TryParse(tbxMinDistanceSun.Text, out d))
            {
                queryBld.MinDistanceSunInAU = d;

                cbxMinDistanceSun.Checked = true;
                tbxMinDistanceSun.Enabled = false;
            }
            else
            {
                tbxMinDistanceSun.Text = "";
            }

        }

        private void tbxMaxDistanceSun_Leave(object sender, EventArgs e)
        {
            double d;
            if (double.TryParse(tbxMaxDistanceSun.Text, out d))
            {
                queryBld.MaxDistanceSunInAU = d;
                cbxMaxDistanceSun.Checked = true;                
                tbxMaxDistanceSun.Enabled = false;
            }
            else
            {
                tbxMaxDistanceSun.Text = "";
            }

        }
    }
}
