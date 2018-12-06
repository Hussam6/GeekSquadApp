using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public sealed partial class CreateUser : Page
    {
        List<string> provinces = new List<string>();
        public CreateUser()
        {
            this.InitializeComponent();
            provinces.Add("Alberta");
            provinces.Add("British Columbia");
            provinces.Add("Manitoba");
            provinces.Add("New Bruswick");
            provinces.Add("Newfoundland");
            provinces.Add("Northwest Territories");
            provinces.Add("Nova Scotia");
            provinces.Add("Nunavut");
            provinces.Add("Ontario");
            provinces.Add("Prince Edward Island");
            provinces.Add("Quebec");
            provinces.Add("Saskatchewan");
            provinces.Add("Yukon");
        }

        private void OnClickEnterBtn(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CxtPage));
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
