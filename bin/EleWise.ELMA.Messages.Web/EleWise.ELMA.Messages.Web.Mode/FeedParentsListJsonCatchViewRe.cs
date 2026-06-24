using System.Web.Mvc;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Extensions;

namespace EleWise.ELMA.Messages.Web.Models;

public class FeedParentsListJsonCatchViewResult : JsonCatchViewResult
{
	public override void ExecuteResult(ControllerContext context)
	{
		base.ExecuteResult(context);
		if (((ViewResultBase)this).get_Model() is FeedParentsListJsonModel feedParentsListJsonModel)
		{
			string value = ((object)new { feedParentsListJsonModel.UrlRedirect, feedParentsListJsonModel.ViewResult }.ToJson()).ToString();
			context.get_HttpContext().Response.Output.Write(value);
		}
	}
}
