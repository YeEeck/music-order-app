using NAudio.Wave;
using OrderMusicApp.Utils.AudioPlayerManager.Obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMusicApp.Utils.AudioPlayerManager
{
    public class AudioPlayerManager
    {
        private static AudioPlayerManager instance = new AudioPlayerManager();

        private AudioPlayerManager() { }

        public static AudioPlayerManager Instance { get { return instance; } }

        public static AudioPlayerManager GetInstance()
        {
            return instance;
        }

        public List<AudioDevice> DeviceList
        {
            get
            {
                List<AudioDevice> result = new List<AudioDevice>();
                foreach (var dev in DirectSoundOut.Devices)
                {
                    result.Add(new AudioDevice() { Guid = dev.Guid, Name = dev.Description });
                }
                return result;
            }
        }

        public void PlayMusic(string path, Guid device)
        {
            DirectSoundOut directSoundOut = new(device);
            AudioFileReader audioFileReader = new(path);
            directSoundOut.Init(audioFileReader);
            directSoundOut.Play();
            Task.Run(() =>
            {
                Thread.Sleep(5000);
                directSoundOut.Stop();
            });
        }
    }
}
