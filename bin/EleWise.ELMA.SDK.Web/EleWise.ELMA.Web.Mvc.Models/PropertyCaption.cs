using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Models;

public class PropertyCaption
{
	public bool Required { get; set; }

	public string Text { get; set; }

	public string Description { get; set; }

	public MvcHtmlString PropertyPath { get; set; }
}
