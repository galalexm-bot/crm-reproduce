using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Content.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Content.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.UI.Models;

namespace EleWise.ELMA.BPM.Web.Content.Components;

[Component]
public class PageProfileContentModelExtension : IPageContentModelExtension
{
	public bool CheckPage(IPortalObject page)
	{
		return page is IPageProfile;
	}

	public IPageContentModel CreateModel(IPortalObject page)
	{
		return new PageProfileContentModel
		{
			Page = page
		};
	}

	public bool CheckModel(IPageContentModel model)
	{
		return model is PageProfileContentModel;
	}

	public MvcHtmlString RenderModel(HtmlHelper html, IPageContentModel model)
	{
		IFormMetadataItemHeader formMetadataItemHeader = AbstractNHEntityManager<IFormMetadataItemHeader, long>.Instance.LoadOrNull(model.Page.Uid);
		if (formMetadataItemHeader == null)
		{
			return ChildActionExtensions.Action(html, "PageV2", "UI", (object)new
			{
				area = "EleWise.ELMA.SDK.Web",
				pageUid = model.Page.Uid,
				partial = true
			});
		}
		return ChildActionExtensions.Action(html, "Page", "UI", (object)new
		{
			area = "EleWise.ELMA.SDK.Web",
			pageName = formMetadataItemHeader.Name,
			partial = true
		});
	}
}
