using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.BPM.Web.Tasks.Components;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;

namespace EleWise.ELMA.Documents.Web.Components;

[Component(Order = 15)]
internal class ReplacementTaskDocumentPermissionEditView : ReplacementEditViewBase
{
	public override string Id => TasksReplacementEditView.PanelId;

	public override string Name => SR.T("Задачи");

	public override MvcHtmlString Render(HtmlHelper html, ReplacementModel model)
	{
		IReplacementTaskDocumentPermission replacementTaskDocumentPermission = ((model != null) ? (model.Replacement as IReplacementTaskDocumentPermission) : null);
		string htmlFieldPrefix = html.get_ViewData().get_TemplateInfo().get_HtmlFieldPrefix();
		html.get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix("Replacement");
		MvcHtmlString result = ((replacementTaskDocumentPermission == null) ? MvcHtmlString.Empty : PartialExtensions.Partial(html, "Replacement/ReplacementTaskDocumentPermissionEditView", (object)replacementTaskDocumentPermission));
		html.get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix(htmlFieldPrefix);
		return result;
	}
}
