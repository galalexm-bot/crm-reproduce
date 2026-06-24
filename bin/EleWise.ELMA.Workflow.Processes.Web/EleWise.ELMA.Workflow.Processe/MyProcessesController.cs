using System;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Html.EditableList;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Processes.Web.Models;
using EleWise.ELMA.Workflow.Security;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.Workflow.Processes.Web.Controllers;

public class MyProcessesController : FilterWorkflowInstanceController
{
	protected override Guid? Code => WorkflowConstants.MyProcessesFilterCode;

	protected override string GridIdPrefix => "TabInstancesGridPanDiv";

	public override bool ShowContentButtons => false;

	protected override bool EnableEqlQuery => true;

	[CustomGridAction]
	public ActionResult GridData(GridCommand command, [Bind(Prefix = "InstanceFilter")] IWorkflowInstanceFilter instanceFilter, [Bind(Prefix = "DataFilter")] FilterModel filterModel, string gridId, long? FilterId = null, bool? isPortletModel = false)
	{
		FilterModel filterModel2 = filterModel;
		if (filterModel2 == null)
		{
			filterModel2 = CreateFilter(FilterId);
		}
		object datafilter = UniversalFilterSaver.Pack(filterModel2.Filter);
		if (instanceFilter != null)
		{
			filterModel2.Filter = UniversalFilterSaver.UnPack(datafilter, null, instanceFilter);
		}
		string gridPrefix = ((Controller)this).get_Request()["gridPrefix"];
		bool showStartDateColumn = Convert.ToBoolean(((Controller)this).get_Request()["showStartDateColumn"] ?? false.ToString());
		ContextGridModel model = WorkflowInstanceController.CreateContextGridModel(command, (IWorkflowInstanceFilter)filterModel2.Filter, gridPrefix, showStartDateColumn, null, filterModel2);
		InitGridModel(model, gridId, filterModel2);
		model.IsPortletModel = isPortletModel.HasValue && isPortletModel.Value;
		Type type = ((((IWorkflowInstanceFilter)filterModel2.Filter).ProcessHeader != null) ? WorkflowInstanceManager.Instance.GetContextType(((IWorkflowInstanceFilter)filterModel2.Filter).ProcessHeader) : typeof(IWorkflowInstanceContext));
		return ExportExcel(model.GridData, type, () => (ActionResult)(object)((Controller)this).PartialView("WorkflowInstance/Grid", (object)model));
	}

	[ContentItem(Name = "SR.M('Мои процессы')", Image24 = "#process.svg", Order = 140)]
	[FilterMenuItem(Id = "my-processes", Type = typeof(IWorkflowInstance), FilterEditAction = "EditFilters", CodeStr = "{934820F0-6591-4891-8341-CFF23190E816}")]
	public ActionResult Index(long? FilterId = null, [Bind(Prefix = "InstanceFilter")] IWorkflowInstanceFilter instanceFilter = null, int? selectedTab = null)
	{
		if (instanceFilter == null)
		{
			ActionResult val = BaseIndex(FilterId);
			if (val != null)
			{
				return val;
			}
		}
		if (instanceFilter == null)
		{
			instanceFilter = InterfaceActivator.Create<IWorkflowInstanceFilter>();
		}
		if (!instanceFilter.IsEmulation.HasValue)
		{
			instanceFilter.IsEmulation = false;
		}
		WorkflowInstanceFilterViewModel workflowInstanceFilterViewModel = BaseIndexModel(WorkflowPermissionProvider.MyProcessesPermission.Id, FilterId, instanceFilter, selectedTab);
		return (ActionResult)(object)((Controller)this).View((object)workflowInstanceFilterViewModel);
	}

	public ActionResult Search(long? FilterId = null)
	{
		if (((Controller)this).get_Request().QueryString.Count == 0)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
		}
		WorkflowInstanceFilterViewModel workflowInstanceFilterViewModel = BaseIndexModel(WorkflowPermissionProvider.MyProcessesPermission.Id, FilterId);
		return (ActionResult)(object)((Controller)this).View("Index", (object)workflowInstanceFilterViewModel);
	}

	[HttpPost]
	public override ActionResult EditFilter([Bind(Prefix = "DataFilter")] FilterModel model, EditableListModel access)
	{
		model.Filter.PermissionId = WorkflowPermissionProvider.MyProcessesPermission.Id;
		return base.EditFilter(model, access);
	}
}
