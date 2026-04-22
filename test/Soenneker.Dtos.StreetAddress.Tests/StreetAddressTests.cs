using Soenneker.Tests.HostedUnit;

namespace Soenneker.Dtos.StreetAddress.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class StreetAddressTests : HostedUnitTest
{
    public StreetAddressTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
