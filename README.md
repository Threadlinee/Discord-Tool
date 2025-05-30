# dctool 💬

![image](https://github.com/user-attachments/assets/33d3f2ac-ee0c-4740-b862-4a3ce836dda3)


![image](https://github.com/user-attachments/assets/257bc567-8d99-40ed-86ef-98174c8f4ae3)
FOR WINDOWS USERS!!!

GO TO DISCORD-TOOL FOLDER GO BIN/DEBUG/NET8.0/discordtool.exe or whatever the .exe name is

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
    
wget https://packages.microsoft.com/config/debian/12/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
sudo apt-get update

# Install the .NET 8 SDK
sudo apt-get install -y dotnet-sdk-8.0

---

## 🚀 How to Run

1. **Clone the repo**
    ```bash
    git clone https://github.com/dionabazi/Discord-Tool.git
    cd Discord-Tool
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

## ☕ Support Me
If you like this project, feel free to [buy me a coffee](https://ko-fi.com/G2G114SBVV)!

[![Buy Me a Coffee](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/G2G114SBVV)
