using System;
using System.Security.Cryptography.X509Certificates;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Security.Components;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.BPM.Web.Security.Controllers;

[AnyPermission(new string[] { "7B1CC80C-1AD0-404A-8564-06DE4B269469" })]
public class SecuritySettingsController : BPMController
{
	public SecuritySettingsModule SettingsModule { get; set; }

	public SecuritySettings Settings => SettingsModule.Settings;

	[HttpGet]
	public ActionResult View()
	{
		return (ActionResult)(object)((Controller)this).PartialView((object)Settings);
	}

	public ActionResult Edit()
	{
		return (ActionResult)(object)((Controller)this).PartialView((object)Settings);
	}

	public ActionResult GetRootThumbprint(string address)
	{
		if (string.IsNullOrWhiteSpace(address))
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false,
				error = SR.T("Для получения отпечатка корневого сертификата с центра сертификации необходимо указать адрес центра сертификации")
			}, (JsonRequestBehavior)0);
		}
		X509Certificate2 x509Certificate = null;
		try
		{
			x509Certificate = CertificationAuthorityManager.GetRootCertificate(address);
		}
		catch (Exception ex)
		{
			base.Logger.Error(SR.T("Ошибка получения корневого сертификата."), ex);
			if (x509Certificate == null)
			{
				return (ActionResult)(object)((Controller)this).Json((object)new
				{
					success = false,
					error = SR.T("Ошибка получения корневого сертификата: {0}", ex.Message)
				}, (JsonRequestBehavior)0);
			}
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = true,
			thumbprint = x509Certificate.Thumbprint
		}, (JsonRequestBehavior)0);
	}
}
