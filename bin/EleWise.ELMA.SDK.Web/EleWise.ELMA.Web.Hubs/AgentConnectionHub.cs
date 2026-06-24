using System.Threading.Tasks;
using EleWise.ELMA.Hubs;
using EleWise.ELMA.Hubs.Attributes;
using EleWise.ELMA.Web.Hubs.Attributes;

namespace EleWise.ELMA.Web.Hubs;

[HubName("agentConnection")]
[HubAuthorize]
internal sealed class AgentConnectionHub : HubBase<IAgentHubClient>, IAgentHub, IHub
{
	public Task Exchange(string command, string args)
	{
		return Task.CompletedTask;
	}
}
