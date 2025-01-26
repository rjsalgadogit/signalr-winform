using SignalRWinform.Server.Helpers.SignalR;

namespace SignalRWinform.Server
{
    public partial class MainForm : Form
    {
        private SignalRServer _signalRServer;

        public MainForm()
        {
            InitializeComponent();
            _signalRServer = new SignalRServer();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Run the server in a separate thread to avoid blocking UI
            new Thread(() => _signalRServer.Start()).Start();
        }
    }
}
