using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMusicApp.Modules.ControlInterfaceModule.WebInterface.Router
{
    public interface IWebRouter
    {
        public string DoRouter(string url, string RequestType); 
    }
}
