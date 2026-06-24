using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
public interface ICloneTaskExtendedModel
{
	IEnumerable<Action<ITask>> UpdateActions(ICreateTaskExtendedModel model);
}
