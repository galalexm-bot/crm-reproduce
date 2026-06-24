using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.BPM.Web.Content.Controllers;
using EleWise.ELMA.BPM.Web.Tasks.Controllers;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Processes.Web.Models;
using EleWise.ELMA.Workflow.Security;

namespace EleWise.ELMA.Workflow.Processes.Web.Controllers;

public class FilterWorkflowInstanceController : FilterTreeContentController<IWorkflowInstance, long>
{
	public virtual ActionResult WorkflowFilterFields(long? inputVal, string HtmlFieldPrefix, Guid MainTypeUid, string TypesControlName, bool? ShowAllFields, long? FilterId = null)
	{
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		Filter contextFilter = null;
		IProcessHeader processHeader = null;
		if (inputVal.HasValue && inputVal.Value > 0)
		{
			if (((ClassMetadata)MetadataLoader.LoadMetadata(InterfaceActivator.TypeOf<IWorkflowInstanceFilter>())).Properties.FirstOrDefault((PropertyMetadata p) => p.Name == "ContextFilter") == null)
			{
				throw new Exception(SR.T("Нет своства ContextFilter"));
			}
			processHeader = ProcessHeaderManager.Instance.Load(inputVal.Value);
			if (processHeader.Published == null)
			{
				throw new Exception(SR.T("Нет опубликованной версии процесса"));
			}
			Type instanceContextFilterType = Locator.GetServiceNotNull<WorkflowInstanceContextService>().GetInstanceContextFilterType(processHeader.Published);
			if (instanceContextFilterType != null)
			{
				contextFilter = (Filter)Activator.CreateInstance(instanceContextFilterType);
			}
		}
		FilterModel filterModel = new FilterModel(InterfaceActivator.Create<IFilter>(), MainTypeUid, null, null, "Filter", null, Code);
		ViewDataDictionary viewData = ((ControllerBase)this).get_ViewData();
		TemplateInfo val = new TemplateInfo();
		val.set_HtmlFieldPrefix(HtmlFieldPrefix);
		viewData.set_TemplateInfo(val);
		((ControllerBase)this).get_ViewData().set_Item("TypesControlName", (object)TypesControlName);
		if (ShowAllFields.HasValue)
		{
			filterModel.ShowAllFields = ShowAllFields.Value;
		}
		((IWorkflowInstanceFilter)filterModel.Filter).ContextFilter = contextFilter;
		if (processHeader != null)
		{
			((IWorkflowInstanceFilter)filterModel.Filter).ProcessHeader = processHeader;
		}
		return (ActionResult)(object)((Controller)this).PartialView("Filter/FilterModelFields", (object)filterModel);
	}

	public virtual ActionResult TableColumnSettings([Bind(Prefix = "DataFilter")] FilterModel model)
	{
		model?.FillGridState();
		((ControllerBase)this).get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix("DataFilter");
		return (ActionResult)(object)((Controller)this).PartialView("Filter/EntityColumnSettings", (object)model);
	}

	public virtual WorkflowInstanceFilterViewModel BaseIndexModel(Guid permissionId, long? FilterId = null, IWorkflowInstanceFilter instanceFilter = null, int? selectedTab = null)
	{
		if (instanceFilter != null && !instanceFilter.IsEmulation.HasValue)
		{
			instanceFilter.IsEmulation = false;
		}
		if (FilterId.HasValue && FilterId.Value > 0)
		{
			IFilter filter = AbstractNHEntityManager<IFilter, long>.Instance.Load(FilterId.Value);
			if (filter.FilterFields != null)
			{
				IWorkflowInstanceFilter workflowInstanceFilter = (IWorkflowInstanceFilter)UniversalFilterSaver.UnPack(filter.FilterFields);
				if (workflowInstanceFilter != null && workflowInstanceFilter.ProcessHeader != null)
				{
					IProcessHeader processHeader = workflowInstanceFilter.ProcessHeader;
					if (processHeader.Published == null)
					{
						throw new Exception(SR.T("Нет опубликованной версии процесса"));
					}
					FillFilter(processHeader.Published, workflowInstanceFilter);
				}
			}
		}
		else if (instanceFilter != null && instanceFilter.ProcessHeader != null)
		{
			if (instanceFilter.ProcessHeader.Published == null)
			{
				throw new Exception(SR.T("Нет опубликованной версии процесса"));
			}
			FillFilter(instanceFilter.ProcessHeader.Published, instanceFilter);
		}
		FilterModel filterModel = CreateFilter(FilterId, null, instanceFilter);
		if (!FilterId.HasValue || FilterId.Value == 0L)
		{
			filterModel.Filter.PermissionId = permissionId;
		}
		if (filterModel.Filter != null && !((IWorkflowInstanceFilter)filterModel.Filter).IsEmulation.HasValue)
		{
			((IWorkflowInstanceFilter)filterModel.Filter).IsEmulation = false;
		}
		WorkflowInstanceFilterViewModel workflowInstanceFilterViewModel = new WorkflowInstanceFilterViewModel
		{
			Filter = filterModel,
			InstanceCount = WorkflowInstanceManager.Instance.CountUsingContext((IWorkflowInstanceFilter)filterModel.Filter),
			ExpandAdvacedSearch = false
		};
		if (selectedTab.HasValue)
		{
			workflowInstanceFilterViewModel.SelectedTab = selectedTab.Value;
		}
		CalculateTaskCount(permissionId, workflowInstanceFilterViewModel, filterModel);
		IProcessHeader processHeader2 = workflowInstanceFilterViewModel.GetProcessHeader();
		if (processHeader2 != null)
		{
			workflowInstanceFilterViewModel.HasProcessHeaderPermission = CheckProcessHeaderPermission(processHeader2.Id);
		}
		return workflowInstanceFilterViewModel;
	}

