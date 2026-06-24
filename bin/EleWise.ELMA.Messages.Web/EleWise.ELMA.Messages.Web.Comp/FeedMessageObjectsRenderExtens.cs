using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Web.ExtensionPoints;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Messages.Web.Components.Feed;

[Component(Order = 100000)]
public class FeedMessageObjectsRenderExtension : IFeedMessageObjectsRenderExtension
{
	public virtual bool IsSupport(Guid objectTypeUid, MessageObject messageObject)
	{
		return true;
	}

	public virtual string Name(Guid objectTypeUid, MessageObject messageObject)
	{
		Type entityType = ModelHelper.GetEntityType(messageObject.TypeUid);
		if (entityType == null)
		{
			return SR.T("Объект");
		}
		if (!(InterfaceActivator.LoadMetadata(entityType) is EntityMetadata entityMetadata))
		{
			return SR.T("Объект");
		}
		return entityMetadata.DisplayName;
	}

	public virtual MvcHtmlString MessageObject(HtmlHelper html, MessageObject messageObject, object objectModel)
	{
		return PartialExtensions.Partial(html, "MessageObjectLink", (object)messageObject);
	}
}
