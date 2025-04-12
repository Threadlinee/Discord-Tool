using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace dctool
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.Title = "dctool";

            while (true)
            {
                Console.Clear();
                Banner();
                Menu();

                ConsoleKeyInfo input = Console.ReadKey();
                char option = input.KeyChar;
                Console.WriteLine("\n");

                switch (option)
                {
                    case '1':
                        await WebhookMessage();
                        break;
                    case '2':
                        await ViewGuildInfo();
                        break;
                    case '3':
                        await CheckMemberStatus();
                        break;
                    case '4':
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }

                Console.WriteLine("\nPress any key to return to the menu...");
                Console.ReadKey();
            }
        }

        static void Banner()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(@"
▓█████▄  ▄████▄     ▄▄▄█████▓ ▒█████   ▒█████   ██▓    
▒██▀ ██▌▒██▀ ▀█     ▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    
░██   █▌▒▓█    ▄    ▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    
░▓█▄   ▌▒▓▓▄ ▄██▒   ░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░    
░▒████▓ ▒ ▓███▀ ░     ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒
 ▒▒▓  ▒ ░ ░▒ ▒  ░     ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░
 ░ ▒  ▒   ░  ▒          ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░
 ░ ░  ░ ░             ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   
   ░    ░ ░                      ░ ░      ░ ░      ░  ░
 ░      ░                                              
               dctool  - Add discord: snoglide540
");
        }

        static void Menu()
        {
            Console.WriteLine("1. Send Webhook Message");
            Console.WriteLine("2. View Guild Info");
            Console.WriteLine("3. Check Member Status");
            Console.WriteLine("4. Exit");
        }

        static async Task WebhookMessage()
        {
            Console.Clear();
            Console.Write("Webhook URL: ");
            string webhook = Console.ReadLine();

            Console.Write("Message: ");
            string message = Console.ReadLine();

            Console.Write("How many messages to send: ");
            if (!int.TryParse(Console.ReadLine(), out int count) || count <= 0)
            {
                Console.WriteLine("Invalid number.");
                return;
            }

            string json = $"{{\"content\":\"{message}\"}}";

            using (HttpClient client = new HttpClient())
            {
                for (int i = 1; i <= count; i++)
                {
                    HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(webhook, content);

                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine($"[✓] Sent message {i}/{count}");
                    }
                    else
                    {
                        Console.WriteLine($"[X] Failed to send message {i}/{count} - Status: {response.StatusCode}");
                    }

                    await Task.Delay(100);
                }
            }

            Console.WriteLine("\nFinished sending messages.");
        }

        static async Task ViewGuildInfo()
        {
            Console.Clear();
            Console.Write("Bot Token: ");
            string token = Console.ReadLine();

            Console.Write("Guild ID: ");
            string guildId = Console.ReadLine();

            string url = $"https://discord.com/api/v10/guilds/{guildId}";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bot {token}");

                HttpResponseMessage response = await client.GetAsync(url);
                string result = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("\nGuild Info:");
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine($"\nFailed to fetch guild info. Status: {response.StatusCode}");
                    Console.WriteLine(result);
                }
            }
        }

        static async Task CheckMemberStatus()
        {
            Console.Clear();
            Console.Write("Bot Token: ");
            string token = Console.ReadLine();

            Console.Write("Guild ID: ");
            string guildId = Console.ReadLine();

            Console.Write("User ID: ");
            string userId = Console.ReadLine();

            string url = $"https://discord.com/api/v10/guilds/{guildId}/members/{userId}";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bot {token}");

                HttpResponseMessage response = await client.GetAsync(url);
                string result = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("\nMember Info:");
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine($"\nFailed to fetch member info. Status: {response.StatusCode}");
                    Console.WriteLine(result);
                }
            }
        }
    }
}
