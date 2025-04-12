# dctool 💬

**dctool** is a powerful and lightweight console-based Discord utility built in C#.  
It allows you to interact with Discord webhooks, fetch guild information, and check member status — all through a clean terminal UI.

---

## 📦 Features

- ✅ Send custom messages through Discord webhooks (with message count)
- 🔍 Fetch detailed Guild information using a bot token
- 👤 Check member status by User ID
- 💻 Easy-to-use CLI interface
- 🧠 Built-in JSON formatting and API error handling *(optional)*

---

## ⚙️ Requirements

- [.NET 6 SDK or later](https://dotnet.microsoft.com/download)
- Discord **bot token** with proper permissions and intents
  - `GUILD_MEMBERS` intent **must** be enabled in the bot settings

---

## 🚀 How to Run

1. **Clone the repo**
    ```bash
    git clone https://github.com/yourusername/dctool.git
    cd dctool
    ```

2. **Build the project**
    ```bash
    dotnet build
    ```

3. **Run it**
    ```bash
    dotnet run
    ```

---

## 🛠 Usage

Once you launch the tool, you'll see a menu like this:

Send Webhook Message

View Guild Info

Check Member Status

Exit

yaml
Copy
Edit

### 🔧 Webhook Message
- Paste your Discord webhook URL
- Enter the message
- Specify how many times you want to send it

### 📡 View Guild Info
- Paste your bot token and guild ID
- The tool will query the Discord API and return basic server info

### 👥 Check Member Status
- Enter bot token, guild ID, and the user ID
- Returns user data from the server (roles, nickname, joined_at, etc.)

---

## 📄 Example Output

```bash
[✓] Sent message 1/5
[✓] Sent message 2/5
...
Finished sending messages.

Member Info:
{
  "user": {
    "id": "1234567890",
    "username": "example",
    ...
  },
  "joined_at": "2023-05-01T12:34:56.789000+00:00",
  ...
}
🔐 Disclaimer
This tool is for educational and testing purposes only.
Do not use it to spam or break Discord’s Terms of Service.

👑 Author
Made with ❤️ by @d_540sno

Contributions welcome! Open a PR or issue to improve the tool.

📃 License
This project is licensed under the MIT License.

yaml
Copy
Edit
