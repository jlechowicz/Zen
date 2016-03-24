using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zen.Core.Interfaces;
using Microsoft.Practices.Unity;

namespace Zen.Test
{
    [TestClass]
    public class ClientTests : UnitTestBase
    {
        [TestMethod]
        public void CreateDatabasePoolTest()
        {
            var testClient = UnityContainer.Resolve<IZClient>();
            testClient.CreateDatabasePool("127.0.0.1", 2424, "CreatePool", Orient.Client.ODatabaseType.Document, "TestUser", "TestPassword", 10, "CreatePool");
            Assert.AreEqual(1, testClient.DatabasePoolCurrentSize("CreatePool"));
        }

        [TestMethod]
        public void DeleteDatabasePoolTest()
        {
            var testClient = UnityContainer.Resolve<IZClient>();
            testClient.CreateDatabasePool("127.0.0.1", 2424, "DeletePool", Orient.Client.ODatabaseType.Document, "TestUser", "TestPassword", 10, "DeletePool");
            testClient.DropDatabasePool("DeletePool");
            int count = testClient.DatabasePoolCurrentSize("DeletePool");
            Assert.AreEqual(0, count);
        }
    }
}
