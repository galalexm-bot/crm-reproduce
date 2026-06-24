using System;
using System.Web.Mvc;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Content;

public class ContentCategory : IContentCategory, IContentItem
{
	public string Id { get; set; }

	public string Name { get; set; }

	public string Image16 { get; set; }

	public string Image24 { get; set; }

	public string Image32 { get; set; }

	public string Description { get; set; }

	public int Order { get; set; }

	public bool HasMarkup => false;

	public MvcHtmlString RenderMarkup(HtmlHelper htmlHelper)
	{
		throw new NotImplementedException();
	}

	public string GetImage(ObjectIconFormat size = ObjectIconFormat.x16)
	{
		return ContentAction.ImageBySizeAccessor(() => Image16, () => Image24, () => Image32, size);
	}
}
