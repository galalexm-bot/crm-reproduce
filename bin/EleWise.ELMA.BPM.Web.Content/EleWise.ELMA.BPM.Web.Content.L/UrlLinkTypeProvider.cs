using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Content;

namespace EleWise.ELMA.BPM.Web.Content.LinkTypeProviders;

[Component]
public class UrlLinkTypeProvider : LinkTypeProvider, ILinkTypeProvider
{
	private readonly UrlActionProvider urlActionProvider;

	public string Name => SR.M("Ссылка (URL)");

	public int? Order => 5;

	public override string Image => "#web.svg";

	public string Id => urlActionProvider.Id;

	public UrlLinkTypeProvider(UrlActionProvider urlActionProvider)
	{
		this.urlActionProvider = urlActionProvider;
	}

	public MvcHtmlString RenderSelector(HtmlHelper htmlHelper)
	{
		return InputExtensions.TextBox(htmlHelper, "url", (object)"", (object)new
		{
			@class = "text-box"
		});
	}

	protected override string ValueElement(HtmlHelper htmlHelper)
	{
		return "url";
	}

	protected override string TextElement(HtmlHelper htmlHelper)
	{
		return ValueElement(htmlHelper);
	}

	public IContentAction Get(string id)
	{
		return urlActionProvider.Get(id);
	}
}
