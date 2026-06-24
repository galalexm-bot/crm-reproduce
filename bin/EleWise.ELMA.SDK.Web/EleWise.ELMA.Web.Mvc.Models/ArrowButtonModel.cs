using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Models;

public class ArrowButtonModel
{
	public MvcHtmlString Name { get; set; }

	public string ArrowTagId { get; set; }

	public bool IsOpen { get; set; }
}
