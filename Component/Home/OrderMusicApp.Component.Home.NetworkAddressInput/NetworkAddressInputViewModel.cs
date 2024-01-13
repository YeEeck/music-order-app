using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMusicApp.Component.Home.NetworkAddressInput
{
    internal partial class NetworkAddressInputViewModel : ObservableObject
    {
        [ObservableProperty]
        private string ipAddress = "0.0.0.0";

        [ObservableProperty]
        private int port = 8080;
    }
}
