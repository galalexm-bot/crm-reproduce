using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Messages.Managers;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.Messages.Web.Services;

[Service(Type = ComponentType.WebServer, InjectProperties = true, Scope = ServiceScope.Shell, EnableInterceptors = false)]
public class MessageSendHistoryService : IMessageSendHistoryService
{
	public const string Path = "MessageSendHistory";

	public IAuthenticationService AuthenticationService { get; set; }

	protected MessageSendHistory LoadHistory()
	{
		MessageSendHistory result = null;
		try
		{
			result = PersonalizationAdministration.Provider.LoadState<MessageSendHistory>(AuthenticationService.GetCurrentUser().UserName, "MessageSendHistory");
			return result;
		}
		catch (Exception ex)
		{
			Logger.Log.Error(ex.Message, ex);
			return result;
		}
	}

	public List<IInformationChannel> Get()
	{
		Contract.ArgumentNotNull(PersonalizationAdministration.Provider, "PersonalizationAdministration.Provider");
		MessageSendHistory messageSendHistory = LoadHistory();
		if (messageSendHistory == null)
		{
			return new List<IInformationChannel>();
		}
		List<IInformationChannel> channelsForSending = InformationChannelManager.Instance.GetChannelsForSending();
		bool flag = false;
		foreach (long item in messageSendHistory.ChannelsList.Keys.Where((long t) => channelsForSending.All((IInformationChannel channel) => channel.Id != t)).ToList())
		{
			messageSendHistory.ChannelsList.Remove(item);
			flag = true;
		}
		if (flag)
		{
			PersonalizationAdministration.Provider.SaveState(AuthenticationService.GetCurrentUser().UserName, "MessageSendHistory", messageSendHistory);
		}
		return (from k in messageSendHistory.ChannelsList
			orderby k.Value descending
			select k into t
			select channelsForSending.First((IInformationChannel ch) => ch.Id == t.Key) into ch
			where ch != null
			select ch).ToList();
	}

	public void Add(List<IInformationChannel> channels)
	{
		Contract.ArgumentNotNull(PersonalizationAdministration.Provider, "PersonalizationAdministration.Provider");
		if (channels != null && channels.Any())
		{
			MessageSendHistory messageSendHistory = LoadHistory() ?? new MessageSendHistory();
			messageSendHistory.Add(channels.Select((IInformationChannel ch) => ch.Id).ToList());
			PersonalizationAdministration.Provider.SaveState(AuthenticationService.GetCurrentUser().UserName, "MessageSendHistory", messageSendHistory);
		}
	}
}
