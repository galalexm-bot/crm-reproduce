using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Messages.DTO;
using EleWise.ELMA.Messages.Extensions;
using EleWise.ELMA.Messages.Impl.Actors.ActorStates;
using EleWise.ELMA.Messages.Managers;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messages.Models.Chats;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Messages.Impl.Actors;

internal sealed class UserChatListActor : Actor, IUserChatListActor, IActorWithGuidKey, IActor
{
	private UserChatListActorState state;

	private static readonly double ReinitInterval = 15.0;

	private static readonly int RefreshInterval = 5000;

	private DateTime timeToUpdateState = DateTime.Now.AddMinutes(ReinitInterval);

	private readonly UserManager userManager;

	private readonly UserGroupManager userGroupManager;

	private readonly OrganizationItemManager organizationItemManager;

	private readonly InformationChannelManager informationChannelManager;

	private readonly IChatManager chatManager;

	private readonly ISecurityService securityService;

	private readonly IActorModelRuntime actorModelRuntime;

	private readonly ILogger logger;

	public UserChatListActor(UserManager userManager, UserGroupManager userGroupManager, OrganizationItemManager organizationItemManager, InformationChannelManager informationChannelManager, IChatManager chatManager, ISecurityService securityService, IActorModelRuntime actorModelRuntime, ILogger logger)
	{
		this.userManager = userManager;
		this.userGroupManager = userGroupManager;
		this.organizationItemManager = organizationItemManager;
		this.informationChannelManager = informationChannelManager;
		this.chatManager = chatManager;
		this.securityService = securityService;
		this.actorModelRuntime = actorModelRuntime;
		this.logger = logger;
	}

	public override async Task OnActivateAsync()
	{
		try
		{
			EleWise.ELMA.Security.Models.IUser currentUser = userManager.Load(GetPrimaryKey<Guid>());
			await InitState(currentUser);
		}
		catch (Exception message)
		{
			logger.Error(message);
			throw;
		}
	}

	public Task<List<ChatDTO>> GetChats(int? start = null, int? limit = null)
	{
		start = start ?? Page.GetDefaultStart();
		if (limit.HasValue)
		{
			return Task.FromResult((from c in state.Chats.Skip(start.Value).Take(limit.Value)
				select Mapper.Map<ChatState, ChatDTO>(c)).ToList());
		}
		return Task.FromResult((from c in state.Chats.Skip(start.Value)
			select Mapper.Map<ChatState, ChatDTO>(c)).ToList());
	}

	public Task<ChatDTO> GetChat(Guid chatUid)
	{
		return Task.FromResult((from c in state.Chats
			where c.Uid == chatUid
			select Mapper.Map<ChatState, ChatDTO>(c)).FirstOrDefault());
	}

	public Task<long> GetUnreadMessagesCount()
	{
		return Task.FromResult(state.UnreadMessagesCount);
	}

	public async Task<Guid> CreateChat(CreateChatModel chatModel)
	{
		IChat chat = chatManager.Create(chatModel);
		await AddChat(chat.Uid);
		if (chatModel.Channels != null && chatModel.Channels.Any())
		{
			foreach (InformationChannelDTO channel in chat.Channels)
			{
				actorModelRuntime.Publish(ChatActorEvents.AddChatToChannelUidEvent, $"{ChatActorEvents.UpdatedChannel}_{channel.Uid}", chat.Uid).ContinueWith(delegate
				{
				}, TaskContinuationOptions.OnlyOnFaulted);
			}
		}
		return chat.Uid;
	}

	public Task<Guid> CreatePrivateChat(Guid userUid)
	{
		EleWise.ELMA.Security.Models.IUser user = userManager.Load(userUid);
		return СreatePrivateChat(user);
	}

	public Task<Guid> CreatePrivateChat(long userId)
	{
		EleWise.ELMA.Security.Models.IUser user = userManager.Load(userId);
		return СreatePrivateChat(user);
	}

