using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Security.Components;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Text;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using Orchard.Themes;

namespace EleWise.ELMA.BPM.Web.Security.Controllers;

public class CertificateController : BPMController
{
	public IEnumerable<IAuthCryptoProviderWeb> AuthCryptoProviders { get; set; }

	public UserManager UserManager { get; set; }

	public UserCertificateManager UserCertificateManager { get; set; }

	public SecuritySettingsModule Module { get; set; }

	public ICryptoActionsService CryptoActionsService { get; set; }

	public AuthCryptoProviderService AuthCryptoProviderService { get; set; }

	[HttpPost]
	[Themed(false)]
	[AuthenticationFilter(NotRequired = true)]
	public ActionResult LogOn(string certLogin, string returnUrl)
	{
		((Controller)this).get_Session().Clear();
		return LogOn(returnUrl, delegate
		{
			IUser user = UserManager.LoadByLogin(certLogin);
			if (user == null)
			{
				((ControllerBase)this).get_TempData().set_Item("ErrorMessage", (object)SR.T("Указанный пользователь не найден"));
				return ((Controller)(object)this).RedirectLocal(returnUrl);
			}
			string defaultCertificateThumbpint = UserCertificateManager.GetDefaultCertificateThumbpint(user);
			Guid userProviderUid = AuthCryptoProviderService.GetUserProviderUid(user);
			Guid userDigitalSignatureTypeUid = AuthCryptoProviderService.GetUserDigitalSignatureTypeUid(user);
			return LogOn(returnUrl, userProviderUid, userDigitalSignatureTypeUid, defaultCertificateThumbpint);
		});
	}

	[HttpGet]
	[Themed(false)]
	[AuthenticationFilter(NotRequired = true)]
	public ActionResult LogOn(string returnUrl, Guid? providerUid, Guid? digitalSignatureTypeUid)
	{
		return LogOn(returnUrl, providerUid, digitalSignatureTypeUid, null);
	}

