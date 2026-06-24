using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Tasks;

[Component]
public class TasksSettingsModule : GlobalSettingsModuleBase<TasksSettings>
{
	public static Guid _ModuleGuid = new Guid("1BEC7EA1-9B7C-492C-B2C4-AF6B418AC5AF");

	public override Guid ModuleGuid => _ModuleGuid;

	public override string ModuleName => SR.T("Задачи");

	public override string GroupName => SR.T("Задачи и трудозатраты");

	public override Permission AdminPermission => PermissionProvider.AdminWorklogPermission;
}
