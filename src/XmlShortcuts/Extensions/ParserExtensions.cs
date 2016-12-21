using System.Xml.Linq;

namespace XmlShortcuts.Extensions
{
    public static class ParserExtensions
    {
        public static string ValueOf(this XElement x, string name) => x?.Element(name)?.Value;
    }
}
