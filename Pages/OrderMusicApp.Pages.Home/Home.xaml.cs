using OrderMusicApp.Pages.Home.ViewModel;
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

namespace OrderMusicApp.Pages.Home
{
    /// <summary>
    /// Home.xaml µÄ½»»¥Âß¼­
    /// </summary>
    /// 

    public partial class Home : Page
    {
        HomeViewModel vm = new HomeViewModel();
        public Home()
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void AudioDeviceSelector_AudioDeviceChanged(object sender, RoutedEventArgs e)
        {
            int DeviceIndex = (int)e.Source;
            vm.CurrentDeviceIndex = DeviceIndex;
        }
    }
}
