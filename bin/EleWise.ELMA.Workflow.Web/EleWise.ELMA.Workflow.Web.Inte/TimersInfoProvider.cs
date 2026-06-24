using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Web.Extensions;

namespace EleWise.ELMA.Workflow.Web.Integration.ExecutedTaskInfos;

[Component(Order = 200)]
public class TimersInfoProvider : IExecutedTaskInfoProvider
{
	public HtmlString GetInfo(HtmlHelper html, IWorkflowInstance instance)
	{
		IList<WorkflowInstanceTimerInfo> activeTimerInfos = WorkflowInstanceManager.Instance.GetActiveTimerInfos(new IWorkflowInstance[1] { instance }, allowSubInstances: true);
		if (activeTimerInfos == null || !activeTimerInfos.Any())
		{
			return null;
		}
		return (HtmlString)(object)MvcHtmlString.Create(((HtmlString)(object)PartialExtensions.Partial(html, "WorkflowTask/ExecutedInfoTimers", (object)activeTimerInfos)).ToHtmlString());
	}

	public WebData GetData(IWorkflowInstance instance)
	{
		IList<WorkflowInstanceTimerInfo> activeTimerInfos = WorkflowInstanceManager.Instance.GetActiveTimerInfos(new IWorkflowInstance[1] { instance }, allowSubInstances: true);
		if (activeTimerInfos == null || !activeTimerInfos.Any())
		{
			return null;
		}
		WebData webData = new WebData();
		webData.Items = new WebDataItem[1]
		{
			new WebDataItem
			{
				Name = "TimerInfos",
				DataArray = activeTimerInfos.Select((WorkflowInstanceTimerInfo t) => new WebData(new Dictionary<string, object> { { "ExecuteTime", t.ExecuteTime } })).ToArray()
			}
		};
		return webData;
	}
}
