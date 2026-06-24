using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Common.Services;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Security;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Activities.Plugins;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Catalogs;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Connectors;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Web.Components;
using EleWise.ELMA.Workflow.Web.Models;

namespace EleWise.ELMA.Workflow.Web.Controllers;

[Permission("0B0F7BD9-70C9-4AE6-8077-182ABF3DD8A6")]
[RouteArea("EleWise.ELMA.Workflow.Web")]
public class WorkflowTaskController : BPMController<IWorkflowTask, long>
{
	public WorkflowTaskBaseManager WorkflowTaskBaseManager { get; set; }

	public IMetadataRuntimeService MetadataRuntimeService { get; set; }

	public CatalogManager CatalogManager { get; set; }

	public IEntityTaskModelDraftService EntityTaskModelDraftService { get; set; }

	public ActionResult Execute(long id, int? tabIndex, bool? redirectOnComplete)
	{
		base.ActiveMenuItem = "tasks-threads-tree";
		WorkflowTaskInfo workflowTaskInfo = new WorkflowTaskInfo(id, redirectOnComplete);
		string redirectOnCompleteUrl = workflowTaskInfo.GetRedirectOnCompleteUrl(((ControllerBase)this).get_ControllerContext());
		if (!string.IsNullOrEmpty(redirectOnCompleteUrl))
		{
			return (ActionResult)(object)((Controller)this).Redirect(redirectOnCompleteUrl);
		}
		if (tabIndex.HasValue)
		{
			workflowTaskInfo.SelectedTab = tabIndex.Value;
		}
		PrepareWorkflowTaskInfoModel(workflowTaskInfo);
		SetAsReadForFeed(workflowTaskInfo.Task);
		return (ActionResult)(object)((Controller)this).View((object)workflowTaskInfo);
	}

	[AsyncViewItemAction]
	public ActionResult AsyncViewItem(Guid viewItemUid, long taskId, ViewType viewType)
	{
		WorkflowTaskInfo workflowTaskInfo = new WorkflowTaskInfo(taskId);
		ContextPropertyViewItemRenderer.Model = workflowTaskInfo.Entity;
		PrepareWorkflowTaskInfoModel(workflowTaskInfo);
		return AsyncViewItemView(workflowTaskInfo.View as FormViewItem, viewType, viewItemUid, workflowTaskInfo, workflowTaskInfo.Task);
	}

	[EntityForm(AreaName = "EleWise.ELMA.Workflow.Web")]
	public ActionResult CreateForm(long id, Guid? formUid = null, bool formReadOnly = false, string parentFormId = "", string formId = "")
	{
		if (!formUid.HasValue)
		{
			throw new Exception(SR.T("Уникальный идентификатор формы не может быть пустым"));
		}
		WorkflowTaskInfo workflowTaskInfo = new WorkflowTaskInfo(id, initElementView: false, formReadOnly, formUid.Value);
		workflowTaskInfo.DynamicFormSettings.ParentFormId = parentFormId;
		DynamicFormSettings dynamicFormSettings = workflowTaskInfo.DynamicFormSettings;
		dynamicFormSettings.ViewItemId = dynamicFormSettings.ViewItemId + ";" + formUid.Value;
		if (!string.IsNullOrEmpty(formId))
		{
			workflowTaskInfo.DynamicFormSettings.FormId = formId;
		}
		((ControllerBase)this).get_ViewData().set_Item("FormId", (object)workflowTaskInfo.DynamicFormSettings.FormId);
		return (ActionResult)(object)((Controller)this).PartialView("ExecuteFields", (object)workflowTaskInfo);
	}

