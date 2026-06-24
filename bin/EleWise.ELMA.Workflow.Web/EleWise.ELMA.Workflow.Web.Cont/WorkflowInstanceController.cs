using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models;
using EleWise.ELMA.Web.Mvc.Security;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Security;
using EleWise.ELMA.Workflow.Services;
using EleWise.ELMA.Workflow.Web.Helpers;
using EleWise.ELMA.Workflow.Web.Models;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.Workflow.Web.Controllers;

[Permission("0B0F7BD9-70C9-4AE6-8077-182ABF3DD8A6")]
[RouteArea("EleWise.ELMA.Workflow.Web")]
public class WorkflowInstanceController : BPMController<IWorkflowInstance, long>
{
	public WorkflowInstanceContextService WorkflowInstanceContextService { get; set; }

	public IDiagramExporterService DiagramExporterService { get; set; }

	public ProcessHeaderManager ProcessHeaderManager { get; set; }

	public WorkflowTaskBaseManager WorkflowTaskBaseManager { get; set; }

	[Permission]
	public ActionResult Map([InstancePermission(typeof(IWorkflowInstance), "{E9A08507-C44A-481D-A303-2C312EDB8F9A}")] long id, bool displayAsImage = false, bool inPopup = true)
	{
		if (((Controller)this).get_Request().ServerVariables["http_referer"] == null)
		{
			inPopup = false;
		}
		IWorkflowInstance workflowInstance = base.Manager.LoadOrNull(id);
		if (workflowInstance != null)
		{
			if (displayAsImage)
			{
				List<ElementActiveTasks> elementActiveTasks = WorkflowTaskBaseManager.GetElementsWithTaskCountByInstance(workflowInstance, onlyActiveTasks: false).ToList();
				return (ActionResult)(object)((Controller)this).PartialView("WorkflowInstance/Map", (object)new MapElementsInfo
				{
					Instance = workflowInstance,
					ElementActiveTasks = elementActiveTasks
				});
			}
			PageApplicationData pageApplicationData = new PageApplicationData(new Guid("e0da7969-da1a-4622-9ac7-97abffa0a2d1"), new Dictionary<string, object> { { "WorkflowInstanceId", id } });
			if (inPopup)
			{
				pageApplicationData.ApplicationId = new Guid("{12ACB165-D355-40FF-80EE-35512A3800FC}");
				return (ActionResult)(object)((Controller)this).PartialView("Shared/UI/PageApplication", (object)pageApplicationData);
			}
			return (ActionResult)(object)((Controller)this).PartialView("Shared/UI/PageApplicationLayout", (object)new PageApplicationLayoutData
			{
				Title = SR.T("Карта экземпляра процесса"),
				PageData = pageApplicationData
			});
		}
		return null;
	}

