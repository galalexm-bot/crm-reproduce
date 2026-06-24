using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Data;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models;
using EleWise.ELMA.Web.Mvc.Models.Forms;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Models.Help;
using EleWise.ELMA.Web.Mvc.Models.Trees;
using EleWise.ELMA.Web.Mvc.Security;
using EleWise.ELMA.Web.Mvc.Services;
using EleWise.ELMA.Web.Mvc.UI;
using EleWise.ELMA.Web.Mvc.Util;
using EleWise.ELMA.Web.Mvc.Views.ViewItem;
using EleWise.ELMA.Web.Orchard.Mvc;
using EleWise.ELMA.Web.Orchard.Mvc.ViewEngines.Razor;
using Orchard.Environment.Descriptor;
using Orchard.Environment.Descriptor.Models;
using Orchard.Environment.Extensions;
using Orchard.Environment.Extensions.Models;
using Orchard.Mvc.ViewEngines;
using Orchard.Utility.Extensions;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Controllers;

[WebRequestAsyncTimeout]
[TemporaryAuthenticationFilter(Order = 0)]
[AuthenticationFilter(Order = 1)]
[ActionEvent(Order = 2)]
[RegisterContent(Order = 10)]
[HelpFilter(Order = 20)]
[EncryptActionFilter(Order = 100)]
[Component]
[ValidateInput(false)]
[CloseAfterPost]
[SessionState(SessionStateBehavior.Default)]
[AntiForgeryToken]
public abstract class BaseController : Controller, IBaseController
{
	private class FakeView : IView
	{
		public void Render(ViewContext viewContext, TextWriter writer)
		{
		}
	}

	private ControllerActionCallInfo actionCall;

	private ExecuteResultCallInfo resultCall;

	[NotNull]
	public INotifier Notifier { get; set; }

	[NotNull]
	public PoolBasedSettingsService PoolBasedSettingsService { get; set; }

	[NotNull]
	public ISecurityService SecurityService { get; set; }

	[NotNull]
	public IAuthenticationService AuthenticationService { get; set; }

	[NotNull]
	public ILogger Logger { get; set; }

	public IFormViewModelService FormViewModelService { get; set; }

	public ICacheFilesService CacheFilesService { get; set; }

	[NotNull]
	public IUnitOfWorkManager UnitOfWorkManager => Locator.GetServiceNotNull<IUnitOfWorkManager>();

	public IShellDescriptorManager ShellDescriptorManager { get; set; }

	public IExtensionManager ExtensionManager { get; set; }

	public IEnumerable<IViewEngineProvider> ViewEngineProviders { get; set; }

	protected string ViewTitle
	{
		get
		{
			if (((ControllerBase)this).get_ViewData() == null)
			{
				return string.Empty;
			}
			return ((ControllerBase)this).get_ViewData().GetViewTitle();
		}
		set
		{
			if (((ControllerBase)this).get_ViewData() != null)
			{
				((ControllerBase)this).get_ViewData().SetViewTitle(value);
			}
		}
	}

	protected string ActiveMenuItem
	{
		get
		{
			if (((Controller)this).get_HttpContext() == null)
			{
				return string.Empty;
			}
			return ((Controller)this).get_HttpContext().GetCurrentMenuItem();
		}
		set
		{
			((Controller)(object)this).SetCurrentMenuItem(value);
		}
	}

	protected DynamicViewHelper DynamicViewHelper => new DynamicViewHelper(((ControllerBase)this).get_ControllerContext());

	protected BaseController()
	{
		Logger = NullLogger.Instance;
	}

	[NonAction]
	protected RedirectToRouteResult RedirectToAction(string actionName, string controllerName, string area)
	{
		return ((Controller)this).RedirectToAction(actionName, controllerName, (object)new
		{
			Area = area
		});
	}

	protected override RedirectResult Redirect(string redirectUrl)
	{
		if (!string.IsNullOrWhiteSpace(redirectUrl))
		{
			string text = ((Controller)this).get_Request().ToRootUrlString();
			if (redirectUrl.StartsWith(text, StringComparison.OrdinalIgnoreCase))
			{
				redirectUrl = redirectUrl.Substring(text.Length);
			}
		}
		ActionResult obj = ((Controller)(object)this).RedirectLocal(redirectUrl);
		return (RedirectResult)(object)((obj is RedirectResult) ? obj : null);
	}

	[NonAction]
	protected RedirectResult RedirectBack(string infoMessage)
	{
		NameValueCollection nameValueCollection = ((Controller)this).get_Url().RemoveUnsecureParamsFromRequest();
		if (nameValueCollection != null)
		{
			((Controller)this).get_Url().RedirectWithNewQueryString(nameValueCollection);
		}
		if (!string.IsNullOrEmpty(infoMessage))
		{
			Notifier.Information(infoMessage);
		}
		return ((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl(redirectHomeIfNull: true));
	}

	public string RenderRazorViewToString(string viewName, object model)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		AddCachedRazorViewEngine();
		((ControllerBase)this).get_ViewData().set_Model(model);
		using StringWriter stringWriter = new StringWriter();
		ViewEngineResult val = ViewEngines.get_Engines().FindPartialView(((ControllerBase)this).get_ControllerContext(), viewName);
		ViewContext val2 = new ViewContext(((ControllerBase)this).get_ControllerContext(), val.get_View(), ((ControllerBase)this).get_ViewData(), ((ControllerBase)this).get_TempData(), (TextWriter)stringWriter);
		val.get_View().Render(val2, (TextWriter)stringWriter);
		return stringWriter.GetStringBuilder().ToString();
	}

