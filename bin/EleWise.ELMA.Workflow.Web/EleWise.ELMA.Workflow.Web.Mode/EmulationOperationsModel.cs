using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Tasks.Extensions;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models.Trees;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Web.Models;

public class EmulationOperationsModel
{
	private HtmlHelper html;

	private UrlHelper urlHelper;

	public IWorkflowInstance Instance { get; set; }

	public IEnumerable<IWorkflowTaskBase> Tasks { get; set; }

	public IEnumerable<WorkflowInstanceTimerInfo> Timers { get; set; }

	public IEnumerable<IWorkflowInstance> SubInstances { get; set; }

	public IEnumerable<WorkflowMessageBookmarkInfo> MessageBookmarkInfos { get; set; }

	public TreeModel Tree { get; set; }

	public EmulationOperationsModel()
	{
	}

	public EmulationOperationsModel(IWorkflowInstance instance)
	{
		EmulationContextGridModel emulationContextGridModel = new EmulationContextGridModel();
		Instance = instance;
		Tasks = emulationContextGridModel.GetCurrentTasks(instance);
		Timers = emulationContextGridModel.GetCurrentTimers(instance);
		SubInstances = emulationContextGridModel.GetCurrentSubInstances(instance);
	}

	public EmulationOperationsModel(long id, HtmlHelper htmlHelper)
	{
		html = htmlHelper;
		IWorkflowInstance instance = (Instance = WorkflowInstanceManager.Instance.LoadOrNull(id));
		EmulationContextGridModel emulationContextGridModel = new EmulationContextGridModel();
		Instance = instance;
		SubInstances = emulationContextGridModel.GetCurrentSubInstances(instance);
		MessageBookmarkInfos = emulationContextGridModel.GetCurrentMessageBookmarks(instance);
	}

	public void CreateTree(HtmlHelper htmlHelper, UrlHelper url)
	{
		urlHelper = url;
		html = htmlHelper;
		List<TreeMenuNode> children = TreeNodeState(Instance);
		Tree = new TreeModel
		{
			Id = "EmulationProcessTree",
			Children = children,
			HtmlAttributes = new
			{
				style = "width:100%;height:100%; border: 0px solid #FFF;"
			},
			ShowExpandCollapseButtons = true
		};
	}

