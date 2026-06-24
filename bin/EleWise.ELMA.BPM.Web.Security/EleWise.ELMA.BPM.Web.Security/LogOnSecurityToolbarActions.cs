using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Security.Code;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Components;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;

namespace EleWise.ELMA.BPM.Web.Security.Components;

[Component(Order = 50)]
internal sealed class LogOnSecurityToolbarActions : IActionItemProvider
{
	private readonly SecuritySettingsModule securitySettings;

	private readonly TrustedDeviceService trustedDeviceService;

	private readonly AuthCryptoProviderService authCryptoProviderService;

	private readonly IEnumerable<IAuthCryptoProviderWeb> authCryptoProviders;

	private readonly IAuthenticationService authenticationService;

	private readonly AuthCryptoAction authCryptoAction;

	private readonly UserSecurityProfileManager userSecurityProfileManager;

	private const string AuthCryptoPopupId = "AuthCryptoProviderPopup";

	private const string EnableTrustedLoginButtonUid = "EnableTrustedLoginButton";

	private const string AddRemoveTrustedButtonUid = "AddRemoveTrustedButton";

	private const string SelectCryptoEntireButtonUid = "SelectCryptoEntireButton";

	private const string BindCertEntireButtonUid = "BindCertEntireButton";

	private const string SecurityToolbarActionUid = "SecurityToolbarAction";

	private const string ForceChangePasswordButtonUid = "ForceChangePasswordButton";

	private const string TrustedDevicePopupId = "EditDeviceTokenPopup";

	private const string TrustedLogonScripts = "ConfirmTrustedLogonScripts";

	public LogOnSecurityToolbarActions(SecuritySettingsModule securitySettings, TrustedDeviceService trustedDeviceService, AuthCryptoProviderService authCryptoProviderService, IEnumerable<IAuthCryptoProviderWeb> authCryptoProviders, AuthCryptoAction authCryptoAction, IAuthenticationService authenticationService, UserSecurityProfileManager userSecurityProfileManager)
	{
		this.securitySettings = securitySettings;
		this.trustedDeviceService = trustedDeviceService;
		this.authCryptoProviderService = authCryptoProviderService;
		this.authCryptoProviders = authCryptoProviders;
		this.authCryptoAction = authCryptoAction;
		this.authenticationService = authenticationService;
		this.userSecurityProfileManager = userSecurityProfileManager;
	}

