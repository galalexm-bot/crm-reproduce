using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Workflow.Components;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Components;

[Component(Order = 100)]
public class WorkflowProcessHeaderMonitorFilterPropertyEditor : WorkflowInstanceFilterProcessHeaderPropertyEditorExtension
{
	public override bool Resolve(FilterMetadataProperty property, FilterModel filterModel)
	{
		if (filterModel.Filter is IWorkflowInstanceFilter && filterModel.Entity != null && filterModel.Entity.Code == WorkflowConstants.MonitorFilterCode)
		{
			return base.Resolve(property, filterModel);
		}
		return false;
	}

	public override void PropertyAction(HtmlHelper<object> html, FilterMetadataProperty property, FilterModel filterModel, WebViewAttributes a)
	{
		base.PropertyAction(html, property, filterModel, a);
		a.TemplateName = "ProcessHeaderMonitor";
		a.EntityFilterProvider = MonitorPublishedProcessFilterProvider.UID;
	}
}