	protected virtual void CalculateTaskCount(Guid permissionId, WorkflowInstanceFilterViewModel model, FilterModel filterModel)
	{
		InstanceOf<IWorkflowTaskBaseFilter> instanceOf = new InstanceOf<IWorkflowTaskBaseFilter>();
		instanceOf.New.PermissionId = permissionId;
		instanceOf.New.Executor = base.AuthenticationService.GetCurrentUser<IUser>();
		instanceOf.New.Statuses = WorkflowTaskBaseExtensions.ActiveTaskStatuses.ToList();
		instanceOf.New.InstanceFilter = (Filter)filterModel.Filter;
		ITaskBaseFilter filter = AllTasksController.CreateFilterForGrid(instanceOf.New, SearchTasksType.Search);
		model.TasksCount = AbstractNHEntityManager<ITaskBase, long>.Instance.Count(filter);
	}

	protected virtual void FillFilter(IWorkflowProcess process, IWorkflowInstanceFilter filter)
	{
		PropertyMetadata propertyMetadata = ((ClassMetadata)MetadataLoader.LoadMetadata(InterfaceActivator.TypeOf<IWorkflowInstanceFilter>())).Properties.FirstOrDefault((PropertyMetadata p) => p.Name == "ContextFilter");
		if (propertyMetadata == null)
		{
			throw new Exception(SR.T("Нет своства ContextFilter"));
		}
		Type instanceContextFilterType = Locator.GetServiceNotNull<WorkflowInstanceContextService>().GetInstanceContextFilterType(process);
		if (instanceContextFilterType != null)
		{
			PropertyInfo reflectionProperty = filter.GetType().GetReflectionProperty(propertyMetadata.Name);
			if (reflectionProperty.GetValue(filter, null) == null)
			{
				reflectionProperty.SetValue(filter, InterfaceActivator.Create(instanceContextFilterType), null);
			}
		}
	}

	public virtual ActionResult GetAvaliableFilters(string text, Guid typeUid)
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00b4: Expected O, but got Unknown
		IEnumerable<IFilterFolder> source = from f in FilterFolderManager.Instance.LoadFilterFolders(new ReferenceOnEntityType
			{
				TypeUid = typeUid
			}, Code)
			where f.Id > 0 && f.TypeUid != InterfaceActivator.UID<IFilterFolder>() && f.TypeUid != InterfaceActivator.UID<IFilterActionLink>()
			select f;
		if (!string.IsNullOrEmpty(text))
		{
			source = source.Where((IFilterFolder f) => f.Name != null && f.Name.IndexOf(text, StringComparison.OrdinalIgnoreCase) > 0);
		}
		JsonResult val = new JsonResult();
		val.set_Data((object)new SelectList((IEnumerable)source.Select((IFilterFolder u) => new
		{
			id = u.Id,
			text = u.Name
		}).ToList(), "id", "text"));
		return (ActionResult)val;
	}

	public virtual void InitGridModel(ContextGridModel model, string gridId, FilterModel filter)
	{
		model.GridId = gridId;
		model.GridData.GetType().GetProperty("GridId").SetValue(model.GridData, gridId, null);
		model.IsFilterGridState = true;
		model.DisableCustomize = filter.Entity != null && !filter.Entity.IsNew() && (filter.Entity.UseDefaultSettings || (!base.SecurityService.HasPermission(PermissionProvider.FilterEditPermission, filter.Entity) && !base.SecurityService.HasPermission(PermissionProvider.FilterFullAccessPermission, filter.Entity)));
	}

	public bool CheckProcessHeaderPermission(long id)
	{
		if (!base.SecurityService.HasPermission(WorkflowPermissionProvider.FullMonitorAccessPermission))
		{
			return base.SecurityService.HasPermission(WorkflowPermissionProvider.ProcessMonitor, ProcessHeaderManager.Instance.Load(id));
		}
		return true;
	}
}