	private List<TreeMenuNode> TreeNodeState(IWorkflowInstance instance)
	{
		EmulationContextGridModel emulationContextGridModel = new EmulationContextGridModel();
		List<TreeMenuNode> list = new List<TreeMenuNode>();
		IEnumerable<IWorkflowTaskBase> currentTasks = emulationContextGridModel.GetCurrentTasks(instance);
		if (currentTasks.Count() > 0)
		{
			TreeMenuNode treeMenuNode = new TreeMenuNode
			{
				text = SR.T("Задачи"),
				expanded = true,
				id = "Tasks" + Timers,
				icon = "#company.svg",
				HtmlClass = new List<string> { "EmulationSubTreeBlack" }
			};
			List<TreeMenuNode> list2 = new List<TreeMenuNode>();
			foreach (IWorkflowTaskBase task in currentTasks)
			{
				ITaskBase taskBase = task;
				string text = SR.T(taskBase.Subject);
				string text2 = ((text.ToLower().Count() > 25) ? (text.ToLower().Substring(0, 25) + "...") : text.ToLower());
				string text3 = text.ToLower();
				BPMNFlowElement bPMNFlowElement = (BPMNFlowElement)instance.Process.Diagram.Elements.FirstOrDefault(delegate(Element a)
				{
					Guid uid = a.Uid;
					Guid? elementUid = task.WorkflowBookmark.ElementUid;
					return uid == elementUid;
				});
				if (bPMNFlowElement != null)
				{
					SwimlaneElement swimlane = bPMNFlowElement.GetSwimlane(instance.Process.Diagram);
					if (swimlane != null)
					{
						text3 = text3 + " (" + swimlane.LocalizableName + ", " + ((taskBase.ExecutorIsEmulation != null) ? (taskBase.ExecutorIsEmulation.LastName + " " + taskBase.ExecutorIsEmulation.FirstName.Substring(0, 1) + ".") : "") + ")";
						string text4 = ((taskBase.ExecutorIsEmulation != null) ? (taskBase.ExecutorIsEmulation.LastName + " " + ((taskBase.ExecutorIsEmulation.FirstName.Count() >= 1) ? (taskBase.ExecutorIsEmulation.FirstName.Substring(0, 1) + ".") : "")) : "");
						text2 = text2 + " (" + ((swimlane.LocalizableName.Count() > 17) ? (swimlane.LocalizableName.Substring(0, 17) + "...") : swimlane.LocalizableName) + ", " + ((text4.Count() > 17) ? (text4.Substring(0, 17) + "...") : text4) + ")";
					}
				}
				TreeMenuNode item = new TreeMenuNode
				{
					text = text2,
					expanded = true,
					id = "Tasks" + task.Id,
					icon = html.Icon(task),
					href = urlHelper.Entity(task),
					HtmlClass = new List<string> { "EmulationSubTaskTree" },
					HtmlAttributes = new Dictionary<string, object> { { "tooltiptext", text3 } }
				};
				list2.Add(item);
			}
			treeMenuNode.children = list2;
			list.Add(treeMenuNode);
		}
		IEnumerable<WorkflowInstanceTimerInfo> currentTimers = emulationContextGridModel.GetCurrentTimers(instance);
		if (currentTimers.Count() > 0)
		{
			TreeMenuNode treeMenuNode2 = new TreeMenuNode
			{
				text = SR.T("Таймеры"),
				expanded = true,
				id = "Timers" + instance.Id,
				icon = "#change_time.svg",
				HtmlClass = new List<string> { "EmulationSubTreeBlack" }
			};
			List<TreeMenuNode> list3 = new List<TreeMenuNode>();
			foreach (WorkflowInstanceTimerInfo item4 in currentTimers)
			{
				TreeMenuNode item2 = new TreeMenuNode
				{
					text = item4.ElementName + ";" + item4.ExecuteTime,
					expanded = true,
					id = "Timers" + Timers,
					icon = "#change_time.svg",
					HtmlClass = new List<string> { "EmulationSubTreeBlack" }
				};
				list3.Add(item2);
			}
			treeMenuNode2.children = list3;
			list.Add(treeMenuNode2);
		}
		IEnumerable<WorkflowMessageBookmarkInfo> currentMessageBookmarks = emulationContextGridModel.GetCurrentMessageBookmarks(instance);
		if (currentMessageBookmarks.Count() > 0)
		{
			TreeMenuNode treeMenuNode3 = new TreeMenuNode
			{
				text = SR.T("Ожидания сообщений"),
				expanded = true,
				id = "InstanceCurrentMessageBookmarks" + instance.Id
			};
			List<TreeMenuNode> list4 = new List<TreeMenuNode>();
			foreach (WorkflowMessageBookmarkInfo item5 in currentMessageBookmarks)
			{
				TreeMenuNode item3 = new TreeMenuNode
				{
					text = item5.ElementName + ";" + item5.CreationDate,
					expanded = true,
					id = "MessageBookmarkInfos" + item5.Id
				};
				list4.Add(item3);
			}
			treeMenuNode3.children = list4;
			list.Add(treeMenuNode3);
		}
		IEnumerable<IWorkflowInstance> currentSubInstances = emulationContextGridModel.GetCurrentSubInstances(instance);
		if (currentSubInstances.Any())
		{
			TreeMenuNode treeMenuNode4 = new TreeMenuNode
			{
				text = SR.T("Подпроцессы"),
				expanded = true,
				id = "InstanceCurrentSubInstances_" + instance.Id,
				icon = "#process.svg",
				HtmlClass = new List<string> { "EmulationSubProcessTree" }
			};
			List<TreeMenuNode> list5 = new List<TreeMenuNode>();
			foreach (IWorkflowInstance item6 in currentSubInstances)
			{
				string text5 = SR.T(item6.Process.Name);
				TreeMenuNode treeMenuNode5 = new TreeMenuNode
				{
					text = ((text5.ToLower().Count() > 50) ? (text5.ToLower().Substring(0, 49) + "...") : text5.ToLower()),
					expanded = true,
					id = "InstanceCurrentSubInstance_" + item6.Id,
					href = urlHelper.Entity(item6),
					icon = "~/Content/IconPack/process.svg",
					HtmlClass = new List<string> { "EmulationSubTaskTree" },
					HtmlAttributes = new Dictionary<string, object> { 
					{
						"tooltiptext",
						text5.ToLower()
					} }
				};
				treeMenuNode5.children = TreeNodeState(item6);
				list5.Add(treeMenuNode5);
			}
			treeMenuNode4.children = list5;
			list.Add(treeMenuNode4);
		}
		return list;
	}
}
