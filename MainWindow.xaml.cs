using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace CyberSecurityBot
{
    public partial class MainWindow : Window
    {
        private readonly Chatbot _chatbot = new Chatbot();

        public MainWindow()
        {
            InitializeComponent();
            StartBot();
        }

        private async void StartBot()
        {
            AppendMessage("🤖 Your Cyber Friend", Colors.Cyan, true);

            // Play voice greeting
            await System.Threading.Tasks.Task.Run(() => _chatbot.PlayVoiceGreeting());

            AppendMessage("Hello! Welcome to Cybersecurity Awareness Bot.", Colors.White);
            AppendMessage("I'm here to help you stay safe online.\n", Colors.LightGray);
            AppendMessage("What is your name?", Colors.LightBlue);
        }

        private void btnSend_Click(object sender, RoutedEventArgs e) => SendMessage();

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                SendMessage();
                e.Handled = true;
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e) => this.Close();

        private void SendMessage()
        {
            string input = txtInput.Text.Trim();
            if (string.IsNullOrEmpty(input)) return;

            AppendMessage($"You: {input}", Colors.LightBlue);

            string response = _chatbot.ProcessInput(input);

            AppendMessage($"🤖 Cyber Friend: {response}", Colors.LightGreen);

            txtInput.Clear();
            chatScroll.ScrollToEnd();

            // Auto close on exit command
            if (input.ToLower() == "exit" || input.ToLower() == "quit" || input.ToLower() == "close")
            {
                System.Threading.Tasks.Task.Delay(1400).ContinueWith(_ =>
                {
                    Dispatcher.Invoke(() => this.Close());
                });
            }
        }

        private void AppendMessage(string message, Color color, bool bold = false)
        {
            var run = new Run(message + "\n\n")
            {
                Foreground = new SolidColorBrush(color),
                FontWeight = bold ? FontWeights.Bold : FontWeights.Normal
            };

            tbChat.Inlines.Add(run);
            chatScroll.ScrollToEnd();
        }
    }
}