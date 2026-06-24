using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messages.Models.Chats;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.Messages.Managers;

[Service]
internal sealed class ChatMessageManager : IChatMessageManager
{
	private readonly InformationChannelManager informationChannelManager;

	private readonly ChannelMessageManager channelMessageManager;

	private readonly UserManager userManager;

	private readonly IAuthenticationService authenticationService;

	public ChatMessageManager(InformationChannelManager informationChannelManager, ChannelMessageManager channelMessageManager, UserManager userManager, IAuthenticationService authenticationService)
	{
		this.informationChannelManager = informationChannelManager;
		this.channelMessageManager = channelMessageManager;
		this.userManager = userManager;
		this.authenticationService = authenticationService;
	}

	public IChatMessage Create(Guid chatUid, string messageText)
	{
		return new ChatMessage(channelMessageManager.AddComment(chatUid, messageText));
	}

	public IEnumerable<IChatMessage> Find()
	{
		throw new NotImplementedException();
	}

	public IChatMessage Load(Guid uid)
	{
		return new ChatMessage(channelMessageManager.LoadOrNull(uid));
	}

	public IEnumerable<IChatMessage> LoadByChat(Guid uid, FetchOptions opts = null)
	{
		return (from m in GetChatMessages(uid, opts)
			select new ChatMessage(m)).AsEnumerable();
	}

	private IEnumerable<IChannelMessage> GetChatMessages(Guid uid, FetchOptions opts = null)
	{
		IChannelMessage parent = channelMessageManager.LoadOrNull(uid);
		IChannelMessageFilter channelMessageFilter = InterfaceActivator.Create<IChannelMessageFilter>();
		channelMessageFilter.MessageType = ChannelMessageType.Comment;
		channelMessageFilter.Parent = parent;
		if (opts == null)
		{
			opts = new FetchOptions(0, 0, ListSortDirection.Descending, "CreationDate");
		}
		return channelMessageManager.Find(channelMessageFilter, opts);
	}
}
