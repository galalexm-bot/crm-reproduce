using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Web.Service.v1;
using EleWise.ELMA.Workflow.Mobile.ExtensionPoints;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Mobile.API;

internal abstract class BaseHasDynamicFormMethod : PublicServiceMethodExecutor
{
	private IEnumerable<IWorkflowTaskElement> workflowTaskElements;

	private IEnumerable<IWorkflowTaskElement> WorkflowTaskElements => workflowTaskElements ?? (workflowTaskElements = Locator.GetServiceNotNull<IEnumerable<IWorkflowTaskElement>>());

	protected BaseHasDynamicFormMethod(WebData parameters)
		: base(parameters)
	{
	}

	protected virtual bool ExecuteInternal(IWorkflowTaskBase task)
	{
		IWorkflowBookmark workflowBookmark = task.WorkflowBookmark;
		IWorkflowInstance instance = workflowBookmark.Instance;
		Element element = instance.Process.Diagram.Elements.FirstOrDefault(delegate(Element e)
		{
			Guid uid = e.Uid;
			Guid? elementUid = workflowBookmark.ElementUid;
			return uid == elementUid;
		});
		return WorkflowTaskElements.FirstOrDefault((IWorkflowTaskElement e) => e.CanUse(element))?.HasCustomView(element, instance) ?? false;
	}

	protected abstract bool GetTasks(out IList<IWorkflowTaskBase> tasks);

	public override WebData Execute()
	{
		return ExecuteInternal();
	}

	protected virtual WebData ExecuteInternal()
	{
		Dictionary<long, bool> dictionary = new Dictionary<long, bool>();
		if (GetTasks(out var tasks))
		{
			foreach (IWorkflowTaskBase item in tasks)
			{
				bool value = ExecuteInternal(item);
				dictionary[item.Id] = value;
			}
			return FormatResult(dictionary);
		}
		return GetError();
	}

	protected abstract WebData FormatResult(Dictionary<long, bool> result);

	protected virtual WebData GetError()
	{
		return WebData.CreateFromObject(new Dictionary<string, object> { { "Result", false } }).UpdateVersion();
	}
}
