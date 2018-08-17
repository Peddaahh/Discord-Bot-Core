using Discord;
using DiscordBotCore.Discord;
using Xunit;

namespace DiscordBotCore.xUnit.Tests
{
    public class SocketConfigTests
    {
        [Fact]
        public void ConfigDefaultTest()
        {
            const LogSeverity expected = LogSeverity.Verbose;

            var actual = SocketConfig.GetDefault().LogLevel;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ConfigNewTest()
        {
            var actual = SocketConfig.GetNew();

            Assert.NotNull(actual);
        }
    }
}