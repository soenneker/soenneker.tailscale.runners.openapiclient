using Soenneker.Tests.HostedUnit;

namespace Soenneker.Tailscale.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class TailscaleOpenApiClientRunnerTests : HostedUnitTest
{
    public TailscaleOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
