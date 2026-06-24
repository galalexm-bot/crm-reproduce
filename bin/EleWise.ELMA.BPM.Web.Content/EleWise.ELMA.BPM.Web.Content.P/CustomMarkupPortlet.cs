using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.MarkupRendering;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Content.Portlets;

[Component]
public class CustomMarkupPortlet : Portlet<CustomMarkupPortletPersonalization>
{
	public static readonly Guid UID = new Guid("A809AE2D-2D77-4047-991D-C36DCBE113FE");

	private readonly PortletProfile _profile;

	public override IPortletProfile Profile => _profile;

	public IMarkupRenderingService MarkupRenderingService { get; set; }

	public override Guid Uid => UID;

	public override string Name => SR.T("Код");

	public override string Description => SR.T("Позволяет задавать код разметки");

	public override bool AllowMultipleInstance => true;

	public CustomMarkupPortlet()
	{
		_profile = (base.Profile as PortletProfile) ?? PortletProfile.Default;
		_profile.ImageUrl = "#code.svg";
	}

	public override MvcHtmlString Content(HtmlHelper html, CustomMarkupPortletPersonalization data)
	{
		try
		{
			return MarkupRenderingService.Render(html, data.MarkupText ?? "", "razor", data);
		}
		catch (HttpCompileException ex)
		{
			return MvcHtmlString.Create(ex.GetHtmlErrorMessage());
		}
		catch (HttpParseException ex2)
		{
			return MvcHtmlString.Create(ex2.GetHtmlErrorMessage());
		}
		catch (Exception ex3)
		{
			return html.Error(ex3);
		}
	}

	public override MvcHtmlString Settings(HtmlHelper html, CustomMarkupPortletPersonalization data, string path)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		ViewDataDictionary val = new ViewDataDictionary();
		val.set_Item("path", (object)path);
		return PartialExtensions.Partial(html, "CustomMarkupPortlet/Settings", (object)data, val);
	}

	protected override Permission PortletPermission()
	{
		return EleWise.ELMA.Content.PermissionProvider.ManageMarkup;
	}

	protected override bool HasViewPermission(CustomMarkupPortletPersonalization data)
	{
		return true;
	}
}
