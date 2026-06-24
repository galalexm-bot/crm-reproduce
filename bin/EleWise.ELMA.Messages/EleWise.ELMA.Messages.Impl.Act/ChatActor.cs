using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Messages.DTO;
using EleWise.ELMA.Messages.Extensions;
using EleWise.ELMA.Messages.Helpers;
using EleWise.ELMA.Messages.Impl.Actors.ActorStates;
using EleWise.ELMA.Messages.Managers;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messages.Models.Chats;
using EleWise.ELMA.Messages.Services;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Messages.Impl.Actors;

internal sealed class ChatActor : Actor, IChatActor, IActorWithGuidKey, IActor
{
	private ChatActorState state;

	private static readonly double ReinitInterval = 15.0;

	private static readonly int RefreshInterval = 5000;

	private DateTime timeToUpdateState = DateTime.Now.AddMinutes(ReinitInterval);

	private readonly IChatManager chatManager;

	private readonly IChatMessageManager chatMessageManager;

	private readonly ISecurityServiceAsync securityService;

	private readonly IChatAttachmentPreparator chatAttachmentsPreparator;

	private readonly IActorModelRuntime actorModelRuntime;

	private readonly UserGroupManager userGroupManager;

	private readonly InformationChannelManager informationChannelManager;

	private readonly ILogger logger;

	public ChatActor(IChatManager chatManager, IChatMessageManager chatMessageManager, ISecurityServiceAsync securityService, IChatAttachmentPreparator chatAttachmentsPreparator, IActorModelRuntime actorModelRuntime, UserGroupManager userGroupManager, InformationChannelManager informationChannelManager, ILogger logger)
	{
		this.chatManager = chatManager;
		this.chatMessageManager = chatMessageManager;
		this.securityService = securityService;
		this.chatAttachmentsPreparator = chatAttachmentsPreparator;
		this.actorModelRuntime = actorModelRuntime;
		this.userGroupManager = userGroupManager;
		this.informationChannelManager = informationChannelManager;
		this.logger = logger;
	}

	public override async Task OnActivateAsync()
	{
		try
		{
			await InitState();
		}
		catch (Exception message)
		{
			logger.Error(message);
			throw;
		}
	}

	public Task<List<MessageDTO>> GetMessages(string lastMessageHash = null, int? start = null, int? limit = null, ListSortDirection sortDirection = ListSortDirection.Descending)
	{
		start = start ?? Page.GetDefaultStart();
		limit = limit ?? Page.GetDefaultLimit();
		if (state.Messages.Count < start + limit)
		{
			LoadMessages(start.Value, limit.Value);
		}
		if (sortDirection == ListSortDirection.Descending)
		{
			return Task.FromResult((from m in (from m in state.Messages
					orderby m.Hash descending
					where !string.IsNullOrEmpty(lastMessageHash) || string.Compare(lastMessageHash, m.Hash) >= 0
					select m).Skip(start.Value).Take(limit.Value)
				select new MessageDTO(m, state.Uid, state.Subject)).ToList());
		}
		return Task.FromResult((from m in (from m in state.Messages
				orderby m.Hash
				where !string.IsNullOrEmpty(lastMessageHash) || string.Compare(lastMessageHash, m.Hash) < 0
				select m).Skip(start.Value).Take(limit.Value)
			select new MessageDTO(m, state.Uid, state.Subject)).ToList());
	}

	public Task<MessageModel> SendMessage(MessageCreateDTO message)
	{
		(string, ICollection<ChatAttachmentDTO>) tuple = chatAttachmentsPreparator.PrepareAttachmentsWithMessage(message.Text, message.Attachments);
		MessageActorState messageActorState = Mapper.Map<IChatMessage, MessageActorState>(chatMessageManager.Create(state.Uid, tuple.Item1));
		messageActorState.Attachments = tuple.Item2;
		state.Messages.Add(messageActorState);
		state.LastActivity = messageActorState.Date.Value;
		state.LastHash = messageActorState.Hash;
		actorModelRuntime.Publish(state.Uid, ChatActorEvents.SendMessageEvent, (messageActorState.Author.Uid, messageActorState.Hash)).ContinueWith(delegate
		{
		}, TaskContinuationOptions.OnlyOnFaulted);
		return Task.FromResult(new MessageModel
		{
			Message = new MessageDTO(messageActorState, state.Uid, state.Subject),
			Recipients = state.Recipients.Select((UserDTO u) => u.UserName).ToList()
		});
	}

	public Task<ChatDTO> GetChatInfo()
	{
		return Task.FromResult(Mapper.Map<ChatActorState, ChatDTO>(state));
	}

