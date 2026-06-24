using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Tasks.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface ICalendarItemExcludedTypes
{
	IEnumerable<Guid> Uids();
}
