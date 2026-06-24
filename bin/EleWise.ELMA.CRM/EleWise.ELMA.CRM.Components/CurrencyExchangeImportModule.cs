using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Settings;

namespace EleWise.ELMA.CRM.Components;

[Component]
public class CurrencyExchangeImportModule : GlobalSettingsModuleBase<CurrencyExchangeImportSettings>
{
	public override string ModuleName => SR.T("Настройка периодического обновления валют");

	public override Guid ModuleGuid => __AssemblyInfo.UID;
}
