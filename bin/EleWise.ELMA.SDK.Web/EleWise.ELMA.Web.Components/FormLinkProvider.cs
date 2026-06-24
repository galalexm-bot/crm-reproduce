using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.Web.Components;

[Component]
public class FormLinkProvider : LinkTypeProvider, ILinkTypeProvider
{
	public override bool ShowInTree => false;

	public override string Image => "#pattern.svg";

	public override string ActionType => ContentAction.ActionTypeDialog;

	public override string Category => SR.M("Формы");

	public string Id => "EleWise.ELMA.Web.Components.FormActionProvider";

	public string Name => SR.M("Открыть форму");

	public int? Order => 0;

	protected override string ValueElement(HtmlHelper htmlHelper)
	{
		return "FormActionProvider_Id";
	}

	protected override string TextElement(HtmlHelper htmlHelper)
	{
		return "FormActionProvider_Text";
	}

	public IContentAction Get(string parameters)
	{
		ContentAction contentAction = new ContentAction
		{
			Id = parameters,
			NameForLocalization = Name,
			Category = Category,
			ActionType = ActionType,
			Image16 = Image
		};
		string[] parts = parameters.Split(new string[1] { "-BEFE1D44-62F6-457E-B628-F6CDC62FC2C9-" }, StringSplitOptions.None);
		if (!Guid.TryParse(parts.Last(), out var buttonUid))
		{
			buttonUid = Guid.Empty;
		}
		int popupWidth = int.Parse(parts[4]);
		string popupId = $"T{Guid.NewGuid()}";
		contentAction.LinkTemplate = delegate(RequestContext cc)
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			object obj = cc.RouteData.Values["Button-id"];
			string value = new UrlHelper(cc).Action("OpenForm", "DynamicForms", (object)new
			{
				area = "EleWise.ELMA.SDK.Web",
				newPopupId = popupId,
				buttonUid = buttonUid,
				actionSettings = ""
			});
			return ((object)MvcHtmlString.Create($"elma.dynamicForms.refreshPopupWithWidth('{obj}', '{HttpUtility.JavaScriptStringEncode(popupId)}', '{HttpUtility.JavaScriptStringEncode(value)}', {((popupWidth > 0) ? (-1) : 900)});")).ToString().PrepareJavascriptHref();
		};
		contentAction.OnRenderDelegate = delegate(HtmlHelper helper)
		{
			helper.RegisterContent("ButtonPopupOpen" + popupId, (dynamic d) => helper.PopupWindow(popupId, parts[3], popupWidth));
		};
		return contentAction;
	}

	public MvcHtmlString RenderSelector(HtmlHelper htmlHelper)
	{
		return MvcHtmlString.Empty;
	}
}
