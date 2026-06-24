using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc;

public static class ActionResultTypeResolver
{
	public static ActionResultType Resolve(ActionResult actionResult)
	{
		if (actionResult == null)
		{
			return ActionResultType.Unknown;
		}
		if (actionResult is ITypedActionResult typedActionResult)
		{
			return typedActionResult.ResultType;
		}
		if (actionResult is JsonResult)
		{
			return ActionResultType.Json;
		}
		if (actionResult is ViewResultBase)
		{
			return ActionResultType.Html;
		}
		return ActionResultType.Unknown;
	}
}
