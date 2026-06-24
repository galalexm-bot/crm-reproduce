using System.Collections.Generic;

namespace EleWise.ELMA.BPM.Web.Content.Models;

public sealed class PageInputsModel
{
	public string ActionId { get; set; }

	public long PageId { get; set; }

	public List<string> PropertyNames { get; set; }

	public object Context { get; set; }
}
