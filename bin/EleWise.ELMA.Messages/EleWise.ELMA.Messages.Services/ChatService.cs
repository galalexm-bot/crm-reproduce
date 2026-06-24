using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.DTO;
using EleWise.ELMA.Messages.Impl.Actors;
using EleWise.ELMA.Messages.Models.Chats;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Web.Mvc.Services;

namespace EleWise.ELMA.Messages.Services;

[Service]
internal sealed class ChatService : IInternalChatService, IChatService
{
	private readonly IAuthenticationService authenticationService;

	private readonly IActorModelRuntime actorModelRuntime;

	private readonly EntityUrlResolverService entityUrlResolver;

	public ChatService(IAuthenticationService authenticationService, IActorModelRuntime actorModelRuntime, EntityUrlResolverService entityUrlResolver)
	{
		this.authenticationService = authenticationService;
		this.actorModelRuntime = actorModelRuntime;
		this.entityUrlResolver = entityUrlResolver;
	}

	public async Task<Page<ChatDTO>> GetChats(int? start = null, int? limit = null)
	{
		List<ChatDTO> list = await GetUserChatListActor().GetChats(0);
		List<ChatDTO> chatList2 = new List<ChatDTO>();
		foreach (ChatDTO item in list)
		{
			chatList2.Add(await GetChatDTO(item));
		}
		start = start ?? Page.GetDefaultStart();
		limit = limit ?? Page.GetDefaultLimit();
		chatList2 = chatList2.OrderByDescending((ChatDTO c) => c.LastActivity).Skip(start.Value).Take(limit.Value)
			.ToList();
		return new Page<ChatDTO>(chatList2, start, limit);
	}

	public async Task<ChatDTO> GetChat(Guid chatUid)
	{
		return await GetChatDTO(await GetUserChatListActor().GetChat(chatUid));
	}

	public async Task<Page<MessageDTO>> GetMessages(Guid chatUid, string lastMessageHash = null, int? start = null, int? limit = null, ListSortDirection? sortDirection = null)
	{
		IChatActor chatActor = GetChatActor(chatUid);
		start = start ?? Page.GetDefaultStart();
		limit = limit ?? Page.GetDefaultLimit();
		return new Page<MessageDTO>(await chatActor.GetMessages(lastMessageHash, start, limit, sortDirection ?? ListSortDirection.Descending), start, limit);
	}

	public async Task<long> GetUnreadMessagesCounter()
	{
		return await GetUserChatListActor().GetUnreadMessagesCount();
	}

	public async Task<MessageModel> SendMessage(Guid chatUid, MessageCreateDTO message)
	{
		return await GetChatActor(chatUid).SendMessage(message);
	}

	public async Task<Guid> CreateChat(CreateChatModel chatModel)
	{
		return await GetUserChatListActor().CreateChat(chatModel);
	}

	public async Task<Guid> StartConversation(Guid userUid)
	{
		return await GetUserChatListActor().CreatePrivateChat(userUid);
	}

	public async Task<Guid> StartConversation(long userId)
	{
		return await GetUserChatListActor().CreatePrivateChat(userId);
	}

	public async Task<ParticipantsDTO> GetChatParticipants(Guid chatUid)
	{
		return await GetChatActor(chatUid).GetParticipants();
	}

	public async Task<ChatModel> AddChatParticipants(Guid chatUid, IEnumerable<long> users, IEnumerable<long> userGroups, IEnumerable<long> organizationItems)
	{
		IChatActor chatActor = GetChatActor(chatUid);
		ICollection<IUser> newRecipients = await chatActor.AddChatParticipants(users, userGroups, organizationItems);
		if (newRecipients == null || !newRecipients.Any())
		{
			return null;
		}
		ChatDTO chat = await chatActor.GetChatInfo();
		return new ChatModel
		{
			Recipients = newRecipients.Select((IUser r) => r.UserName).ToList(),
			Chat = chat
		};
	}

	public async Task<bool> DeleteChatParticipants(Guid chatUid, IEnumerable<long> users, IEnumerable<long> userGroups, IEnumerable<long> organizationItems)
	{
		return await GetChatActor(chatUid).DeleteChatParticipants(users, userGroups, organizationItems);
	}

	public async Task<bool> AddToFavorite(Guid chatUid)
	{
		await GetUserChatListActor().AddToFavorite(chatUid);
		return true;
	}

	public async Task<bool> DeleteFromFavorite(Guid chatUid)
	{
		await GetUserChatListActor().DeleteFromFavorite(chatUid);
		return true;
	}

	public async Task<bool> Mute(Guid chatUid)
	{
		await GetUserChatListActor().Mute(chatUid);
		return true;
	}

	public async Task<bool> Unmute(Guid chatUid)
	{
		await GetUserChatListActor().Unmute(chatUid);
		return true;
	}

	public async Task<Page<ChatDTO>> FindChats(ChatFilter filter, int? start = null, int? limit = null)
	{
		return new Page<ChatDTO>(new List<ChatDTO>(), start, limit);
	}

	public async Task<Page<MessageDTO>> FindMessages(ChatMessageFilter filter, int? start = null, int? limit = null)
	{
		return new Page<MessageDTO>(new List<MessageDTO>(), start, limit);
	}

	public async Task<bool> ReadToHash(Guid chatUid, string messageHash)
	{
		await GetUserChatListActor().ReadToHash(chatUid, messageHash);
		return true;
	}

	private async Task<ChatDTO> GetChatDTO(ChatDTO chat)
	{
		ChatDTO chatDTO = await GetChatActor(chat.Uid).GetChatInfo();
		chat.Subject = chatDTO.Subject;
		chat.Avatar = chatDTO.Avatar;
		chat.Type = chatDTO.Type;
		chat.LastActivity = chatDTO.LastActivity;
		chat.LastMessageHash = chatDTO.LastMessageHash;
		if (chatDTO.Type == ChatTypeEnum.Private)
		{
			chat.Participants = chatDTO.Participants;
		}
		chat.Channels = chatDTO.Channels;
		return chat;
	}

	private IUserChatListActor GetUserChatListActor()
	{
		IUser currentUser = authenticationService.GetCurrentUser<IUser>();
		return actorModelRuntime.GetActor<IUserChatListActor>(currentUser.Uid);
	}

	private IChatActor GetChatActor(Guid chatUid)
	{
		return actorModelRuntime.GetActor<IChatActor>(chatUid);
	}
}
