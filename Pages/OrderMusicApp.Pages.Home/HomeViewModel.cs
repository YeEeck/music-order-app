﻿using CommunityToolkit.Mvvm.ComponentModel;
using OrderMusicApp.Modules.ControlInterfaceModule;
using OrderMusicApp.Utils.AudioPlayerManager;
using OrderMusicApp.Utils.AudioPlayerManager.Obj;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
            //AudioDeviceList = _audioDevices;
        }

        [ObservableProperty]
        private int currentDeviceIndex;

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

        [ObservableProperty]
        private string ipAddress = "0.0.0.0";

        [ObservableProperty]
        private uint port = 8080;
    }
}
