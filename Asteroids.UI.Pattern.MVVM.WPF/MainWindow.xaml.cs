using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.IO;

namespace Asteroids.UI.Pattern.MVVM.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        mko.Log.LogServer log = new mko.Log.LogServer();


        AsteroidsCollectorMVVM mvvmCollector;
        AsteroidsRepoMVVM mvvmRepo;

        AsteroidsBL.IAsteroidsCollector collector;
        //AsteroidsBL.IAsteroidsRepository repo;

        System.Timers.Timer clock = new System.Timers.Timer(500.0);

        IEnumerable<AsteroidsBL.IAsteroid> Asteroids = new AsteroidsBL.IAsteroid[] { };


        public MainWindow()
        {
            InitializeComponent();

            var hnd = new WpfLbxLogHnd(lbxLog);
            log.registerLogHnd(hnd);

            mvvmCollector = ((AsteroidsCollectorMVVM)FindResource("Collector"));
            mvvmRepo = ((AsteroidsRepoMVVM)FindResource("Repo"));
        }

        private void mnuFileExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private async void mnuiFileOpen_Click(object sender, RoutedEventArgs e)
        {
            tabControlMain.SelectedItem = ImportTab;

            var openAsteroidsCSV = new Microsoft.Win32.OpenFileDialog();
            openAsteroidsCSV.Multiselect = false;

            if(openAsteroidsCSV.ShowDialog()?? false)
            {
                //MessageBox.Show("Selected Filename: " + openAsteroidsCSV.FileName);

                // Erfassung vorbereiten
                mko.TraceHlp.ThrowArgExIfNot(File.Exists(openAsteroidsCSV.FileName), "Die Datei " + openAsteroidsCSV.FileName + " existiert nicht");

                ((AsteroidsCollectorMVVM)FindResource("Collector")).StartCollect();
                collector = ((AsteroidsCollectorMVVM)FindResource("Collector")).Collector;

                clock.AutoReset = true;
                clock.Elapsed += new System.Timers.ElapsedEventHandler(clock_Elapsed);
                clock.Enabled = true;

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

                clock.Stop();

                //UpdateCollectorCounterTimer_Tick(null, null);

                mvvmRepo.Repo = collector.CreateRepository();
                //presenter = new Impl.PresenterV1(this, repo);

                log.Log(mko.Log.RC.CreateStatus("Einlesen erfolgreich beendet"));

            }
        }

        void clock_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            // Das Setzen der Label- Eigenschaft wird an den UI Thread delegiert.
            // Dieses Vorgehen wird durch das STA erzwungen
            //Dispatcher.Invoke(
            //    new Action<string>(time => lblStatusTime.Content = time),
            //    new object[] { DateTime.Now.ToLongTimeString() });

            //// Weiterschalten des ProgressBar
            Dispatcher.Invoke(
                //new Action<int>(sec => { progress.Value = (double)sec; Zeiger.X2 = Zx(sec); Zeiger.Y2 = Zy(sec); }),
                new Action(() => {                    
                    tbxReadCountAsteroids.Text = collector.Count.ToString("D10");

                    // Die Aktualisierung des Ziels der Datenbindung wird gestartet
                    GrdCollected.GetBindingExpression(DataGrid.ItemsSourceProperty).UpdateTarget();                    

                }),
                new object[] {});

            // Direkter Zugriff aus dem Timer- Thread auf die Elemente der Oberfläche 
            // ist verboten !!
            //Zeiger.X2 = Zx(sekunde); 
            //Zeiger.Y2 = Zy(sekunde);
        }


        private void btnClearLog_Click(object sender, RoutedEventArgs e)
        {
            lbxLog.Items.Clear();
        }


        long fib_i = 1;
        long fib_ii = 2;
        private void btnTestLog_Click(object sender, RoutedEventArgs e)
        {
            var fib_iii = fib_i + fib_ii;
            fib_i = fib_ii;
            fib_ii = fib_iii;

            if(fib_iii % 2 == 0)
                log.Log(mko.Log.RC.CreateStatus($"Eine Fibonacci- Zahl {fib_iii}"));
            else
                log.Log(mko.Log.RC.CreateError($"Eine Fibonacci- Zahl {fib_iii}"));
        }

        private void btnClearFib_Click(object sender, RoutedEventArgs e)
        {
            fib_i = 1;
            fib_ii = 2;
            log.Log(mko.Log.RC.CreateStatus("Fibonacci reset"));
        }

        private void btnNewFilter_Click(object sender, RoutedEventArgs e)
        {
            mvvmRepo.NewFilter();
        }

        private void btnDefSort_Click(object sender, RoutedEventArgs e)
        {
            mvvmRepo.NewSortOrderBuilder();
        }

        private void btnFilterAndSort_Click(object sender, RoutedEventArgs e)
        {
            mvvmRepo.NewFilteredSortedSet();
            CountFilteredAsteroids.GetBindingExpression(Label.ContentProperty).UpdateTarget();
            GrdFilteredSorted.GetBindingExpression(DataGrid.ItemsSourceProperty).UpdateTarget();

        }
    }
}