	public IEnumerable<IActionItem> GetItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		EleWise.ELMA.Security.Models.IUser userFromModel = htmlHelper.GetUserFromModel();
		if (userFromModel == null || !authCryptoAction.HasPermission(userFromModel))
		{
			return null;
		}
		LogOnSecurityActionsModel logOnModel = CreateModel(userFromModel, htmlHelper);
		EleWise.ELMA.Security.Models.IUser currentUser = authenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		ActionToolbarItem actionToolbarItem = new ActionToolbarItem("SecurityToolbarAction")
		{
			Text = SR.T("Безопасность"),
			IconUrl = "#admin.svg"
		};
		if (logOnModel.IsCurrentUser)
		{
			actionToolbarItem.Items.Add(new ActionToolbarItem("AddRemoveTrustedButton")
			{
				Text = ((logOnModel.CurrentToken != null) ? SR.T("Добавить в доверенные") : SR.T("Удалить из доверенных")),
				Click = ((logOnModel.CurrentToken != null) ? "addTrustedDevice_click()" : "delTrustedDevice_click()"),
				OnRender = delegate(HtmlHelper html)
				{
					html.RegisterContent("EditDeviceTokenPopup", delegate
					{
						//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
						//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
						//IL_00be: Expected O, but got Unknown
						//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
						//IL_00cf: Expected O, but got Unknown
						StringBuilder stringBuilder = new StringBuilder();
						stringBuilder.Append(html.PopupWindow("EditDeviceTokenPopup", SR.T("Добавление доверенного устройства")));
						stringBuilder.Append(PartialExtensions.Partial(html, "TrustedDevice/TrustedDevicesScript", (object)new TrustedDevicesScriptModel
						{
							User = logOnModel.User,
							PopupId = "EditDeviceTokenPopup",
							AddTrustedDeviceSubmitCallback = "addTrustedDeviceSubmitCallback",
							DeleteDeviceCallback = "deleteTrustedDeviceSubmitCallback",
							RefreshGridFunc = "refreshTrustedDevicesGrid"
						}));
						HtmlHelper obj2 = html;
						EleWise.ELMA.Security.Models.IUser user2 = logOnModel.User;
						ViewDataDictionary val2 = new ViewDataDictionary();
						val2.Add("RefreshMenu", (object)true);
						stringBuilder.Append(PartialExtensions.Partial(obj2, "TrustedDevice/TrustedLogOnScript", (object)user2, val2));
						return (object)new MvcHtmlString(stringBuilder.ToString());
					});
				}
			});
		}
		else
		{
			htmlHelper.RegisterContent("ConfirmTrustedLogonScripts", delegate
			{
				//IL_0016: Unknown result type (might be due to invalid IL or missing references)
				//IL_001b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0031: Expected O, but got Unknown
				HtmlHelper obj = htmlHelper;
				EleWise.ELMA.Security.Models.IUser user = logOnModel.User;
				ViewDataDictionary val = new ViewDataDictionary();
				val.Add("RefreshMenu", (object)true);
				return PartialExtensions.Partial(obj, "TrustedDevice/TrustedLogOnScript", (object)user, val);
			});
		}
		actionToolbarItem.Items.Add(new ActionToolbarItem("EnableTrustedLoginButton")
		{
			Text = (logOnModel.TrustedLogonEnabled ? SR.T("Разрешить вход с любых устройств") : SR.T("Включить вход только с доверенных устройств")),
			Click = (logOnModel.TrustedLogonEnabled ? "disableTrustedLogin_click()" : "enableTrustedLogin_click()")
		});
		if (logOnModel.User.AllowChangePassword() && logOnModel.User.AuthProviderGuid == Guid.Empty && currentUser.Id != logOnModel.User.Id)
		{
			bool flag = userSecurityProfileManager.Load(logOnModel.User)?.ForcedChangePassword ?? true;
			actionToolbarItem.Items.Add(new ActionToolbarItem("ForceChangePasswordButton")
			{
				Text = (flag ? SR.T("Снять принудительную смену пароля") : SR.T("Сменить пароль при следующем входе")),
				Click = (flag ? $"elma.profile.resetForcedChangePassword('{logOnModel.User.Id}')" : $"elma.profile.setForcedChangePassword('{logOnModel.User.Id}')")
			});
		}
		if (logOnModel.AllowLoginByCertificate)
		{
			string arg = ContextVars.Get<string>("logon_uniqueUid");
			string arg2 = $"AttachCertFunc{arg}";
			_ = $"attachCert{arg}";
			actionToolbarItem.Items.Add(new ActionToolbarItem("SelectCryptoEntireButton")
			{
				Text = SR.T("Выбор криптопровайдера для входа"),
				Click = ((object)htmlHelper.OpenPopup("AuthCryptoProviderPopup")).ToString(),
				OnRender = delegate(HtmlHelper html)
				{
					html.RegisterContent("AuthCryptoProviderPopup", (dynamic d) => html.PopupWindow("AuthCryptoProviderPopup", SR.T("Выберите криптопровайдер"), (object p) => PartialExtensions.Partial(htmlHelper, "Editors/CryproProviderSelector", (object)new CryptoProviderSelectorModel
					{
						UserId = logOnModel.User.Id,
						Action = "SaveAuthCryptoProvider",
						Controller = "User",
						Area = "EleWise.ELMA.BPM.Web.Security",
						PopupId = "AuthCryptoProviderPopup",
						Providers = logOnModel.CryptoProviders.Select((IAuthCryptoProviderWeb pr) => pr.Provider),
						DefaultProviderUid = logOnModel.DefaultCryptoProviderUid,
						SelectedProviderUid = logOnModel.SelectedCryptoProviderUid,
						DefaultDigitalSignatureTypeUid = logOnModel.DefaultDigitalSignatureTypeUid,
						SelectedDigitalSignatureTypeUid = logOnModel.SelectedDigitalSignatureTypeUid,
						DigitalSignatureTypes = logOnModel.DigitalSignatureTypes
					})));
				}
			});
			actionToolbarItem.Items.Add(new ActionToolbarItem("BindCertEntireButton")
			{
				Text = SR.T("Привязать сертификат для входа"),
				Click = $"{arg2}()"
			});
		}
		return new IActionItem[1] { actionToolbarItem };
	}

	public void InsertItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		if (rootItem == null || rootItem.Uid != "DefaultActionsToolbar")
		{
			return;
		}
		rootItem.Items.FirstOrDefault((IActionItem item) => item != null && item.Uid == "UserProfileButtonActionsGroup");
		if (!(rootItem.Items.FirstOrDefault((IActionItem item) => item != null && item.Uid == "MoreButtonToolbarGroup") is ActionToolbarGroup actionToolbarGroup))
		{
			return;
		}
		IActionItem additionalButton = actionToolbarGroup.Items.FirstOrDefault((IActionItem m) => m.Uid == "more_btn");
		if (additionalButton != null)
		{
			GetItems(additionalButton, htmlHelper).ForEach(delegate(IActionItem item)
			{
				additionalButton.Items.Add(item);
			});
		}
	}

	private LogOnSecurityActionsModel CreateModel(EleWise.ELMA.Security.Models.IUser user, HtmlHelper html)
	{
		SecuritySettings settings = securitySettings.Settings;
		string contextDeviceToken = TrustedDeviceTokenHelper.GetContextDeviceToken(((ControllerContext)html.get_ViewContext()).get_HttpContext(), user.UserName);
		string[] deviceTokens = trustedDeviceService.GetDeviceTokens(TrustedDeviceTokenHelper.GetContextDeviceInfo(((ControllerContext)html.get_ViewContext()).get_HttpContext()), user);
		Guid providerUid = authCryptoProviderService.GetUserProviderUid(user);
		return new LogOnSecurityActionsModel
		{
			User = user,
			IsCurrentUser = (authenticationService.GetCurrentUser() == user),
			AllowLoginByCertificate = settings.AllowLoginByCertificate,
			AllowLoginByToken = settings.AllowLoginByToken,
			CurrentToken = (deviceTokens.Contains(contextDeviceToken) ? contextDeviceToken : null),
			TrustedLogonEnabled = trustedDeviceService.TrustedLogonEnabled(user),
			CryptoProvider = authCryptoProviders.FirstOrDefault((IAuthCryptoProviderWeb p) => p.ProviderUid == providerUid),
			CryptoProviders = authCryptoProviders,
			SelectedCryptoProviderUid = authCryptoProviderService.GetUserProviderUid(user, onlyProfile: true),
			DefaultCryptoProviderUid = authCryptoProviderService.DefaultProviderUid,
			SelectedDigitalSignatureTypeUid = authCryptoProviderService.GetUserDigitalSignatureTypeUid(user, onlyProfile: true),
			DefaultDigitalSignatureTypeUid = authCryptoProviderService.DefaultDigitalSignatureTypeUid,
			DigitalSignatureTypes = authCryptoProviderService.GetDigitalSignatureTypes()
		};
	}
}
