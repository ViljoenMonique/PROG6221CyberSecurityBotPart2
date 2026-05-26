# Cybersecurity Awareness Bot - Part 2

**PROG6221 - Programming 2A**  
**Student:** Monique Viljoen

![Your Cyber Friend ASCII Art](ascii-art-your-cyber-friend.png)

A modern **WPF GUI** Cybersecurity Awareness Chatbot with voice greeting, intelligent responses, memory, and sentiment detection.

## Features

- Voice Greeting on startup (`greeting.wav`)
- Custom ASCII Art displayed in the GUI header
- Remembers user's name and favourite topic (Memory & Recall)
- Keyword Recognition (password, phishing, 2FA, hacked, safe browsing, updates)
- Sentiment Detection (worried, curious, frustrated, etc.)
- Random Responses for better engagement
- Clean dark cyber-themed GUI with Send & Exit buttons
- Exit command (`exit`) or Exit button

## Technologies Used

- C# .NET 8.0
- Windows Presentation Foundation (WPF)
- Object-Oriented Programming (Multiple Classes)
- Dictionaries for keyword & sentiment handling

## Project Structure

```bash
CyberSecurityBotPart2/
├── Assets/
│   └── greeting.wav
├── ascii-art-your-cyber-friend.png
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

