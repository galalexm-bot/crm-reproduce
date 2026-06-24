using System.Threading.Tasks;
using EleWise.ELMA.Hubs;
using EleWise.ELMA.Messages.DTO;

namespace EleWise.ELMA.Messages.Components.Hubs.Chat;

internal interface IChatClient : IClient
{
	Task ReceiveMessage(MessageDTO messages);

	Task ReceiveChat(ChatDTO chat);
}
