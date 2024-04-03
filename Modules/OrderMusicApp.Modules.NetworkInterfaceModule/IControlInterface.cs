using OrderMusicApp.Modules.ControlInterfaceModule.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMusicApp.Modules.ControlInterfaceModule
{
    internal interface IControlInterface
    {
        public void Start() { }

        public void Stop() { }

        public bool PausePlay();

        public void ContinuePlay();

        public void AddToPlayList(int id)
        {

        }

        public void RemoveFromPlayList(int id) {
        
        }

        public bool PlayMusic(int id);

        public MusicControlInfo GetCurrentMusicInfo();

        public List<MusicControlInfo> GetPlaylistMusicInfo();
    }
}