	private async Task<Guid> СreatePrivateChat(EleWise.ELMA.Security.Models.IUser user)
	{
		Guid chatUid = chatManager.CreateOrLoadPrivateChat(user);
		await AddChat(chatUid);
		actorModelRuntime.Publish(ChatActorEvents.AddChatParticipantUidEvent, $"{ChatActorEvents.AddedUser}_{user.Id}", chatUid).ContinueWith(delegate
		{
		}, TaskContinuationOptions.OnlyOnFaulted);
		return chatUid;
	}

	private async Task<ChatState> AddChat(Guid chatUid)
	{
		if (!state.Chats.Any((ChatState c) => c.Uid == chatUid))
		{
			IChatParticipant chatParticipant = chatManager.LoadChatParticipant(chatUid);
			ChatState chatState = await InitChatState(chatParticipant);
			state.Chats.Add(chatState);
			return chatState;
		}
		return state.Chats.Where((ChatState c) => c.Uid == chatUid).FirstOrDefault();
	}

	public Task AddToFavorite(Guid chatUid)
	{
		ChangeFavoriteFlag(chatUid, flag: true);
		return Task.CompletedTask;
	}

	public Task DeleteFromFavorite(Guid chatUid)
	{
		ChangeFavoriteFlag(chatUid, flag: false);
		return Task.CompletedTask;
	}

	public Task Mute(Guid chatUid)
	{
		ChangeMuteFlag(chatUid, flag: true);
		return Task.CompletedTask;
	}

	public Task Unmute(Guid chatUid)
	{
		ChangeMuteFlag(chatUid, flag: false);
		return Task.CompletedTask;
	}

	public async Task ReadToHash(Guid chatUid, string messageHash, bool isLastMessageHash = false)
	{
		ChatState chat = state.Chats.Where((ChatState c) => c.Uid == chatUid).FirstOrDefault();
		if (chat == null)
		{
			chat = await AddChat(chatUid);
		}
		if (chat != null)
		{
			int num = 0;
			if (!isLastMessageHash)
			{
				num = await actorModelRuntime.GetActor<IChatActor>(chatUid).GetMessagesCountAfter(messageHash);
			}
			state.UnreadMessagesCount = state.UnreadMessagesCount - chat.UnreadCount + num;
			chat.UnreadCount = num;
			chat.LastReadHash = messageHash;
		}
	}

	private async Task InitState(EleWise.ELMA.Security.Models.IUser currentUser, bool firstInit = true)
	{
		state = new UserChatListActorState
		{
			User = currentUser
		};
		IEnumerable<IChatParticipant> chats = chatManager.FindChatsParticipant(state.User);
		IEnumerable<long> groupsByUser = userGroupManager.GetGroupsByUser(state.User.Id);
		IEnumerable<long> itemsByUser = organizationItemManager.GetItemsByUser(state.User.Id);
		IEnumerable<IInformationChannel> channels = new List<IInformationChannel>();
		securityService.RunByUser(state.User, delegate
		{
			IInformationChannelFilter informationChannelFilter = InterfaceActivator.Create<IInformationChannelFilter>();
			informationChannelFilter.Assigned = true;
			channels = informationChannelManager.Find(informationChannelFilter, FetchOptions.All);
		});
		await Task.WhenAll(Subscribe(groupsByUser, itemsByUser, channels, firstInit), InitChats(chats));
		InitUnreadMessageCount();
		if (firstInit)
		{
			TimeSpan timeSpan = TimeSpan.FromMilliseconds(RefreshInterval);
			RegisterTimer(Refresh, null, timeSpan, timeSpan);
		}
	}

	private async Task InitChats(IEnumerable<IChatParticipant> chats)
	{
		ChatState[] source = await Task.WhenAll(chats.Select(async (IChatParticipant c) => await InitChatState(c)));
		state.Chats = source.Where((ChatState c) => c != null).ToList();
	}

	private async Task<ChatState> InitChatState(IChatParticipant chatParticipant)
	{
		ChatState chatState = new ChatState
		{
			Uid = chatParticipant.Uid,
			UnreadCount = chatParticipant.UnreadCount,
			IsFavorite = chatParticipant.IsFavorite,
			IsMute = chatParticipant.IsMute,
			LastReadHash = chatParticipant.LastReadHash
		};
		await SubscribeOnChatEvents(chatParticipant.Uid);
		return chatState;
	}

