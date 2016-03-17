using Orient.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zen.Core.Interfaces;

namespace Zen.Core.Entities
{
    public class ZDatabase : ODatabase, IZDatabase
    {
        private string query = "select expand(classes) from metadata:schema";
        public IZClass[] Classes
        {
            get
            {
                ZClass[] classes = QueryClassNames();
                return classes;
            }
        }

        private ZClass[] QueryClassNames()
        {
            var result = Command(query).ToSingle();
            var schema = result.GetField<List<ODocument>>("Content");
            var classNames = schema.Select(d => d.GetField<string>("name"));
            var classes = classNames.Select(n => new ZClass { Name = n }).ToArray();
            return classes;
        }

        public string Name { get; set; }

        public IZRole[] Roles { get; }

        public IZUser[] Users { get; }

        public ZDatabase(string clientAlias) : base(clientAlias) { }
    }
}
