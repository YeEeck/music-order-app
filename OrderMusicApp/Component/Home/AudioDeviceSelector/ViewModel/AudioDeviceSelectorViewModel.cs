using NAudio.Wave;
using OrderMusicApp.Utils.AudioPlayerManager;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMusicApp.Component.Home.AudioDeviceSelector.ViewModel
{
    internal class AudioDeviceSelectorViewModel
    {
        private ObservableCollection<string> _audioDevices = new ObservableCollection<string>();

        public ObservableCollection<string> AudioDevices { get { return _audioDevices; } }

        public AudioDeviceSelectorViewModel() {
            foreach (var audioDevice in AudioPlayerManager.Instance.DeviceList)
            {
                _audioDevices.Add(audioDevice.Name);
            }
        }
    }
}
