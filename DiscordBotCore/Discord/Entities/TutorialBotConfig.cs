using Discord.WebSocket;

namespace DiscordBotCore.Discord.Entities
{
    public class TutorialBotConfig
    {
        public string Token { get; set; }
        public DiscordSocketConfig SocketConfig { get; set; }
    }
}