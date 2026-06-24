using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Security.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IAlternativeMethodProvider
{
	Guid ProviderUid { get; }

	string DisplayName { get; }

	SelectListItem NewListItem { get; }

	bool CanRender(HtmlHelper html);

	MvcHtmlString RenderContent(HtmlHelper html);
}
