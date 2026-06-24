using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Web.Models;

public class MapInfo
{
	private List<IWorkflowTaskBase> activeTasks;

	public IWorkflowInstance Instance { get; set; }

	public List<IWorkflowTaskBase> ActiveTasks()
	{
		if (activeTasks != null)
		{
			return activeTasks;
		}
		List<IWorkflowTaskBase> list = new List<IWorkflowTaskBase>();
		if (Instance != null)
		{
			List<Element> source = Instance.Process.Diagram.Elements.Where((Element e) => e.GetType().IsSubclassOf(typeof(TaskElement))).ToList();
			IWorkflowTaskBaseFilter workflowTaskBaseFilter = InterfaceActivator.Create<IWorkflowTaskBaseFilter>();
			workflowTaskBaseFilter.InstanceId = Instance.Id;
			workflowTaskBaseFilter.ActivityUids = source.Select((Element e) => e.Uid).ToList();
			Dictionary<Guid, List<IWorkflowTaskBase>> tasks = (from t in WorkflowTaskBaseManager.Instance.Find(workflowTaskBaseFilter, null)
				group t by t.GetElement().Uid).ToDictionary((IGrouping<Guid, IWorkflowTaskBase> g) => g.Key, (IGrouping<Guid, IWorkflowTaskBase> g) => g.ToList());
			list.AddRange(tasks.Keys.Select((Guid uid) => tasks[uid].OrderByDescending((IWorkflowTaskBase t) => t.CreationDate).First()));
			activeTasks = list;
		}
		return list;
	}
}