	public ActionResult SuccessJson()
	{
		return (ActionResult)(object)((Controller)this).Json((object)"action work success", "text/html", (JsonRequestBehavior)0);
	}

	public ActionResult ErrorJson(string message)
	{
		return (ActionResult)(object)((Controller)this).Json((object)$"error:{message}", "text/html", (JsonRequestBehavior)0);
	}

	public bool IsCreatorRequest()
	{
		if (((Controller)this).get_Request()["CreatorRequest"] != null)
		{
			return Convert.ToBoolean(((Controller)this).get_Request()["CreatorRequest"]);
		}
		return false;
	}

	public ActionResult CreatorJson(IEntity entity, string error = null)
	{
		return CreatorJsonWithInformation(entity, null, error);
	}

	public ActionResult CreatorJsonWithInformation(IEntity entity, string information, string error = null)
	{
		Dictionary<string, object> dictionary = null;
		Guid? typeUid = null;
		if (((Controller)this).get_Request().Form["propertyCollectionOnCallback"] != null)
		{
			dictionary = new Dictionary<string, object>();
			IEnumerable<string> enumerable = ClassSerializationHelper.DeserializeObjectByJson<IEnumerable<string>>(((Controller)this).get_Request().Form["propertyCollectionOnCallback"]);
			IEntity entity2 = entity.CastAsRealType();
			Type type = entity2.GetType();
			if (MetadataLoader.LoadMetadata(type) is EntityMetadata entityMetadata)
			{
				typeUid = entityMetadata.Uid;
			}
			foreach (string item in enumerable)
			{
				PropertyInfo reflectionProperty = type.GetReflectionProperty(item);
				if (reflectionProperty != null)
				{
					object value = reflectionProperty.GetValue(entity2, null);
					dictionary.Add(item, value);
				}
			}
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			id = entity?.GetId(),
			typeUid = typeUid,
			text = entity?.ToString(),
			popupId = ((Controller)this).get_Request()["PopupId"],
			inputId = ((Controller)this).get_Request()["InputId"],
			previosPopupId = ((Controller)this).get_Request()["PreviosPopupId"],
			containerId = ((Controller)this).get_Request()["ContainerId"],
			error = error,
			information = information,
			entity = dictionary
		}, "text/html", (JsonRequestBehavior)0);
	}

	protected bool IsCustomViewRequest()
	{
		if (((Controller)this).get_Request().QueryString["ViewFormUid"] == null)
		{
			return ((Controller)this).get_Request().Form["ViewFormUid"] != null;
		}
		return true;
	}

	protected ActionResult HandleCustomViewJsonCallback(IEntity entity)
	{
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		if (((ControllerBase)this).get_ControllerContext().get_HttpContext().Items["$SelfInitialize$"] == null)
		{
			((ControllerBase)this).get_ControllerContext().get_HttpContext().Items["$SelfInitialize$"] = true;
		}
		EntityFormModel model = FormViewModelService.GetEntityFormModel(entity, new Guid(((Controller)this).get_Request().Form["ViewFormUid"]));
		model.UniqueId = ((Controller)this).get_Request().Form["UniqueId"];
		HtmlCatchViewResult htmlCatchViewResult = new HtmlCatchViewResult();
		((ViewResultBase)htmlCatchViewResult).set_ViewName("Templates/EntityViewForm");
		((ViewResultBase)htmlCatchViewResult).set_ViewData(new ViewDataDictionary((object)model));
		((ViewResultBase)htmlCatchViewResult).set_TempData(new TempDataDictionary());
		HtmlCatchViewResult htmlCatchViewResult2 = htmlCatchViewResult;
		return (ActionResult)(object)new CompositeActionResult((IEnumerable<ActionResult>)(object)new HtmlCatchViewResult[1] { htmlCatchViewResult2 }, delegate(ControllerContext context, IEnumerable<ActionResult> results)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(((HtmlCatchViewResult)(object)results.First()).HtmlResult);
			string text = ((HtmlString)(object)context.get_HttpContext().RenderForZone("DefaultContentZone")).ToHtmlString();
			if (!text.IsNullOrEmpty())
			{
				stringBuilder.Append(text);
			}
			string text2 = ((HtmlString)(object)context.get_HttpContext().RenderForZone("Scripts")).ToHtmlString();
			if (!text2.IsNullOrEmpty())
			{
				stringBuilder.Append(text2);
			}
			dictionary["html"] = stringBuilder.ToString();
			dictionary["info"] = new
			{
				id = ((entity != null) ? entity.GetId() : null),
				typeUid = model.EntityFormInfo.TypeUid,
				popupId = ((Controller)this).get_Request()["PopupId"],
				previosPopupId = ((Controller)this).get_Request()["PreviosPopupId"],
				containerId = ((Controller)this).get_Request()["ContainerId"]
			};
			context.get_HttpContext().Response.ContentType = "text/plain";
			context.get_HttpContext().Response.Output.Write(dictionary.ToJson());
		})
		{
			ResultType = ActionResultType.Unknown
		};
	}

	public ActionResult RedirectError(string url, string text)
	{
		if (!string.IsNullOrEmpty(text))
		{
			Notifier.Error(text);
		}
		if (string.IsNullOrEmpty(url))
		{
			url = "~/";
		}
		return (ActionResult)(object)((Controller)this).Redirect(url);
	}

	public void WriteErrorMessages(List<string> messages)
	{
		foreach (string message in messages)
		{
			Notifier.Error(message);
		}
	}

	public virtual JsonResult MoveColumn(string gridId, int oldIndex, int newIndex)
	{
		GridState gridState = GridPersonalizationAdministration.LoadState(gridId);
		if (gridState != null && gridState.ColumnStates != null)
		{
			if (gridState.ColumnStates.Count < newIndex || gridState.ColumnStates.Count < oldIndex)
			{
				return ((Controller)this).Json((object)"", (JsonRequestBehavior)0);
			}
			ColumnState columnState = gridState.ColumnStates.FirstOrDefault((ColumnState c) => c.Order == oldIndex);
			if (columnState != null)
			{
				columnState.Order = newIndex;
				GridPersonalizationAdministration.SaveState(gridId, gridState);
			}
		}
		return ((Controller)this).Json((object)"", (JsonRequestBehavior)0);
	}

	public virtual JsonResult SaveSortState(string gridId, string sortExpr)
	{
		GridState gridState = GridPersonalizationAdministration.LoadState(gridId);
		if (gridState != null)
		{
			lock (gridState)
			{
				gridState.SortExpression = sortExpr;
				GridPersonalizationAdministration.SaveState(gridId, gridState);
			}
		}
		return ((Controller)this).Json((object)"", (JsonRequestBehavior)0);
	}

	public virtual JsonResult HiddenChangeColumn(string gridId, int columnIndex, bool hidden)
	{
		GridState gridState = GridPersonalizationAdministration.LoadState(gridId);
		if (gridState != null && columnIndex < gridState.ColumnStates.Count && gridState.AvailableColumns.Count < gridState.ColumnStates.Count - 1)
		{
			ColumnState columnState = gridState.ColumnStates.FirstOrDefault((ColumnState c) => c.Order == columnIndex);
			if (columnState != null)
			{
				columnState.Hidden = hidden;
				GridPersonalizationAdministration.SaveState(gridId, gridState);
			}
		}
		return ((Controller)this).Json((object)"", (JsonRequestBehavior)0);
	}

	public virtual JsonResult SavePageSize(string gridId, int pageSize)
	{
		GridState gridState = GridPersonalizationAdministration.LoadState(gridId);
		if (gridState != null)
		{
			gridState.PageSize = pageSize;
			GridPersonalizationAdministration.SaveState(gridId, gridState);
		}
		return ((Controller)this).Json((object)new
		{
			containerId = gridId,
			pageSize = pageSize,
			success = true
		}, (JsonRequestBehavior)0);
	}

	public virtual JsonResult SaveCurrentPage(string gridId, int currentPage)
	{
		GridState gridState = GridPersonalizationAdministration.LoadState(gridId);
		if (gridState != null)
		{
			gridState.CurrentPage = currentPage;
			GridPersonalizationAdministration.SaveState(gridId, gridState);
		}
		return ((Controller)this).Json((object)new
		{
			containerId = gridId,
			currentPage = currentPage,
			success = true
		}, (JsonRequestBehavior)0);
	}

	public virtual ActionResult SaveTreeNodeState(string treeId, string nodeId, bool expanded)
	{
		TreeState treeState = TreePersonalizationAdministration.LoadState(treeId);
		if (treeState == null)
		{
			treeState = new TreeState
			{
				Id = treeId
			};
		}
		treeState[nodeId] = expanded;
		TreePersonalizationAdministration.SaveState(treeId, treeState);
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = true
		}, (JsonRequestBehavior)0);
	}

	protected void CheckPermission(Permission permission)
	{
		PermissionActionResultImpl.CheckPermission(SecurityService, permission);
		if (!SecurityService.HasPermission(permission))
		{
			throw new SecurityException(SR.T("Отсутствует привилегия \"{0}\"", permission.Name));
		}
	}

	protected void CheckPermission(Permission permission, object target)
	{
		PermissionActionResultImpl.CheckPermission(SecurityService, permission, target);
	}

	protected override void OnActionExecuting(ActionExecutingContext filterContext)
	{
		((Controller)this).OnActionExecuting(filterContext);
		actionCall = DiagnosticsManager.StartCall(() => new ControllerActionCallInfo(filterContext));
	}

	protected override void OnActionExecuted(ActionExecutedContext filterContext)
	{
		((Controller)this).OnActionExecuted(filterContext);
		if (actionCall != null)
		{
			actionCall.ActionExecutedContext = filterContext;
			DiagnosticsManager.StopCall(actionCall);
			actionCall = null;
		}
	}

	protected override void OnException(ExceptionContext errorContext)
	{
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		((Controller)this).OnException(errorContext);
		if (errorContext == null)
		{
			return;
		}
		if (errorContext.get_Exception() != null)
		{
			Logger.Error(errorContext.get_Exception());
		}
		if (errorContext.get_Exception() is HttpAntiForgeryException && !object.Equals("LogOn", ((ControllerBase)this).get_ControllerContext().get_RouteData().Values["action"]))
		{
			string url = "";
			if (((ControllerBase)this).get_ControllerContext().get_IsChildAction())
			{
				url = "~/";
			}
			else
			{
				HttpContextBase httpContext = ((ControllerBase)this).get_ControllerContext().get_HttpContext();
				if (httpContext != null && httpContext.Request != null && httpContext.Request.Url != null)
				{
					url = httpContext.Request.Url.ToString();
				}
			}
			errorContext.set_Result((ActionResult)(object)((Controller)this).RedirectToAction("RedirectError", (object)new
			{
				url = url,
				text = SR.T("Ваша сессия устарела. Пожалуйста, заполните данную форму заново.")
			}));
			errorContext.set_ExceptionHandled(true);
			errorContext.set_Exception(errorContext.get_Exception());
		}
		if (actionCall != null)
		{
			actionCall.ActionExecutedContext = new ActionExecutedContext((ControllerContext)(object)actionCall.ActionExecutingContext, actionCall.ActionExecutingContext.get_ActionDescriptor(), true, errorContext.get_Exception());
			DiagnosticsManager.StopCall(actionCall, errorContext.get_Exception());
			actionCall = null;
		}
		if (resultCall != null)
		{
			resultCall.ResultExecutedContext = new ResultExecutedContext((ControllerContext)(object)resultCall.ResultExecutingContext, resultCall.ResultExecutingContext.get_Result(), true, errorContext.get_Exception());
			DiagnosticsManager.StopCall(resultCall, errorContext.get_Exception());
			resultCall = null;
		}
	}

	protected override void OnResultExecuting(ResultExecutingContext filterContext)
	{
		((Controller)this).OnResultExecuting(filterContext);
		resultCall = DiagnosticsManager.StartCall(() => new ExecuteResultCallInfo(filterContext));
	}

	protected override void OnResultExecuted(ResultExecutedContext filterContext)
	{
		((Controller)this).OnResultExecuted(filterContext);
		if (resultCall != null)
		{
			resultCall.ResultExecutedContext = filterContext;
			DiagnosticsManager.StopCall(resultCall);
			resultCall = null;
		}
	}

	protected bool ReValidateModel(object model, string prefix)
	{
		Func<string, bool> predicate = (string k) => k.StartsWith(prefix + ".");
		if (!((Controller)this).get_ModelState().get_Keys().Any(predicate))
		{
			throw new InvalidOperationException(SR.T("Нет модели состояния с именем \"{0}\".  Добавленные имена моделей: {1}", prefix, string.Join(", ", ((Controller)this).get_ModelState().get_Keys().ToArray())));
		}
		foreach (string item in ((Controller)this).get_ModelState().get_Keys().Where(predicate))
		{
			((Collection<ModelError>)(object)((Controller)this).get_ModelState().get_Item(item).get_Errors()).Clear();
		}
		return ((Controller)this).TryValidateModel(model, prefix);
	}

	[NonAction]
	public virtual string HelpUrl()
	{
		bool.TryParse(((Controller)this).get_Request().Headers["Spa-Request"], out var result);
		if (((ControllerBase)this).get_ControllerContext().get_IsChildAction() || (AjaxRequestExtensions.IsAjaxRequest(((Controller)this).get_Request()) && !result))
		{
			return null;
		}
		try
		{
			WebHelpService service = Locator.GetService<WebHelpService>();
			return (service == null) ? null : ((Controller)this).get_Url().Content(service.GetPageUrl(((ControllerBase)this).get_ControllerContext()));
		}
		catch (Exception exception)
		{
			Logger.Debug(SR.T("Ошибка при определении ссылки на справку"), exception);
		}
		return null;
	}

	public virtual ActionResult GridExportExcelReset(string gridId)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		GridExportExcelUtility.ResetExportExcelStatus(((Controller)this).get_Session().SessionID, AuthenticationService.GetCurrentUser().GetId(), gridId);
		return (ActionResult)new EmptyResult();
	}

	protected virtual bool IsExportExcel()
	{
		ValueProviderResult value = ((ControllerBase)this).get_ValueProvider().GetValue("exportExcel");
		if (value == null || !bool.TryParse(value.get_AttemptedValue(), out var result) || !result)
		{
			return false;
		}
		return true;
	}

	protected internal virtual ActionResult ExportExcel(IGridData gridData, Type type, Func<ActionResult> partialView, GridExportExcelOptions options)
	{
		ValueProviderResult value = ((ControllerBase)this).get_ValueProvider().GetValue("exportExcel");
		if (value == null || !bool.TryParse(value.get_AttemptedValue(), out var result) || !result)
		{
			return partialView();
		}
		ValueProviderResult value2 = ((ControllerBase)this).get_ValueProvider().GetValue("gridId");
		string text = ((value2 != null) ? value2.get_AttemptedValue() : "");
		ValueProviderResult value3 = ((ControllerBase)this).get_ValueProvider().GetValue("provider");
		if (value3 == null || !Guid.TryParse(value3.get_AttemptedValue(), out var result2))
		{
			result2 = Guid.Empty;
		}
		ValueProviderResult value4 = ((ControllerBase)this).get_ValueProvider().GetValue("size");
		string text2 = ((value4 != null) ? value4.get_AttemptedValue() : "0");
		EntityMetadata entityMetadata = MetadataLoader.LoadMetadata(type) as EntityMetadata;
		ValueProviderResult value5 = ((ControllerBase)this).get_ValueProvider().GetValue("exportExcelFileName");
		string input = ((value5 != null && !value5.get_AttemptedValue().IsNullOrWhiteSpace()) ? value5.get_AttemptedValue() : ((entityMetadata == null || entityMetadata.DisplayName.IsNullOrWhiteSpace()) ? "Grid" : entityMetadata.DisplayName));
		input = Regex.Replace(input, "[\\/\\\\:*?\"<>|\\s]", "") + ".xlsx";
		Guid guid = CacheFilesService.CreateCacheFile(input);
		string filePath = CacheFilesService.GetFilePath(guid);
		string fileHref = ((Controller)this).get_Url().Action("Download", "BinaryFiles", (object)new
		{
			area = "EleWise.ELMA.SDK.Web"
		}) + "/" + guid;
		bool flag = GridExportExcelUtility.ExportExcel(gridData, type, text2 == "0", text, result2, guid, filePath, ((Controller)this).get_Session().SessionID, AuthenticationService.GetCurrentUser().GetId(), TimeSpan.FromSeconds(5.0), options);
		string error = (flag ? GridExportExcelUtility.GetExportExcelStatus(((Controller)this).get_Session().SessionID, AuthenticationService.GetCurrentUser().GetId(), text).Error : null);
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			fileHref = fileHref,
			ready = flag,
			error = error
		}, (JsonRequestBehavior)0);
	}

	protected internal virtual ActionResult ExportExcel(IGridData gridData, Type type, Func<ActionResult> partialView)
	{
		return ExportExcel(gridData, type, partialView, null);
	}

	protected internal virtual ActionResult ExportExcel(DataTable table, Func<ActionResult> partialView)
	{
		ValueProviderResult value = ((ControllerBase)this).get_ValueProvider().GetValue("exportExcel");
		if (value == null || !bool.TryParse(value.get_AttemptedValue(), out var result) || !result)
		{
			return partialView();
		}
		ValueProviderResult value2 = ((ControllerBase)this).get_ValueProvider().GetValue("gridId");
		string text = ((value2 != null) ? value2.get_AttemptedValue() : "");
		string tableName = table.TableName;
		tableName = ((!string.IsNullOrWhiteSpace(tableName)) ? tableName : "Grid") + ".xlsx";
		Guid guid = CacheFilesService.CreateCacheFile(tableName);
		string filePath = CacheFilesService.GetFilePath(guid);
		string fileHref = ((Controller)this).get_Url().Action("Download", "BinaryFiles", (object)new
		{
			area = "EleWise.ELMA.SDK.Web"
		}) + "/" + guid;
		bool flag = TableExportExcelUtility.ExportExcel(table, text, guid, filePath, ((Controller)this).get_Session().SessionID, AuthenticationService.GetCurrentUser().GetId(), TimeSpan.FromSeconds(5.0));
		string error = (flag ? GridExportExcelUtility.GetExportExcelStatus(((Controller)this).get_Session().SessionID, AuthenticationService.GetCurrentUser().GetId(), text).Error : null);
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			fileHref = fileHref,
			ready = flag,
			error = error
		}, (JsonRequestBehavior)0);
	}

	protected FileContentResult File(byte[] fileContents, string contentType)
	{
		return File(fileContents, contentType, null);
	}

	protected virtual FileContentResult File(byte[] fileContents, string contentType, string fileDownloadName)
	{
		return new FileContentResult(fileContents, contentType)
		{
			FileDownloadName = fileDownloadName.ReplaceInvalidFileNameChars()
		};
	}

	protected FileStreamResult File(Stream fileStream, string contentType)
	{
		return File(fileStream, contentType, null);
	}

	protected virtual FileStreamResult File(Stream fileStream, string contentType, string fileDownloadName)
	{
		return new FileStreamResult(fileStream, contentType)
		{
			FileDownloadName = fileDownloadName.ReplaceInvalidFileNameChars()
		};
	}

	protected FilePathResult File(string fileName, string contentType)
	{
		return File(fileName, contentType, null);
	}

	protected virtual FilePathResult File(string fileName, string contentType, string fileDownloadName)
	{
		FilePathResult filePathResult = new FilePathResult(fileName, contentType);
		if (!string.IsNullOrEmpty(fileDownloadName))
		{
			filePathResult.FileDownloadName = fileDownloadName.ReplaceInvalidFileNameChars();
		}
		return filePathResult;
	}

	protected virtual BinaryFileResult File(BinaryFile binaryFile)
	{
		long size = binaryFile.GetSize();
		if (size > 1000000000)
		{
			((Controller)this).get_Response().BufferOutput = false;
			((Controller)this).get_Response().AddHeader("Content-Length", size.ToString());
		}
		return new BinaryFileResult(binaryFile);
	}

	protected virtual BinaryFileResult File(BinaryFile binaryFile, BinaryFileCachingOptions cachingOptions)
	{
		return new BinaryFileResult(binaryFile, cachingOptions);
	}

	protected virtual LazyRedirectResult LazyRedirect(Func<string> urlFunc)
	{
		return new LazyRedirectResult(urlFunc);
	}

	protected virtual LazyRedirectResult LazyRedirectPermanent(Func<string> urlFunc)
	{
		return new LazyRedirectResult(urlFunc, permanent: true);
	}

	protected JsonResult LazyJson(Action<JsonResult> action)
	{
		return LazyJson(action, null, null, (JsonRequestBehavior)1);
	}

	protected virtual JsonResult LazyJson(Action<JsonResult> action, string contentType, Encoding contentEncoding, JsonRequestBehavior behavior)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		LazyJsonResult lazyJsonResult = new LazyJsonResult(action);
		((JsonResult)lazyJsonResult).set_ContentType(contentType);
		((JsonResult)lazyJsonResult).set_ContentEncoding(contentEncoding);
		((JsonResult)lazyJsonResult).set_JsonRequestBehavior(behavior);
		return (JsonResult)(object)lazyJsonResult;
	}

	protected override JsonResult Json(object data, string contentType, Encoding contentEncoding, JsonRequestBehavior behavior)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		ElmaJsonResult elmaJsonResult = new ElmaJsonResult();
		((JsonResult)elmaJsonResult).set_Data(data);
		((JsonResult)elmaJsonResult).set_ContentType(contentType);
		((JsonResult)elmaJsonResult).set_ContentEncoding(contentEncoding);
		((JsonResult)elmaJsonResult).set_JsonRequestBehavior(behavior);
		return (JsonResult)(object)elmaJsonResult;
	}

	protected ActionResult AsyncViewItemView(ViewItem viewItem, ViewType viewType, object originalModel, object model = null, string htmlFieldPrefix = null, ItemType itemType = ItemType.Default, Guid? viewProviderUid = null, string viewItemId = null, Guid? dynamicFormsProviderUid = null, string dynamicFormsProviderData = null, string formId = null)
	{
		ViewItemControl<ViewItem, object, object>.IsAsync = true;
		((ControllerBase)this).get_ViewData().set_Item("ViewItem", (object)viewItem);
		((ControllerBase)this).get_ViewData().set_Item("Model", model);
		((ControllerBase)this).get_ViewData().set_Item("HtmlFieldPrefix", (object)htmlFieldPrefix);
		((ControllerBase)this).get_ViewData().set_Item("ViewType", (object)viewType);
		((ControllerBase)this).get_ViewData().set_Item("ItemType", (object)itemType);
		((ControllerBase)this).get_ViewData().set_Item("ViewProviderUid", (object)(viewProviderUid ?? Guid.Empty));
		((ControllerBase)this).get_ViewData().set_Item("ViewItemId", (object)viewItemId);
		((ControllerBase)this).get_ViewData().set_Item("DynamicFormsProviderUid", (object)(dynamicFormsProviderUid ?? Guid.Empty));
		((ControllerBase)this).get_ViewData().set_Item("DynamicFormsProviderData", (object)dynamicFormsProviderData);
		((ControllerBase)this).get_ViewData().set_Item("FormId", (object)formId);
		Dictionary<string, object> routes = new Dictionary<string, object>();
		((Controller)this).get_Request().QueryString.AllKeys.Each(delegate(string queryKey)
		{
			routes[queryKey] = ((Controller)this).get_Request().QueryString[queryKey];
		});
		((Controller)this).get_Request().RequestContext.RouteData.Values.Keys.Where((string queryKey) => queryKey.ToLower() != "action" && queryKey.ToLower() != "controller").Each(delegate(string queryKey)
		{
			routes[queryKey] = ((Controller)this).get_Request().RequestContext.RouteData.Values[queryKey];
		});
		((ControllerBase)this).get_ViewData().set_Item("ActionRoute", (object)new ActionRoute((string)((Controller)this).get_Request().RequestContext.RouteData.Values["action"], (string)((Controller)this).get_Request().RequestContext.RouteData.Values["controller"], routes));
		return (ActionResult)(object)((Controller)this).PartialView("ViewItems/AsyncViewItem", originalModel);
	}

	protected ActionResult AsyncViewItemView<T>(ViewItem viewItem, ViewType viewType, T originalModel, Expression<Func<T, object>> expression = null, ItemType itemType = ItemType.Default, Guid? viewProviderUid = null, string viewItemId = null, Guid? dynamicFormsProviderUid = null, string dynamicFormsProviderData = null, string formId = null)
	{
		return AsyncViewItemView(viewItem, viewType, originalModel, expression?.Compile()(originalModel), (expression != null) ? LinqUtils.FullNameOf(expression) : null, itemType, viewProviderUid, viewItemId, dynamicFormsProviderUid, dynamicFormsProviderData, formId);
	}

	protected ActionResult AsyncViewItemView(FormViewItem formViewItem, ViewType viewType, Guid viewItemUid, object originalModel, object model = null, string htmlFieldPrefix = null, ItemType itemType = ItemType.Default, Guid? viewProviderUid = null, string viewItemId = null, Guid? dynamicFormsProviderUid = null, string dynamicFormsProviderData = null, string formId = null)
	{
		ViewItem viewItem = formViewItem.TransformateExtensions(originalModel).FindItem(viewItemUid);
		return AsyncViewItemView(viewItem, viewType, originalModel, model, htmlFieldPrefix, itemType, viewProviderUid, viewItemId, dynamicFormsProviderUid, dynamicFormsProviderData, formId);
	}

	protected ActionResult AsyncViewItemView<T>(FormViewItem formViewItem, ViewType viewType, Guid viewItemUid, T originalModel, Expression<Func<T, object>> expression = null, ItemType itemType = ItemType.Default, Guid? viewProviderUid = null, string viewItemId = null, Guid? dynamicFormsProviderUid = null, string dynamicFormsProviderData = null, string formId = null)
	{
		ViewItem viewItem = formViewItem.TransformateExtensions(originalModel).FindItem(viewItemUid);
		return AsyncViewItemView(viewItem, viewType, originalModel, expression, itemType, viewProviderUid, viewItemId, dynamicFormsProviderUid, dynamicFormsProviderData, formId);
	}

	protected void SetAsReadForFeed(Guid objectUid, long objectId, IUser recipient = null)
	{
		try
		{
			FeedSetReadHelper.SetAsReadForObject(objectUid, objectId, (recipient != null) ? new long?((long)recipient.GetId()) : null);
		}
		catch (Exception exception)
		{
			string message = ((recipient == null) ? SR.T("Ошибка при попытке установить сообщениям ленты статуса \"Прочитано\" для сущности {0}:{1}", objectUid, objectId) : SR.T("Ошибка при попытке установить сообщениям ленты статуса \"Прочитано\" для сущности {0}:{1} и пользователя {2}", objectUid, objectId, recipient));
			EleWise.ELMA.Logging.Logger.Log.Error(message, exception);
		}
	}

	public void SetAsReadForFeed(IEntity entity, IUser recipient = null)
	{
		try
		{
			FeedSetReadHelper.SetAsReadForObject(entity, (recipient != null) ? new long?((long)recipient.GetId()) : null);
		}
		catch (Exception exception)
		{
			string message = SR.T("Ошибка при попытке установить сообщениям ленты статуса \"Прочитано\" для сущности {0}", entity) + ((recipient != null) ? SR.T(" и пользователя {0}", recipient.ToString()) : "");
			EleWise.ELMA.Logging.Logger.Log.Error(message, exception);
		}
	}

	protected override ITempDataProvider CreateTempDataProvider()
	{
		return (ITempDataProvider)(object)new CacheTempDataProvider();
	}

	internal ViewResult GetViewResult(string viewName)
	{
		return ((Controller)this).View(viewName);
	}

	internal ViewResult GetViewResult(string viewName, object model)
	{
		return ((Controller)this).View(viewName, model);
	}

	internal PartialViewResult GetPartialViewResult(string viewName, object model)
	{
		return ((Controller)this).PartialView(viewName, model);
	}

	protected HtmlHelper GetHtmlHelper()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_001f: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0029: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		return new HtmlHelper(new ViewContext(((ControllerBase)this).get_ControllerContext(), (IView)(object)new FakeView(), new ViewDataDictionary(), new TempDataDictionary(), TextWriter.Null), (IViewDataContainer)new ViewPage());
	}

	private void AddCachedRazorViewEngine()
	{
		Type viewEngineType = TypeOf<CachedRazorViewEngine>.Raw;
		if (!((IEnumerable<IViewEngine>)ViewEngines.get_Engines()).All((IViewEngine e) => ((object)e).GetType() != viewEngineType))
		{
			return;
		}
		ShellDescriptor shellDescriptor = ShellDescriptorManager.GetShellDescriptor();
		IEnumerable<FeatureDescriptor> source = from fd in ExtensionManager.EnabledFeatures(shellDescriptor).Reverse()
			where DefaultExtensionTypes.IsModule(fd.Extension.ExtensionType)
			select fd;
		List<string> virtualPaths = source.Select((FeatureDescriptor fd) => fd.Extension.Location + "/" + fd.Extension.Id).Concat(new string[1] { "~" }).Distinct(StringComparer.OrdinalIgnoreCase)
			.ToList();
		List<string> extensionLocations = source.Select((FeatureDescriptor fd) => fd.Extension.Location).Distinct(StringComparer.OrdinalIgnoreCase).ToList();
		CreateModulesViewEngineParams parameters = new CreateModulesViewEngineParams
		{
			VirtualPaths = virtualPaths,
			ExtensionLocations = extensionLocations
		};
		foreach (IViewEngineProvider viewEngineProvider in ViewEngineProviders)
		{
			IViewEngine item = viewEngineProvider.CreateModulesViewEngine(parameters);
			((Collection<IViewEngine>)(object)ViewEngines.get_Engines()).Add(item);
		}
	}
}
public abstract class BaseController<TModel, TModelId> : BaseController, IBaseController<TModel, TModelId>, IBaseController where TModel : IEntity<TModelId>
{
	public IEntityManager<TModel, TModelId> Manager { get; set; }

