using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interop;

namespace MusicPlayer
{
    internal class CustomMessageBox
    {
        public static MessageBoxResult Show(string message, MessageBoxImage image)
        {
            MessageBoxResult result = MessageBoxResult.None;

            Application.Current.Dispatcher.BeginInvoke((Action)(() =>
            {
                CustomMessageBoxWindow msg = new CustomMessageBoxWindow(message, image);
                msg.ShowDialog();
                result = msg.Result;
            }));

            return result;
            /*

           CustomMessageBoxWindow msg = new CustomMessageBoxWindow(message, image);

            Application.Current.Dispatcher.Invoke(() =>
            {              
                msg.ShowDialog();                
            });
            return msg.Result;
            */
        }
    }
}
