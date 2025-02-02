﻿using GDNET.Server;
using NUnit.Framework;

namespace GDNET.Tests.Server.Objects
{
    public class TestAccount
    {
        [Test]
        public void TestRyuuhouAccount()
        {
            var acc = User.Get(7361923);

            Assert.AreEqual(acc.Username, "Mikotawa", "Usernames are not the same.");
        }

        [Test]
        public void TestShaggy23Account()
        {
            var acc = User.Get(2888);

            Assert.AreEqual(acc.Username, "shaggy23", "Usernames are not the same.");
            Assert.AreEqual(acc.Badge, ModeratorType.Elder, "uh oh brothers.");
        }
    }
}