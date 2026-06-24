using System;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Content.LinkTypeProviders;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Content.Portlets;

[Component]
public class HTMLPortlet : Portlet<HTMLPortletPersonalization>
{
	public static readonly Guid id = new Guid("42322F50-9950-4D6B-B849-EC50345483E4");

	private readonly PortletProfile _profile;

	private HtmlContentActionRenderer htmlContentActionRenderer;

	public override Guid Uid => id;

	public override string Name => SR.T("HTML");

	public override string Description => SR.T("Портлет с форматируемым текстом");

	public override IPortletProfile Profile => _profile;

	public override bool AllowMultipleInstance => true;

	public override bool GoodExternalSupported => true;

	public HTMLPortlet(HtmlContentActionRenderer htmlContentActionRenderer)
	{
		_profile = (base.Profile as PortletProfile) ?? PortletProfile.Default;
		_profile.Customizable = true;
		_profile.ImageUrl = "#portlet_html.svg";
		this.htmlContentActionRenderer = htmlContentActionRenderer;
	}

	public override MvcHtmlString Content(HtmlHelper html, HTMLPortletPersonalization data)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		return new MvcHtmlString(PrepareMarkup(data, html) ?? SR.T("Чтобы добавить содержание, откройте страницу в режиме редактирования"));
	}

	public override MvcHtmlString Settings(HtmlHelper html, HTMLPortletPersonalization data, string path)
	{
		return RenderSettingsPartialView(html, "HtmlPortlet/Edit", data);
	}

	private string PrepareMarkup(HTMLPortletPersonalization data, HtmlHelper html)
	{
		string text = data.Text;
		if (text == null)
		{
			return null;
		}
		return "<div class=\"html_string\"><div class=\"top\"></div>" + htmlContentActionRenderer.PrepareMarkup(text, html) + "<div class=\"bottom\"></div></div>";
	}

	protected override Permission PortletPermission()
	{
		return null;
	}
}
