using System.Xml.Linq;
using XmlShortcuts.Extensions;
using Xunit;

namespace XmlShortcuts.test
{
    public class StringValueParserTests
    {
        [Fact]
        public void InvokingOnNullReturnsNull()
        {
            var value = default(XElement).ValueOf("node");
            Assert.Null(value);
        }

        [Fact]
        public void ValueOfNonExistentElementReturnsNull()
        {
            var x = new XElement("root");
            Assert.Null(x.ValueOf("node"));
        }

        [Fact]
        public void ValueOfEmptyElementReturnsEmptyString()
        {
            var x = new XElement("root", new XElement("node"));
            Assert.Equal(x.ValueOf("node"), "");
        }

        [Fact]
        public void ExtractsValueCorrectly()
        {
            var x = new XElement("root", new XElement("node", "some kind of string"));
            Assert.Equal(x.ValueOf("node"), "some kind of string");
        }
    }
}
