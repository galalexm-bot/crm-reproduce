using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Common.Services;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Messages.Managers;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Security.Managers;

namespace EleWise.ELMA.Messages.Services;

[Service(Scope = ServiceScope.Shell, Type = ComponentType.WebServer)]
internal class ServerRestartMessageService : IServerRestartMessageService
{
	private static FetchOptions InformationChannelFetchOptions = new FetchOptions
	{
		SelectColumns = new List<string>
		{
			LinqUtils.NameOf((Expression<Func<IInformationChannel, object>>)((IInformationChannel x) => x.Id)),
			LinqUtils.NameOf((Expression<Func<IInformationChannel, object>>)((IInformationChannel x) => x.Name))
		},
		UseProjections = true
	};

	private InformationChannelManager ChannelManager => InformationChannelManager.Instance;

	private ChannelMessageManager MessageManager => ChannelMessageManager.Instance;

	private UserManager UserManager => UserManager.Instance;

	public IEnumerable<InformationChannelInfo> GetInformationChannelInfo()
	{
		return ChannelManager.Find(InformationChannelFetchOptions).Select(ChannelSelector).ToArray();
	}

	public IEnumerable<InformationChannelInfo> GetInformationChannelInfo(IEnumerable<long> channels)
	{
		Contract.ArgumentNotNull(channels, "channels");
		return ChannelManager.FindByIdArray(channels.ToArray(), null, InformationChannelFetchOptions).Select(ChannelSelector).ToArray();
	}

	public long? SendMessage(IEnumerable<long> channels, long sender, string subject, string text, ScheduledRestart entry)
	{
		Contract.ArgumentNotNull(channels, "channels");
		Contract.Check<ArgumentException>(channels.Count() > 0, "channels.Count() > 0");
		Contract.Check<ArgumentException>(sender > 0, "sender > 0");
		Contract.ArgumentNotNullOrEmpty(subject, "subject");
		Contract.ArgumentNotNullOrEmpty(text, "message");
		Contract.ArgumentNotNull(entry, "entry");
		DateTime now = DateTime.Now;
		IChannelMessage channelMessage = MessageManager.Create();
		channelMessage.CreationAuthor = UserManager.Load(sender);
		channelMessage.FullMessage = FormatMessage(text, now, entry);
		if (entry.ParentMessageId == 0L)
		{
			channelMessage.MessageType = ChannelMessageType.Post;
			channelMessage.Subject = FormatMessage(subject, now, entry);
			ICollection<IInformationChannel> collection = ChannelManager.FindByIdArray(channels.ToArray());
			channelMessage.Channels.AddAll(collection);
			channelMessage.Save();
			return channelMessage.Id;
		}
		IChannelMessage channelMessage2 = MessageManager.LoadOrNull(entry.ParentMessageId);
		if (channelMessage2 != null)
		{
			channelMessage.MessageType = ChannelMessageType.Comment;
			channelMessage.Parent = channelMessage2;
			channelMessage.Channels = channelMessage2.Channels;
			channelMessage.Recipients = channelMessage2.Recipients;
			channelMessage2.Messages.Add(channelMessage);
			channelMessage2.Save();
			return channelMessage.Id;
		}
		Logger.Log.ErrorFormat("ServerRestartMessageService.SendMessage(): Parent post #{0} is not found for entry #{1}, cannot send comment message.", entry.ParentMessageId, entry.Id);
		return null;
	}

	private InformationChannelInfo ChannelSelector(IInformationChannel channel)
	{
		return new InformationChannelInfo
		{
			Id = channel.Id,
			Name = channel.Name
		};
	}

	private string FormatMessage(string message, DateTime now, ScheduledRestart entry)
	{
		List<string> list = new List<string>();
		TimeSpan timeSpan = entry.RestartDate - now;
		if (timeSpan.TotalMinutes >= 1.0)
		{
			if (timeSpan.Days != 0)
			{
				list.Add(SR.T("{0} дн.", timeSpan.Days));
			}
			if (timeSpan.Hours != 0)
			{
				list.Add(SR.T("{0} ч.", timeSpan.Hours));
			}
			if (timeSpan.Minutes != 0)
			{
				list.Add(SR.T("{0} мин.", timeSpan.Minutes));
			}
		}
		else
		{
			list.Add(SR.T("{0} сек.", timeSpan.Seconds));
		}
		return message.Replace("{RestartDate}", entry.RestartDate.ToString()).Replace("{TimeLeft}", string.Join(" ", list)).Replace("{Reason}", string.IsNullOrWhiteSpace(entry.Reason) ? SR.T("Причина перезапуска не указана") : entry.Reason);
	}
}
