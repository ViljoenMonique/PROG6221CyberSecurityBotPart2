//Added custom ASCII art "Your Cyber Friend" in GUI header

using System;

namespace CyberSecurityBot
{
    public class Chatbot
    {
        private readonly AudioPlayer _audioPlayer = new AudioPlayer();
        private readonly MemoryStore _memory = new MemoryStore();
        private readonly SentimentDetector _sentiment = new SentimentDetector();
        private readonly KeywordResponder _keywords = new KeywordResponder();

        public void PlayVoiceGreeting()
        {
            _audioPlayer.PlayGreeting();
        }

        public string ProcessInput(string input)
        {
            string lower = input.ToLower().Trim();

            if (lower == "exit" || lower == "quit" || lower == "close")
                return "Goodbye! Stay safe online! 👋";

            // Memory - Name
            if (_memory.UserName == null)
            {
                string name = ExtractName(input);
                if (!string.IsNullOrWhiteSpace(name))
                {
                    _memory.UserName = name;
                    return $"Nice to meet you, {name}! What is your favourite cybersecurity topic?";
                }
            }

            // Memory - Favourite Topic
            if (_memory.FavouriteTopic == null && (lower.Contains("favourite") || lower.Contains("favorite")))
            {
                _memory.FavouriteTopic = input;
                return $"Excellent! I'll remember that your favourite topic is {_memory.FavouriteTopic} and give you more related tips.";
            }

            string greeting = !string.IsNullOrEmpty(_memory.UserName) ? $"{_memory.UserName}, " : "";

            // Sentiment Detection (High Priority)
            string sentimentReply = _sentiment.GetResponse(input);
            if (!string.IsNullOrEmpty(sentimentReply))
                return greeting + sentimentReply;

            // Special Responses
            if (lower.Contains("how are you"))
                return greeting + "I'm doing great, thanks for asking! How can I help you stay safe online today?";

            // Keyword Recognition
            string? keywordReply = _keywords.GetResponse(input);
            if (!string.IsNullOrEmpty(keywordReply))
                return greeting + keywordReply;

            // Memory Recall
            if (!string.IsNullOrEmpty(_memory.FavouriteTopic))
                return greeting + $"Since you mentioned {_memory.FavouriteTopic}, would you like more tips on that?";

            return greeting + "Interesting question! Feel free to ask me about passwords, phishing, 2FA, hacked accounts, or safe browsing.";
        }

        private string ExtractName(string input)
        {
            string lower = input.ToLower();
            if (lower.Contains("my name is")) return input.Substring(lower.IndexOf("my name is") + 10).Trim();
            if (lower.Contains("name is")) return input.Substring(lower.IndexOf("name is") + 8).Trim();
            if (lower.Contains("i am")) return input.Substring(lower.IndexOf("i am") + 4).Trim();

            if (input.Split(' ').Length <= 3 && input.Length > 2)
                return input.Trim();

            return "";
        }

        public void DisplayAsciiLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
  _____   ___   _   _   ____     ____   _   _   _____   ____   _   _   ____  
 / ___/  / _ \ | | | | / __ \   / __ \ | | | | |  _  \ / __ \ | | | | / __ \ 
/ /     | | | | | | | | |  | |  | |  | | | | | | | | | |  | | | | | | |  | |
| |     | |_| | |_| | | |__| |  | |__| | |_| | | |_| | | |__| | |_| | | |__| |
 \____/  \___/  \___/  \____/    \____/  \___/  |_____/  \____/  \___/   \____/ 

               Y O U R   C Y B E R   F R I E N D
");
            Console.WriteLine("".PadRight(80, '='));
            Console.ResetColor();
        }
    }
}
