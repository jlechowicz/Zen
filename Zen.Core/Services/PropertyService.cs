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
    public class PropertyService : IPropertyService
    {
        public IZProperty[] GetPropertiesFromClass(IZDatabase database, string className)
        {
            string query = string.Format("select expand(properties) from (select expand(classes) from metadata:schema) where name = '{0}'", className);
            var result = database.Command(query).ToSingle();
            var schema = result.GetField<List<ODocument>>("Content");
            var propertyNames = schema.Select(d => d.GetField<string>("name"));
            var properties = propertyNames.Select(n => new ZProperty { PropertyName = n, ValueType = OType.Null }).ToArray();
            return properties;
        }
    }
}
