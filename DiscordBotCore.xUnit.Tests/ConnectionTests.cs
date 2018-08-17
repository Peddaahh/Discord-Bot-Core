using System.Threading.Tasks;
using Discord.Net;
using DiscordBotCore.Discord;
using DiscordBotCore.Discord.Entities;
using Xunit;

namespace DiscordBotCore.xUnit.Tests
{
    public class ConnectionTests
    {
        [Fact]
        public void ConnectionAsyncTest()
        {
            Assert.ThrowsAsync<HttpException>(AttemptWrongConnect);
        }

        private async Task AttemptWrongConnect()
        {
            var conn = Unity.Resolve<Connection>();
            await conn.ConnectAsync(new TutorialBotConfig {Token = "FAKE-TOKEN"});
        }
    }
}