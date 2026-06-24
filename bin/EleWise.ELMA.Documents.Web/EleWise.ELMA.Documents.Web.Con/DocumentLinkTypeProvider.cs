using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using EleWise.ELMA.BPM.Web.Common.Attributes;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Web.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Content;

namespace EleWise.ELMA.Documents.Web.ContentLinkTypeProviders;

[Component]
[ActionWizardItem(Order = 10, Image32 = "#doc.svg", Category = ActionWizardItemCategory.Link)]
public class DocumentLinkTypeProvider : LinkTypeProvider, ILinkTypeProvider
{
	public string Id => "DocumentLinkTypeProvider";

	public string Name => SR.M("Документ");

	public int? Order => 20;

	public override string Image => "#file.svg";

	public DocumentManager DocumentManager { get; set; }

	public ISecurityService SecurityService { get; set; }

	public IContentAction Get(string id)
	{
		return new ContentAction
		{
			Id = id,
			ReferenceType = "Document",
			Image24 = "#file.svg",
			Routes = new ActionRoute("View", "Document", new
			{
				area = "EleWise.ELMA.Documents.Web",
				id = id
			}),
			MatchCurrentDelegate = (RequestContext requestContext) => (object.Equals(requestContext.RouteData.Values["action"], "View") && object.Equals(requestContext.RouteData.Values["controller"], "Document") && object.Equals(requestContext.RouteData.Values["area"], "EleWise.ELMA.Documents.Web") && object.Equals(requestContext.RouteData.Values["id"], id)) ? 9 : 0
		};
	}

	public MvcHtmlString RenderSelector(HtmlHelper htmlHelper)
	{
		return PartialExtensions.Partial(htmlHelper, "ContentSelectors/DocumentSelector", (object)new DocumentSelectorModel());
	}

	protected override string ValueElement(HtmlHelper htmlHelper)
	{
		return "Document_Id";
	}

	protected override string TextElement(HtmlHelper htmlHelper)
	{
		return ValueElement(htmlHelper) + "-input";
	}

	public override string GetActionName(IContentAction contentAction)
	{
		long id = long.Parse(contentAction.Id);
		string text = SR.M("Не найдено");
		SecurityService.RunWithElevatedPrivilegies(delegate
		{
			IDocument document = DocumentManager.LoadOrNull(id);
			if (document != null)
			{
				text = document.Name;
			}
		});
		return text;
	}
}
