using System;
using System.Collections.Generic;
using EleWise.ELMA.Messages.Models.Chats;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Messages.Managers;

internal interface IChatMessageManager
{
	IChatMessage Load(Guid uid);

	IEnumerable<IChatMessage> LoadByChat(Guid uid, FetchOptions opts = null);

	IEnumerable<IChatMessage> Find();

	IChatMessage Create(Guid chatUid, string messageText);
}
