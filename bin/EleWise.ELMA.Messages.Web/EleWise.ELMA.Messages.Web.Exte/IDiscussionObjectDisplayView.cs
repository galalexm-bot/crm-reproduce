using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Models;

namespace EleWise.ELMA.Messages.Web.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IDiscussionObjectDisplayView
{
	bool CheckType(IDiscussionObject obj);

	MvcHtmlString Render(HtmlHelper html, IDiscussionObject obj);
}
