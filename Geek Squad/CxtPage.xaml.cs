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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Geek_Squad
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CxtPage : Page
    {
        string name = "Bob";
        public CxtPage()
        {
            this.InitializeComponent();
            welcomeTv.Text = "Welcome, " + name + "!";
        }

        private void logoutBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void checkStatusBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CheckOrder));
        }

        private void changeInfoBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EditInfo));
        }
    }
}
