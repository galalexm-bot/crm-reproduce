using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Services;
using EleWise.ELMA.Workflow.Web.Extensions;

namespace EleWise.ELMA.Workflow.Processes.Web.Integration.ExecutedTaskInfos;

[Component(Order = 300)]
public class ReceiveMessageInfoProvider : IExecutedTaskInfoProvider
{
	public HtmlString GetInfo(HtmlHelper html, IWorkflowInstance instance)
	{
		IList<WorkflowMessageBookmarkInfo> activeMessageBookmarkInfos = Locator.GetServiceNotNull<IWorkflowMessagingService>().GetActiveMessageBookmarkInfos(new IWorkflowInstance[1] { instance }, allowSubInstances: true);
		if (activeMessageBookmarkInfos == null || !activeMessageBookmarkInfos.Any())
		{
			return null;
		}
		return (HtmlString)(object)MvcHtmlString.Create(((HtmlString)(object)PartialExtensions.Partial(html, "ExecutedInfoReceiveMessage", (object)activeMessageBookmarkInfos)).ToHtmlString());
	}

	public WebData GetData(IWorkflowInstance instance)
	{
		IList<WorkflowMessageBookmarkInfo> activeMessageBookmarkInfos = Locator.GetServiceNotNull<IWorkflowMessagingService>().GetActiveMessageBookmarkInfos(new IWorkflowInstance[1] { instance }, allowSubInstances: true);
		if (activeMessageBookmarkInfos == null || !activeMessageBookmarkInfos.Any())
		{
			return null;
		}
		WebData webData = new WebData();
		webData.Items = new WebDataItem[1]
		{
			new WebDataItem
			{
				Name = "MessageInfos",
				DataArray = activeMessageBookmarkInfos.Select((WorkflowMessageBookmarkInfo t) => new WebData(new Dictionary<string, object> { 
				{
					"MessageType",
					(t.MessageType != null) ? t.MessageType.Name : ""
				} })).ToArray()
			}
		};
		return webData;
	}
}
