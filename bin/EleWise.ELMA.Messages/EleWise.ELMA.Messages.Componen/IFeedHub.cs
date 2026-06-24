using System;
using EleWise.ELMA.Hubs;

namespace EleWise.ELMA.Messages.Components.Hubs;

internal interface IFeedHub : IHub
{
	void SendComment(string comment, long actionObjectId, Guid actionObjectUid, string changeDateHash);
}
