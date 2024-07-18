using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using OrderMusicApp.Modules.ControlInterfaceModule;
using OrderMusicApp.Utils.AudioPlayerManager;
using OrderMusicApp.Utils.AudioPlayerManager.Obj;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace OrderMusicApp.Pages.Home.ViewModel
{
    internal partial class HomeViewModel : ObservableObject
    {
        private readonly ObservableCollection<string> _audioDevices = [];

        private readonly ControlInterface controlInterfaceManager = ControlInterface.Instance;

        public ObservableCollection<string> AudioDeviceList { get { return _audioDevices; } }

        public HomeViewModel()
        {
            UpdateAudioDeviceListData();
            AudioTestCommand = new RelayCommand(AudioTest);
            ServerLinkTestCommand = new RelayCommand(ServerLinkTest);
            //AudioDeviceList = _audioDevices;
        }

        [ObservableProperty]
        private int currentDeviceIndex;

        [ObservableProperty]
        private string ipAddress = "0.0.0.0";

        [ObservableProperty]
        private uint port = 8080;

        public Guid CurrentDeviceGuid
        {
            get
            {
                return AudioPlayerManager.Instance.DeviceList.ToArray()[CurrentDeviceIndex].Guid;
            }
        }

        public void UpdateAudioDeviceListData()
        {
            foreach (var audioDevice in AudioPlayerManager.Instance.DeviceList)
            {
                _audioDevices.Add(audioDevice.Name);
            }
        }

        public ICommand AudioTestCommand { get; }

        private void AudioTest()
        {
            AudioPlayerManager.Instance.PlayMusic("D:\\CloudMusic\\1.mp3", CurrentDeviceGuid);
        }

        public ICommand ServerLinkTestCommand { get; }

        private void ServerLinkTest()
        {
            Task.Run(() =>
            {
                Modules.WebApi.Program.Main(["", IpAddress, Port.ToString()]);
            });
            Process.Start(new ProcessStartInfo($"https://127.0.0.1:{Port}") { UseShellExecute = true });
        }
    }
}
