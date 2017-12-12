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
using AsteroidsBL;
using MkPrgNet.Pattern.Repository;

namespace Asteroids.UI.Pattern.Presenter.WinForm
{
    public partial class MainForm : Form, IView
    {
        mko.Log.LogServer log = new mko.Log.LogServer();

        AsteroidsBL.IAsteroidsCollector collector;
        AsteroidsBL.IAsteroidsRepository repo;

        Impl.PresenterV1 presenter;

        public MainForm()
        {
            InitializeComponent();
        }        

        private void MainForm_Load(object sender, EventArgs e)
        {            
        }

        private async void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabImportCSV;

            if (openAsteroidsCSV.ShowDialog() == DialogResult.OK)
            {
                // Erfassung vorbereiten
                mko.TraceHlp.ThrowArgExIfNot(File.Exists(openAsteroidsCSV.FileName), "Die Datei " + openAsteroidsCSV.FileName + " existiert nicht");

                collector = new AsteroidsBL.AsteroidsCollector();

                //UpdateCollectorCounterTimer.Enabled = true;
                UpdateCollectorCounterTimer.Start();

                log.Log(mko.Log.RC.CreateStatus("Einlesevorgang gestartet"));

                await Task.Run(() =>
                {
                    var reader = new AsteroidsDAL.CSV.AsteroidsCSVReader(openAsteroidsCSV.FileName, 2);

                    // geht nicht aus einem anderen Thread
                    //lblImportCsvCountAsteroids.Text = "HAllo";

                    while (!reader.EOF)
                    {
                        collector.Add(reader.Read());
                    }
                });

                UpdateCollectorCounterTimer.Stop();

                //UpdateCollectorCounterTimer_Tick(null, null);

                repo = collector.CreateRepository();
                presenter = new Impl.PresenterV1(this, repo);

                log.Log(mko.Log.RC.CreateStatus("Einlesen erfolgreich beendet"));

            }

        }

        private void UpdateCollectorCounterTimer_Tick(object sender, EventArgs e)
        {
            tbxCollectedCount.Text = collector.Count.ToString("D10");

            CollectedAsteroidsBindingSource.DataSource = collector.GetLast(20);
            CollectedAsteroidsBindingSource.ResetBindings(false);

        }

        // Button- Clicks auf Presenter umleiten
        private void btnNewQuery_Click(object sender, EventArgs e)
        {
            presenter.BtnNewClick();
        }


        private void btnDefSort_Click(object sender, EventArgs e)
        {
            presenter.BtnDefSortClick();
        }

        private void btnExeQuery_Click(object sender, EventArgs e)
        {
            presenter.BtnFilterClick();
            QueryResultbindingSource.DataSource = AsteroidSelection.Get();
        }



        // Member von IView

        public bool EnableNewBtn
        {
            get
            {
                return btnNewQuery.Enabled;
            }

            set
            {
                btnNewQuery.Enabled = value;
            }
        }

        public double? DiameterMinInKm
        {
            get
            {
                double diameter;
                return double.TryParse(tbxDiameterMin.Text, out diameter)
                        ? new double?(diameter) : new double?();
            }

            set
            {
                tbxDiameterMin.Text = value.HasValue ? value.Value.ToString() : "";
            }
        }

        public bool EnableDiameterMinInKm
        {
            get
            {
                return tbxDiameterMin.Enabled;
            }

            set
            {
                tbxDiameterMin.Enabled = value;
            }
        }

        public double? DiameterMaxInKm
        {
            get
            {
                double diameter;
                return double.TryParse(tbxDiameterMax.Text, out diameter)
                        ? new double?(diameter) : new double?();
            }

            set
            {
                tbxDiameterMax.Text = value.HasValue ? value.Value.ToString() : "";
            }

        }

        public bool EnableDiameterMaxInKm
        {
            get
            {
                return tbxDiameterMax.Enabled;
            }

            set
            {
                tbxDiameterMax.Enabled = value;
            }
        }

        public double? OrbitSunRadiusMinInAU
        {
            get
            {
                double diameter;
                return double.TryParse(tbxDistanceSunMin.Text, out diameter)
                        ? new double?(diameter) : new double?();
            }

            set
            {
                tbxDistanceSunMin.Text = value.HasValue ? value.Value.ToString() : "";
            }
        }

        public bool EnableOrbitSunRadiusMinInAU
        {
            get
            {
                return tbxDistanceSunMin.Enabled;
            }

            set
            {
                tbxDistanceSunMin.Enabled = value;
            }
        }

        public double? OrbitSunRadiusMaxInAU
        {
            get
            {
                double diameter;
                return double.TryParse(tbxDistanceSunMax.Text, out diameter)
                        ? new double?(diameter) : new double?();
            }

            set
            {
                tbxDistanceSunMax.Text = value.HasValue ? value.Value.ToString() : "";
            }
        }

        public bool EnableOrbitSunRadiusMaxInAU
        {
            get
            {
                return tbxDistanceSunMax.Enabled;
            }

            set
            {
                tbxDistanceSunMax.Enabled = value;
            }
        }

        public bool EnableSortBtn
        {
            get
            {
                return btnDefSort.Enabled;
            }

            set
            {
                btnDefSort.Enabled = value;
            }
        }

        public bool? SortByDiameterAsc
        {
            get
            {
                return new bool?(rbtDiameterUp.Checked);
            }

            set
            {
                if (value.HasValue)
                {
                    rbtDiameterUp.Checked = value.Value;
                    rbtDiameterDown.Checked = !value.Value;
                }
            }
        }

        public bool EnableSortByDiameterAsc
        {
            get
            {
                return rbtDiameterUp.Enabled;
            }

            set
            {
                rbtDiameterUp.Enabled = value;
            }
        }

        public bool? SortByOrbitSunRadiusAsc
        {
            get
            {
                return new bool?(rbtDistanceSunUp.Checked);
            }

            set
            {
                if (value.HasValue)
                {
                    rbtDistanceSunUp.Checked = value.Value;
                    rbtDistanceSunDown.Checked = !value.Value;
                }
            }
        }

        public bool EnableSortByOrbitSunRadiusAsc
        {
            get
            {
                return rbtDistanceSunUp.Enabled;
            }

            set
            {
                rbtDistanceSunUp.Enabled = value;
            }
        }

        public bool EnableFilterBtn
        {
            get
            {
                return btnExeQuery.Enabled;
            }

            set
            {
                btnExeQuery.Enabled = value;
            }
        }

        public IFilteredSortedSet<IAsteroid> AsteroidSelection
        {
            get;
            set;
        }

    }
}
