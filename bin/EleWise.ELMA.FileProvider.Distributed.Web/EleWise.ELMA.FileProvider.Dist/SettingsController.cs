using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FileProvider.Distributed.Web.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Controllers;
using Orchard.Themes;

namespace EleWise.ELMA.FileProvider.Distributed.Web.Controllers;

[Themed]
public class SettingsController : BaseController
{
	public IFileGatewayService FileGatewayService { get; set; }

	[HttpPost]
	public ActionResult SetUserGateway(long userId, string gateway)
	{
		IUser user = UserManager.Instance.LoadOrNull(userId);
		IUser user2 = user ?? base.AuthenticationService.GetCurrentUser();
		if (user2 == null)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				result = false
			});
		}
		FileGatewayService.SetUserGateway(user2, gateway);
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			result = true
		});
	}

	public ActionResult EditUserGateway(long userId)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		IUser user = UserManager.Instance.LoadOrNull(userId);
		IUser user2 = user ?? base.AuthenticationService.GetCurrentUser();
		string userGateway = FileGatewayService.GetUserGateway(user2);
		SelectUserGatewayModel selectUserGatewayModel = new SelectUserGatewayModel();
		selectUserGatewayModel.DisplayName = user2.FullName;
		selectUserGatewayModel.UserId = userId;
		selectUserGatewayModel.UserLogin = user2.UserName;
		SelectListItem[] array = new SelectListItem[1];
		SelectListItem val = new SelectListItem();
		val.set_Text(SR.T("Отключить индивидуальное сопоставление"));
		val.set_Value((string)null);
		val.set_Selected(userGateway.IsNullOrEmpty());
		array[0] = val;
		selectUserGatewayModel.Items = ((IEnumerable<SelectListItem>)(object)array).Concat(((IEnumerable<string>)FileGatewayService.AllGateways).Select((Func<string, SelectListItem>)delegate(string x)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			SelectListItem val2 = new SelectListItem();
			val2.set_Text(x);
			val2.set_Value(x);
			val2.set_Selected(x == userGateway);
			return val2;
		})).ToArray();
		SelectUserGatewayModel selectUserGatewayModel2 = selectUserGatewayModel;
		return (ActionResult)(object)((Controller)this).PartialView((object)selectUserGatewayModel2);
	}
}
