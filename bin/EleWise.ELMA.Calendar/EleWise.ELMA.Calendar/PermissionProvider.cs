using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.Calendar;

[Component]
public class PermissionProvider : IPermissionProvider
{
	public const string Module = "EleWise.ELMA.BPM.Web.Calendar";

	public const string CalendarAccessPermissionId = "47DB2A47-0E59-420E-87E7-E85890750CA1";

	public static readonly Permission CalendarAccessPermission = Permission.Create("47DB2A47-0E59-420E-87E7-E85890750CA1", SR.M("Доступ к модулю \"Календарь\""), string.Empty, SR.M("Календарь")).ModuleUid("EleWise.ELMA.BPM.Web.Calendar");

	public const string ScheduleViewPermissionId = "2AC915A2-D101-43FA-A9EB-F1DE6981AC22";

	public static readonly Permission ScheduleViewPermission = Permission.Create("2AC915A2-D101-43FA-A9EB-F1DE6981AC22", SR.M("Просмотр"), string.Empty, SR.M("Календарь")).ModuleUid("EleWise.ELMA.BPM.Web.Calendar").InstancePermission<ISchedule>(CommonPermissions.View);

	public const string ScheduleEditPermissionId = "60885B94-C7EB-4BFA-AD8F-8234FFF88F06";

	public static readonly Permission ScheduleEditPermission = Permission.Create("60885B94-C7EB-4BFA-AD8F-8234FFF88F06", SR.M("Редактирование"), string.Empty, SR.M("Календарь")).ModuleUid("EleWise.ELMA.BPM.Web.Calendar").InstancePermission<ISchedule>()
		.Dependencies(ScheduleViewPermission);

	public const string ScheduleFullPermissionId = "8B55FD06-BF9F-4974-9263-B647C0A3BB36";

	public static readonly Permission ScheduleFullPermission = Permission.Create("8B55FD06-BF9F-4974-9263-B647C0A3BB36", SR.M("Полный доступ"), string.Empty, SR.M("Календарь")).ModuleUid("EleWise.ELMA.BPM.Web.Calendar").InstancePermission<ISchedule>()
		.Dependencies(ScheduleViewPermission, ScheduleEditPermission);

	public const string ScheduleAdminPermissionId = "71C2885B-3C58-4671-AA89-BF50ED7A4950";

	public static readonly Permission ScheduleAdminPermission = Permission.Create("71C2885B-3C58-4671-AA89-BF50ED7A4950", SR.M("Настройка общих календарей"), string.Empty, SR.M("Календарь")).ModuleUid("EleWise.ELMA.BPM.Web.Calendar");

	public const string AccessToAllEventsPermissionId = "619D2E3B-9837-443C-A8E7-9997CCD25605";

	public readonly Guid AccessToAllEventsPermissionUid = new Guid("619D2E3B-9837-443C-A8E7-9997CCD25605");

	public static readonly Permission AccessToAllEventsPermission = Permission.Create("619D2E3B-9837-443C-A8E7-9997CCD25605", SR.M("Доступ ко всем событиям"), string.Empty, SR.M("Календарь")).ModuleUid("EleWise.ELMA.BPM.Web.Calendar");

	public const string ViewEventPermissionId = "F40A82A1-04DC-4AEE-A34D-4EA47268B0BE";

	public static readonly Permission ViewEventPermission = Permission.Create("F40A82A1-04DC-4AEE-A34D-4EA47268B0BE", SR.M("Просмотр события"), string.Empty, SR.M("Календарь")).ModuleUid("EleWise.ELMA.BPM.Web.Calendar").InstancePermission<ICalendarEvent>(CommonPermissions.View)
		.AdminPermissions(AccessToAllEventsPermission);

	public const string EditEventPermissionId = "C17D7DF9-2E6C-4130-91E8-7C75C6B9DACF";

	public static readonly Permission EditEventPermission = Permission.Create("C17D7DF9-2E6C-4130-91E8-7C75C6B9DACF", SR.M("Редактирование события"), string.Empty, SR.M("Календарь")).ModuleUid("EleWise.ELMA.BPM.Web.Calendar").InstancePermission<ICalendarEvent>(CommonPermissions.Edit)
		.AdminPermissions(AccessToAllEventsPermission);

	public const string ProductionSchedulePermissionId = "99A0C619-AF6B-4D66-88C4-2C8F07B34575";

	public static readonly Permission ProductionSchedulePermission = Permission.Create("99A0C619-AF6B-4D66-88C4-2C8F07B34575", SR.M("Настройка производственных календарей"), string.Empty, SR.M("Календарь")).ModuleUid("EleWise.ELMA.BPM.Web.Calendar");

	public List<string> LocalizedItemsNames => null;

	public List<string> LocalizedItemsDescriptions => null;

	public List<string> LocalizedItemsCategories => null;

	public IEnumerable<Permission> GetPermissions()
	{
		return new Permission[9] { CalendarAccessPermission, ViewEventPermission, EditEventPermission, AccessToAllEventsPermission, ScheduleViewPermission, ScheduleEditPermission, ScheduleFullPermission, ScheduleAdminPermission, ProductionSchedulePermission };
	}

	public IEnumerable<PermissionStereotype> GetPermissionStereotypes()
	{
		IEnumerable<Permission> permissions = from i in GetPermissions()
			where i.Id != AccessToAllEventsPermissionUid
			select i;
		return new PermissionStereotype[3]
		{
			new PermissionStereotype(permissions, SecurityConstants.AdminGroupDescriptor),
			new PermissionStereotype(new Permission[1] { ScheduleAdminPermission }, SecurityConstants.ConfiguringGroupDescriptor),
			new PermissionStereotype(new Permission[3] { CalendarAccessPermission, ScheduleViewPermission, ViewEventPermission }, SecurityConstants.AllUsersGroupDescriptor)
		};
	}

	public Dictionary<Permission, string> GetPermissionNames()
	{
		Dictionary<Permission, string> dictionary = new Dictionary<Permission, string>();
		dictionary.Add(CalendarAccessPermission, "CalendarAccessPermission");
		dictionary.Add(ViewEventPermission, "ViewEventPermission");
		dictionary.Add(EditEventPermission, "EditEventPermission");
		dictionary.Add(AccessToAllEventsPermission, "AccessToAllEventsPermission");
		dictionary.Add(ScheduleViewPermission, "ScheduleViewPermission");
		dictionary.Add(ScheduleEditPermission, "ScheduleEditPermission");
		dictionary.Add(ScheduleFullPermission, "ScheduleFullPermission");
		dictionary.Add(ScheduleAdminPermission, "ScheduleAdminPermission");
		return dictionary;
	}
}
