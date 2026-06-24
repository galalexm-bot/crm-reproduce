using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using EleWise.ELMA.Hubs;
using EleWise.ELMA.Messages.DTO;
using EleWise.ELMA.Messages.Models.Chats;

namespace EleWise.ELMA.Messages.Components.Hubs.Chat;

internal interface IChatHub : IHub
{
	Task<Page<ChatDTO>> GetChats(int? start = null, int? limit = null);

	Task<ChatDTO> GetChat(Guid chatUid);

	Task<long> GetUnreadMessagesCount();

	Task<Page<MessageDTO>> GetMessages(Guid chatUid, string lastMessageHash = null, int? start = null, int? limit = null, ListSortDirection? sortDirection = ListSortDirection.Descending);

	Task<Guid> SendMessage(Guid chatUid, MessageCreateDTO message);

	Task<Guid> CreateChat(CreateChatModel chatModel);

	Task<Guid> StartConversation(long userId);

	Task<ParticipantsDTO> GetChatParticipants(Guid chatUid);

	Task<bool> AddChatParticipants(Guid chatUid, IEnumerable<long> users, IEnumerable<long> userGroups, IEnumerable<long> organizationItems);

	Task<bool> DeleteChatParticipants(Guid chatUid, IEnumerable<long> users, IEnumerable<long> userGroups, IEnumerable<long> organizationItems);

	Task<bool> AddToFavorite(Guid chatUid);

	Task<bool> DeleteFromFavorite(Guid chatUid);

	Task<bool> Mute(Guid chatUid);

	Task<bool> Unmute(Guid chatUid);

	Task<Page<ChatDTO>> FindChats(ChatFilter filter, int? start = null, int? limit = null);

	Task<Page<MessageDTO>> FindMessages(ChatMessageFilter filter, int? start = null, int? limit = null);

	Task<bool> ReadToHash(Guid chatUid, string messageHash);

	Task<ChatClientState> GetState();
}
