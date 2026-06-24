using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Settings;

namespace EleWise.ELMA.Common.Components;

[Component]
public class GlobalScoringSettingsModule : GlobalSettingsModuleBase<GlobalScoringSettings>
{
	public override Guid ModuleGuid => __AssemblyInfo.UID;

	public override string ModuleName => SR.T("Глобальные настройки скоринга");
}
