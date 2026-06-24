using System;
using System.Threading.Tasks;
using EleWise.ELMA.Messages.DTO;

namespace EleWise.ELMA.Messages.Services;

public interface IChatService
{
	Task<Guid> CreateChat(CreateChatModel chatModel);

	Task<Guid> StartConversation(Guid userUid);

	Task<Guid> StartConversation(long userId);

	Task<MessageModel> SendMessage(Guid chatUid, MessageCreateDTO message);
}
