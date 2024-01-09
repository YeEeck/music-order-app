using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMusicApp.Component.Home.AudioDeviceSelector
{
    internal partial class AudioDeviceSelectorViewModel : ObservableObject
    {
        [ObservableProperty]
        private int selectorIndex;
    }
}
