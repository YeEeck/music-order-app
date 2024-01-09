using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
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
    public partial class AudioDeviceSelector : UserControl
    {
        AudioDeviceSelectorViewModel vm = new AudioDeviceSelectorViewModel();
        public AudioDeviceSelector()
        {
            InitializeComponent();
            //DataContext = vm;
            //DataContext.ToString();
            //DataContext = this;
            //DataContext = new AudioDeviceSelectorViewModel();
            WrapGrid.DataContext = vm;
        }

        [Category("AudioDevices")]
        public static readonly DependencyProperty AudioDevicesProperty = DependencyProperty.Register("AudioDevices", typeof(ObservableCollection<string>), typeof(AudioDeviceSelector), new FrameworkPropertyMetadata(null));

        //private ObservableCollection<string> _audioDevices = new ObservableCollection<string>();

        public ObservableCollection<string> AudioDevices
        {
            get { return (ObservableCollection<string>)GetValue(AudioDevicesProperty); }
            set { SetValue(AudioDevicesProperty, value); }
        }

        public static readonly RoutedEvent AudioDeviceChangedEvent = EventManager.RegisterRoutedEvent("AudioDeviceChanged", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(AudioDeviceSelector));

        public event RoutedEventHandler AudioDeviceChanged
        {
            add
            {
                AddHandler(AudioDeviceChangedEvent, value);
            }

            remove
            {
                RemoveHandler(AudioDeviceChangedEvent, value);
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox? control = sender as ComboBox;
            RoutedEventArgs args = new RoutedEventArgs(AudioDeviceChangedEvent, control?.SelectedIndex);
            RaiseEvent(args);
        }
    }

}
