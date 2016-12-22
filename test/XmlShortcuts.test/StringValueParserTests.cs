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
            var value = default(XElement).ValueOf("test");
            Assert.Null(value);
        }
    }
}
