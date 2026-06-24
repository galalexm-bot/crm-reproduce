using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.ExtensionPoints;

[Obsolete("Устарел, будет удален в следющих версиях. Используйте IOvertimeWorkLogExtension2.")]
[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IOvertimeWorkLogExtension
{
	bool EnableExtension(IEntity obj);

	string FullOvertimeWorkLogDescription(IWorkLogItem workLogItem, List<long> selectedIds = null);
}
