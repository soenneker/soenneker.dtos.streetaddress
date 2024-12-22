using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Dtos.StreetAddress.Tests;

[Collection("Collection")]
public class StreetAddressTests : FixturedUnitTest
{
    public StreetAddressTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
