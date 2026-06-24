using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Security;
using Newtonsoft.Json;

namespace EleWise.ELMA.Web.Hubs.Services;

[Service(EnableInterceptors = false, InjectProperties = false)]
internal class AgentHubService : IAgentHubService
{
	private static readonly ILogger Logger = EleWise.ELMA.Logging.Logger.GetLogger("AgentHubServiceLogger");

	private readonly IHubContextFactory contextFactory;

	private IHubContextWrapper<IAgentHubClient> hubContext;

	private IHubContextWrapper<IAgentHubClient> HubContext => hubContext ?? (hubContext = contextFactory.GetContext<AgentHub, IAgentHubClient>());

	public AgentHubService(IHubContextFactory contextFactory)
	{
		this.contextFactory = contextFactory;
	}

	public void Send<T>(IUser user, string command, T arguments) where T : class
	{
		if (user != null)
		{
			Send(new List<IUser> { user }, command, arguments);
		}
	}

	public void Send<T>(IEnumerable<IUser> users, string command, T arguments) where T : class
	{
		Send(users.Select((IUser u) => u.UserName), command, arguments);
	}

	public void Send<T>(string userName, string command, T arguments) where T : class
	{
		Send(new List<string> { userName }, command, arguments);
	}

	public void Send<T>(IEnumerable<string> userNames, string command, T arguments) where T : class
	{
		string args = ((arguments != null && !(arguments is string)) ? JsonConvert.SerializeObject((object)arguments) : (arguments as string));
		if (HubContext != null)
		{
			HubContext.Clients.Users(userNames.ToList()).Exchange(command, args);
			Logger.Debug(SR.T("Выполнение команды \"{0}\" для пользователей: {1}", command, string.Join(", ", userNames)));
		}
		else
		{
			Logger.Error(SR.T("Не удалось выполнить команды \"{0}\" для пользователей: {1}. Не удалось получить контекст хаба", command, string.Join(", ", userNames)));
		}
	}

	public void SendAll<T>(string command, T arguments) where T : class
	{
		string args = ((arguments != null && !(arguments is string)) ? JsonConvert.SerializeObject((object)arguments) : (arguments as string));
		if (HubContext != null)
		{
			HubContext.Clients.All.Exchange(command, args);
			Logger.Debug(SR.T("Выполнение команды \"{0}\" для всех пользователей", command));
		}
		else
		{
			Logger.Error(SR.T("Не удалось выполнить команды \"{0}\" для всех пользователей. Не удалось получить контекст хаба", command));
		}
	}
}