	private async Task SubscribeOnChatEvents(Guid chatUid)
	{
		ISubscription value = await actorModelRuntime.Subscribe(chatUid, ChatActorEvents.SendMessageEvent, ((Guid authorUid, string messageHash) messageData) => OnSendMessage(chatUid, messageData));
		state.ChatSubscriptions.Add(chatUid, value);
	}

	private void InitUnreadMessageCount()
	{
		state.UnreadMessagesCount = state.Chats.Sum((ChatState c) => c.UnreadCount);
	}

	private void ChangeFavoriteFlag(Guid chatUid, bool flag)
	{
		ChatState chatState = state.Chats.Where((ChatState c) => c.Uid == chatUid).FirstOrDefault();
		if (chatState != null)
		{
			chatState.IsFavorite = flag;
		}
	}

	private void ChangeMuteFlag(Guid chatUid, bool flag)
	{
		ChatState chatState = state.Chats.Where((ChatState c) => c.Uid == chatUid).FirstOrDefault();
		if (chatState != null)
		{
			chatState.IsMute = flag;
		}
	}

	private async Task Subscribe(IEnumerable<long> userGroupIds, IEnumerable<long> orgItemIds, IEnumerable<IInformationChannel> channels, bool firstInit = true)
	{
		List<Task> list = new List<Task>
		{
			userGroupIds.ForEachAsync((long group) => SubscribeOnUserGroupEvents(group)),
			orgItemIds.ForEachAsync((long orgItem) => SubscribeOnOrgItemEvents(orgItem)),
			channels.ForEachAsync((IInformationChannel channel) => SubscribeOnChannelEvents(channel.Uid))
		};
		if (firstInit)
		{
			list.Add(SubscribeOnUserEvents(state.User.Id));
		}
		await Task.WhenAll(list);
	}

	private Task SubscribeOnUserEvents(long userId)
	{
		return Task.WhenAll<ISubscription>(SubscribeOnItem<Guid>(ChatActorEvents.AddChatParticipantUidEvent, ChatActorEvents.AddedUser, userId), SubscribeOnItem<Guid>(ChatActorEvents.DeleteChatParticipantUidEvent, ChatActorEvents.DeletedUser, userId), SubscribeOnItem<long>(ChatActorEvents.AddUserToGroupUidEvent, ChatActorEvents.AddedUser, userId), SubscribeOnItem<long>(ChatActorEvents.DeleteUserFromGroupUidEvent, ChatActorEvents.DeletedUser, userId), SubscribeOnItem<long>(ChatActorEvents.AddUserToOrgItemUidEvent, ChatActorEvents.AddedUser, userId), SubscribeOnItem<long>(ChatActorEvents.DeleteUserFromOrgItemUidEvent, ChatActorEvents.DeletedUser, userId), SubscribeOnItem<long>(ChatActorEvents.AddUserToChannelUidEvent, ChatActorEvents.AddedUser, userId), SubscribeOnItem<long>(ChatActorEvents.DeleteUserFromChannelUidEvent, ChatActorEvents.DeletedUser, userId));
	}

	private async Task SubscribeOnUserGroupEvents(long userGroupId)
	{
		Task<ISubscription>[] subscription = new Task<ISubscription>[6]
		{
			SubscribeOnItem<Guid>(ChatActorEvents.AddChatParticipantUidEvent, ChatActorEvents.AddedGroup, userGroupId),
			SubscribeOnItem<Guid>(ChatActorEvents.DeleteChatParticipantUidEvent, ChatActorEvents.DeletedGroup, userGroupId),
			SubscribeOnItem<long>(ChatActorEvents.AddGroupToGroupUidEvent, ChatActorEvents.AddedGroup, userGroupId),
			SubscribeOnItem<long>(ChatActorEvents.DeleteGroupFromGroupUidEvent, ChatActorEvents.DeletedGroup, userGroupId),
			SubscribeOnItem<long>(ChatActorEvents.AddGroupToChannelUidEvent, ChatActorEvents.AddedGroup, userGroupId),
			SubscribeOnItem<long>(ChatActorEvents.DeleteGroupFromChannelUidEvent, ChatActorEvents.DeletedGroup, userGroupId)
		};
		await state.UserGroupSubscriptions.Add(userGroupId, subscription);
	}

