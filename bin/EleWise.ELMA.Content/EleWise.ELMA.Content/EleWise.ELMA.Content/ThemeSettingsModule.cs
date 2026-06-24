using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Runtime.Settings;

namespace EleWise.ELMA.Content;

[Component]
public class ThemeSettingsModule : GlobalSettingsModuleBase<ThemeSettings>
{
	public static Guid _ModuleGuid = new Guid("C46AD3B5-9B0E-460E-B9C3-E156A92E06F8");

	public override Guid ModuleGuid => _ModuleGuid;

	public override string ModuleName => SR.T("Цветовая схема");

	public ColorSchemeManager ColorSchemeManager { get; set; }

	public override void SaveSettings()
	{
		base.SaveSettings();
		ColorSchemeManager.ClearSchemeChache(Settings.CurrentColorScheme.Uid);
	}
}
