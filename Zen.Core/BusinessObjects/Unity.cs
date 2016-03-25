using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zen.Core.BusinessObjects
{
    public static class Unity
    {
        private static IUnityContainer _container;

        public static IUnityContainer Instance
        {
            get
            {
                return _container;
            }
        }

        static Unity()
        {
            if (_container == null)
            {
                _container = new UnityContainer();
            }

            var section = ConfigurationManager.GetSection("unity") as UnityConfigurationSection;
            if (section != null && section.Containers.Count > 0)
            {
                section.Configure(_container);
            }
        }
    }
}
