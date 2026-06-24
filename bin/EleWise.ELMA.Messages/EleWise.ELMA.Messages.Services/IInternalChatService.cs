using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using EleWise.ELMA.Messages.DTO;
using EleWise.ELMA.Messages.Models.Chats;

namespace EleWise.ELMA.Messages.Services;

internal interface IInternalChatService : IChatService
{
	Task<Page<ChatDTO>> GetChats(int? start = null, int? limit = null);

	Task<long> GetUnreadMessagesCounter();

	Task<Page<MessageDTO>> GetMessages(Guid chatUid, string lastMessageHash = null, int? start = null, int? limit = null, ListSortDirection? sortDirection = null);

	Task<ChatDTO> GetChat(Guid chatUid);

	Task<ParticipantsDTO> GetChatParticipants(Guid chatUid);

	Task<ChatModel> AddChatParticipants(Guid chatUid, IEnumerable<long> users, IEnumerable<long> userGroups, IEnumerable<long> organizationItems);

	Task<bool> DeleteChatParticipants(Guid chatUid, IEnumerable<long> users, IEnumerable<long> userGroups, IEnumerable<long> organizationItems);

	Task<bool> AddToFavorite(Guid chatUid);

	Task<bool> DeleteFromFavorite(Guid chatUid);

	Task<bool> Mute(Guid chatUid);

	Task<bool> Unmute(Guid chatUid);

	Task<Page<ChatDTO>> FindChats(ChatFilter filter, int? start = null, int? limit = null);

	Task<Page<MessageDTO>> FindMessages(ChatMessageFilter filter, int? start = null, int? limit = null);

	Task<bool> ReadToHash(Guid chatUid, string messageHash);
}
