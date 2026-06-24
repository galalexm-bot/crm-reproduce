using System;
using System.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class LogOnViewModel
{
	public string ErrorMessage { get; set; }

	public string LogoType { get; set; }

	public string LogoTypeText { get; set; }

	public Func<HtmlHelper, MvcHtmlString> Body { get; set; }
}
