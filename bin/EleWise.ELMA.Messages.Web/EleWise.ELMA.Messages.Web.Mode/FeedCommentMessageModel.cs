using System.Collections.Generic;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messaging;

namespace EleWise.ELMA.Messages.Web.Models;

public class FeedCommentMessageModel
{
	public IFeedObjectGroupExtension RenderExtension;

	public Dictionary<MessageAttachment, object> FeedAttachments { get; set; }

	public FeedModel Message { get; set; }
}
