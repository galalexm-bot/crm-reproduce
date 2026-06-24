using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Tasks.ExtensionPoints;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface ISolveTaskUnderControlManagement
{
	IEnumerable<Guid> TypeUid { get; }
}
