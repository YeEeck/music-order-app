namespace OrderMusicApp.Utils.CloudMusicService
{
    public class CloudMusicService
    {
        private CloudMusicService() { }

        public static CloudMusicService _instance = new CloudMusicService();

        public static CloudMusicService Instance {  get { return _instance; } }
    }
}
