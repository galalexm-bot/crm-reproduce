using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Messages.DTO;
using EleWise.ELMA.Messages.Helpers;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messages.Models.Chats;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.Messages.Managers;

[Service]
internal sealed class ChatManager : IChatManager
{
	private readonly InformationChannelManager informationChannelManager;

	private readonly ChannelMessageManager channelMessageManager;

	private readonly UserManager userManager;

	private readonly IAuthenticationService authenticationService;

	private const string PrivateChatKey = "private";

	public ChatManager(InformationChannelManager informationChannelManager, ChannelMessageManager channelMessageManager, UserManager userManager, IAuthenticationService authenticationService)
	{
		this.informationChannelManager = informationChannelManager;
		this.channelMessageManager = channelMessageManager;
		this.userManager = userManager;
		this.authenticationService = authenticationService;
	}

	public IChat Load(Guid uid)
	{
		return new Chat(channelMessageManager.LoadOrNull(uid));
	}

	public IChatParticipant LoadChatParticipant(Guid uid)
	{
		IChannelMessage channelMessage = LoadLastMessage(uid);
		return new ChatParticipant
		{
			Uid = uid,
			UserUid = authenticationService.GetCurrentUser<IUser>().Uid,
			IsFavorite = false,
			IsMute = false,
			UnreadCount = 0L,
			LastReadHash = ((channelMessage != null) ? MessageHashHelper.GenerateHash(channelMessage.Id, channelMessage.CreationDate.Value) : "")
		};
	}

	public IEnumerable<IChatParticipant> FindChatsParticipant(IUser user, FetchOptions opts = null)
	{
		return GetChatParticipants(user);
	}

	public Guid CreateOrLoadPrivateChat(IUser user)
	{
		return LoadPrivateChat(user.Uid)?.Uid ?? CreatePrivateChat(user);
	}

	public IEnumerable<IChat> Find(FetchOptions opts = null)
	{
		return GetChannelMessages(opts);
	}

	public IChat Create(CreateChatModel model)
	{
		return CreateChatObject(model);
	}

	public Guid CreatePrivateChat(IUser user)
	{
		return CreatePrivateChatObject(user);
	}

	public ICollection<IUser> GetChatRecipients(Guid chatUid)
	{
		IChannelMessage channelMessage = channelMessageManager.LoadOrNull(chatUid);
		List<IUser> channelParticipants = GetChannelParticipants(channelMessage);
		channelParticipants.AddRange((IEnumerable<IUser>)channelMessage.Recipients);
		return channelParticipants;
	}

	public ICollection<IUser> AddChatParticipants(Guid chatUid, IEnumerable<long> userIds, IEnumerable<long> userGroups, IEnumerable<long> organizationItems)
	{
		IChannelMessage message = channelMessageManager.LoadOrNull(chatUid);
		List<IUser> list = new List<IUser>();
		if (userIds != null && userIds.Any())
		{
			IUserFilter userFilter = InterfaceActivator.Create<IUserFilter>();
			userFilter.UserIds = userIds.ToList();
			foreach (IUser item in from u in userManager.Find(userFilter, null)
				where !((IEnumerable<IUser>)message.Recipients).Any((IUser r) => r.Id == u.Id)
				select u)
			{
				message.Recipients.Add(item);
				list.Add(item);
			}
		}
		message.Save();
		return list;
	}

	public ICollection<IUser> DeleteChatParticipants(Guid chatUid, IEnumerable<long> userIds, IEnumerable<long> userGroups, IEnumerable<long> organizationItems)
	{
		IChannelMessage message = channelMessageManager.LoadOrNull(chatUid);
		List<IUser> list = new List<IUser>();
		if (userIds != null && userIds.Any())
		{
			IUserFilter userFilter = InterfaceActivator.Create<IUserFilter>();
			userFilter.UserIds = userIds.ToList();
			foreach (IUser item in from u in userManager.Find(userFilter, null)
				where ((IEnumerable<IUser>)message.Recipients).Any((IUser r) => r.Id == u.Id)
				select u)
			{
				((ICollection<IUser>)message.Recipients).Remove(item);
				list.Add(item);
			}
		}
		message.Save();
		return list;
	}

