using System.Web.Mvc;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Extensions;

namespace EleWise.ELMA.Messages.Web.Models;

public class FeedCommentsListJsonCatchViewResult : JsonCatchViewResult
{
	public override void ExecuteResult(ControllerContext context)
	{
		base.ExecuteResult(context);
		if (((ViewResultBase)this).get_Model() is FeedCommentsListJsonModel feedCommentsListJsonModel)
		{
			string value = ((object)new { feedCommentsListJsonModel.Success, feedCommentsListJsonModel.CanCreateComment, feedCommentsListJsonModel.CanCreateNextComment, feedCommentsListJsonModel.CanCreateQuestion, feedCommentsListJsonModel.Error, feedCommentsListJsonModel.ViewResult }.ToJson()).ToString();
			context.get_HttpContext().Response.Output.Write(value);
		}
	}
}
