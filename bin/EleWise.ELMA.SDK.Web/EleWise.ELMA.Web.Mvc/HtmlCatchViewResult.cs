using System;
using System.IO;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc;

public class HtmlCatchViewResult : PartialViewResult, ITypedActionResult
{
	public ActionResultType ResultType => ActionResultType.Html;

	public string HtmlResult { get; set; }

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
		using (StringWriter stringWriter = new StringWriter())
		{
			ViewContext val2 = new ViewContext(context, ((ViewResultBase)this).get_View(), ((ViewResultBase)this).get_ViewData(), ((ViewResultBase)this).get_TempData(), (TextWriter)stringWriter);
			OnViewContextCreated(val2);
			((ViewResultBase)this).get_View().Render(val2, (TextWriter)stringWriter);
			OnViewRendered(val2);
			HtmlResult = stringWriter.ToString();
		}
		if (val != null)
		{
			val.get_ViewEngine().ReleaseView(context, ((ViewResultBase)this).get_View());
		}
	}

	protected virtual void OnViewContextCreated(ViewContext viewContext)
	{
	}

	protected virtual void OnViewRendered(ViewContext viewContext)
	{
	}
}
