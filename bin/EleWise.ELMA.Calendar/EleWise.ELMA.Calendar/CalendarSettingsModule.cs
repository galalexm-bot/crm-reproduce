using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Calendar;

[Component]
public class CalendarSettingsModule : GlobalSettingsModuleBase<CalendarSettings>
{
	public const string UID = "4797ba4a-c829-4d77-b0b2-3048d13cdc36";

	public static readonly Guid Uid = new Guid("4797ba4a-c829-4d77-b0b2-3048d13cdc36");

	public override Guid ModuleGuid => Uid;

	public override string ModuleName => SR.T("Календарь");

	public override Permission AdminPermission => PermissionProvider.ScheduleAdminPermission;
}
