# Cybersecurity Awareness Bot - Part 2

**PROG6221 - Programming 2A**  
**Student:** Monique Viljoen

This is the **Part 2** version of the Cybersecurity Awareness Chatbot. It builds upon the console application from Part 1 and now features a full **WPF Graphical User Interface**.

## ✨ Key Features (Part 2)

- Modern WPF GUI with dark cyber theme
- Voice Greeting on startup
- Custom ASCII Art displayed in the header
- Remembers user's name and favourite topic (Memory & Recall)
- Keyword Recognition (password, phishing, 2FA, hacked, safe browsing, etc.)
- Sentiment Detection (responds to worried, curious, frustrated, etc.)
- Random Responses for better engagement
- Exit button and `exit` command

## Project Structure

├── Assets/
│   └── greeting.wav
├── MainWindow.xaml
├── MainWindow.xaml.cs
├── Chatbot.cs
├── KeywordResponder.cs
├── SentimentDetector.cs
├── MemoryStore.cs
├── AudioPlayer.cs
├── README.md
└── .github/workflows/dotnet.yml

##  GitHub Actions CI Status

<img src="https://github.com/ViljoenMonique/PROG6221CyberSecurityBot/actions/workflows/dotnet.yml/badge.svg" alt="GitHub Actions CI">

