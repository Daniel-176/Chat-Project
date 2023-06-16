using Newtonsoft.Json;
using SuperSocket.ClientEngine;
using WebSocket4Net;
using System;
using System.Windows.Forms;


namespace chat
{
    public partial class Form1 : Form
    {
        private WebSocket websocket;
        private string usernameFilePath = "username.txt";
        private string savedUsername;

        public Form1()
        {
            InitializeComponent();

            connectingscreen.Size = this.Size;
            savedUsername = LoadSavedUsername();
            username.Text = savedUsername;
            websocket = new WebSocket("ws://localhost:8080");

            websocket.Opened += (sender, e) =>
            {
                // Update the label text when connected
                UpdateStatusLabel("Status: Connected");
                connectingscreen.Size = new Size(0, 0);
            };

            websocket.Closed += (sender, e) =>
            {
                // Update the label text when disconnected
                UpdateStatusLabel("Status: Disconnected");
                connectingscreen.Size = this.Size;
                ConnectWebSocket();
            };

            websocket.Error += (sender, e) =>
            {
                UpdateStatusLabel("Status: ERROR");
            };

            websocket.MessageReceived += (sender, e) =>
            {
                // Handle the received message
                HandleReceivedMessage(e.Message);
            };

            ConnectWebSocket();
        }

        private void ConnectWebSocket()
        {
            try
            {
                websocket.Open();
            }
            catch (Exception ex)
            {
                // Handle connection error
                UpdateStatusLabel($"Status: Connection Error - {ex.Message}");
            }
        }

        private void KEYDOWNN(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevents the default behavior of the Enter key

                // Create your JSON message object
                var message = new { type = "sendmsg", UserName = username.Text, txt = chatbox.Text };

                // Serialize the message object to JSON
                string json = JsonConvert.SerializeObject(message);
                string stringifyjson = JsonConvert.ToString(json);

                // Send the JSON message through the WebSocket
                websocket.Send(stringifyjson);
                chatbox.Text = "";
            }
        }

        private void HandleReceivedMessage(string data)
        {
            // Convert the byte array to a string
            dynamic receivedMessage = JsonConvert.DeserializeObject(data);

            // Extract the relevant information from the received message
            string messageType = receivedMessage.type;
            string userName = receivedMessage.UserName;
            string text = receivedMessage.txt;

            // Update the UI or perform any other actions based on the received message
            if (messageType == "sendmsg")
            {
                string formattedMessage = $"{userName}: {text}";
                chatlist.Items.Add(formattedMessage);
            }
        }

        private string LoadSavedUsername()
        {
            try
            {
                if (File.Exists(usernameFilePath))
                {
                    return File.ReadAllText(usernameFilePath);
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
                Console.WriteLine($"Error loading saved username: {ex.Message}");
            }

            return string.Empty;
        }

        private void SaveUsername(string username)
        {
            try
            {
                File.WriteAllText(usernameFilePath, username);
            }
            catch (Exception ex)
            {
                // Handle the exception
                Console.WriteLine($"Error saving username: {ex.Message}");
            }
        }

        private void UpdateStatusLabel(string status)
        {
            if (statusLabel.InvokeRequired)
            {
                // If called from a different thread, invoke the method on the UI thread
                Invoke(new MethodInvoker(() => UpdateStatusLabel(status)));
            }
            else
            {
                // Update the label text
                statusLabel.Text = status;
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            SaveUsername(username.Text);
        }
    }
}