	private async Task SubscribeOnOrgItemEvents(long orgItemId)
	{
		Task<ISubscription>[] subscription = new Task<ISubscription>[6]
		{
			SubscribeOnItem<Guid>(ChatActorEvents.AddChatParticipantUidEvent, ChatActorEvents.AddedOrgItem, orgItemId),
			SubscribeOnItem<Guid>(ChatActorEvents.DeleteChatParticipantUidEvent, ChatActorEvents.DeletedOrgItem, orgItemId),
			SubscribeOnItem<long>(ChatActorEvents.AddOrgItemToGroupUidEvent, ChatActorEvents.AddedOrgItem, orgItemId),
			SubscribeOnItem<long>(ChatActorEvents.DeleteOrgItemFromGroupUidEvent, ChatActorEvents.DeletedOrgItem, orgItemId),
			SubscribeOnItem<long>(ChatActorEvents.AddOrgItemToChannelUidEvent, ChatActorEvents.AddedOrgItem, orgItemId),
			SubscribeOnItem<long>(ChatActorEvents.DeleteOrgItemFromChannelUidEvent, ChatActorEvents.DeletedOrgItem, orgItemId)
		};
		await state.OrgItemsSubscriptions.Add(orgItemId, subscription);
	}

	private async Task SubscribeOnChannelEvents(Guid channelUid)
	{
		Task<ISubscription>[] subscription = new Task<ISubscription>[2]
		{
			SubscribeOnItem<Guid>(ChatActorEvents.AddChatToChannelUidEvent, ChatActorEvents.UpdatedChannel, channelUid),
			SubscribeOnItem<Guid>(ChatActorEvents.DeleteChatFromChannelUidEvent, ChatActorEvents.UpdatedChannel, channelUid)
		};
		await state.ChannelsSubscriptions.Add(channelUid, subscription);
	}

	private Task<ISubscription> SubscribeOnItem<T>(Guid eventId, string eventNamespace, object itemId)
	{
		return actorModelRuntime.Subscribe(eventId, $"{eventNamespace}_{itemId.ToString()}", (T _) => OnChange());
	}

	private Task OnChange()
	{
		timeToUpdateState = DateTime.Now.AddMilliseconds(RefreshInterval);
		return Task.CompletedTask;
	}

	private async Task OnSendMessage(Guid chatUid, (Guid authorUid, string messageHash) messageData)
	{
		if (state.User.Uid == messageData.authorUid)
		{
			await ReadToHash(chatUid, messageData.messageHash);
		}
		else
		{
			IncChatCounter(chatUid);
		}
	}

	private void IncChatCounter(Guid chatUid)
	{
		ChatState chatState = state.Chats.Where((ChatState c) => c.Uid == chatUid).FirstOrDefault();
		if (chatState != null)
		{
			chatState.UnreadCount++;
			state.UnreadMessagesCount++;
		}
	}

	private async Task Refresh(object args)
	{
		if (timeToUpdateState <= DateTime.Now)
		{
			await ReinitState();
			timeToUpdateState = DateTime.Now.AddMinutes(ReinitInterval);
		}
	}

	private async Task ReinitState()
	{
		_ = 1;
		try
		{
			await UnsubscribeFromEverything();
			await InitState(state.User, firstInit: false);
		}
		catch (Exception message)
		{
			logger.Error(message);
			throw;
		}
	}

	private Task UnsubscribeFromEverything()
	{
		return Task.WhenAll(state.ChatSubscriptions.ClearSubscriptions(), state.UserGroupSubscriptions.ClearSubscriptions(), state.OrgItemsSubscriptions.ClearSubscriptions(), state.ChannelsSubscriptions.ClearSubscriptions());
	}
}
