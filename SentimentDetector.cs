using System.Collections.Generic;

namespace CyberSecurityBot
{
    public class SentimentDetector
    {
        private readonly Dictionary<string, string> _responses = new Dictionary<string, string>();

        public SentimentDetector()
        {
            // Worried / Scared / Anxious
            _responses["worried"] = "I'm sorry you're feeling worried. Let's work through this together and keep you safe online.";
            _responses["scared"] = "I understand this can be scary. I'm here to help you protect yourself step by step.";
            _responses["anxious"] = "It's normal to feel anxious about online safety. Let's address your concerns.";

            // Frustrated / Confused
            _responses["frustrated"] = "I understand this is frustrating. Let me explain it more clearly and simply.";
            _responses["confused"] = "No worries at all! Let me try to explain it in a simpler way.";

            // Curious / Interested
            _responses["curious"] = "Great question! I'm happy to explain in more detail.";
            _responses["interested"] = "Excellent! I'm glad you're interested in cybersecurity.";

            // Positive / Thanks
            _responses["thanks"] = "You're very welcome! Glad I could help 😊";
            _responses["thank"] = "You're very welcome! Glad I could help 😊";
            _responses["good"] = "I'm happy you're feeling positive! Let's keep learning together.";
        }

        public string GetResponse(string input)
        {
            string lower = input.ToLower();
            foreach (var word in _responses.Keys)
            {
                if (lower.Contains(word))
                    return _responses[word];
            }
            return "";
        }
    }
}