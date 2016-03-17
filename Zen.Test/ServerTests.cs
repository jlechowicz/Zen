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
        public void CreateDatabaseTest()
        {
            
            var testServer = UnityContainer.Resolve<IZServer>();

            using (testServer)
            {
                var result = testServer.CreateDatabase("FooDB", Orient.Client.ODatabaseType.Document, Orient.Client.OStorageType.Local);
                Assert.IsTrue(result);
                Assert.IsTrue(testServer.DatabaseExist("FooDB"));
            }

            //testClient.DropDatabasePool("UnitTestDatabase");
            //Assert.AreEqual(0, testClient.DatabasePoolCurrentSize("UnitTestDatabase"));
        }

        [TestMethod]
        public void DeleteDatabaseTest()
        {
            var testServer = UnityContainer.Resolve<IZServer>();

            using (testServer)
            {
                if (!testServer.DatabaseExist("BarDB"))
                {
                    testServer.CreateDatabase("BarDB", Orient.Client.ODatabaseType.Document, Orient.Client.OStorageType.Local);
                }
                testServer.DropDatabase("BarDB");
                Assert.IsFalse(testServer.DatabaseExist("BarDB"));
            }
        }
    }
}
