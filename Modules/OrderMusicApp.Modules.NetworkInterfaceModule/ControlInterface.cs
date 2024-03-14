using OrderMusicApp.Modules.ControlInterfaceModule.Entity;

namespace OrderMusicApp.Modules.ControlInterfaceModule
{
    public class ControlInterface : IControlInterface
    {
        private static ControlInterface _instance = new ControlInterface();

        public static ControlInterface Instance { get { return _instance; } }

        private ControlInterface()
        {
            Task.Run(() =>
            {
                WebApi.Program.Main([]);
            });
        }

        public void ContinuePlay()
        {
            throw new NotImplementedException();
        }

        public MusicControlInfo GetCurrentMusicInfo()
        {
            throw new NotImplementedException();
        }

        public List<MusicControlInfo> GetPlaylistMusicInfo()
        {
            throw new NotImplementedException();
        }

        public void PausePlay()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
