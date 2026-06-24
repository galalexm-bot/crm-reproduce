using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Security.Code;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Components;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Security.Controllers;

public class TrustedDeviceController : BPMController
{
	public TrustedDeviceService TrustedDeviceService { get; set; }

	public AuthCryptoAction AuthCryptoAction { get; set; }

	public IEnumerable<ICertificateCryptoAction> CertificateCryptoActions { get; set; }

	public GridData<TrustedDeviceModel> CreateGridData(GridCommand command, EleWise.ELMA.Security.Models.IUser user, Guid cryptoActionUid)
	{
		GridData<TrustedDeviceModel> obj = new GridData<TrustedDeviceModel>
		{
			Command = command,
			IsPageable = false
		};
		bool flag = CertificateCryptoActions.FirstOrDefault((ICertificateCryptoAction a) => a.ActionUid == cryptoActionUid)?.SupportOtherDevices ?? false;
		List<DeviceToken> source = ((user != null && flag) ? TrustedDeviceService.GetDevices(user) : new List<DeviceToken>());
		IEnumerable<IUserPublicKeyToken> source2;
		if (!flag)
		{
			IEnumerable<IUserPublicKeyToken> enumerable = new List<IUserPublicKeyToken>();
			source2 = enumerable;
		}
		else
		{
			source2 = UserPublicKeyTokenManager.Instance.GetTokens(user);
		}
		IEnumerable<TrustedDeviceModel> list = from x in Enumerable.Union(second: source2.Select((IUserPublicKeyToken x) => new TrustedDeviceModel(x)), first: Enumerable.Union(second: from x in UserCertificateManager.Instance.GetCertificates(user, cryptoActionUid)
				select new TrustedDeviceModel(x), first: source.Select((DeviceToken x) => new TrustedDeviceModel(x))))
			where x != null
			select x;
		obj.SetCount((GridData<TrustedDeviceModel> d, FetchOptions f) => list.Count());
		obj.SetDataSource((GridData<TrustedDeviceModel> d, FetchOptions f) => (d.Count <= 0) ? new List<TrustedDeviceModel>() : list);
		return obj;
	}

	[HttpGet]
	public ActionResult Edit(long? id)
	{
		TrustedDeviceModel trustedDeviceModel = new TrustedDeviceModel
		{
			Name = ((Controller)this).get_Request().Browser.Browser
		};
		return (ActionResult)(object)((Controller)this).PartialView((object)trustedDeviceModel);
	}

	[CustomGridAction]
	public ActionResult Grid(GridCommand command, long userId, bool? editable, Guid cryptoActionUid)
	{
		EleWise.ELMA.Security.Models.IUser user = UserManager.Instance.LoadOrNull(userId);
		EleWise.ELMA.Security.IUser currentUser = base.AuthenticationService.GetCurrentUser();
		DeviceTokenGridModel deviceTokenGridModel = new DeviceTokenGridModel
		{
			GridData = CreateGridData(command, user, cryptoActionUid),
			CookieToken = ((user != null) ? TrustedDeviceTokenHelper.GetContextDeviceToken(((Controller)this).get_HttpContext(), user.UserName) : null),
			Editable = (editable ?? false),
			IsCurrentUser = (user == currentUser),
			TicketInfo = ((Controller)this).get_HttpContext().GetTrustedDeviceTicketInfo(),
			User = user
		};
		return (ActionResult)(object)((Controller)this).PartialView((object)deviceTokenGridModel);
	}

	[HttpGet]
	public ActionResult ProfileSection(long userId)
	{
		EleWise.ELMA.Security.Models.IUser user = UserManager.Instance.LoadOrNull(userId);
		return (ActionResult)(object)((Controller)this).PartialView((object)user);
	}

	[HttpPost]
	public ActionResult AddDevice(string name)
	{
		string text = string.Empty;
		string token = string.Empty;
		try
		{
			string msg = "";
			EleWise.ELMA.Security.Models.IUser currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
			if (!AuthCryptoAction.HasPermission(currentUser, out msg))
			{
				throw new SecurityException(msg);
			}
			string contextDeviceInfo = TrustedDeviceTokenHelper.GetContextDeviceInfo(((Controller)this).get_HttpContext());
			token = TrustedDeviceService.AddDevice(contextDeviceInfo, name);
			TrustedDeviceTokenHelper.CreateDeviceTokenCookie(((Controller)this).get_HttpContext(), currentUser.UserName, token);
		}
		catch (Exception ex)
		{
			text = ex.Message;
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = string.IsNullOrEmpty(text),
			error = text,
			token = token
		});
	}

	[HttpPost]
	public ActionResult DeleteDevice(long userId, string token)
	{
		string text = string.Empty;
		try
		{
			string msg = "";
			EleWise.ELMA.Security.Models.IUser user = UserManager.Instance.Load(userId);
			base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
			if (!AuthCryptoAction.HasPermission(user, out msg))
			{
				throw new SecurityException(msg);
			}
			if (TrustedDeviceService.TrustedLogonEnabled(user) && TrustedDeviceService.GetDevices(user).Count <= 1 && !UserPublicKeyTokenManager.Instance.Exists(user) && !UserCertificateManager.Instance.Exists(user))
			{
				throw new Exception(SR.T("Не останется ни одного доверенного устройства"));
			}
			if (TrustedDeviceService.GetDeviceTokens(TrustedDeviceTokenHelper.GetContextDeviceInfo(((Controller)this).get_HttpContext())).Contains(token))
			{
				TrustedDeviceTokenHelper.RemoveDeviceTokenCookie(((Controller)this).get_HttpContext(), user.UserName);
			}
			if (!string.IsNullOrEmpty(token))
			{
				TrustedDeviceService.DeleteDevice(token, user);
			}
			else
			{
				string contextDeviceToken = TrustedDeviceTokenHelper.GetContextDeviceToken(((Controller)this).get_HttpContext(), user.UserName);
				if (string.IsNullOrEmpty(contextDeviceToken))
				{
					throw new Exception(SR.T("Невозможно определить устройство для удаления"));
				}
				TrustedDeviceService.DeleteDevice(contextDeviceToken, user);
			}
		}
		catch (Exception ex)
		{
			text = ex.Message;
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = string.IsNullOrEmpty(text),
			error = text
		});
	}

	[HttpPost]
	public ActionResult TrustedEnable(long userId, bool enabled, Guid cryptoActionUid)
	{
		string text = string.Empty;
		try
		{
			ICertificateCryptoAction obj = CertificateCryptoActions.FirstOrDefault((ICertificateCryptoAction a) => a.ActionUid == cryptoActionUid) ?? throw new SecurityException(SR.T("Не найдено указанное криптодействие"));
			string msg = "";
			EleWise.ELMA.Security.Models.IUser user = UserManager.Instance.LoadOrNull(userId);
			if (!obj.HasPermission(user, out msg))
			{
				throw new SecurityException(msg);
			}
			obj.EnableTrusted(user, enabled);
		}
		catch (Exception ex)
		{
			text = ex.Message;
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = string.IsNullOrEmpty(text),
			error = text
		});
	}
}
