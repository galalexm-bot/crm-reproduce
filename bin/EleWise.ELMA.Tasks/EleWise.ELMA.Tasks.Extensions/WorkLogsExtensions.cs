using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Extensions;

public static class WorkLogsExtensions
{
	public static bool IsSupported(this IOvertimeWorkLogWithDraftsExtension extension, WorkLogItemModel workLogItemModel)
	{
		return extension.SupportedModels(new List<WorkLogItemModel> { workLogItemModel }).Any();
	}

	public static string OvertimeDescription(this IOvertimeWorkLogWithDraftsExtension extension, WorkLogItemModel workLogItemModel, bool includeDraft = true)
	{
		return extension.OvertimeDescription(workLogItemModel, new List<long>(), includeDraft);
	}

	public static string OvertimeDescription(this IOvertimeWorkLogWithDraftsExtension extension, WorkLogItemModel workLogItemModel, IEnumerable<long> selectedIds, bool includeDraft = true)
	{
		return extension.OvertimeDescriptionMap(new List<WorkLogItemModel> { workLogItemModel }, selectedIds, includeDraft)[workLogItemModel];
	}

	public static IDictionary<WorkLogItemModel, string> OvertimeDescriptionMap(this IOvertimeWorkLogWithDraftsExtension extension, IEnumerable<WorkLogItemModel> workLogItemModels, bool includeDraft = true)
	{
		return extension.OvertimeDescriptionMap(workLogItemModels, new List<long>(), includeDraft);
	}
}
