using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Settings;

namespace EleWise.ELMA.Common.Components;

[Component]
public class ServerRestartSettingsModule : GlobalSettingsModuleBase<ServerRestartSettings>
{
	private object accessLock = new object();

	public override Guid ModuleGuid => __AssemblyInfo.UID;

	public override string ModuleName => SR.T("Планировщик перезапуска сервера");

	public override string ModuleNamespace => "EleWise.ELMA.Common";

	public override ServerRestartSettings Settings
	{
		get
		{
			lock (accessLock)
			{
				return base.Settings;
			}
		}
		set
		{
			lock (accessLock)
			{
				base.Settings = value;
			}
		}
	}

	public override void SaveSettings()
	{
		lock (accessLock)
		{
			base.SaveSettings();
		}
	}

	protected override void LoadSettings()
	{
		lock (accessLock)
		{
			base.LoadSettings();
		}
	}

	public ServerRestartSettings GetSettingsCopyThreadSafe()
	{
		lock (accessLock)
		{
			return Settings.Clone();
		}
	}
}