	protected internal virtual ActionResult GridView(GridData<TModel> gridData)
	{
		gridData = gridData ?? new GridData<TModel>();
		if (gridData.DataSourceIsNull)
		{
			gridData.SetCount((GridData<TModel> d, FetchOptions f) => Manager.Count());
			gridData.SetDataSource((GridData<TModel> d, FetchOptions f) => Manager.Find(f));
		}
		return ExportExcel(gridData, typeof(TModel), () => (ActionResult)(object)((Controller)this).PartialView((object)gridData));
	}

	protected internal virtual ActionResult GridView(string view, GridData<TModel> gridData)
	{
		gridData = gridData ?? new GridData<TModel>();
		if (gridData.DataSourceIsNull)
		{
			gridData.SetCount((GridData<TModel> d, FetchOptions f) => Manager.Count());
			gridData.SetDataSource((GridData<TModel> d, FetchOptions f) => Manager.Find(f));
		}
		return ExportExcel(gridData, typeof(TModel), () => (ActionResult)(object)((Controller)this).PartialView(view, (object)gridData));
	}

	protected internal ActionResult GridView<TFilter>(string view, GridData<TModel, TFilter> gridData) where TFilter : IEntityFilter
	{
		gridData = gridData ?? new GridData<TModel, TFilter>();
		if (gridData.DataSourceIsNull)
		{
			gridData.SetCount((GridData<TModel, TFilter> d, FetchOptions f) => Manager.Count(d.DataFilter));
			gridData.SetDataSource((GridData<TModel, TFilter> d, FetchOptions f) => Manager.Find(d.DataFilter, f));
		}
		return ExportExcel(gridData, typeof(TModel), () => (ActionResult)(object)((Controller)this).PartialView(view, (object)gridData));
	}

