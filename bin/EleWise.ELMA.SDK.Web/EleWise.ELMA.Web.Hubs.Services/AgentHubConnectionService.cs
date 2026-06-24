using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using Newtonsoft.Json;

namespace EleWise.ELMA.Web.Hubs.Services;

[Service(EnableInterceptors = false)]
internal sealed class AgentHubConnectionService : IAgentHubConnectionService
{
	private static readonly ILogger Logger = EleWise.ELMA.Logging.Logger.GetLogger("AgentHubConnectionServiceLogger");

	private const string CacheKey = "EleWise.ELMA.Web.Hubs.Services.AgentHubConnections";

	private const string ConnectCommand = "connect";

	private const string DisconnectCommand = "disconnect";

	private readonly IHubContextFactory contextFactory;

	private readonly ICacheService cacheService;

	private IHubContextWrapper<IAgentHubClient> hubConnectionContext;

	private IHubContextWrapper<IAgentHubClient> HubConnectionContext => hubConnectionContext ?? (hubConnectionContext = contextFactory.GetContext<AgentConnectionHub, IAgentHubClient>());

	public AgentHubConnectionService(IHubContextFactory contextFactory, ICacheService cacheService)
	{
		this.contextFactory = contextFactory;
		this.cacheService = cacheService;
	}

	public void OnConnected(string connectionId, string userId)
	{
		Dictionary<string, string> orAdd = cacheService.GetOrAdd("EleWise.ELMA.Web.Hubs.Services.AgentHubConnections", () => new Dictionary<string, string>());
		orAdd[connectionId] = userId;
		cacheService.Insert("EleWise.ELMA.Web.Hubs.Services.AgentHubConnections", orAdd, TimeSpan.FromDays(1000000.0));
		if (HubConnectionContext != null)
		{
			HubConnectionContext.Clients.All.Exchange("connect", userId);
			Logger.Debug(SR.T("Подключение. Пользователь {0} подключен. Идентификатор подключения SignalR: {1}", userId, connectionId));
		}
		else
		{
			Logger.Error(SR.T("Не удалось подключить пользователя {0}. Не удалось получить контекст хаба. Идентификатор подключения SignalR: {1}", userId, connectionId));
		}
	}

	public void OnDisconnected(string connectionId)
	{
		Dictionary<string, string> value = null;
		cacheService.TryGetValue<Dictionary<string, string>>("EleWise.ELMA.Web.Hubs.Services.AgentHubConnections", out value);
		if (value != null && value.ContainsKey(connectionId))
		{
			string text = value[connectionId];
			value.Remove(connectionId);
			cacheService.Insert("EleWise.ELMA.Web.Hubs.Services.AgentHubConnections", value, TimeSpan.FromDays(1000000.0));
			if (HubConnectionContext != null)
			{
				if (!value.ContainsValue(text))
				{
					HubConnectionContext.Clients.All.Exchange("disconnect", text);
				}
				Logger.Debug(SR.T("Отключение. Пользователь {0} отключен. Идентификатор подключения SignalR: {1}", text, connectionId));
			}
			else
			{
				Logger.Error(SR.T("Не удалось отключить пользователя {0}. Не удалось получить контекст хаба. Идентификатор подключения SignalR: {1}", text, connectionId));
			}
		}
		else
		{
			Logger.Debug(SR.T("Отключение. Подключение не найдено. Идентификатор подключения SignalR: {0}", connectionId));
		}
	}

	public bool IsConnected(string userId)
	{
		Dictionary<string, string> value = null;
		cacheService.TryGetValue<Dictionary<string, string>>("EleWise.ELMA.Web.Hubs.Services.AgentHubConnections", out value);
		bool flag = value?.ContainsValue(userId) ?? false;
		if (Logger.IsDebugEnabled())
		{
			if (flag)
			{
				string key = value.First((KeyValuePair<string, string> p) => p.Value.Equals(userId)).Key;
				Logger.Debug(SR.T("Проверка соединения. Пользователь {0} подключен. Идентификатор подключения SignalR: {1}", userId, key));
			}
			else
			{
				Logger.Debug(SR.T("Проверка соединения. Подключение не найдено. Пользователь: {0}", userId));
			}
		}
		return flag;
	}

	public void Send<T>(string userName, string command, T arguments) where T : class
	{
		string args = ((arguments != null && !(arguments is string)) ? JsonConvert.SerializeObject((object)arguments) : (arguments as string));
		if (HubConnectionContext != null)
		{
			HubConnectionContext.Clients.Users(new List<string> { userName }).Exchange(command, args);
			Logger.Debug(SR.T("Выполнение команды \"{0}\" для пользователя: {1}", command, userName));
		}
		else
		{
			Logger.Error(SR.T("Не удалось выполнить команду \"{0}\" для пользователя: {1}. Не удалось получить контекст хаба", command, userName));
		}
	}
}
