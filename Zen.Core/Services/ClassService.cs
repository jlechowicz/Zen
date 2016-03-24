using Orient.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zen.Core.Entities;
using Zen.Core.Interfaces;

namespace Zen.Core.Services
{
    public class ClassService : IClassService
    {
        public IZClass[] GetClassesFromDatabase(IZDatabase database)
        {
            string query = "select expand(classes) from metadata:schema";
            var result = database.Command(query).ToSingle();
            var schema = result.GetField<List<ODocument>>("Content");
            var classNames = schema.Select(d => d.GetField<string>("name"));
            var classes = classNames.Select(n => new ZClass { Name = n }).ToArray();
            return classes;
        }
    }
}
