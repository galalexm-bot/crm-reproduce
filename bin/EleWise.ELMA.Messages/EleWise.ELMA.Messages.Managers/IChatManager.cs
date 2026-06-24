using System;
using System.Collections.Generic;
using EleWise.ELMA.Messages.DTO;
using EleWise.ELMA.Messages.Models.Chats;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Messages.Managers;

internal interface IChatManager
{
	IChat Load(Guid uid);

	IChatParticipant LoadChatParticipant(Guid uid);

	IEnumerable<IChatParticipant> FindChatsParticipant(IUser user, FetchOptions opts = null);

	Guid CreateOrLoadPrivateChat(IUser user);

	IEnumerable<IChat> Find(FetchOptions opts = null);

	IChat Create(CreateChatModel model);

	ICollection<IUser> GetChatRecipients(Guid chatUid);

	ICollection<IUser> AddChatParticipants(Guid chatUid, IEnumerable<long> userIds, IEnumerable<long> userGroups, IEnumerable<long> organizationItems);

	ICollection<IUser> DeleteChatParticipants(Guid chatUid, IEnumerable<long> userIds, IEnumerable<long> userGroups, IEnumerable<long> organizationItems);
}
