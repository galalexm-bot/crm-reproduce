using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.ExtensionPoints;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface ITaskExpirationAction
{
	bool CheckType(ITaskBase task);

	void DoAction(ITaskBase task, DateTime date);
}
