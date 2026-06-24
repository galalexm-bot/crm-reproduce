using System;
using System.ServiceModel;
using System.ServiceModel.Activation;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.API.Feed.Models;
using EleWise.ELMA.Messages.Managers;
using EleWise.ELMA.Messages.Mobile.API.Interfaces;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Web.Service;

namespace EleWise.ELMA.Messages.Mobile.API.Services;

[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, MaxItemsInObjectGraph = int.MaxValue)]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
[Component]
[Uid("{D1F2869E-EE4C-4DD9-BA95-700DF9D7797D}")]
internal class MessageFeedServiceExtension : IMessageFeedServiceExtension, IPublicAPIWebService
{
	public const string GuidS = "{D1F2869E-EE4C-4DD9-BA95-700DF9D7797D}";

	public static Guid Uid = new Guid("{D1F2869E-EE4C-4DD9-BA95-700DF9D7797D}");

	private FeedManager feedManager;

	public FeedManager FeedManager => feedManager ?? (feedManager = FeedManager.Instance);

	public FeedPost GetPost(string parentObjectId, string parentObjectUid, string recipientId)
	{
		if (!long.TryParse(parentObjectId, out var result))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Неверный формат идентификатора родительского сообщения: {0}", parentObjectId), 404);
		}
		if (!Guid.TryParse(parentObjectUid, out var result2))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Неверный формат уникального идентификатора родительского сообщения: {0}", parentObjectUid), 404);
		}
		if (!long.TryParse(recipientId, out var result3))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Неверный формат идентификатора получателя сообщения: {0}", recipientId), 404);
		}
		return FeedPost.CreateFeedPost(FeedManager.LoadMessage(result, result2, result3) ?? throw PublicServiceException.CreateWebFault(SR.T("Сообщение не найдено"), 404));
	}
}