	public Task<ParticipantsDTO> GetParticipants()
	{
		return Task.FromResult(state.Participants);
	}

	public Task<ICollection<UserDTO>> GetRecipients()
	{
		return Task.FromResult(state.Recipients);
	}

	public async Task<ICollection<EleWise.ELMA.Security.Models.IUser>> AddChatParticipants(IEnumerable<long> users, IEnumerable<long> userGroups, IEnumerable<long> organizationItems)
	{
		ICollection<EleWise.ELMA.Security.Models.IUser> newRecipients = new List<EleWise.ELMA.Security.Models.IUser>();
		if (state.Type != 0)
		{
			newRecipients = chatManager.AddChatParticipants(GetPrimaryKey<Guid>(), users, userGroups, organizationItems);
			state.Participants.Users.AddRange(newRecipients.Select((EleWise.ELMA.Security.Models.IUser r) => Mapper.Map<EleWise.ELMA.Security.Models.IUser, UserDTO>(r)));
			state.Participants.ParticipantsCount = state.Participants.ParticipantsCount + newRecipients.Count;
			state.Recipients = state.Participants.Users;
			state.LastActivity = DateTime.Now;
			state.LastHash = MessageHashHelper.GenerateHash(0L, DateTime.Now);
			users.ForEach(delegate(long user)
			{
				PublishEvent(ChatActorEvents.AddChatParticipantUidEvent, ChatActorEvents.AddedUser, user);
			});
			foreach (long userGroup in userGroups)
			{
				PublishEvent(ChatActorEvents.AddChatParticipantUidEvent, ChatActorEvents.AddedGroup, userGroup);
				await SubscribeOnUserGroupEvents(userGroup);
			}
			foreach (long organizationItem in organizationItems)
			{
				PublishEvent(ChatActorEvents.AddChatParticipantUidEvent, ChatActorEvents.AddedOrgItem, organizationItem);
				await SubscribeOnOrgItemEvents(organizationItem);
			}
		}
		return newRecipients;
	}

	public Task<bool> DeleteChatParticipants(IEnumerable<long> users, IEnumerable<long> userGroups, IEnumerable<long> organizationItems)
	{
		if (state.Type == ChatTypeEnum.Private)
		{
			return Task.FromResult(result: false);
		}
		ICollection<EleWise.ELMA.Security.Models.IUser> deletedRecipients = chatManager.DeleteChatParticipants(GetPrimaryKey<Guid>(), users, userGroups, organizationItems);
		state.Participants.Users.RemoveAll((UserDTO u) => deletedRecipients.Any((EleWise.ELMA.Security.Models.IUser r) => r.Uid == u.Uid));
		state.Participants.ParticipantsCount = state.Participants.ParticipantsCount - deletedRecipients.Count;
		state.Recipients = state.Participants.Users;
		state.LastActivity = DateTime.Now;
		state.LastHash = MessageHashHelper.GenerateHash(0L, DateTime.Now);
		users.ForEach(delegate(long user)
		{
			PublishEvent(ChatActorEvents.DeleteChatParticipantUidEvent, ChatActorEvents.DeletedUser, user);
		});
		userGroups.ForEach(delegate(long userGroup)
		{
			PublishEvent(ChatActorEvents.DeleteChatParticipantUidEvent, ChatActorEvents.DeletedGroup, userGroup);
		});
		organizationItems.ForEach(delegate(long orgItem)
		{
			PublishEvent(ChatActorEvents.DeleteChatParticipantUidEvent, ChatActorEvents.DeletedOrgItem, orgItem);
		});
		OnChange();
		return Task.FromResult(result: true);
	}

	public Task<int> GetMessagesCountAfter(string lastReadHash)
	{
		if (state.Messages.Where((MessageActorState m) => m.Hash == lastReadHash).FirstOrDefault() != null)
		{
			return Task.FromResult(state.Messages.Count((MessageActorState m) => string.Compare(m.Hash, lastReadHash) > 0));
		}
		return Task.FromResult(0);
	}

	private void PublishEvent(Guid eventId, string eventNamespace, long itemId)
	{
		actorModelRuntime.Publish(eventId, $"{eventNamespace}_{itemId}", state.Uid).ContinueWith(delegate
		{
		}, TaskContinuationOptions.OnlyOnFaulted);
	}

