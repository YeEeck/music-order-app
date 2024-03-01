using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OrderMusicApp.Modules.ControlInterfaceModule.WebInterface.Router.Route.BaseRoute;

namespace OrderMusicApp.Modules.ControlInterfaceModule.WebInterface.Router.Route
{
    public interface IWebRoute
    {
        public string Do();

        public void RegProcessFunction(Func<string> function);

        public RouteType Type { get; set; }

        public string Name { get; set; }
    }
}
