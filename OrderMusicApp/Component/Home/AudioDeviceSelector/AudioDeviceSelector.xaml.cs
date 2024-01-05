using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace OrderMusicApp.Component.Home.AudioDeviceSelector
{
    /// <summary>
    /// AudioDeviceSelector.xaml 的交互逻辑
    /// </summary>
    public partial class AudioDeviceSelector : UserControl
    {
        public AudioDeviceSelector()
        {
            InitializeComponent();
            //DataContext = vm;
            //DataContext.ToString();
            //DataContext = this;
            
        }

        [Category("AudioDevices")]
        public static readonly DependencyProperty AudioDevicesProperty = DependencyProperty.Register("AudioDevices", typeof(ObservableCollection<string>), typeof(AudioDeviceSelector), new FrameworkPropertyMetadata(null));

        //private ObservableCollection<string> _audioDevices = new ObservableCollection<string>();

        public ObservableCollection<string> AudioDevices
        {
            get { return (ObservableCollection<string>)GetValue(AudioDevicesProperty); }
            set { SetValue(AudioDevicesProperty, value); }
        }

    }
}
