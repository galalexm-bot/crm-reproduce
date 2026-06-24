using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Settings;

namespace EleWise.ELMA.RPA.Services;

[Component]
internal sealed class RPAClientSettingsModule : GlobalSettingsModuleBase<RPAClientSettings>
{
	public override string ModuleName => SR.T("Интеграция с системой RPA");

	public override Guid ModuleGuid => __AssemblyInfo.UID;
}
