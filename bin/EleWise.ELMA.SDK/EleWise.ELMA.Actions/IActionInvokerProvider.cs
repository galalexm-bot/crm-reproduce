using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Actions;

[ExtensionPoint(ComponentType.Server)]
public interface IActionInvokerProvider
{
	IEnumerable<IActionInvoker> GetInvokers();

	IActionInvoker GetInvoker(Guid actionObjectUid, Guid actionTypeUid);
}
