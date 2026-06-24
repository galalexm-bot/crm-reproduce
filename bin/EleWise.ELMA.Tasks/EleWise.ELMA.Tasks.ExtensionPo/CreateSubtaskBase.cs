using System;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.ExtensionPoints;

public abstract class CreateSubtaskBase : ICreateSubtaskExtension
{
	public abstract Guid SubTaskTypeUid { get; }

	public abstract Guid ParentTaskTypeUid { get; }

	public abstract string SubTaskTypeName { get; }

	public bool CanCreateSubtaskFrom(ITaskBase parentTask)
	{
		return parentTask.TypeUid == ParentTaskTypeUid;
	}

	public abstract ICreateSubtaskActionModel CreateSettings(ITaskBase parentTask);
}
