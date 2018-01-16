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

namespace Asteroids.UI.Pattern.MVVM.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        mko.Log.LogServer log = new mko.Log.LogServer();

        public MainWindow()
        {
            InitializeComponent();

            var hnd = new WpfLbxLogHnd(lbxLog);
            log.registerLogHnd(hnd);
        }

        private void mnuFileExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void mnuiFileOpen_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.Multiselect = false;

            if(dlg.ShowDialog()?? false)
            {
                MessageBox.Show("Selected Filename: " + dlg.FileName);
            }
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
    }
}