	[HttpPost]
	public ActionResult Execute(WorkflowTaskInfoBase infoBase, bool isAjax = false)
	{
		WorkflowTaskInfo workflowTaskInfo = new WorkflowTaskInfo(infoBase.Id, null, initElementView: false);
		if (workflowTaskInfo.Task.IsComplete())
		{
			base.Notifier.Error(SR.T("Ошибка. Задача завершена."));
			return (ActionResult)(object)((Controller)this).RedirectToAction("Execute", (object)workflowTaskInfo.Id);
		}
		if (infoBase.SelectedConnectorUid != Guid.Empty)
		{
			if (base.Logger.IsDebugEnabled())
			{
				base.Logger.Debug("Start execute task");
			}
			workflowTaskInfo.Task.Execute(infoBase.SelectedConnectorUid);
			if (base.Logger.IsDebugEnabled())
			{
				base.Logger.Debug("End execute task");
			}
			string value = ((Controller)this).get_HttpContext().Request["CloseAfterPost"] ?? string.Empty;
			bool result = false;
			bool.TryParse(value, out result);
			string nextTaskUrl = workflowTaskInfo.GetNextTaskUrl(((ControllerBase)this).get_ControllerContext(), redirectToDefaultIfNoTasks: true, ((Controller)this).get_Url().Action("Execute", (object)new
			{
				Id = workflowTaskInfo.Id,
				redirectOnComplete = true,
				@interface = (result ? "lite" : "")
			}));
			((Controller)this).get_HttpContext().Response.AppendHeader("CloseAfterPost", "false");
			return (ActionResult)(object)((Controller)this).Redirect(nextTaskUrl);
		}
		workflowTaskInfo.Instance.Save();
		if (isAjax)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = true
			});
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Execute", (object)workflowTaskInfo.Id);
	}

	public ActionResult Questions(long taskId)
	{
		return (ActionResult)(object)((Controller)this).PartialView((object)new WorkflowTaskInfo(taskId, null, initElementView: false));
	}

	public ActionResult Comments(long taskId)
	{
		return (ActionResult)(object)((Controller)this).PartialView((object)new WorkflowTaskInfo(taskId, null, initElementView: false));
	}

	[HttpPost]
	public ActionResult ExecutedInfoContent(long taskId, bool? redirectOnComplete)
	{
		IWorkflowTaskBase task = WorkflowTaskBaseManager.Load(taskId);
		WorkflowTaskExecutedInfo executedInfo = new WorkflowTaskExecutedInfo(task, redirectOnComplete);
		Dictionary<string, object> result = new Dictionary<string, object>();
		string text = executedInfo.GetRedirectOnCompleteUrl(((ControllerBase)this).get_ControllerContext());
		if (text != null && text.StartsWith("~"))
		{
			text = text.Substring(1);
		}
		result["NextTaskUrl"] = text;
		if (!string.IsNullOrEmpty(text))
		{
			return (ActionResult)(object)((Controller)this).Json((object)result);
		}
		((ControllerBase)this).get_ViewData().set_Model((object)executedInfo);
		HtmlCatchViewResult[] array = new HtmlCatchViewResult[1];
		HtmlCatchViewResult htmlCatchViewResult = new HtmlCatchViewResult();
		((ViewResultBase)htmlCatchViewResult).set_ViewName("WorkflowTask/ExecutedInfoContent");
		((ViewResultBase)htmlCatchViewResult).set_ViewData(((ControllerBase)this).get_ViewData());
		((ViewResultBase)htmlCatchViewResult).set_TempData(((ControllerBase)this).get_TempData());
		array[0] = htmlCatchViewResult;
		return (ActionResult)(object)new CompositeActionResult((IEnumerable<ActionResult>)(object)array, delegate(ControllerContext context, IEnumerable<ActionResult> results)
		{
			HtmlCatchViewResult htmlCatchViewResult2 = (HtmlCatchViewResult)(object)results.First();
			bool setting = SR.GetSetting("Workflow.ImmediatelyExecuteItem", defaultValue: true);
			result["Html"] = htmlCatchViewResult2.HtmlResult;
			result["NeedRefresh"] = executedInfo.Instance.Status == WorkflowInstanceStatus.Running && (!setting || executedInfo.QueueItems.Count > 0);
			MvcHtmlString value = result.ToJson();
			context.get_HttpContext().Response.ContentType = "application/json";
			context.get_HttpContext().Response.Output.Write(value);
		});
	}

	[HttpGet]
	public ActionResult CatalogEdit(long id, int? tabIndex, bool? redirectOnComplete)
	{
		WorkflowTaskInfo workflowTaskInfo = new WorkflowTaskInfo(id, redirectOnComplete);
		string redirectOnCompleteUrl = workflowTaskInfo.GetRedirectOnCompleteUrl(((ControllerBase)this).get_ControllerContext());
		if (!string.IsNullOrEmpty(redirectOnCompleteUrl))
		{
			return (ActionResult)(object)((Controller)this).Redirect(redirectOnCompleteUrl);
		}
		if (workflowTaskInfo.Task.Status == TaskBaseStatus.WasClosed)
		{
			base.Notifier.Error(SR.T("Редактирование справочника отменено."));
		}
		if (!(workflowTaskInfo.Task.CastAsRealType() is ICatalogEditTask catalogEditTask))
		{
			return null;
		}
		if (tabIndex.HasValue)
		{
			workflowTaskInfo.SelectedTab = tabIndex.Value;
		}
		if (!(workflowTaskInfo.Element is CatalogEditElement catalogEditElement))
		{
			return null;
		}
		CatalogEditTaskInfo catalogEditTaskInfo = new CatalogEditTaskInfo
		{
			WorkflowExecInfo = workflowTaskInfo,
			IsActive = catalogEditTask.IsActive(),
			ReadOnly = !catalogEditTask.CanExecute()
		};
		IEntity entity = catalogEditElement.ExtractFromInstance(workflowTaskInfo.Instance);
		bool flag = false;
		EntityMetadata entityMetadata = null;
		ICatalogProfile catalogProfile = null;
		Guid guid;
		if (entity == null)
		{
			guid = CatalogEditActivity.GetCatlogType(catalogEditElement, workflowTaskInfo.Instance.Context);
			if (guid == Guid.Empty)
			{
				throw new ArgumentException(SR.T("Для выполнения операции должен быть задан тип каталога"));
			}
			Type typeByUid = MetadataRuntimeService.GetTypeByUid(guid);
			entityMetadata = MetadataLoader.LoadMetadata(typeByUid) as EntityMetadata;
			catalogProfile = CatalogManager.LoadByCatalog(entityMetadata.ImplementationUid);
			if (!base.SecurityService.HasPermission(PermissionProvider.CatalogsAccessPermission, catalogProfile))
			{
				throw new SecurityException(SR.T("Отсутствует доступ к справочникам"));
			}
			if (!base.SecurityService.HasPermission(PermissionProvider.CatalogAddPermission, catalogProfile))
			{
				throw new SecurityException(SR.T("Недостаточно прав для добавления справочника \"{0}\"", entityMetadata.DisplayName));
			}
			entity = (IEntity)InterfaceActivator.Create(typeByUid);
			flag = true;
		}
		else
		{
			guid = InterfaceActivator.UID(entity.CastAsRealType().GetType());
		}
		if (catalogEditTaskInfo.ReadOnly)
		{
			catalogEditTaskInfo.CatalogInfo = new CatalogInfo(entity, ViewType.Display);
		}
		else if (catalogEditElement.DocumentTypeFromVar)
		{
			catalogEditTaskInfo.CatalogInfo = new CatalogInfo(entity, ViewType.Edit);
			catalogEditTaskInfo.CatalogInfo.TypeUid = guid;
		}
		else
		{
			if (entityMetadata == null)
			{
				entityMetadata = MetadataLoader.LoadMetadata(entity.GetType()) as EntityMetadata;
			}
			if (entityMetadata == null)
			{
				return null;
			}
			if (catalogProfile == null)
			{
				catalogProfile = CatalogManager.LoadByCatalog(entityMetadata.ImplementationUid);
			}
			if (!flag)
			{
				if (entityMetadata.CanUsePermissions())
				{
					if (!base.SecurityService.HasPermission(PermissionProvider.CatalogInstancePowerPermission, entity))
					{
						throw new SecurityException(SR.T("Недостаточно прав для редактирования справочника \"{0}\"", entity));
					}
				}
				else
				{
					if (!base.SecurityService.HasPermission(PermissionProvider.CatalogsAccessPermission, catalogProfile))
					{
						throw new SecurityException(SR.T("Отсутствует доступ к справочникам"));
					}
					if (!base.SecurityService.HasPermission(PermissionProvider.CatalogEditPermission, catalogProfile))
					{
						throw new SecurityException(SR.T("Недостаточно прав для редактирования справочника \"{0}\"", entityMetadata.DisplayName));
					}
				}
			}
			if (catalogEditElement != null && catalogEditElement.Map != null)
			{
				PropertyMapHelper.Map(((IWorkflowTaskBase)catalogEditTask).WorkflowBookmark.Instance.Context, entity.CastAsRealType(), catalogEditElement.Map.Reverse());
				catalogEditTaskInfo.CatalogInfo = ((!catalogEditElement.SelectDocumentForm) ? new CatalogInfo(entity, entity.IsNew() ? ViewType.Create : ViewType.Edit)
				{
					TypeUid = entityMetadata.Uid
				} : new CatalogInfo(entity, catalogEditElement.DocumentFormUid, null, entity.IsNew() ? ViewType.Create : ViewType.Edit)
				{
					TypeUid = entityMetadata.Uid
				});
			}
			InitSelectedConnectorUid((IWorkflowTaskBase)catalogEditTask, catalogEditTaskInfo);
			if (catalogEditTaskInfo.WorkflowExecInfo.SelectedConnector != null)
			{
				catalogEditTaskInfo.WorkflowExecInfo.SelectedConnector.DefaultDisplayName = SR.T("Редактировать справочник");
			}
			EntityTaskModelDraftService.ApplyStates(id, catalogEditTaskInfo.CatalogInfo);
			List<FlowConnectorElement> list = (from c in catalogEditElement.OutputConnectors.OfType<FlowConnectorElement>()
				where c.Status == CatalogCancelConnectorStatus.UID
				select c).ToList();
			if (list.Count > 0)
			{
				catalogEditTaskInfo.CancelConnectorUid = list.Select((FlowConnectorElement c) => c.Uid).ToList();
				catalogEditTaskInfo.ValidateContext = list.First().ValidateContextVariables;
			}
		}
		SetAsReadForFeed(catalogEditTask);
		if (catalogEditTaskInfo.CatalogInfo != null && catalogEditTaskInfo.CatalogInfo.DynamicFormSettings != null)
		{
			catalogEditTaskInfo.CatalogInfo.DynamicFormSettings.FormId = "CatalogEditForm";
		}
		if (catalogEditTaskInfo.WorkflowExecInfo != null && catalogEditTaskInfo.WorkflowExecInfo.DynamicFormSettings != null)
		{
			catalogEditTaskInfo.WorkflowExecInfo.DynamicFormSettings.FormId = "CatalogEditForm";
		}
		((Controller)(object)this).SetCurrentMenuItem("tasks-threads-tree");
		return (ActionResult)(object)((Controller)this).View((object)catalogEditTaskInfo);
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult CatalogEdit([Bind(Prefix = "CatalogContent")] CatalogInfo cat, [Bind(Prefix = "WorkflowExecInfo")] WorkflowTaskInfoBase baseInfo)
	{
		WorkflowTaskInfo info = new WorkflowTaskInfo(baseInfo.Id, null, initElementView: false);
		if (info.Task.Status == TaskBaseStatus.WasClosed)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("CatalogEdit", (object)info.Id);
		}
		info.SelectedConnectorUid = baseInfo.SelectedConnectorUid;
		if (info.SelectedConnectorUid == Guid.Empty)
		{
			EntityTaskModelDraftService.Save(cat, baseInfo.Id);
			info.Instance.Save();
			return (ActionResult)(object)((Controller)this).RedirectToAction("CatalogEdit", (object)new { info.Id });
		}
		FlowConnectorElement flowConnectorElement = info.Instance.Process.Diagram.Elements.FirstOrDefault((Element e) => e.Uid == baseInfo.SelectedConnectorUid) as FlowConnectorElement;
		bool flag = false;
		if (flowConnectorElement != null)
		{
			flag = flowConnectorElement.Status == CatalogCancelConnectorStatus.UID;
		}
		if (!flag)
		{
			ModelHelper.GetEntityManager(cat.Entity.GetType()).Save(cat.Entity);
			if (info.Element is CatalogEditElement catalogEditElement && catalogEditElement.ExtractFromInstance(info.Instance) == null)
			{
				catalogEditElement.SetToInstance(info.Instance, cat.Entity);
				info.Instance.Save();
			}
		}
		if (baseInfo.SelectedConnectorUid != Guid.Empty)
		{
			info.Task.Execute(info.SelectedConnectorUid);
		}
		return (ActionResult)(object)LazyRedirect(() => info.GetNextTaskUrl(((ControllerBase)this).get_ControllerContext(), redirectToDefaultIfNoTasks: true, ((Controller)this).get_Url().Action("CatalogEdit", (object)new
		{
			Id = info.Id,
			redirectOnComplete = true
		})));
	}

	private void InitSelectedConnectorUid(IWorkflowTaskBase task, CatalogTaskInfo model, bool getFirst = false)
	{
		Element element = task.WorkflowBookmark.Instance.Process.Diagram.Elements.FirstOrDefault(delegate(Element e)
		{
			Guid uid = e.Uid;
			Guid? elementUid = task.WorkflowBookmark.ElementUid;
			return uid == elementUid;
		});
		if (element != null)
		{
			Connector connector = element.OutputConnectors.FirstOrDefault((Connector c) => c is FlowConnectorElement);
			if (connector != null)
			{
				model.WorkflowExecInfo.SelectedConnectorUid = connector.Uid;
				model.WorkflowExecInfo.SelectedConnector = (FlowConnectorElement)connector;
			}
			else if (getFirst)
			{
				FlowConnectorElement flowConnectorElement = element.OutputConnectors.FirstOrDefault() as FlowConnectorElement;
				model.WorkflowExecInfo.SelectedConnectorUid = flowConnectorElement?.Uid ?? Guid.Empty;
				model.WorkflowExecInfo.SelectedConnector = flowConnectorElement;
			}
		}
	}

	private void PrepareWorkflowTaskInfoModel(WorkflowTaskInfo model)
	{
		if (model.View is FormViewItem && DirectoryMapVirtualPathProvider.AnyConfigFile("~/Modules/EleWise.ELMA.Workflow.Web/Views/WorkflowTask/Execute.cshtml", "~/Modules/EleWise.ELMA.Workflow.Web/Views/WorkflowTask/ExecuteTabView.cshtml", "~/Modules/EleWise.ELMA.Workflow.Web/Views/Shared/WorkflowTask/FieldsView.cshtml", "~/Modules/EleWise.ELMA.Workflow.Web/Views/Shared/WorkflowTask/DefaultFieldsView.cshtml") && model.FormSettings != null)
		{
			ViewItem viewItem = model.View.FindItem(new Guid("7b3db26d-9e23-467f-923a-e8cd3aa189b1"));
			model.FormSettings.ShowCommonInfo = viewItem != null && !viewItem.Hide;
			ViewItem viewItem2 = model.View.FindItem(new Guid("aa7b18c0-36d3-48fc-913b-42f1f457c203"));
			model.FormSettings.ShowTabs = viewItem2 != null && !viewItem2.Hide;
			ViewItem viewItem3 = model.View.FindItem(new Guid("0e1ab805-6da7-4aef-9d46-8d797af396a1"));
			PanelViewItem panelViewItem = model.View.FindItem<PanelViewItem>(new Guid("E515C52D-5D13-4A37-B0E1-1B1E0645C5A4"));
			model.FormSettings.UseCustomView = panelViewItem != null && (viewItem3?.Hide ?? true);
			model.FormSettings.CustomViewName = (model.FormSettings.UseCustomView ? panelViewItem.CustomViewName : null);
			ViewItem viewItem4 = model.View.FindItem(new Guid("0ecbf8a0-9cd9-4c2a-8fd5-9649c105d938"));
			model.FormSettings.ShowConnectorButtons = viewItem4 != null && !viewItem4.Hide;
		}
	}
}
