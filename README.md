# Cybersecurity Awareness Bot - Part 2

**PROG6221 - Programming 2A**  
**Student:** Monique Viljoen

This is **Part 2** of the Cybersecurity Awareness Chatbot. It builds upon the console version from Part 1 and now features a full **WPF Graphical User Interface** with advanced capabilities.

## Features

- **Voice Greeting** on startup (`greeting.wav`)
- **Custom ASCII Art** displayed in the GUI header
- **User Name Memory** – remembers the user's name
- **Favourite Topic Memory** – remembers user's preferred topic
- **Keyword Recognition** – responds to cybersecurity topics (password, phishing, 2FA, hacked, safe browsing, updates)
- **Sentiment Detection** – detects and responds to emotions (worried, curious, frustrated, etc.)
- **Random Responses** – provides variety in answers
- **Clean Dark-Themed GUI** with Send and Exit buttons
- **Exit Command** – type `exit` or click Exit button

## Technologies

- C# .NET 8.0
- Windows Presentation Foundation (WPF)
- Object-Oriented Programming (Multiple Classes)
- Dictionaries for keyword and sentiment handling


## Project Structure

```bash
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

