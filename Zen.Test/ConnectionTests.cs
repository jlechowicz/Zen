using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using Zen.Core.Interfaces;

namespace Zen.Test
{
    [TestClass]
    public class ConnectionTests
    {
        [TestMethod]
        public void ConnectToDatabaseTest()
        {
            var connection = Substitute.For<IOConnection>();
            connection.Open().Returns(0);
            connection.Close().Returns(0);
            using (connection)
            {
                var openResult = connection.Open();
                Assert.AreEqual(0, openResult);
                var closeResult = connection.Close();
                Assert.AreEqual(0, closeResult);
            }
        }

        [TestMethod]
        public void InvalidLoginTest()
        {
            var connection = Substitute.For<IOConnection>();
            connection.Username = "InvalidUsername";
            connection.Password = "InvalidPassword";
            connection.Open().Returns(1);
            using (connection)
            {
                var openResult = connection.Open();
                Assert.AreEqual(1, openResult);
            }
        }
    }
}