	[Permission]
	public ActionResult ImageMap([InstancePermission(typeof(IWorkflowInstance), "{E9A08507-C44A-481D-A303-2C312EDB8F9A}")] long id)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		IWorkflowInstance workflowInstance = base.Manager.LoadOrNull(id);
		if (workflowInstance != null && base.SecurityService.HasPermission(WorkflowPermissionProvider.ViewTaskListOfInstance, workflowInstance))
		{
			return (ActionResult)new FileStreamResult(DiagramExporterService.ExportDiagramWorkflowInstance(workflowInstance), "image/jpeg");
		}
		return null;
	}

	public ActionResult GetRoutesForType(Guid objectType, string text = "", RelationType? relationType = null, List<long> objects = null, object objectId = null, Guid? objectSubType = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return (ActionResult)new JsonResult();
	}

	public ActionResult GetContextVarsForStart(long processHeadId, Guid objectType, string text = "", RelationType? relationType = null, List<object> objectList = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Expected O, but got Unknown
		JsonResult val = new JsonResult();
		val.set_Data((object)new SelectList((IEnumerable)new object[0]));
		return (ActionResult)val;
	}

	public ActionResult StartRouteContextVar(StartRouteInfo info, List<object> objectList = null)
	{
		if (info.ProcessHeader != null)
		{
			info.ContexVarSelector = true;
			List<PropertyMetadata> inputContextVars = StartRouteHelper.GetInputContextVars(info.ObjectType, info.RelationType, info.ProcessHeader.Id, "", objectList ?? info.Objects.Cast<object>().ToList());
			info.ContexVarCount = inputContextVars.Count;
			info.ContextVar = inputContextVars.Select((PropertyMetadata x) => x.Uid).FirstOrDefault();
		}
		return (ActionResult)(object)((Controller)this).PartialView((object)info);
	}

	public ActionResult GetWorkflowInstanceName(long processHeadId, string defaultCaption)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		IProcessHeader processHeader = ProcessHeaderManager.Load(processHeadId);
		if (processHeader.Published == null || processHeader.Published.NamingScheme == null)
		{
			JsonResult val = new JsonResult();
			val.set_Data((object)new
			{
				Name = string.Empty,
				Ask = true
			});
			return (ActionResult)val;
		}
		string text = "";
		if (processHeader.Published.NamingScheme.Type == InstanceNamingScheme.SchemeType.Template)
		{
			text = processHeader.Published.NamingScheme.TemplateText;
		}
		if (string.IsNullOrEmpty(text))
		{
			text = SR.T(processHeader.Name) ?? defaultCaption;
		}
		JsonResult val2 = new JsonResult();
		val2.set_Data((object)new
		{
			Name = text,
			Ask = (processHeader.Published.NamingScheme.Type != InstanceNamingScheme.SchemeType.Template)
		});
		return (ActionResult)val2;
	}

	[HttpGet]
	public ActionResult StartRouteForm(StartRouteInfo info)
	{
		return (ActionResult)(object)((Controller)this).PartialView((object)info);
	}

	[HttpGet]
	public ActionResult StartRouteWindow(StartRouteInfo info)
	{
		((Controller)this).get_ModelState().Clear();
		return (ActionResult)(object)((Controller)this).PartialView((object)info);
	}

	[HttpPost]
	public ActionResult StartRoute(StartRouteInfo info)
	{
		return (ActionResult)(object)((Controller)this).Redirect(StartRouteHelper.RunStartRoute(this, info).UrlRedirect);
	}

	public ActionResult ExecuteInfo(long id)
	{
		WorkflowInstanceExecuteInfo workflowInstanceExecuteInfo = new WorkflowInstanceExecuteInfo(base.Manager.Load(id), true);
		return (ActionResult)(object)((Controller)this).PartialView("WorkflowInstance/ExecuteInfo", (object)workflowInstanceExecuteInfo);
	}

	[HttpPost]
	public ActionResult ExecuteInfoContent(long id)
	{
		IWorkflowInstance instance = base.Manager.Load(id);
		WorkflowInstanceExecuteInfo executeInfo = new WorkflowInstanceExecuteInfo(instance, true);
		Dictionary<string, object> result = new Dictionary<string, object>();
		string redirectOnCompleteUrl = executeInfo.GetRedirectOnCompleteUrl(((ControllerBase)this).get_ControllerContext());
		result["NextTaskUrl"] = redirectOnCompleteUrl;
		if (!string.IsNullOrEmpty(redirectOnCompleteUrl))
		{
			return (ActionResult)(object)((Controller)this).Json((object)result);
		}
		((ControllerBase)this).get_ViewData().set_Model((object)executeInfo);
		HtmlCatchViewResult[] array = new HtmlCatchViewResult[1];
		HtmlCatchViewResult htmlCatchViewResult = new HtmlCatchViewResult();
		((ViewResultBase)htmlCatchViewResult).set_ViewName("WorkflowInstance/ExecuteInfoContent");
		((ViewResultBase)htmlCatchViewResult).set_ViewData(((ControllerBase)this).get_ViewData());
		((ViewResultBase)htmlCatchViewResult).set_TempData(((ControllerBase)this).get_TempData());
		array[0] = htmlCatchViewResult;
		return (ActionResult)(object)new CompositeActionResult((IEnumerable<ActionResult>)(object)array, delegate(ControllerContext context, IEnumerable<ActionResult> results)
		{
			bool setting = SR.GetSetting("Workflow.ImmediatelyExecuteItem", defaultValue: true);
			HtmlCatchViewResult htmlCatchViewResult2 = (HtmlCatchViewResult)(object)results.First();
			result["Html"] = htmlCatchViewResult2.HtmlResult;
			result["NeedRefresh"] = !setting || executeInfo.QueueItems.Count > 0;
			MvcHtmlString value = result.ToJson();
			context.get_HttpContext().Response.ContentType = "application/json";
			context.get_HttpContext().Response.Output.Write(value);
		});
	}

	public ActionResult GetContextVarInfo(IProcessHeader processHeader, Guid contextVarGuid)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		if (contextVarGuid == Guid.Empty || processHeader == null)
		{
			JsonResult val = new JsonResult();
			val.set_Data((object)null);
			return (ActionResult)val;
		}
		IPropertyMetadata instanceContextPropertyMetadata = WorkflowInstanceContextService.GetInstanceContextPropertyMetadata(processHeader.Published, contextVarGuid);
		if (instanceContextPropertyMetadata != null)
		{
			JsonResult val2 = new JsonResult();
			val2.set_Data((object)new
			{
				instanceContextPropertyMetadata.Name,
				((EntitySettings)instanceContextPropertyMetadata.Settings).RelationType
			});
			return (ActionResult)val2;
		}
		JsonResult val3 = new JsonResult();
		val3.set_Data((object)null);
		return (ActionResult)val3;
	}

	[CustomGridAction]
	public ActionResult ActiveTasksPopup(GridCommand command, Guid elementGuid, long processId)
	{
		IWorkflowTaskBaseFilter workflowTaskBaseFilter = InterfaceActivator.Create<IWorkflowTaskBaseFilter>();
		workflowTaskBaseFilter.PermissionId = Guid.Parse("0B0F7BD9-70C9-4AE6-8077-182ABF3DD8A6");
		workflowTaskBaseFilter.InstanceId = processId;
		workflowTaskBaseFilter.ActivityUids = new List<Guid> { elementGuid };
		workflowTaskBaseFilter.PermissionUser = GetCurrentUser();
		return (ActionResult)(object)((Controller)this).PartialView("ActiveTasksPopup", (object)WorkflowTaskBaseManager.CreateGridData(command, workflowTaskBaseFilter));
	}
}
