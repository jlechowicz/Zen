using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Practices.Unity;
using Zen.Core.Interfaces;
using NSubstitute;
using System.Collections.Generic;

namespace Zen.Test
{
    [TestClass]
    public class GlobalTestInitializer : UnitTestBase
    {
        private static IDictionary<string, int> _databasePool;
        private static IList<string> _databases;
        private static readonly string INVALID_USERNAME = "invuser";
        private static readonly string INVALID_PASSWORD = "invpassword";

        [AssemblyInitialize]
        public static void Init(TestContext context)
        {
            if (UnityContainer == null)
            {
                UnityContainer = new UnityContainer();
            }

            RegisterServerWithUnity();
            RegisterClientWithUnity();

        }

        private static void RegisterClientWithUnity()
        {
            if (_databasePool == null)
            {
                _databasePool = new Dictionary<string, int>();
            }

            var client = Substitute.For<IZClient>();

            SetupClientMocks(client);

            UnityContainer.RegisterInstance(client);
        }

        private static void SetupClientMocks(IZClient client)
        {
            client
                            .When(x => x.CreateDatabasePool(Arg.Any<string>(), Arg.Any<int>(), Arg.Any<string>(), Arg.Any<Orient.Client.ODatabaseType>(), Arg.Any<string>(), Arg.Any<string>(), Arg.Any<int>(), Arg.Any<string>()))
                            .Do(x =>
                            {
                                string username = x.ArgAt<string>(4).Trim().ToLowerInvariant();
                                string password = x.ArgAt<string>(5).Trim().ToLowerInvariant();

                                if (username.Equals(INVALID_USERNAME) || username.Equals(INVALID_PASSWORD))
                                {
                                    throw new ArgumentException("Invalid login credentials.");
                                }

                                if (_databasePool.ContainsKey(x.ArgAt<string>(7)))
                                {
                                    _databasePool[x.ArgAt<string>(7)]++;
                                }
                                else
                                {
                                    _databasePool.Add(x.ArgAt<string>(7), 1);
                                }
                            });

            client
                .DatabasePoolCurrentSize(Arg.Any<string>()).Returns(x => _databasePool[x.Arg<string>()]);

            client
                .WhenForAnyArgs(x => x.DropDatabasePool(Arg.Any<string>()))
                .Do(x =>
                {
                    if (_databasePool.ContainsKey(x.Arg<string>()))
                    {
                        if (_databasePool[x.Arg<string>()] > 0)
                        {
                            _databasePool[x.Arg<string>()]--;
                        }
                    }
                });
        }

        private static void RegisterServerWithUnity()
        {
            var server = Substitute.For<IZServer>();
            if (_databases == null)
            {
                _databases = new List<string>();
            }

            SetupServerMocks(server);

            UnityContainer.RegisterInstance(server);
        }

        private static void SetupServerMocks(IZServer server)
        {
            server.DatabaseExist(Arg.Any<string>()).ReturnsForAnyArgs(x => { return _databases.Contains(x.Arg<string>()); });

            server
                .CreateDatabase(Arg.Any<string>(), Arg.Any<Orient.Client.ODatabaseType>(), Arg.Any<Orient.Client.OStorageType>())
                .Returns(x => 
                {
                    if (!_databases.Contains(x.Arg<string>()))
                    {
                        _databases.Add(x.Arg<string>());
                        return true;
                    }
                    else
                    {
                        throw new ArgumentException(string.Format("Cannot add Database '{0}'. Database already exists.", x.Arg<string>()));
                    }
                });

            server
                .When(x => x.DropDatabase(Arg.Any<string>()))
                .Do(x =>
                {
                    if (_databases.Contains(x.Arg<string>()))
                    {
                        _databases.Remove(x.Arg<string>());
                    }
                    else
                    {
                        throw new ArgumentException(string.Format("Cannot drop Database '{0}'. Database not found.", x.Arg<string>()));
                    }
                });
        }
    }
}
