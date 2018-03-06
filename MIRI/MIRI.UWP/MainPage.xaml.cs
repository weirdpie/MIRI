using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace MIRI.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new MIRI.App());
        }

        private void BTN_1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(QR),null);
         
        }

        private void BTN_2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Colaborators), null);
           
        }

        private void BTN_3_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Settings), null);
           
        }
    }
}
