using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using AutoMapper;
using EleWise.ELMA.Hubs;
using EleWise.ELMA.Messages.DTO;
using EleWise.ELMA.Messages.Models.Chats;
using EleWise.ELMA.Messages.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.Messages.Components.Hubs.Chat;

internal sealed class ChatHub : HubBase<IChatClient>, IChatHub, IHub, IChatHubService
{
	private readonly IInternalChatService chatService;

	private readonly IAuthenticationService authenticationService;

	public ChatHub(IChatService chatService, IAuthenticationService authenticationService)
	{
		CheckChatEnabled();
		this.chatService = chatService as IInternalChatService;
		this.authenticationService = authenticationService;
	}

	public Task<Page<ChatDTO>> GetChats(int? start = null, int? limit = null)
	{
		return chatService.GetChats(start, limit);
	}

	public Task<ChatDTO> GetChat(Guid chatGuid)
	{
		return chatService.GetChat(chatGuid);
	}

	public Task<long> GetUnreadMessagesCount()
	{
		return chatService.GetUnreadMessagesCounter();
	}

	public async Task<Page<MessageDTO>> GetMessages(Guid chatGuid, string lastMessageHash = null, int? start = null, int? limit = null, ListSortDirection? sortDirection = null)
	{
		return await chatService.GetMessages(chatGuid, lastMessageHash, start, limit, sortDirection);
	}

	public async Task<Guid> SendMessage(Guid chatGuid, MessageCreateDTO message)
	{
		MessageModel model = await chatService.SendMessage(chatGuid, message);
		await base.Clients.Users(model.Recipients).ReceiveMessage(model.Message);
		return model.Message.Uid;
	}

	public Task<Guid> CreateChat(CreateChatModel chatModel)
	{
		return chatService.CreateChat(chatModel);
	}

	public Task<Guid> StartConversation(long userId)
	{
		return chatService.StartConversation(userId);
	}

	public Task<ParticipantsDTO> GetChatParticipants(Guid chatGuid)
	{
		return chatService.GetChatParticipants(chatGuid);
	}

	public async Task<bool> AddChatParticipants(Guid chatUid, IEnumerable<long> users, IEnumerable<long> userGroups, IEnumerable<long> organizationItems)
	{
		ChatModel chatModel = await chatService.AddChatParticipants(chatUid, users, userGroups, organizationItems);
		if (chatModel != null)
		{
			await base.Clients.Users(chatModel.Recipients).ReceiveChat(chatModel.Chat);
			return true;
		}
		return false;
	}

	public Task<bool> DeleteChatParticipants(Guid chatUid, IEnumerable<long> users, IEnumerable<long> userGroups, IEnumerable<long> organizationItems)
	{
		return chatService.DeleteChatParticipants(chatUid, users, userGroups, organizationItems);
	}

	public Task<bool> AddToFavorite(Guid chatUid)
	{
		return chatService.AddToFavorite(chatUid);
	}

	public Task<bool> DeleteFromFavorite(Guid chatUid)
	{
		return chatService.DeleteFromFavorite(chatUid);
	}

	public Task<bool> Mute(Guid chatUid)
	{
		return chatService.Mute(chatUid);
	}

	public Task<bool> Unmute(Guid chatUid)
	{
		return chatService.Unmute(chatUid);
	}

	public Task<Page<ChatDTO>> FindChats(ChatFilter filter, int? start = null, int? limit = null)
	{
		return chatService.FindChats(filter, start, limit);
	}

	public Task<Page<MessageDTO>> FindMessages(ChatMessageFilter filter, int? start = null, int? limit = null)
	{
		return chatService.FindMessages(filter, start, limit);
	}

	public Task<bool> ReadToHash(Guid chatUid, string messageHash)
	{
		return chatService.ReadToHash(chatUid, messageHash);
	}

	public async Task<ChatClientState> GetState()
	{
		long unreadCount = await chatService.GetUnreadMessagesCounter();
		IUser currentUser = authenticationService.GetCurrentUser<IUser>();
		return new ChatClientState
		{
			UnreadCount = unreadCount,
			CurrentUser = Mapper.Map<IUser, UserDTO>(currentUser),
			Date = DateTime.Now.ToUniversalTime()
		};
	}

	private void CheckChatEnabled()
	{
		if (!SR.GetSetting("ELMAChat.Enabled", defaultValue: false))
		{
			throw new Exception(SR.T("ChatHub недоступен."));
		}
	}
}
