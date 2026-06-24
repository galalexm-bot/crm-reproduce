using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
public interface ICreateSubtaskActionHandler : IEventHandler
{
	void ProcessBeforeCreate(ITaskBase source, ITaskBase target, ICreateSubtaskActionModel subtaskModel);

	void ProcessBeforeSave(ITaskBase source, ITaskBase target, ICreateSubtaskActionModel subtaskModel);
}
