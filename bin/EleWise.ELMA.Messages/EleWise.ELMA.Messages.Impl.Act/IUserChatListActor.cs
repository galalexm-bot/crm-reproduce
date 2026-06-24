using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Messages.DTO;

namespace EleWise.ELMA.Messages.Impl.Actors;

internal interface IUserChatListActor : IActorWithGuidKey, IActor
{
	Task<List<ChatDTO>> GetChats(int? start = null, int? limit = null);

	Task<ChatDTO> GetChat(Guid chatUid);

	Task<long> GetUnreadMessagesCount();

	Task<Guid> CreateChat(CreateChatModel chatModel);

	Task<Guid> CreatePrivateChat(Guid userUid);

	Task<Guid> CreatePrivateChat(long userId);

	Task AddToFavorite(Guid chatUid);

	Task DeleteFromFavorite(Guid chatUid);

	Task Mute(Guid chatUid);

	Task Unmute(Guid chatUid);

	Task ReadToHash(Guid chatUid, string messageHash, bool isLastMessageHash = true);
}