	private IChannelMessage LoadPrivateChat(Guid userUid)
	{
		IUser user = userManager.Load(userUid);
		IUser currentUser = authenticationService.GetCurrentUser<IUser>();
		return channelMessageManager.Find(string.Format("MessageType = 0 and Subject = '{0}' and Recipients in ({1}) and Recipients in ({2})", "private", currentUser.Id, user.Id)).FirstOrDefault();
	}

	private IEnumerable<IChat> GetChannelMessages(FetchOptions opts = null)
	{
		IUser currentUser = authenticationService.GetCurrentUser<IUser>();
		ICollection<IChannelMessage> source = channelMessageManager.Find(string.Format("MessageType = 0 and Subject = '{0}' and Recipients in ({1})", "private", currentUser.Id));
		IEnumerable<IChannelMessage> source2 = from c in (from c in channelMessageManager.Find(string.Format("MessageType = 0 and Subject <> '{0}'", "private"))
				where channelMessageManager.HasComment(c)
				select c).ToList()
			where c.Subject != "private"
			select c;
		List<Chat> list = source.Select((IChannelMessage c) => new Chat(c)).ToList();
		list.AddRange(source2.Select((IChannelMessage c) => new Chat(c)));
		return list;
	}

	private IEnumerable<IChatParticipant> GetChatParticipants(IUser user)
	{
		ICollection<IChannelMessage> first = channelMessageManager.Find(string.Format("MessageType = 0 and Subject = '{0}' and Recipients in ({1})", "private", user.Id));
		ICollection<IChannelMessage> second = channelMessageManager.Find(string.Format("MessageType = 0 and Subject <> '{0}'", "private"));
		List<IChatParticipant> list = new List<IChatParticipant>();
		foreach (IChannelMessage item in first.Union(second))
		{
			IChannelMessageFilter channelMessageFilter = InterfaceActivator.Create<IChannelMessageFilter>();
			channelMessageFilter.MessageType = ChannelMessageType.Comment;
			channelMessageFilter.Parent = item;
			IChannelMessage channelMessage = channelMessageManager.Find(channelMessageFilter, new FetchOptions(0, 1, ListSortDirection.Descending, "CreationDate")).FirstOrDefault();
			list.Add(new ChatParticipant
			{
				Uid = item.Uid,
				UserUid = user.Uid,
				IsFavorite = false,
				IsMute = false,
				UnreadCount = 0L,
				LastReadHash = ((channelMessage != null) ? MessageHashHelper.GenerateHash(channelMessage.Id, channelMessage.CreationDate.Value) : "")
			});
		}
		return list;
	}

	private IChannelMessage LoadLastMessage(Guid uid)
	{
		IChannelMessage parent = channelMessageManager.LoadOrNull(uid);
		IChannelMessageFilter channelMessageFilter = InterfaceActivator.Create<IChannelMessageFilter>();
		channelMessageFilter.MessageType = ChannelMessageType.Comment;
		channelMessageFilter.Parent = parent;
		return channelMessageManager.Find(channelMessageFilter, new FetchOptions(0, 1, ListSortDirection.Descending, "CreationDate")).FirstOrDefault();
	}

	private IChat CreateChatObject(CreateChatModel model)
	{
		IUser currentUser = authenticationService.GetCurrentUser<IUser>();
		IChannelMessage channelMessage = channelMessageManager.Create();
		channelMessage.MessageType = ChannelMessageType.Post;
		channelMessage.CreationDate = DateTime.Now;
		channelMessage.Subject = model.Subject;
		channelMessage.FullMessage = "";
		channelMessage.CreationAuthor = currentUser;
		if (model.Channels != null && model.Channels.Any())
		{
			foreach (Guid channel in model.Channels)
			{
				channelMessage.Channels.Add(informationChannelManager.Load(channel));
			}
		}
		channelMessageManager.ProcessChannelAndSave(channelMessage);
		return new Chat(channelMessage);
	}

