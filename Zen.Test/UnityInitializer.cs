using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Practices.Unity;
using Zen.Core.Interfaces;
using NSubstitute;
using System.Collections.Generic;

namespace Zen.Test
{
    [TestClass]
    public class UnityInitializer : UnitTestBase
    {
        private IDictionary<string, int> _databasePool;
        [AssemblyInitialize]
        public void Init()
        {
            if (UnityContainer == null)
            {
                UnityContainer = new UnityContainer();
            }

            RegisterServerWithUnity();
            RegisterClientWithUnity();

        }

        private void RegisterClientWithUnity()
        {
            if (_databasePool == null)
            {
                _databasePool = new Dictionary<string, int>();
            }

            var client = Substitute.For<IZClient>();
            client
                .When(x => x.CreateDatabasePool("127.0.0.1", 2424, "UnitTestGraphDatabase", Orient.Client.ODatabaseType.Graph, "testLogin", "testPassword", 10, "UnitTestGraphDatabase"))
                .Do(x =>
                {
                    if (_databasePool.ContainsKey("UnitTestGraphDatabase"))
                    {
                        _databasePool["UnitTestGraphDatabase"]++;
                    }
                    else
                    {
                        _databasePool.Add("UnitTestGraphDatabase", 1);
                    }
                });

            client.DatabasePoolCurrentSize("UnitTestGraphDatabase").Returns(_databasePool["UnitTestGraphDatabase"]);

            client
                .When(x => x.DropDatabasePool("UnitTestGraphDatabase"))
                .Do(x =>
                {
                    if (_databasePool.ContainsKey("UnitTestGraphDatabase"))
                    {
                        if(_databasePool["UnitTestGraphDatabase"] > 0)
                        {
                            _databasePool["UnitTestGraphDatabase"]--;
                        }
                    }
                });
            UnityContainer.RegisterInstance(client);
        }

        private static void RegisterServerWithUnity()
        {
            var server = Substitute.For<IZServer>();
            server.DatabaseExist("UnitTestGraphDatabase").Returns(true);
            server.CreateDatabase(null, Orient.Client.ODatabaseType.Document, Orient.Client.OStorageType.Local).ReturnsForAnyArgs(true);
            UnityContainer.RegisterInstance(server);
        }
    }
}
