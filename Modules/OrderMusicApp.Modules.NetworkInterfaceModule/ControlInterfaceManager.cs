namespace OrderMusicApp.Modules.ControlInterfaceModule
{
    public class ControlInterfaceManager
    {
        private Dictionary<string, IControlInterface> controlInterfaceList = new();

        private ControlInterfaceManager()
        {
            RegisterControlInterface("WEB", new WebInterface.WebInterface());
            controlInterfaceList["WEB"].Start("127.0.0.1", 8080);
        }

        private static ControlInterfaceManager _instance = new ControlInterfaceManager();

        public static ControlInterfaceManager Instance
        {
            get { return _instance; }
        }

        private void RegisterControlInterface(string name, IControlInterface controlInterface)
        {
            controlInterfaceList.Add(name, controlInterface);
            controlInterface.MessageReceived += ((string param, string message) =>
            {
                MessageRouter(param, message);
            });
        }

        private void MessageRouter(string param, string message)
        {

        }
    }
}
