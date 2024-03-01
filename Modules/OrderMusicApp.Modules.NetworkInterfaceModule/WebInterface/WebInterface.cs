using OrderMusicApp.Modules.ControlInterfaceModule.WebInterface.Router;
using OrderMusicApp.Utils.CmdRunner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OrderMusicApp.Modules.ControlInterfaceModule.WebInterface
{
    internal class WebInterface : IControlInterface
    {
        public event Action<string, string>? MessageReceived;

        private IWebRouter _webRouter = new PageRouter();

        public void Start(string ip, uint port)
        {
            string[] prefixesList = [@$"http://{ip}:{port}/"];
            Task.Run(() =>
            {
                SimpleListenerExample(prefixesList);
            });

        }

        public void Stop()
        {
            throw new NotImplementedException();
        }


        // This example requires the System and System.Net namespaces.
        private void SimpleListenerExample(string[] prefixes)
        {
            if (!HttpListener.IsSupported)
            {
                Console.WriteLine("Windows XP SP2 or Server 2003 is required to use the HttpListener class.");
                return;
            }

            // URI prefixes are required,
            // for example "http://contoso.com:8080/index/".
            if (prefixes == null || prefixes.Length == 0)
                throw new ArgumentException("prefixes");

            // Create a listener.
            HttpListener listener = new HttpListener();
            listener.AuthenticationSchemes = AuthenticationSchemes.Anonymous;
            // Add the prefixes.
            foreach (string s in prefixes)
            {
                listener.Prefixes.Add(s);
            }
            while (true)
            {
                listener.Start();
                Console.WriteLine("Listening...");
                // Note: The GetContext method blocks while waiting for a request.
                HttpListenerContext context = listener.GetContext();
                HttpListenerRequest request = context.Request;
                // Obtain a response object.
                HttpListenerResponse response = context.Response;
                // Construct a response.
                string responseString = _webRouter.DoRouter(request.RawUrl, request.HttpMethod);
                // string responseString = $"<HTML><BODY> Hello world!<br/>{request.RawUrl}</BODY></HTML>";
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
                // Get a response stream and write the response to it.
                response.ContentLength64 = buffer.Length;
                System.IO.Stream output = response.OutputStream;
                output.Write(buffer, 0, buffer.Length);
                // You must close the output stream.
                output.Close();
                listener.Stop();
            }
        }
    }
}
