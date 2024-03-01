using OrderMusicApp.Modules.ControlInterfaceModule.WebInterface.Router.Route;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMusicApp.Modules.ControlInterfaceModule.WebInterface.Router
{
    public class BaseRouter : IWebRouter
    {
        protected Dictionary<string, IWebRoute> routeList_Get = new Dictionary<string, IWebRoute>();

        protected Dictionary<string, IWebRoute> routeList_Post = new Dictionary<string, IWebRoute>();

        public BaseRouter() { 
            InitRouteReg();
        }

        protected void RegRoute(string path, IWebRoute route, Func<string> processFunction)
        {
            if (route.Type == RouteType.GET)
            {
                RegGetRoute(path, route, processFunction);
            }
            else
            {
                RegPostRoute(path, route, processFunction);
            }
        }
        
        protected void RegGetRoute(string path, IWebRoute route, Func<string> processFunction)
        {
            route.RegProcessFunction(processFunction);
            routeList_Get.Add(path, route);
        }

        protected void RegPostRoute(string path, IWebRoute route, Func<string> processFunction)
        {
            route.RegProcessFunction(processFunction);
            routeList_Post.Add(path, route);
        }

        protected virtual void InitRouteReg()
        {

        }


        public virtual string DoRouter(string url, string RequestType)
        {
            if (RequestType.ToUpper() == "GET")
            {
                if (!routeList_Get.ContainsKey(url))
                {
                    return "";
                }
                else
                {
                    return routeList_Get[url].Do();
                }
            }
            else
            {
                if (!routeList_Post.ContainsKey(url))
                {
                    return "";
                }
                else
                {
                    return routeList_Post[url].Do();
                }
            }
        }
    }
}
