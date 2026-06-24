using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Common.Attributes;
using EleWise.ELMA.BPM.Web.Content.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Content.LinkTypeProviders;

[Component]
[ActionWizardItem(Order = 20, Image32 = "#page_outline.svg", Category = ActionWizardItemCategory.Link)]
public class PagesLinkTypeProvider : LinkTypeProvider, ILinkTypeProvider
{
	public const string ID = "PagesLinkTypeProvider";

	public string Id => "PagesLinkTypeProvider";

	public string Name => SR.M("Страница");

	public int? Order => 30;

	public override string Image => "#page_fill.svg";

	public IEntityManager<IPageBase> PageBaseManager { get; set; }

	public ISecurityService SecurityService { get; set; }

	public MvcHtmlString RenderSelector(HtmlHelper htmlHelper)
	{
		return PartialExtensions.Partial(htmlHelper, "ContentSelectors/PageSelector", (object)new PageSelectorModel());
	}

	protected override string ValueElement(HtmlHelper htmlHelper)
	{
		return "Page_Id";
	}

	protected override string TextElement(HtmlHelper htmlHelper)
	{
		return ValueElement(htmlHelper) + "-input";
	}

	public IContentAction Get(string id)
	{
		return new ContentAction
		{
			Id = id,
			ReferenceType = "Page",
			Routes = new ActionRoute("View", "Page", new
			{
				area = "EleWise.ELMA.BPM.Web.Content",
				id = id,
				scope = PersonalizationScope.User
			})
		};
	}

	public override string GetActionName(IContentAction contentAction)
	{
		long id = long.Parse(contentAction.Id);
		string text = SR.M("Не найдено");
		SecurityService.RunWithElevatedPrivilegies(delegate
		{
			IPageBase pageBase = PageBaseManager.LoadOrNull(id);
			if (pageBase != null)
			{
				text = pageBase.Name;
			}
		});
		return text;
	}
}
