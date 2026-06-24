using System;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc;

public class LazyJsonResult : JsonResult
{
	private readonly Action<JsonResult> action;

	public LazyJsonResult(Action<JsonResult> action)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		this.action = action;
	}

	public override void ExecuteResult(ControllerContext context)
	{
		action((JsonResult)(object)this);
		((JsonResult)this).ExecuteResult(context);
	}
}
