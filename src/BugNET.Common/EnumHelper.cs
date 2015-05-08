using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugNET.Common
{
    public static class EnumHelpers<T>
    {
        private static Dictionary<string, T> _valueMap;

        public static T FromString(string value)
        {
            if (_valueMap == null)
            {
                _valueMap = new Dictionary<string, T>(StringComparer.OrdinalIgnoreCase);

                foreach (var item in Enum.GetValues(typeof(T)))
                {
                    _valueMap.Add(item.ToString(), (T)item);
                }
            }

            return _valueMap[value];
        }

    }

    public static class EnumStringExtensions
    {
        public static T ToEnum<T>(this string value)
        {
            return EnumHelpers<T>.FromString(value);
        }
    }
}
