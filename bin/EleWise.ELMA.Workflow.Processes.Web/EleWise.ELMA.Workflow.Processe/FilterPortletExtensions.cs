using System;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Processes.Web.Controllers;
using EleWise.ELMA.Workflow.Processes.Web.Models;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.Workflow.Processes.Web.Extensions;

[Component(Order = 1000)]
public class FilterPortletExtensions : IFilterPortlet
{
	public bool AvailableFilterType(Guid filterTypeUid)
	{
		return filterTypeUid == InterfaceActivator.UID<IWorkflowInstance>();
	}

	public object GetModel(GridCommand command, FilterModel filterModel, string gridId, HtmlHelper html)
	{
		ContextGridModel contextGridModel = WorkflowInstanceController.CreateContextGridModel(command, (IWorkflowInstanceFilter)filterModel.Filter, null, showStartDateColumn: false, null, filterModel, isPortlet: true);
		contextGridModel.GridId = gridId;
		contextGridModel.GridData.GetType().GetProperty("GridId").SetValue(contextGridModel.GridData, gridId, null);
		contextGridModel.IsFilterGridState = true;
		contextGridModel.IsPortletModel = true;
		contextGridModel.DisableCustomize = true;
		contextGridModel.IsFilterPortletModel = true;
		return contextGridModel;
	}

	public string ViewName()
	{
		return "WorkflowInstance/Grid";
	}
}
