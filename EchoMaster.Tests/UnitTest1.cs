using FluentAssertions;

namespace EchoMaster.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string expected = "Hello World!";

            string result = "Hello";

            result.Should().BeEquivalentTo(expected);
        }
    }
}