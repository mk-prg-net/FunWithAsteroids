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
    public partial class Form1 : Form
    {
        mko.Log.LogServer log = new mko.Log.LogServer();

        AsteroidsBL.IAsteroidsCollector collector;
        AsteroidsBL.IAsteroidsRepository repo;

        public Form1()
        {
            InitializeComponent();

            var lbxHnd = new mko.Log.WinFormListBoxLogHnd(lbxLog);
            log.registerLogHnd(lbxHnd);

            //var lbxLbl = new mko.Log.WinFormStatusStripLogHnd(statusStrip1);

            log.Log(mko.Log.RC.CreateStatus("Initialisierung beendet"));
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

                    while (!reader.EOF)
                    {
                        collector.Add(reader.Read());
                    }                    
                });

                UpdateCollectorCounterTimer.Stop();

                UpdateCollectorCounterTimer_Tick(null, null);

                log.Log(mko.Log.RC.CreateStatus("Einlesen erfolgreich beendet"));
                                
            }

        }

        private void UpdateCollectorCounterTimer_Tick(object sender, EventArgs e)
        {
            lblImportCsvCountAsteroids.Text = collector.Count.ToString("D10");

            CollectedAsteroidsBindingSource.DataSource = collector.GetLast(20);
            CollectedAsteroidsBindingSource.ResetBindings(false);
        }
    }
}
