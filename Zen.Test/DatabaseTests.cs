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
        public void GetClassesTest()
        {
            var database = Substitute.For<IODatabase>();
            database.Classes.Returns(new IOClass[] { });
            IOClass[] classes = database.Classes;
            Assert.AreEqual(0, classes.Length);
        }

        [TestMethod]
        public void GetUsersTest()
        {
            var database = Substitute.For<IODatabase>();
            database.Users.Returns(new IOUser[] { });
            IOUser[] users = database.Users;
            Assert.AreEqual(0, users.Length);
        }

        [TestMethod]
        public void GetRolesTest()
        {
            var database = Substitute.For<IODatabase>();
            database.Roles.Returns(new IORole[] { });
            IORole[] roles = database.Roles;
            Assert.AreEqual(0, roles.Length);
        }
    }
}