	private Guid CreatePrivateChatObject(IUser anotherUser)
	{
		IUser currentUser = authenticationService.GetCurrentUser<IUser>();
		IChannelMessage channelMessage = channelMessageManager.Create();
		channelMessage.MessageType = ChannelMessageType.Post;
		channelMessage.CreationDate = DateTime.Now;
		channelMessage.Subject = "private";
		channelMessage.FullMessage = "";
		channelMessage.CreationAuthor = currentUser;
		channelMessage.Recipients.Add(currentUser);
		channelMessage.Recipients.Add(anotherUser);
		channelMessageManager.ProcessChannelAndSave(channelMessage);
		return channelMessage.Uid;
	}

	private List<IUser> GetChannelParticipants(IChannelMessage message)
	{
		List<IUser> list = new List<IUser>();
		if (message != null)
		{
			((IEnumerable<IInformationChannel>)message.Channels).ForEach(delegate(IInformationChannel ch)
			{
				IEnumerable<IUser> collection = from p in (IEnumerable<IInformationChannelPermission>)ch.Permissions
					where p.Assigned is IUser
					select p.User;
				list.AddRange(collection);
				IEnumerable<IUserGroup> enumerable = from p in (IEnumerable<IInformationChannelPermission>)ch.Permissions
					where p.Assigned is IUserGroup
					select p.Group;
				List<IUserGroup> chekedGroups = new List<IUserGroup>();
				List<IUser> users = new List<IUser>();
				foreach (IUserGroup item in enumerable)
				{
					GroupsPermissionsMessage(message, ref users, item, ref chekedGroups);
				}
				if (users != null)
				{
					list.AddRange(users.Where((IUser u) => !list.Contains(u)));
				}
				foreach (IOrganizationItem item2 in from p in (IEnumerable<IInformationChannelPermission>)ch.Permissions
					where p.Assigned is IOrganizationItem
					select p.OrganizationItem into p
					where p != null
					select p)
				{
					list.AddRange((IEnumerable<IUser>)item2.Users);
				}
				foreach (IOrganizationItem item3 in from p in (IEnumerable<IInformationChannelPermission>)ch.Permissions
					where p.Assigned is IOrganizationItem
					select p.OrganizationItemPosition into p
					where p != null
					select p)
				{
					if (item3.User != null)
					{
						list.Add(item3.User);
					}
				}
			});
		}
		return list;
	}

	private static void GroupsPermissionsMessage(IBaseMessage message, ref List<IUser> users, IUserGroup group, ref List<IUserGroup> chekedGroups)
	{
		if (group == null || chekedGroups.Contains(group))
		{
			return;
		}
		chekedGroups.Add(group);
		if (chekedGroups == null)
		{
			chekedGroups = new List<IUserGroup>();
		}
		if (users == null)
		{
			users = new List<IUser>();
		}
		foreach (IUser item in (IEnumerable<IUser>)group.Users)
		{
			if (!users.Contains(item))
			{
				users.Add(item);
			}
		}
		foreach (IOrganizationItem item2 in ((IEnumerable<IOrganizationItem>)group.OrganizationItems).Where((IOrganizationItem oi) => oi.ItemType == OrganizationItemType.Position))
		{
			if (item2.User != null && !users.Contains(item2.User))
			{
				users.Add(item2.User);
			}
		}
		foreach (IOrganizationItem item3 in ((IEnumerable<IOrganizationItem>)group.OrganizationItems).Where((IOrganizationItem oi) => oi.ItemType == OrganizationItemType.EmployeeGroup))
		{
			foreach (IUser item4 in (IEnumerable<IUser>)item3.Users)
			{
				if (!users.Contains(item4))
				{
					users.Add(item4);
				}
			}
		}
		foreach (IUserGroup item5 in (IEnumerable<IUserGroup>)group.Groups)
		{
			GroupsPermissionsMessage(message, ref users, item5, ref chekedGroups);
		}
	}
}
