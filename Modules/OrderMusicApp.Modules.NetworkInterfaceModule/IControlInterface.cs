using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMusicApp.Modules.ControlInterfaceModule
{
    internal interface IControlInterface
    {
        public event Action<string, string> MessageReceived;

        public void Start(string ip, uint port);

        public void Stop();
    }
}
