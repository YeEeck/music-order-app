using OrderMusicApp.Modules.ControlInterfaceModule.WebInterface.Router.Route;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMusicApp.Modules.ControlInterfaceModule.WebInterface.Router
{
    public class PageRouter : BaseRouter
    {
        protected override void InitRouteReg()
        {
            base.InitRouteReg();
            Route.BaseRoute homeRoute = new Route.BaseRoute() { Name = "Home", Type = RouteType.GET };

            base.RegRoute("/", homeRoute, () => { return $"<HTML><BODY> Hello world!</BODY></HTML>"; });
        }
    }
}
