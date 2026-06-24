using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Content.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Models;

namespace EleWise.ELMA.BPM.Web.Content.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IPageContentModelExtension
{
	bool CheckPage(IPortalObject page);

	IPageContentModel CreateModel(IPortalObject page);

	bool CheckModel(IPageContentModel model);

	MvcHtmlString RenderModel(HtmlHelper html, IPageContentModel model);
}
