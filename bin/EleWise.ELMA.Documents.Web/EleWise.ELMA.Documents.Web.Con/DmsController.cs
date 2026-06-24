using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Exceptions;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Services;
using EleWise.ELMA.Documents.Web.Exceptions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.Documents.Web.Controllers;

[Permission("410ABDDC-FC2D-46E6-BB5E-ADF1B41E49A1")]
public class DmsController<TModel, TModelId> : BPMController<TModel, TModelId> where TModel : IEntity<TModelId>
{
	[NotNull]
	public ISystemFoldersService SystemFoldersService { get; set; }

	public string GetRedirectToDocumentUrl(IDocument document, bool toDocumentChapter)
	{
		string text = ((Controller)this).get_Url().get_RequestContext().HttpContext.Request.Params.Get("ReturnUrl");
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		if (document != null && !document.IsDeleted)
		{
			return ((Controller)this).get_Url().Action("View", "Document", (object)new
			{
				area = "EleWise.ELMA.Documents.Web",
				id = document.Id
			});
		}
		if (toDocumentChapter)
		{
			return ((Controller)this).get_Url().Action("View", "Folder", (object)new
			{
				area = "EleWise.ELMA.Documents.Web"
			});
		}
		return ((Controller)this).get_Url().ReturnUrl(redirectHomeIfNull: true);
	}

	public ActionResult RedirectToDocument(IDocument document, string message = null)
	{
		if (!string.IsNullOrEmpty(message))
		{
			base.Notifier.Information(message);
		}
		string redirectToDocumentUrl = GetRedirectToDocumentUrl(document, toDocumentChapter: false);
		return (ActionResult)(object)((Controller)this).Redirect(redirectToDocumentUrl);
	}

	protected override void OnException(ExceptionContext filterContext)
	{
		DmsController.ProcessException(filterContext, (ControllerBase)(object)this);
		base.OnException(filterContext);
	}
}
[Permission("410ABDDC-FC2D-46E6-BB5E-ADF1B41E49A1")]
public class DmsController : BPMController
{
	protected override void OnException(ExceptionContext filterContext)
	{
		ProcessException(filterContext, (ControllerBase)(object)this);
		base.OnException(filterContext);
	}

	public static void ProcessException(ExceptionContext filterContext, ControllerBase controller)
	{
		if (filterContext.get_Exception() != null)
		{
			ApprovementIsActiveException ex = (filterContext.get_Exception() as ApprovementIsActiveException) ?? (filterContext.get_Exception().InnerException as ApprovementIsActiveException);
			if (ex != null)
			{
				filterContext.set_Result(DmsActionResults.ApprovementIsActive(ex, controller));
				filterContext.set_ExceptionHandled(true);
			}
			DocumentActionException ex2 = (filterContext.get_Exception() as DocumentActionException) ?? (filterContext.get_Exception().InnerException as DocumentActionException);
			if (ex2 != null)
			{
				filterContext.set_Result(DmsActionResults.DocumentActionCancel(ex2, controller));
				filterContext.set_ExceptionHandled(true);
			}
		}
	}
}
