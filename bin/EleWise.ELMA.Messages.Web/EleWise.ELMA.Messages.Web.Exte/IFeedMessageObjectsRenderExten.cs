using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messaging;

namespace EleWise.ELMA.Messages.Web.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IFeedMessageObjectsRenderExtension
{
	bool IsSupport(Guid objectTypeUid, MessageObject messageObject);

	string Name(Guid objectTypeUid, MessageObject messageObject);

	MvcHtmlString MessageObject(HtmlHelper html, MessageObject messageObject, object objectModel);
}
