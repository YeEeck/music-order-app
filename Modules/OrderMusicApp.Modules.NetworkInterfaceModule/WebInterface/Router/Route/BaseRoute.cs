using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMusicApp.Modules.ControlInterfaceModule.WebInterface.Router.Route
{
    public enum RouteType
    {
        GET = 0,
        POST = 1,
    }

    internal class BaseRoute : IWebRoute
    {
        protected Func<string>? ProcessFunction = null;

        public RouteType Type { get; set; }

        public required string Name { get; set; }

        public string Description = "";

        public string Do()
        {
            if (ProcessFunction != null)
            {
                return ProcessFunction();
            }
            return "";
        }

        public void RegProcessFunction(Func<string> function)
        {
            ProcessFunction = function;
        }
    }
}
