using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mko.Log;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Asteroids.UI.Pattern.MVVM.WPF
{
    public class WpfLbxLogHnd : mko.Log.ILogHnd
    {

        ListBox lbx;

        static Brush RedText
        {
            get
            {
                if(_RedText== null)
                {
                    _RedText = new SolidColorBrush(Colors.DarkRed);
                }
                return _RedText;
            }
        }
        static Brush _RedText;
        
        static Brush BlueText
        {
            get
            {
                if (_BlueText == null)
                {
                    _BlueText = new SolidColorBrush(Colors.DarkBlue);
                }
                return _BlueText;
            }
        }
        static Brush _BlueText;

        static void SetMonospaced12pt(dynamic UiTxtElem, Brush brush)
        {
            UiTxtElem.Foreground = brush;
            UiTxtElem.FontFamily = new FontFamily("Consolas");
            UiTxtElem.FontSize = 12;                
        }

        public WpfLbxLogHnd(ListBox lbx)
        {
            this.lbx = lbx;
        }

        public void OnLog(string userId, ILogInfo info)
        {            

            var dp = new DockPanel();
            dp.HorizontalAlignment = HorizontalAlignment.Left;

            var Time = new TextBlock();
            SetMonospaced12pt(Time, BlueText);
            Time.Text = info.LogDate.ToLongTimeString();
            Time.TextAlignment = TextAlignment.Center;
            Time.Width = 80;

            dp.Children.Add(Time);

            var Info = new TextBlock();
            Info.HorizontalAlignment = HorizontalAlignment.Stretch;
            Info.Text = info.Message;

            if (info.LogType == EnumLogType.Error)
                SetMonospaced12pt(Info, RedText);
            else
                SetMonospaced12pt(Info, BlueText);

            dp.Children.Add(Info);

            lbx.Items.Add(new ListBoxItem()
            {
                Content = dp
            });
        }

        public void SetSelfDeregisterDelegate(DgDeregisterILogHnd dg)
        {
            
        }
    }
}
