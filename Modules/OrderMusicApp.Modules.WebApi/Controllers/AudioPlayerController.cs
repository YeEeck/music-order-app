using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderMusicApp.Modules.ControlInterfaceModule;

namespace OrderMusicApp.Modules.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AudioPlayerController : ControllerBase
    {
        private ControlInterface _service = ControlInterface.Instance;

        // POST: AudioPlayerController/Play
        [HttpPost]
        [Route("Play")]
        public Dictionary<string, object> Play([FromBody] Body data)
        {

            bool success = _service.PlayMusic(data.id);
            Dictionary<string, object> result = new Dictionary<string, object>
            {
                { "id", data.id },
                { "success", success }
            };
            return result;
        }

        [HttpPost]
        [Route("Pause")]
        public Dictionary<string, object> Pause()
        {
            bool success = _service.PausePlay();
            Dictionary<string, object> result = new Dictionary<string, object> {
                {"success", success}
            };
            return result;
        }

        public class Body
        {
            public int id;
        }
    }
}
