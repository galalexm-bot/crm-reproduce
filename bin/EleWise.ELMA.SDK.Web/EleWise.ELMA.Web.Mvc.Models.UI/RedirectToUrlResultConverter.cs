using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.UI.Results;
using EleWise.ELMA.Web.Mvc.Controllers;

namespace EleWise.ELMA.Web.Mvc.Models.UI.ResultConverters;

[Component]
public class RedirectToUrlResultConverter : IFormResultConverter
{
	public Type ResultType => typeof(RedirectToUrlResult);

	public ActionResult Convert(FormResult result, BaseController controller)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		return (ActionResult)new RedirectResult(((RedirectToUrlResult)result).Url);
	}

	public Dictionary<string, object> GetClientData(FormResult result, BaseController controller)
	{
		string text = ((RedirectToUrlResult)result).Url;
		if (text.StartsWith("~"))
		{
			text = text.Substring(1);
		}
		return new Dictionary<string, object> { { "RedirectUrl", text } };
	}
}
