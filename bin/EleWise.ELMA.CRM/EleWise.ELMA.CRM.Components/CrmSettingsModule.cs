using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Settings;

namespace EleWise.ELMA.CRM.Components;

[Component]
public class CrmSettingsModule : GlobalSettingsModuleBase<CrmSettings>
{
	public override Guid ModuleGuid => new Guid("ef4c9484-6690-474a-89a7-dc7ee8a898d8");

	public override string ModuleName => SR.T("Работа с клиентами");
}
