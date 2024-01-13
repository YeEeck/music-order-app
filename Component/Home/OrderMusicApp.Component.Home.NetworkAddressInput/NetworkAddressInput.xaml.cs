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
        NetworkAddressInputViewModel vm = new NetworkAddressInputViewModel();
        public NetworkAddressInput()
        {
            InitializeComponent();
            DataContext = vm;
        }
    }

}
