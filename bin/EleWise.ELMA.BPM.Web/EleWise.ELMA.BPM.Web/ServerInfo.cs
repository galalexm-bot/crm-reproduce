using System.ComponentModel;
using System.Globalization;
using System.Threading;
using System.Web.Services;
using EleWise.ELMA.BPM.Mvc.Application.Orchard;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.BPM.Web;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[ToolboxItem(false)]
public class ServerInfo : WebService
{
	[WebMethod]
	public StartInformation GetStartInformation()
	{
		CultureInfo cultureInfo = SR.GetCultureFromSettings() ?? SR.KeyCultureInfo;
		Thread.CurrentThread.CurrentUICulture = cultureInfo;
		Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(cultureInfo.Name);
		return StartInformation.Root;
	}

	[WebMethod]
	public StartInformation GetStartInformationLocalized(string lang)
	{
		CultureInfo cultureInfo = null;
		if (!string.IsNullOrEmpty(lang))
		{
			cultureInfo = SR.GetCultureByName(lang);
		}
		if (cultureInfo == null)
		{
			cultureInfo = SR.GetCultureFromSettings() ?? SR.KeyCultureInfo;
		}
		Thread.CurrentThread.CurrentUICulture = cultureInfo;
		Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(cultureInfo.Name);
		return StartInformation.Root;
	}

	[WebMethod]
	public int GetRemotingPort()
	{
		if (StartInformation.Root == null || (StartInformation.Root.Status != StartStatus.Started && StartInformation.Root.ErrorType != StartErrorType.ConfigurationScriptsRecompileRequired))
		{
			return 0;
		}
		CommonSettingsModule service = Locator.GetService<CommonSettingsModule>();
		return service.Settings.StartedRemotingPort;
	}

	[WebMethod]
	public bool AdminHasEmptyPassword()
	{
		if (StartInformation.Root == null || (StartInformation.Root.Status != StartStatus.Started && StartInformation.Root.ErrorType != StartErrorType.ConfigurationScriptsRecompileRequired))
		{
			return false;
		}
		return UserManager.Instance.Login("admin", "") != null;
	}

	[WebMethod]
	public StartInformation Reactivate()
	{
		if (StartInformation.Root == null)
		{
			return null;
		}
		if (StartInformation.Root.Status != StartStatus.NotActivated)
		{
			return StartInformation.Root;
		}
		ComponentManager.Current.LicenseManager.ApplyAllActivationKeys();
		ELMAEnviromentStarter.StartApplication();
		return StartInformation.Root;
	}
}
