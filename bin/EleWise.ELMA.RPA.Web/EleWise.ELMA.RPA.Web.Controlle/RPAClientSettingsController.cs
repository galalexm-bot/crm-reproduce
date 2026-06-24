using System;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.RPA.DTO.Managers;
using EleWise.ELMA.RPA.DTO.Models;
using EleWise.ELMA.RPA.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.RPA.Web.Controllers;

public class RPAClientSettingsController : BPMController
{
	private static readonly RPAClientSettingsModule settingsModule;

	private static readonly RPAClientSettingsModule SettingsModule = settingsModule ?? (settingsModule = Locator.GetServiceNotNull<RPAClientSettingsModule>());

	private readonly IRPAProcessDTOManager processDTOManager;

	private RPAClientSettings Settings => SettingsModule.Settings;

	public RPAClientSettingsController(IRPAProcessDTOManager processDTOManager)
	{
		this.processDTOManager = processDTOManager;
	}

	[HttpGet]
	public ActionResult View()
	{
		return (ActionResult)(object)((Controller)this).PartialView((object)Settings);
	}

	[HttpGet]
	public ActionResult Edit()
	{
		return (ActionResult)(object)((Controller)this).PartialView((object)Settings);
	}

	public ActionResult GenerateToken()
	{
		Guid authToken = Guid.NewGuid();
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			AuthToken = authToken
		});
	}

	public ActionResult Register()
	{
		try
		{
			Contract.ArgumentNotNull(Settings.ServerAddress, SR.T("Адрес сервера RPA"));
			RegistrationResponseDTO registrationResponseDTO = processDTOManager.Register(Settings);
			return (ActionResult)(object)((Controller)this).Json((object)registrationResponseDTO);
		}
		catch (ArgumentNullException ex)
		{
			EleWise.ELMA.Logging.Logger.Log.Error(ex.Message, ex);
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				error = ex.Message
			});
		}
		catch (Exception ex2)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				error = ex2.Message
			});
		}
	}

	public ActionResult GetRegistrationStatus()
	{
		try
		{
			Contract.ArgumentNotNull(Settings.ServerAddress, SR.T("Адрес сервера RPA"));
			RegistrationStatusResponseDTO registrationStatus = processDTOManager.GetRegistrationStatus(Settings.AuthToken);
			return (ActionResult)(object)((Controller)this).Json((object)registrationStatus);
		}
		catch (ArgumentNullException ex)
		{
			EleWise.ELMA.Logging.Logger.Log.Error(ex.Message, ex);
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				error = ex.Message
			});
		}
		catch (Exception ex2)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				error = ex2.Message
			});
		}
	}
}
