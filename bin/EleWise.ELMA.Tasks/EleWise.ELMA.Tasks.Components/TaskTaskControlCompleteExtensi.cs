using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Components;

[Component]
internal sealed class TaskTaskControlCompleteExtension : ITaskControlCompleteExtension
{
	private TaskManager taskManager;

	public TaskTaskControlCompleteExtension(TaskManager taskManager)
	{
		this.taskManager = taskManager;
	}

	public bool Can(Type type)
	{
		if (!(type == InterfaceActivator.TypeOf<ITask>()))
		{
			return type.IsSubclassOf(InterfaceActivator.TypeOf(typeof(ITask)));
		}
		return true;
	}

	public ITaskBase DoControlComplete(Type type, long taskId, ICommentActionModel actionModel = null)
	{
		return taskManager.DoControlComplete(taskId, actionModel);
	}
}
