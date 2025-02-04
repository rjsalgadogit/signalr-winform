using Microsoft.AspNetCore.SignalR.Client;
using System.Windows.Forms;

namespace SignalRWinform.Client
{
    public partial class MainForm : Form
    {
        private string _connectionId;
        private HubConnection _hubConnection;

        public MainForm()
        {
            InitializeComponent();
            InitializeConnection();
            StartConnection();


            textBox1.KeyUp += textBox1_KeyUp;
        }

        private void InitializeConnection()
        {
            _hubConnection = new HubConnectionBuilder()
                .WithUrl("http://localhost:5055/signalr-hub") // Replace with your server URL
                .WithAutomaticReconnect()
                .Build();

            // Receive a message from the server
            _hubConnection.On<string, string>("ReceiveMessage", (user, message) =>
            {
                AppendMessage($"{user}: {message}");
            });
        }

        private void AppendMessage(string message)
        {
            Invoke((Action)(() => richTextBox1.AppendText($"{message} {Environment.NewLine}")));
            //richTextBox1.AppendText($"{message} {Environment.NewLine}");
        }

        private async void StartConnection()
        {
            // Set and display the connection ID (optional)
            _hubConnection.On<string>("SetConnectionId", (connectionId) =>
            {
                _connectionId = connectionId;

                AppendMessage("Connected to the server.");
                AppendMessage($"Your Connection ID: {connectionId}");
            });

            try
            {
                await _hubConnection.StartAsync();
            }
            catch (Exception ex)
            {
                AppendMessage($"Error: {ex.Message}");
            }
        }

        private async Task SendMessage(string input)
        {
            try
            {
                if (_hubConnection.State == HubConnectionState.Connected)
                {
                    await _hubConnection.SendAsync("SendMessage", _connectionId, input);
                    textBox1.Clear();
                    textBox1.Focus();
                }
                else
                    AppendMessage("Not connected to the server.");
            }
            catch (Exception ex)
            {
                AppendMessage($"Error: {ex.Message}");
            }
        }

        private async void btnSendMessage_Click(object sender, EventArgs e)
        {
            await SendMessage(textBox1.Text);
        }

        private async void ProcessRFIDInput(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                // Example: Check if the input matches an RFID format
                //MessageBox.Show($"RFID Detected: {input}", "RFID Scanner");
                await SendMessage(input);
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            // Check if the last character was entered
            string inputText = textBox1.Text;

            // If Enter key is pressed, process input
            if (e.KeyCode == Keys.Enter)
            {
                ProcessRFIDInput(inputText);
            }
        }
    }
}
