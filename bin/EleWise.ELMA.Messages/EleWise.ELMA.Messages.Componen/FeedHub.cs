using System;
using EleWise.ELMA.Hubs;

namespace EleWise.ELMA.Messages.Components.Hubs;

internal sealed class FeedHub : HubBase<IFeedClient>, IFeedHub, IHub
{
	public void SendComment(string comment, long actionObjectId, Guid actionObjectUid, string changeDateHash)
	{
		throw new NotImplementedException();
	}
}
