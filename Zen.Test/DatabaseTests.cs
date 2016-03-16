using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zen.Core.Interfaces;
using NSubstitute;

namespace Zen.Test
{
    [TestClass]
    public class DatabaseTests
    {
        [TestMethod]
        public void ConnectToDatabaseTest()
        {
            var database = Substitute.For<IODatabase>();
            string username = string.Empty;
            string password = string.Empty;
            database.Connect(username, password).Returns(1);
            int result = database.Connect(username, password);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void InvalidLoginTest()
        {
            var database = Substitute.For<IODatabase>();
            string username = "username";
            string password = "invalidpassword";
            database.Connect(username, password).Returns(0);
            int result = database.Connect(username, password);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void GetClassesTest()
        {
            var database = Substitute.For<IODatabase>();
            string username = string.Empty;
            string password = string.Empty;
            database.Connect(username, password).Returns(1);
            database.GetClasses().Returns(new IOClass[] { });
            IOClass[] classes = database.GetClasses();
            Assert.AreEqual(0, classes.Length);
        }
    }
}