	private async Task InitState()
	{
		IChat chat = chatManager.Load(GetPrimaryKey<Guid>());
		if (chat != null)
		{
			state = new ChatActorState
			{
				Uid = chat.Uid,
				Type = chat.Type,
				Subject = chat.Subject,
				Participants = chat.Participants,
				Channels = chat.Channels,
				LastActivity = chat.CreationDate,
				LastHash = MessageHashHelper.GenerateHash(0L, chat.CreationDate)
			};
			InitMessages();
			await InitParticipants();
			TimeSpan timeSpan = TimeSpan.FromMilliseconds(RefreshInterval);
			RegisterTimer(Refresh, null, timeSpan, timeSpan);
		}
	}

	private void InitMessages()
	{
		state.Messages = new List<MessageActorState>();
		IEnumerable<IChatMessage> enumerable = chatMessageManager.LoadByChat(state.Uid);
		if (enumerable == null || !enumerable.Any())
		{
			return;
		}
		foreach (IChatMessage item in enumerable)
		{
			if (item.Attachments != null)
			{
				ICollection<ChatAttachmentDTO> collection2 = (item.Attachments = chatAttachmentsPreparator.PrepareAttachments(item.Attachments));
			}
		}
		state.Messages.AddRange(enumerable.Select((IChatMessage m) => Mapper.Map<IChatMessage, MessageActorState>(m)));
		state.LastActivity = enumerable.FirstOrDefault().Date.Value;
		state.LastHash = enumerable.FirstOrDefault().Hash;
	}

	private async Task InitParticipants()
	{
		await UnsubscribeFromEverything();
		List<UserDTO> list = (from x in chatManager.GetChatRecipients(state.Uid)
			group x by x.Uid into x
			select Mapper.Map<EleWise.ELMA.Security.Models.IUser, UserDTO>(x.First())).ToList();
		state.Participants = new ParticipantsDTO
		{
			Users = list,
			ParticipantsCount = (list?.Count ?? 0)
		};
		state.Recipients = list;
		await Subscribe();
	}

	private void LoadMessages(int start, int limit)
	{
		FetchOptions opts = new FetchOptions(start, limit, ListSortDirection.Descending, "CreationDate");
		IEnumerable<IChatMessage> source = chatMessageManager.LoadByChat(state.Uid, opts);
		source = source.Where((IChatMessage m) => !state.Messages.Any((MessageActorState sm) => m.Uid == sm.Uid)).ToList();
		state.Messages.AddRange(source.Select((IChatMessage m) => Mapper.Map<IChatMessage, MessageActorState>(m)));
	}

	private Task UnsubscribeFromEverything()
	{
		return Task.WhenAll(state.UserGroupSubscriptions.ClearSubscriptions(), state.OrgItemsSubscriptions.ClearSubscriptions(), state.ChannelsSubscriptions.ClearSubscriptions());
	}

	private async Task Subscribe()
	{
		if (state.Participants.UserGroups != null)
		{
			foreach (EntityHeaderDTO userGroup in state.Participants.UserGroups)
			{
				await SubscribeOnUserGroupEvents(userGroup.Id);
			}
		}
		if (state.Participants.OrganizationItems != null)
		{
			foreach (EntityHeaderDTO organizationItem in state.Participants.OrganizationItems)
			{
				await SubscribeOnOrgItemEvents(organizationItem.Id);
			}
		}
		if (state.Channels == null)
		{
			return;
		}
		foreach (InformationChannelDTO channel in state.Channels)
		{
			await SubscribeOnChannelEvents(channel.Uid);
		}
	}

	private async Task SubscribeOnUserGroupEvents(long userGroupId)
	{
		if (state.UserGroupSubscriptions.FirstOrDefault((KeyValuePair<long, ICollection<ISubscription>> s) => s.Key == userGroupId).Value != null)
		{
			return;
		}
		IUserGroup group = userGroupManager.LoadOrNull(userGroupId);
		if (group == null)
		{
			return;
		}
		Task<ISubscription>[] subscription = new Task<ISubscription>[6]
		{
			SubscribeOnItem(ChatActorEvents.AddUserToGroupUidEvent, ChatActorEvents.UpdatedGroup, userGroupId),
			SubscribeOnItem(ChatActorEvents.DeleteUserFromGroupUidEvent, ChatActorEvents.UpdatedGroup, userGroupId),
			SubscribeOnItem(ChatActorEvents.AddGroupToGroupUidEvent, ChatActorEvents.UpdatedGroup, userGroupId),
			SubscribeOnItem(ChatActorEvents.DeleteGroupFromGroupUidEvent, ChatActorEvents.UpdatedGroup, userGroupId),
			SubscribeOnItem(ChatActorEvents.AddOrgItemToGroupUidEvent, ChatActorEvents.UpdatedGroup, userGroupId),
			SubscribeOnItem(ChatActorEvents.DeleteOrgItemFromGroupUidEvent, ChatActorEvents.UpdatedGroup, userGroupId)
		};
		await state.UserGroupSubscriptions.Add(userGroupId, subscription);
		foreach (IUserGroup item in (IEnumerable<IUserGroup>)group.Groups)
		{
			await SubscribeOnUserGroupEvents(item.Id);
		}
		foreach (IOrganizationItem item2 in (IEnumerable<IOrganizationItem>)group.OrganizationItems)
		{
			await SubscribeOnOrgItemEvents(item2.Id);
		}
	}

