using OrderMusicApp.Pages.Home.ViewModel;
using OrderMusicApp.Utils.AudioPlayerManager;
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
            int DeviceIndex = (int)e.OriginalSource;
            vm.CurrentDeviceIndex = DeviceIndex;
        }

        private void Audio_Output_Button_Click(object sender, RoutedEventArgs e)
        {
            AudioPlayerManager.Instance.PlayMusic("D:\\CloudMusic\\1.mp3", vm.CurrentDeviceGuid);
        }

        private void AudioDeviceSelector_MouseUp(object sender, MouseButtonEventArgs e)
        {
            vm.UpdateAudioDeviceListData();
        }
    }
}