	protected internal ActionResult GridView<TFilter>(GridData<TModel, TFilter> gridData) where TFilter : IEntityFilter
	{
		gridData = gridData ?? new GridData<TModel, TFilter>();
		if (gridData.DataSourceIsNull)
		{
			gridData.SetCount((GridData<TModel, TFilter> d, FetchOptions f) => Manager.Count(d.DataFilter));
			gridData.SetDataSource((GridData<TModel, TFilter> d, FetchOptions f) => Manager.Find(d.DataFilter, f));
		}
		return ExportExcel(gridData, typeof(TModel), () => (ActionResult)(object)((Controller)this).PartialView((object)gridData));
	}

	protected internal virtual GridData<TModel> CreateGridData(GridCommand command)
	{
		return Manager.CreateGridData(command);
	}

	protected internal GridData<TModel, TFilter> CreateGridData<TFilter>(GridCommand command) where TFilter : class, IEntityFilter
	{
		return Manager.CreateGridData<TModel, TFilter>(command);
	}

	protected internal GridData<TModel, TFilter> CreateGridData<TFilter>(GridCommand command, TFilter filter) where TFilter : class, IEntityFilter
	{
		return Manager.CreateGridData(command, filter);
	}

	protected void ThrowExceptionIfDeleted(ISoftDeletable obj)
	{
		if (obj != null && obj.IsDeleted)
		{
			IEntity entity = (obj as IEntity).CastAsRealType();
			if (entity != null)
			{
				IMetadata metadata = MetadataLoader.LoadMetadata(EntityHelper.GetType(entity), inherit: false, loadImplementation: false);
				object id = entity.GetId();
				throw new ObjectIsDeletedException(SR.T("Объект \"{0}\" с идентификатором {1} удален из системы", entity.ToString(), id))
				{
					ObjectId = id,
					ObjectType = (metadata?.Uid ?? Guid.Empty)
				};
			}
		}
	}
}
