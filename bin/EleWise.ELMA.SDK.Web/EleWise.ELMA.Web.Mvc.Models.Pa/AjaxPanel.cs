using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Models.Panels;

public class AjaxPanel
{
	public string Id { get; set; }

	public string Url { get; set; }

	public DynamicLoadMode LoadMode { get; set; }

	public string DataFromId { get; set; }

	public FormMethod Method { get; set; }

	public MvcHtmlString Content { get; set; }

	public bool ShowLoader { get; set; }

	public AjaxPanel()
	{
		LoadMode = DynamicLoadMode.Custom;
		Method = (FormMethod)1;
		ShowLoader = true;
	}
}
