using System;
using System.Drawing;
using System.Linq;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using EleWise.ELMA.BPM.Mvc.Application.Orchard;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Runtime;

namespace EleWise.ELMA.BPM.Web;

public class ActivationDemo : Page
{
	protected HtmlHead Head1;

	protected HtmlGenericControl activateBody;

	protected Literal lblRegNumber;

	protected Label lblActivationInfo;

	protected bool CanAddActivationKey
	{
		get
		{
			if (ComponentManager.Initialized)
			{
				return ComponentManager.Current.LicenseManager != null;
			}
			return false;
		}
	}

	protected string ActivationUrl
	{
		get
		{
			ILicensedUnit mainLicensedUnit = ComponentManager.Current.ModuleManager.MainLicensedUnit;
			if (mainLicensedUnit == null)
			{
				return "";
			}
			string registrationKey = ComponentManager.Current.LicenseManager.GetRegistrationKey(mainLicensedUnit);
			return VersionInfo.GetCEActivationUrl(registrationKey);
		}
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		if (OrchardApplication.ActivationPage != "ActivationDemo.aspx")
		{
			base.Response.Redirect("~/" + OrchardApplication.ActivationPage, endResponse: false);
			Context.ApplicationInstance.CompleteRequest();
			return;
		}
		ILicensedUnit mainLicensedUnit = ComponentManager.Current.ModuleManager.MainLicensedUnit;
		lblRegNumber.Text = ComponentManager.Current.LicenseManager.GetRegistrationKey(mainLicensedUnit);
		ILicenseInfo licenseInfo = null;
		if (ComponentManager.Current.ModuleManager.MainApplication != null)
		{
			foreach (ILicensedUnit item in ComponentManager.Current.ModuleManager.MainApplication.SystemModules.OfType<ILicensedUnit>())
			{
				ILicenseInfo licenseInfo2 = item.GetLicenseInfo();
				if (licenseInfo2 != null && licenseInfo2.Status != 0)
				{
					licenseInfo = licenseInfo2;
					break;
				}
			}
		}
		ILicenseInfo licenseInfo3 = licenseInfo ?? mainLicensedUnit.GetLicenseInfo();
		ITrialLicenseInfo trialLicenseInfo = licenseInfo3 as ITrialLicenseInfo;
		if (licenseInfo3 != null && licenseInfo3.Status != LicenseStatus.NotActivated)
		{
			switch (licenseInfo3.Status)
			{
			case LicenseStatus.Activated:
			{
				if (StartInformation.Root.Status == StartStatus.NotActivated && !string.IsNullOrEmpty(ELMAEnviromentStarter.StartupExceptionText))
				{
					lblActivationInfo.Text = ELMAEnviromentStarter.StartupExceptionText;
					lblActivationInfo.ForeColor = Color.Red;
					break;
				}
				IWorkplaceLicenseInfo workplaceLicenseInfo = licenseInfo3 as IWorkplaceLicenseInfo;
				string text = ((trialLicenseInfo == null || !trialLicenseInfo.TrialExpiration.HasValue) ? SR.T("Количество лицензий: {0}", (workplaceLicenseInfo != null && workplaceLicenseInfo.WorkplaceCount.HasValue) ? workplaceLicenseInfo.WorkplaceCount.Value : 0u) : SR.T("Количество лицензий: {0}. Срок действия лицензии: {1}", (workplaceLicenseInfo != null && workplaceLicenseInfo.WorkplaceCount.HasValue) ? workplaceLicenseInfo.WorkplaceCount.Value : 0u, trialLicenseInfo.TrialExpiration.Value.ToShortDateString()));
				lblActivationInfo.Text = text;
				lblActivationInfo.ForeColor = Color.Green;
				break;
			}
			case LicenseStatus.DateExpired:
			{
				string text = ((trialLicenseInfo == null || !trialLicenseInfo.TrialExpiration.HasValue) ? SR.T("Истек срок действия лицензии") : SR.T("Истек срок действия лицензии: {0}", trialLicenseInfo.TrialExpiration.Value.ToShortDateString()));
				lblActivationInfo.Text = text;
				lblActivationInfo.ForeColor = Color.Red;
				break;
			}
			}
		}
		else
		{
			lblActivationInfo.Text = "";
		}
	}
}
