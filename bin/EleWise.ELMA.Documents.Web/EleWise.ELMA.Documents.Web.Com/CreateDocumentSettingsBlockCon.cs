using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Components;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Web.Extensions;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Documents.Web.Components;

[Component(Order = 230)]
public class CreateDocumentSettingsBlockControllerBase : DocumentStorageSettingsBlockControllerBase<CreateDocumentSettings, CreateDocumentSettingsBlock>
{
	public CreateDocumentSettingsBlockControllerBase(CreateDocumentSettingsBlock module)
		: base(module)
	{
	}

	public override MvcHtmlString RenderDisplay(HtmlHelper html)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		ViewDataDictionary val = new ViewDataDictionary();
		val.Add("viewType", (object)ViewType.Display);
		return PartialExtensions.Partial(html, "Document/CreateDocumentSettings", (object)this, val);
	}

	public override MvcHtmlString RenderEdit(HtmlHelper html)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		ViewDataDictionary val = new ViewDataDictionary();
		val.Add("viewType", (object)ViewType.Edit);
		return PartialExtensions.Partial(html, "Document/CreateDocumentSettings", (object)this, val);
	}
}
