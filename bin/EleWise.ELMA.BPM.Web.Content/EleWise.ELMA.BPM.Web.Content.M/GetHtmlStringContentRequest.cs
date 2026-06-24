using System;
using System.Collections.Generic;

namespace EleWise.ELMA.BPM.Web.Content.Models;

[Serializable]
public sealed class GetHtmlStringContentRequest
{
	public string HtmlValue { get; set; }

	public List<string> RegisteredZones { get; set; } = new List<string>();

}
