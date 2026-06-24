using System;
using System.ComponentModel;
using System.Text;
using System.Xml.Serialization;
using EleWise.ELMA.Packaging.Logging;

namespace EleWise.ELMA.Packaging.Components.Web.Settings;

public class IISHostingSettings
{
	[DefaultValue(null)]
	public string SiteName { get; set; }

	[DefaultValue(null)]
	public string PoolName { get; set; }

	[DefaultValue(0)]
	public int Port { get; set; }

	[DefaultValue(IISAuthenticationType.Default)]
	public IISAuthenticationType AuthenticationType { get; set; }

	[DefaultValue(null)]
	public string UserName { get; set; }

	[XmlIgnore]
	public string Password { get; set; }

	[DefaultValue(null)]
	[XmlElement("Password")]
	public string PasswordEncrypted
	{
		get
		{
			if (string.IsNullOrEmpty(Password))
			{
				return null;
			}
			return Convert.ToBase64String(Encoding.UTF8.GetBytes(Password));
		}
		set
		{
			try
			{
				Password = (string.IsNullOrEmpty(value) ? null : Encoding.UTF8.GetString(Convert.FromBase64String(value)));
			}
			catch (Exception exception)
			{
				Logger.Log.Warn(SR.T("Не удалось расшифровать пароль: '{0}'", value), exception);
			}
		}
	}

	public void InitByDefault()
	{
		SiteName = "ELMA";
		PoolName = "ELMA";
		AuthenticationType = IISAuthenticationType.ApplicationPoolIdentity;
		Port = 80;
	}
}
