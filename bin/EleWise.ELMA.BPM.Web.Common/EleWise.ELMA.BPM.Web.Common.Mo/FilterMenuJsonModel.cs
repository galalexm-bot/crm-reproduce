using System.Collections.Generic;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class FilterMenuJsonModel
{
	public string Text { get; set; }

	public string ImageUrl { get; set; }

	public string Value { get; set; }

	public bool Expanded { get; set; }

	public FilterMenuJsonModel[] Items { get; set; }

	public IDictionary<string, object> ExtHtmlAttributes { get; set; }
}
