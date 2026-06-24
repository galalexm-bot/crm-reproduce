using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Calendar.Export.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.Calendar.Export.Security;

[Component]
public class ExternalCalendarPermissionProvider : IPermissionProvider
{
	public const string Module = "EleWise.ELMA.BPM.Web.Calendar.Export";

	public static string ModuleName = SR.M("Экспорт календарей");

	public const string ViewCalendarPermissionId = "{802A52EA-C59B-4324-B5E2-0C975116DCF7}";

	public const string EditCalendarPermissionId = "{4966DED9-8587-4342-ACCB-604C88EFE7C8}";

	public static readonly Permission ViewCalendarPermission = Permission.Create("{802A52EA-C59B-4324-B5E2-0C975116DCF7}", SR.M("Просмотр внешнего календаря"), "", ModuleName).ModuleUid("EleWise.ELMA.BPM.Web.Calendar.Export").InstanceParentPermission((IExternalCalendar c) => c.Schedule, PermissionProvider.ScheduleViewPermission, CommonPermissions.View);

	public static readonly Permission EditCalendarPermission = Permission.Create("{4966DED9-8587-4342-ACCB-604C88EFE7C8}", SR.M("Редактирование внешнего календаря"), "", ModuleName).ModuleUid("EleWise.ELMA.BPM.Web.Calendar.Export").InstanceParentPermission((IExternalCalendar c) => c.Schedule, PermissionProvider.ScheduleEditPermission, CommonPermissions.Edit);

	public List<string> LocalizedItemsNames => null;

	public List<string> LocalizedItemsDescriptions => null;

	public List<string> LocalizedItemsCategories => null;

	public IEnumerable<Permission> GetPermissions()
	{
		return new Permission[2] { ViewCalendarPermission, EditCalendarPermission };
	}

	public IEnumerable<PermissionStereotype> GetPermissionStereotypes()
	{
		return Enumerable.Empty<PermissionStereotype>();
	}
}
