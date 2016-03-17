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
            var database = Substitute.For<IZDatabase>();
            database.Classes.Returns(new IZClass[] { });
            IZClass[] classes = database.Classes;
            Assert.AreEqual(0, classes.Length);
        }

        [TestMethod]
        public void GetUsersTest()
        {
            var database = Substitute.For<IZDatabase>();
            database.Users.Returns(new IZUser[] { });
            IZUser[] users = database.Users;
            Assert.AreEqual(0, users.Length);
        }

        [TestMethod]
        public void GetRolesTest()
        {
            var database = Substitute.For<IZDatabase>();
            database.Roles.Returns(new IZRole[] { });
            IZRole[] roles = database.Roles;
            Assert.AreEqual(0, roles.Length);
        }
    }
}
