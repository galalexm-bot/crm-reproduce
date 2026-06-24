using System;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.Security.Components;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.BPM.Web.Security.Controllers;

public class TokenController : BPMController
{
	[HttpPost]
	public ActionResult Delete(long id, long userId)
	{
		if (!Locator.GetServiceNotNull<SecuritySettingsModule>().Settings.AllowLoginByToken)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false,
				error = SR.T("Вход по токену отключен")
			});
		}
		try
		{
			IUser user = UserManager.Instance.LoadOrNull(userId);
			UserPublicKeyTokenManager.Instance.UnRegisterToken(id, user);
		}
		catch (Exception ex)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false,
				error = ex.Message
			});
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = true
		});
	}

	[HttpGet]
	public ActionResult KeyExists(long userId, string publicKey)
	{
		try
		{
			IUser user = UserManager.Instance.Load(userId);
			bool exists = UserPublicKeyTokenManager.Instance.GetTokens(user).Any((IUserPublicKeyToken x) => x.PublicKey == publicKey);
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = true,
				exists = exists
			}, (JsonRequestBehavior)0);
		}
		catch (Exception ex)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false,
				error = ex.Message
			});
		}
	}
}
