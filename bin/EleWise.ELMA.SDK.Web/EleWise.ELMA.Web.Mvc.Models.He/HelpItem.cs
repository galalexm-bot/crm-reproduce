using System;
using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Web.Mvc.Models.Help;

[Serializable]
public class HelpItem : IXsiType
{
	public string PageId { get; set; }

	public string PageUrl { get; set; }
}
