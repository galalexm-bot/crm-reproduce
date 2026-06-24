using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Content.Controllers;
using EleWise.ELMA.BPM.Web.Content.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Content.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Content.Components;

[Component]
public class PortalPageContentModelExtension : IPageContentModelExtension
{
	public bool CheckPage(IPortalObject page)
	{
		return page is IPageBase;
	}

	public IPageContentModel CreateModel(IPortalObject page)
	{
		IPortletPage portletPage = page as IPortletPage;
		if (portletPage == null && page != null)
		{
			IPortletPageConverter portletPageConverter = ComponentManager.Current.GetExtensionPoints<IPortletPageConverter>().FirstOrDefault((IPortletPageConverter p) => p.Type.IsInstanceOfType(page));
			if (portletPageConverter != null)
			{
				portletPage = portletPageConverter.Convert((IPageBase)page);
			}
		}
		if (portletPage == null)
		{
			return null;
		}
		return PageController.CreatePageContentModel(portletPage, PersonalizationScope.User, edit: false);
	}

	public bool CheckModel(IPageContentModel model)
	{
		return model is PortalPageContentModel;
	}

	public MvcHtmlString RenderModel(HtmlHelper html, IPageContentModel model)
	{
		return html.Portal(((PortalPageContentModel)model).PortalModel);
	}
}
