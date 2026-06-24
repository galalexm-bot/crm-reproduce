using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.UI.Results;
using EleWise.ELMA.Web.Mvc.Controllers;

namespace EleWise.ELMA.Web.Mvc.Models.UI.ResultConverters;

[Component]
public class RedirectToPageResultConverter : IFormResultConverter
{
	public Type ResultType => typeof(RedirectToPageResult);

	public ActionResult Convert(FormResult result, BaseController controller)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		RedirectToPageResult redirectToPageResult = (RedirectToPageResult)result;
		return (ActionResult)new RedirectResult("~/UI/Page/" + redirectToPageResult.PageId);
	}

	public Dictionary<string, object> GetClientData(FormResult result, BaseController controller)
	{
		RedirectToPageResult redirectToPageResult = (RedirectToPageResult)result;
		string value = "/UI/Page/" + redirectToPageResult.PageId;
		return new Dictionary<string, object> { { "RedirectUrl", value } };
	}
}
