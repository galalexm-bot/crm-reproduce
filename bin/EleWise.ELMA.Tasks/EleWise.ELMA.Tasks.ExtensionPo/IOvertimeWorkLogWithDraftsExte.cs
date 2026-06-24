using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IOvertimeWorkLogWithDraftsExtension
{
	IEnumerable<WorkLogItemModel> SupportedModels(IEnumerable<WorkLogItemModel> workLogItemModels);

	IDictionary<WorkLogItemModel, string> OvertimeDescriptionMap(IEnumerable<WorkLogItemModel> workLogItemModels, IEnumerable<long> selectedIds, bool includeDraft = true);
}
