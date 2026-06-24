using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EleWise.ELMA.Hubs;
using EleWise.ELMA.Hubs.Attributes;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Web.Hubs.Attributes;
using EleWise.ELMA.Web.Hubs.Services;
using Microsoft.AspNet.SignalR;

namespace EleWise.ELMA.Web.Hubs;

[HubName("agent")]
[PublicSessionAuthorize]
internal sealed class AgentHub : HubBase<IAgentHubClient>, IAgentHub, IHub
{
	private static readonly ILogger Logger = EleWise.ELMA.Logging.Logger.GetLogger("AgentHubLogger");

	private const string AgentConnectionName = "agent";

	private const string NameKey = "name";

	private const string ConnectionData = "connectionData";

	public IAgentHubConnectionService ConnectionService { get; set; }

	public override Task OnConnected()
	{
		SetAgentStateConnected(isReconnected: false);
		return Task.CompletedTask;
	}

	public override Task OnDisconnected(bool stopCalled)
	{
		ConnectionService.OnDisconnected(base.Context.ConnectionId);
		Logger.Debug(SR.T("Подключение SignalR с идентификатором {0} разорвано", base.Context.ConnectionId));
		return Task.CompletedTask;
	}

	public override Task OnReconnected()
	{
		SetAgentStateConnected(isReconnected: true);
		return Task.CompletedTask;
	}

	public Task Exchange(string command, string args)
	{
		return Task.CompletedTask;
	}

	private void SetAgentStateConnected(bool isReconnected)
	{
		if (new JsonSerializer().Deserialize<Dictionary<string, string>[]>(base.Context.QueryString["connectionData"])[0].FirstOrDefault((KeyValuePair<string, string> i) => i.Key.ToLower() == "name").Value == "agent")
		{
			IRequest request = ((RequestWrapper)base.Context.Request).request;
			string userId = DependencyResolverExtensions.Resolve<IUserIdProvider>(GlobalHost.get_DependencyResolver()).GetUserId(request);
			ConnectionService.OnConnected(base.Context.ConnectionId, userId);
			if (isReconnected)
			{
				Logger.Info(SR.T("Пользователь {0} переподключился. Идентификатор подключения SignalR: {1}", userId, base.Context.ConnectionId));
			}
			else
			{
				Logger.Info(SR.T("Пользователь {0} подключился. Идентификатор подключения SignalR: {1}", userId, base.Context.ConnectionId));
			}
		}
	}
}
