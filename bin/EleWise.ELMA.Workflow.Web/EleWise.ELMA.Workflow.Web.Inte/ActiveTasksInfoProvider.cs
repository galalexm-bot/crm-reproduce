using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Web.Extensions;

namespace EleWise.ELMA.Workflow.Web.Integration.ExecutedTaskInfos;

[Component(Order = 100)]
public class ActiveTasksInfoProvider : IExecutedTaskInfoProvider
{
	public static List<string> Projections = new List<string>
	{
		LinqUtils.NameOf((Expression<Func<ITaskBase, object>>)((ITaskBase t) => t.Id)),
		LinqUtils.NameOf((Expression<Func<ITaskBase, object>>)((ITaskBase t) => t.TypeUid)),
		LinqUtils.NameOf((Expression<Func<ITaskBase, object>>)((ITaskBase t) => t.Executor)),
		LinqUtils.NameOf((Expression<Func<ITaskBase, object>>)((ITaskBase t) => t.Subject)),
		LinqUtils.NameOf((Expression<Func<ITaskBase, object>>)((ITaskBase t) => t.Status)),
		LinqUtils.NameOf((Expression<Func<IWorkflowTaskBase, object>>)((IWorkflowTaskBase t) => t.WorkflowBookmark))
	};

	public HtmlString GetInfo(HtmlHelper html, IWorkflowInstance instance)
	{
		IList<IWorkflowTaskBase> tasks = WorkflowTaskBaseManager.Instance.GetTasks(instance, allowSubInstances: true, Projections);
		if (!tasks.Any())
		{
			return null;
		}
		return (HtmlString)(object)MvcHtmlString.Create(((HtmlString)(object)PartialExtensions.Partial(html, "WorkflowTask/ExecutedInfoTasks", (object)tasks)).ToHtmlString());
	}

	public WebData GetData(IWorkflowInstance instance)
	{
		IList<IWorkflowTaskBase> tasks = WorkflowTaskBaseManager.Instance.GetTasks(instance, allowSubInstances: true, Projections);
		if (!tasks.Any())
		{
			return null;
		}
		Guid subjectUid = InterfaceActivator.PropertyUid((ITaskBase t) => t.Subject);
		Guid executorUid = InterfaceActivator.PropertyUid((ITaskBase t) => t.Executor);
		WebData webData = new WebData();
		webData.Items = new WebDataItem[1]
		{
			new WebDataItem
			{
				Name = "ActiveTasks",
				DataArray = tasks.Select((IWorkflowTaskBase t) => WebData.CreateFromEntity(t, (PropertyMetadata pm) => pm.Uid == subjectUid || pm.Uid == executorUid, (ITablePartMetadata tpm) => false)).ToArray()
			}
		};
		return webData;
	}
}
