using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.ExtensionPoints;

[Obsolete("Устарел, будет удален в следующих версиях. Используйте IOvertimeWorkLogWithDraftsExtension.")]
[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IOvertimeWorkLogExtension2
{
	IEnumerable<WorkLogItemModel> SupportedModels(IEnumerable<WorkLogItemModel> workLogItemModels);

	IDictionary<WorkLogItemModel, string> OvertimeDescriptionMap(IEnumerable<WorkLogItemModel> workLogItemModels, IEnumerable<long> selectedIds);
}
