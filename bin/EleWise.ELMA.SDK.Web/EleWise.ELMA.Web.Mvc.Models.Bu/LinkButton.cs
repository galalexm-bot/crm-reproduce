using System.Collections.Generic;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Models.Buttons;

public class LinkButton
{
	public string Text { get; set; }

	public string Href { get; set; }

	public string OnClick { get; set; }

	public string Image { get; set; }

	public MvcHtmlString Description { get; set; }

	public IDictionary<string, object> Attributes { get; set; }

	public LinkButton()
	{
		Href = "#";
	}
}
