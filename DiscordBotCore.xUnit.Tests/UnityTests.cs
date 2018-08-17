﻿using DiscordBotCore.Storage;
using Xunit;

namespace DiscordBotCore.xUnit.Tests
{
    public class UnityTests
    {
        [Fact]
        public void UnityResolveTwoObjectsTest()
        {
            var storage1 = Unity.Resolve<IDataStorage>();
            var storage2 = Unity.Resolve<IDataStorage>();

            Assert.NotNull(storage1);
            Assert.NotNull(storage2);
            Assert.Same(storage1, storage2);
        }
    }
}
