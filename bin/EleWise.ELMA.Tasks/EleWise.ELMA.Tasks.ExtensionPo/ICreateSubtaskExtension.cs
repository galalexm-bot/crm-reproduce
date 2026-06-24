using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
public interface ICreateSubtaskExtension
{
	Guid SubTaskTypeUid { get; }

	Guid ParentTaskTypeUid { get; }

	string SubTaskTypeName { get; }

	bool CanCreateSubtaskFrom(ITaskBase parentTask);

	ICreateSubtaskActionModel CreateSettings(ITaskBase parentTask);
}
