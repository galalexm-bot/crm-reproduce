using EleWise.ELMA.Hubs;

namespace EleWise.ELMA.Messages.Components.Hubs;

internal interface IFeedClient : IClient
{
	void SendComment(FeedCommentModel model);
}
