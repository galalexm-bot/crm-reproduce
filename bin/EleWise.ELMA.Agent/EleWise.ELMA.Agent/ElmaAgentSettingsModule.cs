using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Settings;

namespace EleWise.ELMA.Agent;

[Component]
internal sealed class ElmaAgentSettingsModule : GlobalSettingsModuleBase<ElmaAgentSettings>
{
	public override Guid ModuleGuid => __AssemblyInfo.UID;

	public override string ModuleName => SR.T("ELMA Агент");
}
