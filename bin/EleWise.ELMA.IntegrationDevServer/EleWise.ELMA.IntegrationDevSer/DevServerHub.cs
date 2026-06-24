using System.Threading.Tasks;
using EleWise.ELMA.Hubs;
using EleWise.ELMA.Hubs.Attributes;
using EleWise.ELMA.IntegrationDevServer.Services;
using EleWise.ELMA.Web.Hubs.Attributes;

namespace EleWise.ELMA.IntegrationDevServer.Hubs;

[PublicSessionAuthorize]
[HubName("DevServerHub")]
internal sealed class DevServerHub : HubBase<IDevServerClient>, IDevServerHub, IHub
{
	private IDevServerService devServerService;

	public DevServerHub(IDevServerService devServerService)
	{
		this.devServerService = devServerService;
	}

	public Task<string> Deploy(byte[] container)
	{
		return devServerService.Deploy(container);
	}
}
