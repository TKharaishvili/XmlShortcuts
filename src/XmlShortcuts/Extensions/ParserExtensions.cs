using System;
using System.Globalization;
using System.Xml.Linq;

namespace XmlShortcuts.Extensions
{
    public static class ParserExtensions
    {
        public static string ValueOf(this XElement x, string name) => x?.Element(name)?.Value;

        public static long? LongValueOf(this XElement x, string name)
        {
            long result;
            return long.TryParse(x.ValueOf(name), out result) ? result : default(long?);
        }

        public static long? LongValueOf(this XElement x, string name, NumberStyles style, IFormatProvider provider)
        {
            long result;
            return long.TryParse(x.ValueOf(name), style, provider, out result) ? result : default(long?);
        }

        public static int? IntValueOf(this XElement x, string name)
        {
            int result;
            return int.TryParse(x.ValueOf(name), out result) ? result : default(int?);
        }

        public static int? IntValueOf(this XElement x, string name, NumberStyles style, IFormatProvider provider)
        {
            int result;
            return int.TryParse(x.ValueOf(name), style, provider, out result) ? result : default(int?);
        }
    }
}
