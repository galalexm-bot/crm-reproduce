using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.Documents.Exceptions;
using EleWise.ELMA.Documents.Models;

namespace EleWise.ELMA.Documents.Web.Exceptions;

public static class DmsActionResults
{
	public static ActionResult ApprovementIsActive(ApprovementIsActiveException securityException, ControllerBase controller)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		if (controller.get_ControllerContext().get_IsChildAction())
		{
			ViewDataDictionary viewData = controller.get_ViewData();
			ViewResult val = new ViewResult();
			((ViewResultBase)val).set_ViewName("DocumentTask/ApprovementIsActive");
			val.set_MasterName((string)null);
			((ViewResultBase)val).set_ViewData(viewData);
			((ViewResultBase)val).set_TempData(controller.get_TempData());
			return (ActionResult)val;
		}
		RouteValueDictionary routeValueDictionary = new RouteValueDictionary
		{
			{ "action", "ApprovementIsActive" },
			{ "controller", "DocumentTask" },
			{ "area", "EleWise.ELMA.Documents.Web" }
		};
		int num = 0;
		foreach (IDocument document in securityException.Documents)
		{
			routeValueDictionary.Add($"document[{num}]", document.Id);
			num++;
		}
		return (ActionResult)new RedirectToRouteResult(routeValueDictionary);
	}

	public static ActionResult DocumentActionCancel(DocumentActionException exception, ControllerBase controller)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		if (controller.get_ControllerContext().get_IsChildAction())
		{
			ViewDataDictionary viewData = controller.get_ViewData();
			ViewResult val = new ViewResult();
			((ViewResultBase)val).set_ViewName("DocumentActionsProfile/ActionException");
			val.set_MasterName((string)null);
			((ViewResultBase)val).set_ViewData(viewData);
			((ViewResultBase)val).set_TempData(controller.get_TempData());
			return (ActionResult)val;
		}
		return (ActionResult)new RedirectToRouteResult(new RouteValueDictionary
		{
			{ "action", "ActionException" },
			{ "controller", "Document" },
			{ "area", "EleWise.ELMA.Documents.Web" },
			{ "id", exception.DocumentId },
			{ "actionUid", exception.ActionUid },
			{ "message", exception.Message }
		});
	}
}
