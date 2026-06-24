using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.Settings;

namespace EleWise.ELMA.Messaging.Email;

[Component]
public class EmailSettingsModule : GlobalSettingsModuleBase<EmailSettings>
{
	public override string ModuleName => SR.T("Исходящая почта");

	public override Guid ModuleGuid => __AssemblyInfo.UID;

	[Obsolete]
	private void SetSmtpEnableSsl(bool smtpEnableSsl)
	{
		_settings.SmtpEnableSsl = smtpEnableSsl;
	}

	protected override void LoadSettings()
	{
		base.LoadSettings();
		if (_settings.SettingsData.TryGetValue("SmtpEnableSsl", out var value))
		{
			SetSmtpEnableSsl(Convert.ToBoolean(value));
		}
	}

	public override void SaveSettings()
	{
		if (_settings.SettingsData.ContainsKey("SmtpEnableSsl"))
		{
			_settings.SettingsData.Remove("SmtpEnableSsl");
			DataAccessManager.SettingsManager.RemoveString(ModuleGuid, "SmtpEnableSsl");
		}
		base.SaveSettings();
	}
}
