using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Tasks.ExtensionPoints;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface ISolveTaskManagement
{
	IEnumerable<Guid> TypeUid { get; }

	long GetCurrentControlCount(IUser user, bool debugMode);

	long GetExecutionControlCount(IUser user, bool debugMode);
}
