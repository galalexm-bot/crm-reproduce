using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Messages.DTO;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Messages.Impl.Actors;

internal interface IChatActor : IActorWithGuidKey, IActor
{
	Task<List<MessageDTO>> GetMessages(string lastMessageHash = null, int? start = null, int? limit = null, ListSortDirection sortDirection = ListSortDirection.Descending);

	Task<MessageModel> SendMessage(MessageCreateDTO message);

	Task<ChatDTO> GetChatInfo();

	Task<ParticipantsDTO> GetParticipants();

	Task<ICollection<UserDTO>> GetRecipients();

	Task<ICollection<IUser>> AddChatParticipants(IEnumerable<long> users, IEnumerable<long> userGroups, IEnumerable<long> organizationItems);

	Task<bool> DeleteChatParticipants(IEnumerable<long> users, IEnumerable<long> userGroups, IEnumerable<long> organizationItems);

	Task<int> GetMessagesCountAfter(string hash);
}
