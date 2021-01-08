using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace CSC_Assistant.Client.Utils
{
    public static class ReflectionUtils
    {
        public static Dictionary<string,string> DisplayAllProperties<T>(T target, System.Type IgnoreAttribute, bool skipNullEmpty = true)
        {
            //Show all the main details for the item
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(x => !System.Attribute.IsDefined(x, IgnoreAttribute)).ToArray();

            var propCount = Props.Length;
            var dict = new Dictionary<string, string>(propCount);

            foreach (PropertyInfo prop in Props)
            {
                var val = prop.GetValue(target);

                //Skip null/empty values
                if (skipNullEmpty && (val == null) || (val.ToString() == string.Empty)) continue;

                dict.Add(prop.Name, val.ToString());
                //sbNames.Append($"{prop.Name}:\n");
                //sbValues.Append($"{val}\n");
            }

            return dict;
        }
    }
}