	private async Task SubscribeOnOrgItemEvents(long orgItemId)
	{
		if (state.OrgItemsSubscriptions.FirstOrDefault((KeyValuePair<long, ICollection<ISubscription>> s) => s.Key == orgItemId).Value == null)
		{
			Task<ISubscription>[] subscription = new Task<ISubscription>[2]
			{
				SubscribeOnItem(ChatActorEvents.AddUserToOrgItemUidEvent, ChatActorEvents.UpdatedOrgItem, orgItemId),
				SubscribeOnItem(ChatActorEvents.DeleteUserFromOrgItemUidEvent, ChatActorEvents.UpdatedOrgItem, orgItemId)
			};
			await state.OrgItemsSubscriptions.Add(orgItemId, subscription);
		}
	}

	private async Task SubscribeOnChannelEvents(Guid channelUid)
	{
		await securityService.RunWithElevatedPrivilegiesAsync(async delegate
		{
			if (state.ChannelsSubscriptions.FirstOrDefault((KeyValuePair<Guid, ICollection<ISubscription>> s) => s.Key == channelUid).Value == null)
			{
				IInformationChannel channel = informationChannelManager.LoadOrNull(channelUid);
				if (channel != null)
				{
					Task<ISubscription>[] subscription = new Task<ISubscription>[6]
					{
						SubscribeOnChannel(ChatActorEvents.AddUserToChannelUidEvent, ChatActorEvents.UpdatedChannel, channelUid),
						SubscribeOnChannel(ChatActorEvents.AddGroupToChannelUidEvent, ChatActorEvents.UpdatedChannel, channelUid),
						SubscribeOnChannel(ChatActorEvents.AddOrgItemToChannelUidEvent, ChatActorEvents.UpdatedChannel, channelUid),
						SubscribeOnChannel(ChatActorEvents.DeleteUserFromChannelUidEvent, ChatActorEvents.UpdatedChannel, channelUid),
						SubscribeOnChannel(ChatActorEvents.DeleteGroupFromChannelUidEvent, ChatActorEvents.UpdatedChannel, channelUid),
						SubscribeOnChannel(ChatActorEvents.DeleteOrgItemFromChannelUidEvent, ChatActorEvents.UpdatedChannel, channelUid)
					};
					await state.ChannelsSubscriptions.Add(channelUid, subscription);
					foreach (IInformationChannelPermission permission in (IEnumerable<IInformationChannelPermission>)channel.Permissions)
					{
						if (permission.Group != null)
						{
							await SubscribeOnUserGroupEvents(permission.Group.Id);
						}
						if (permission.OrganizationItem != null)
						{
							await SubscribeOnOrgItemEvents(permission.OrganizationItem.Id);
						}
						if (permission.OrganizationItemPosition != null)
						{
							await SubscribeOnOrgItemEvents(permission.OrganizationItemPosition.Id);
						}
					}
				}
			}
		});
	}

	private Task<ISubscription> SubscribeOnItem(Guid eventId, string eventNamespace, object itemId)
	{
		return SubscribeOnItem<long[]>(eventId, eventNamespace, itemId);
	}

	private Task<ISubscription> SubscribeOnChannel(Guid eventId, string eventNamespace, object itemId)
	{
		return SubscribeOnItem<long>(eventId, eventNamespace, itemId);
	}

	private Task<ISubscription> SubscribeOnItem<T>(Guid eventId, string eventNamespace, object itemId)
	{
		return actorModelRuntime.Subscribe(eventId, $"{eventNamespace}_{itemId.ToString()}", (T _) => OnChange());
	}

	private async Task Refresh(object args)
	{
		if (timeToUpdateState <= DateTime.Now)
		{
			await InitParticipants();
			timeToUpdateState = DateTime.Now.AddMinutes(ReinitInterval);
		}
	}

	private Task OnChange()
	{
		timeToUpdateState = DateTime.Now.AddMilliseconds(RefreshInterval);
		return Task.CompletedTask;
	}
}
