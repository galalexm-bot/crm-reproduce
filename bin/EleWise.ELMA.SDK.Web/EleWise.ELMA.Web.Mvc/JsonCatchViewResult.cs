using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc;

public class JsonCatchViewResult : PartialViewResult, ITypedActionResult
{
	private Func<ControllerContext, IDictionary<string, object>> _resultAccessor;

	public ActionResultType ResultType => ActionResultType.Json;

	public IDictionary<string, object> JsonResult { get; set; }

	public JsonCatchViewResult(ViewResultBase actionResult = null, Func<ControllerContext, IDictionary<string, object>> resultAccessor = null)
	{
		if (actionResult != null)
		{
			((ViewResultBase)this).set_ViewName(actionResult.get_ViewName());
			((ViewResultBase)this).set_ViewData(actionResult.get_ViewData());
			((ViewResultBase)this).set_TempData(actionResult.get_TempData());
		}
		_resultAccessor = resultAccessor;
	}

	public override void ExecuteResult(ControllerContext context)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (string.IsNullOrEmpty(((ViewResultBase)this).get_ViewName()))
		{
			((ViewResultBase)this).set_ViewName(context.get_RouteData().GetRequiredString("action"));
		}
		ViewEngineResult val = null;
		if (((ViewResultBase)this).get_View() == null)
		{
			val = ((ViewResultBase)this).FindView(context);
			((ViewResultBase)this).set_View(val.get_View());
		}
		TextWriter @null = TextWriter.Null;
		ViewContext val2 = new ViewContext(context, ((ViewResultBase)this).get_View(), ((ViewResultBase)this).get_ViewData(), ((ViewResultBase)this).get_TempData(), @null);
		OnViewContextCreated(val2);
		((ViewResultBase)this).get_View().Render(val2, @null);
		OnViewRendered(val2);
		if (val != null)
		{
			val.get_ViewEngine().ReleaseView(context, ((ViewResultBase)this).get_View());
		}
		if (_resultAccessor != null)
		{
			JsonResult = _resultAccessor(context);
		}
	}

	protected virtual void OnViewContextCreated(ViewContext viewContext)
	{
	}

	protected virtual void OnViewRendered(ViewContext viewContext)
	{
	}
}
