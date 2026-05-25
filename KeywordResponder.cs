//Added keyword recognition system with multiple cybersecurity topics

using System;
using System.Collections.Generic;

namespace CyberSecurityBot
{
    public class KeywordResponder
    {
        private readonly Dictionary<string, List<string>> _responses = new Dictionary<string, List<string>>();
        private readonly Random _random = new Random();

        public KeywordResponder()
        {
            InitializeResponses();
        }

        private void InitializeResponses()
        {
            // Password Security
            _responses["password"] = new List<string>
            {
                "Strong passwords should be at least 12 characters long with a mix of uppercase, lowercase, numbers and symbols.",
                "Never reuse the same password across different websites. Use a password manager.",
                "Consider using passphrases – they are easier to remember and very secure."
            };

            // Phishing / Scam
            _responses["phish"] = new List<string>
            {
                "Never click links from unknown senders. Phishing is one of the most common cyber attacks.",
                "Always check the sender's email address carefully before clicking anything.",
                "Scammers often create urgency or fear. Take a moment to verify before acting."
            };

            // 2FA / Two-Factor Authentication
            _responses["2fa"] = new List<string>
            {
                "Two-Factor Authentication (2FA) adds a very strong extra layer of security.",
                "Always enable 2FA on your email, banking, and social media accounts.",
                "Use an authenticator app instead of SMS for better security."
            };

            // Hacked Account
            _responses["hacked"] = new List<string>
            {
                "If you suspect your account was hacked, change your password immediately and enable 2FA.",
                "Run a malware scan on your device and monitor your accounts for suspicious activity."
            };

            // Safe Browsing
            _responses["safe"] = new List<string>
            {
                "Always look for the HTTPS padlock in the address bar and keep your browser updated.",
                "Avoid using public Wi-Fi for sensitive activities or use a reliable VPN."
            };

            // Software Updates
            _responses["update"] = new List<string>
            {
                "Always keep your operating system, browser, and apps updated to patch security vulnerabilities."
            };
        }

        public string? GetResponse(string input)
        {
            string lower = input.ToLower();
            foreach (var key in _responses.Keys)
            {
                if (lower.Contains(key))
                {
                    var list = _responses[key];
                    return list[_random.Next(list.Count)];
                }
            }
            return null;
        }
    }
}
