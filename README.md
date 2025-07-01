# 📝 To-DoApp (.NET MAUI)

A simple yet functional **To-Do List App** built using [Microsoft .NET MAUI](https://learn.microsoft.com/dotnet/maui/), designed to help users manage their daily tasks with ease. This cross-platform application supports real-time task updates, persistent storage, and intuitive UI interactions.

---

## 📱 Features

- ✅ Add new tasks
- 📌 Mark tasks as completed (with strikethrough)
- 🗑️ Swipe-to-delete and delete button
- 💾 Persistent task saving using `Preferences` (local storage)
- 📦 MVVM-friendly architecture
- 🎨 UI built using XAML + C#

---

## 🔧 Tech Stack

- **Framework**: .NET MAUI
- **Language**: C#
- **Markup**: XAML
- **Storage**: `Preferences` from `Microsoft.Maui.Storage`
- **IDE**: JetBrains Rider (macOS)
- **Platform**: iOS Simulator (tested), Android (compatible)

---

## 🚀 Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download)
- [Visual Studio 2022+](https://visualstudio.microsoft.com/) or [JetBrains Rider](https://www.jetbrains.com/rider/)
- Xcode (for iOS development on macOS)
- Android SDK (for Android development)

### Run the App

```bash
git clone git@github.com:AZulUye/To-Do-App.git
cd To-Do-App
dotnet build
dotnet run
```
Or run using IDE of your choice.

---

## 📂 Project Structure

```To-DoApp/
│
├── MainPage.xaml              # Main UI layout (XAML)
├── MainPage.xaml.cs          # Logic & event handling (C#)
├── TodoItem.cs               # Task model with INotifyPropertyChanged
├── BoolToTextDecoration...   # Converter for strikethrough text
├── App.xaml                  # Resource dictionary + converter reference
└── Resources/Styles/         # Colors & styles (optional)
```

---

## 🎓 What I Learned

- Building cross-platform UIs with .NET MAUI
- Managing UI bindings with ObservableCollection<T>
- Implementing command-based interaction using ICommand
- Persisting local data using Preferences
- Applying INotifyPropertyChanged for real-time updates
- Structuring XAML UI with layout controls (Grid, StackLayout, SwipeView)
- Debugging iOS simulator logs and resolving CommandParameter binding issues
- Comparing similarities between .NET MAUI and Kotlin after previous experience

---

## 🧑‍💻 Author
Muhammad Zulkifly Al Firdausy
Flutter Developer

---

## 📃 License
This project is licensed under the MIT License. See the LICENSE file for details.
