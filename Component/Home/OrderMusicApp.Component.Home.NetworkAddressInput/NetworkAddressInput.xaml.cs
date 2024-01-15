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

namespace OrderMusicApp.Component.Home.NetworkAddressInput
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class NetworkAddressInput : UserControl
    {
        readonly NetworkAddressInputViewModel vm;

        public NetworkAddressInput()
        {
            InitializeComponent();
            vm = new();
            //WrapGrid.DataContext = vm;
        }
        

        [Category("IpAddress")]
        public static readonly DependencyProperty IpAddressProperty = DependencyProperty.Register("IpAddress", typeof(string), typeof(NetworkAddressInput), new PropertyMetadata(""));

        public string IpAddress
        {
            get { return (string)GetValue(IpAddressProperty); }
            set { SetValue(IpAddressProperty, value); }
        }

        [Category("Port")]
        public static readonly DependencyProperty PortProperty = DependencyProperty.Register("Port", typeof(string), typeof(NetworkAddressInput), new PropertyMetadata(""));

        public uint Port
        {
            get { return (uint)GetValue(IpAddressProperty); }
            set { SetValue(IpAddressProperty, value); }
        }
    }

}
