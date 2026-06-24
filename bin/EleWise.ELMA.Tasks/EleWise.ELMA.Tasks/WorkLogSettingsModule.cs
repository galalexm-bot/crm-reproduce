using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Tasks;

[Component]
public class WorkLogSettingsModule : GlobalSettingsModuleBase<WorkLogSettings>
{
	public static Guid _ModuleGuid = new Guid("0ac37901-8600-47a2-a240-3bc69aa75a36");

	public override Guid ModuleGuid => _ModuleGuid;

	public override string ModuleName => SR.T("Трудозатраты");

	public override Permission AdminPermission => PermissionProvider.AdminWorklogPermission;
}
