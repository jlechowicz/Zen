using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using Zen.Core.Interfaces;
using Microsoft.Practices.Unity;

namespace Zen.Test
{
    [TestClass]
    public class ServerTests : UnitTestBase
    {
        [TestMethod]
        public void ConnectToDatabaseTest()
        {
            var testServer = UnityContainer.Resolve<IZServer>();
            using (testServer)
            {
                Assert.IsTrue(testServer.DatabaseExist("UnitTestDatabase"));
            }
        }

        [TestMethod]
        public void InvalidLoginTest()
        {
            throw new NotImplementedException();
        }
    }
}