	[HttpGet]
	[Themed(false)]
	[AuthenticationFilter(NotRequired = true)]
	public ActionResult AuthorizationStep1()
	{
		byte[] array = new byte[32];
		using (RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider())
		{
			rNGCryptoServiceProvider.GetBytes(array);
		}
		((Controller)this).get_Session()["CertificateS1"] = BitConverter.ToString(array).Replace("-", "");
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = true,
			s1 = ((Controller)this).get_Session()["CertificateS1"]
		}, (JsonRequestBehavior)0);
	}

	[HttpPost]
	[Themed(false)]
	[AuthenticationFilter(NotRequired = true)]
	[TransactionAction]
	public ActionResult AuthorizationStep2(string returnUrl, CertificateAuthenticationData data)
	{
		string error = SR.T("Неизвестная ошибка авторизации");
		try
		{
			using SHA256 item = SHA256.Create();
			string text = string.Concat(((Controller)this).get_Session()["CertificateS1"], ":", data.ClientRandomText);
			string signedText = BitConverter.ToString(MemoryHelper.ActionWithMemoryBuffer<byte, (SHA256, string), byte[]>(EncodingCache.UTF8WithoutEmitIdentifier.GetByteCount(text), (item, text), GetHashAction)).Replace("-", "").ToLower();
			UserCertificateManager.Instance.SignInByCertificate(data.Signature, signedText, data.CryptoProviderUid);
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = true
			});
		}
		catch (LicenseActivationRequiredException exception)
		{
			base.Logger.Error("Authentication failed", exception);
			error = SR.T("Требуется активация сервера");
		}
		catch (LicenseWorkplaceExceededException exception2)
		{
			base.Logger.Error("Authentication failed", exception2);
			error = SR.T("Превышено количество пользовательских лицензий");
		}
		catch (LicenseExpiredException exception3)
		{
			base.Logger.Error("Authentication failed", exception3);
			error = SR.T("Истек срок действия лицензии");
		}
		catch (SimultaneousSessionExceededException ex)
		{
			base.Logger.Error("Authentication failed", ex);
			((Controller)this).get_Session()["SimultaneousSessionExceededException-UserId"] = ((ex.User != null) ? ex.User.GetId() : null);
			return (ActionResult)(object)((Controller)this).RedirectToAction("DemoActiveSessions");
		}
		catch (ConcurrentLicenseExceededException ex2)
		{
			base.Logger.Error("Authentication failed", ex2);
			error = ex2.Message;
		}
		catch (LicenseException exception4)
		{
			base.Logger.Error("Authentication failed", exception4);
			error = SR.T("Ошибка лицензирования");
		}
		catch (AuthenticationException ex3)
		{
			base.Logger.Error("Authentication failed", ex3);
			error = ex3.Message;
		}
		catch (CryptographicException ex4)
		{
			base.Logger.Error("Authentication failed", ex4);
			error = ex4.Message;
		}
		catch (Exception exception5)
		{
			base.Logger.Error("Authentication failed", exception5);
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = false,
			error = error
		});
	}

	private byte[] GetHashAction(byte[] buffer, int offset, int length, (SHA256, string) param)
	{
		var (sHA, text) = param;
		EncodingCache.UTF8WithoutEmitIdentifier.GetBytes(text, 0, text.Length, buffer, offset);
		return sHA.ComputeHash(buffer, offset, length);
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult Register(long userId, string signature, Guid? cryptoAction, bool isDefault)
	{
		try
		{
			IUser user = UserManager.LoadOrNull(userId);
			if (!cryptoAction.HasValue && !CryptoActionsService.IsProvidersEquals(user))
			{
				throw new Exception(SR.T("Невозможно привязать сертификат ко всем действиям пользователя, так как криптопровайдеры действий отличаются."));
			}
			Guid[] obj = ((!cryptoAction.HasValue) ? CryptoActionsService.ActionUids : new Guid[1] { cryptoAction.Value });
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			Guid[] array = obj;
			foreach (Guid cryptoActionUid in array)
			{
				IUserCertificate userCertificate = UserCertificateManager.RegisterCertificateBySignature(signature, SR.T("Привязка сертификата"), user, cryptoActionUid, isDefault);
				list.Add(userCertificate.Thumbprint);
				list2.Add(userCertificate.GetThumbprintByPairs());
			}
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = true,
				thumbprints = list,
				thumbprintsPairs = list2
			});
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

	[HttpPost]
	[TransactionAction]
	public ActionResult Delete(long id, long userId)
	{
		try
		{
			IUser user = UserManager.LoadOrNull(userId);
			UserCertificateManager.UnRegisterCertificate(id, user);
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

	[HttpPost]
	[TransactionAction]
	public ActionResult SetDefault(long id, long userId, bool @default)
	{
		try
		{
			IUser user = UserManager.LoadOrNull(userId);
			UserCertificateManager.SetDefaultCertificate(id, user, @default);
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

	private ActionResult LogOn(string returnUrl, Func<ActionResult> action)
	{
		if (!Module.Settings.AllowLoginByCertificate)
		{
			((ControllerBase)this).get_TempData().set_Item("ErrorMessage", (object)SR.T("Вход по сертификату отключен"));
			return (ActionResult)(object)((Controller)this).RedirectToAction("LogOn", "Account", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Security"
			});
		}
		if (base.AuthenticationService.GetCurrentUser() != null)
		{
			return ((Controller)(object)this).RedirectLocal(returnUrl);
		}
		return action();
	}

	private ActionResult LogOn(string returnUrl, Guid? providerUid, Guid? digitalSignatureTypeUid, string defaultThumbprint)
	{
		if (string.IsNullOrEmpty(returnUrl) && !providerUid.HasValue && !digitalSignatureTypeUid.HasValue)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("LogOn", "Account");
		}
		return LogOn(returnUrl, delegate
		{
			bool allowLoginOnlyByDefaultCertificate = Module.Settings.AllowLoginOnlyByDefaultCertificate;
			IAuthCryptoProviderWeb authCryptoProviderWeb = AuthCryptoProviders.FirstOrDefault(delegate(IAuthCryptoProviderWeb p)
			{
				Guid providerUid2 = p.Provider.ProviderUid;
				Guid? guid = providerUid;
				return providerUid2 == guid;
			});
			if (authCryptoProviderWeb == null)
			{
				((ControllerBase)this).get_TempData().set_Item("ErrorMessage", (object)SR.T("Указанный криптопровайдер не найден"));
				return ((Controller)(object)this).RedirectLocal(returnUrl);
			}
			IDigitalSignatureType digitalSignatureType = (digitalSignatureTypeUid.HasValue ? AuthCryptoProviderService.GetDigitalSignatureType(authCryptoProviderWeb.Provider.ProviderUid, digitalSignatureTypeUid.Value) : null);
			if (digitalSignatureType == null)
			{
				((ControllerBase)this).get_TempData().set_Item("ErrorMessage", (object)SR.T("Тип электронной подписи не найден"));
				return ((Controller)(object)this).RedirectLocal(returnUrl);
			}
			if (!authCryptoProviderWeb.Provider.IsSupportedDigitalSignatureType(digitalSignatureType))
			{
				((ControllerBase)this).get_TempData().set_Item("ErrorMessage", (object)SR.T("Указанный провайдер не поддерживает тип электронной подписи: {0}", digitalSignatureType.DisplayName));
				return ((Controller)(object)this).RedirectLocal(returnUrl);
			}
			((Controller)this).get_Session().Clear();
			return (ActionResult)(object)((Controller)this).View((object)new LogOnModel
			{
				AuthCryptoProvider = authCryptoProviderWeb,
				DefaultThumbprint = defaultThumbprint,
				LoginOnlyByDefaultCertificate = allowLoginOnlyByDefaultCertificate,
				DigitalSignatureType = digitalSignatureType
			});
		});
	}
}
