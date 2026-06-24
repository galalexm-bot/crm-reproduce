using System;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Models.Panels;

public class CollapsiblePanel
{
	private bool saveState = true;

	public string Id { get; set; }

	public string Header { get; set; }

	public string LinkHeader { get; set; }

	public string HeaderClose { get; set; }

	public string ImageUrl { get; set; }

	public string Url { get; set; }

	public DynamicLoadMode LoadMode { get; set; }

	public HtmlStyle Style { get; set; }

	public string Class { get; set; }

	public bool PlusMinus { get; set; }

	public bool Expanded { get; set; }

	public bool SaveState
	{
		get
		{
			return saveState;
		}
		set
		{
			saveState = value;
		}
	}

	public Func<object, object> Content { get; set; }

	public string OnExpand { get; set; }

	public MvcHtmlString HeaderExt { get; set; }

	public CollapsiblePanel()
	{
		PlusMinus = true;
	}
}
