using System.Collections.Generic;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Messages.Components.Hubs;

public interface IFeedHubService
{
	void SendComment(FeedModel model, IEnumerable<IUser> users);
}
