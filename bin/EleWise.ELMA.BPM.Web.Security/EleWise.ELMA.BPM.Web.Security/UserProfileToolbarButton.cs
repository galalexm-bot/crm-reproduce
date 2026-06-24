using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.Actions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Actions;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;

namespace EleWise.ELMA.BPM.Web.Security.Components;

[Component(Order = 10)]
internal sealed class UserProfileToolbarButton : IActionItemProvider
{
	private readonly ISecurityService securityService;

	private readonly ActionDispatcherService actionDispatcherService;

	private readonly ContentDispatchActionService contentDispatchActionService;

	private const string ChangePasswordUid = "ProfileActionChangePassword";

	private const string SetAbsenceUid = "ProfileActionSetAbsence";

	private const string CreateReplacement = "ProfileActionCreateReplacement";

	private const string ChangeCalendar = "ProfileActionChangeCalendar";

	private const string ChangeLocale = "ProfileActionChangeLocale";

	private const string BlockUser = "ProfileActionBlockUser";

	private const string UnBlockUser = "ProfileActionUnBlockUser";

	private const string LanguageSelectPopup = "LanguageSettingsPopup";

	private const string VCard = "ProfileActionGetVCard";

	public UserProfileToolbarButton(ISecurityService securityService, ActionDispatcherService actionDispatcherService, ContentDispatchActionService contentDispatchActionService)
	{
		this.securityService = securityService;
		this.actionDispatcherService = actionDispatcherService;
		this.contentDispatchActionService = contentDispatchActionService;
	}

	public IEnumerable<IActionItem> GetItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		EleWise.ELMA.Security.Models.IUser user = htmlHelper.GetUserFromModel();
		if (user != null)
		{
			yield return CreateVCardButton(htmlHelper, user);
			if (user.AllowChangePassword())
			{
				yield return ChangePasswordButton(htmlHelper, user);
			}
			EleWise.ELMA.Security.Models.IUser currUser = htmlHelper.GetCurrentUser();
			bool flag = securityService.HasPermission(PermissionProvider.ReplacementOwnPermission);
			if (securityService.HasPermission(PermissionProvider.ReplacementUsePermission))
			{
				yield return CreateReplacementButton(htmlHelper, user, hasReplacementOwnPermission: false);
			}
			else if (flag && currUser.Id == user.Id)
			{
				yield return CreateReplacementButton(htmlHelper, user, hasReplacementOwnPermission: true);
			}
			bool flag2 = securityService.HasPermission(PermissionProvider.AbsenceOwnPermission);
			if (securityService.HasPermission(PermissionProvider.AbsenceUsePermission) || flag2)
			{
				yield return SetAbsenceButton(htmlHelper, user, flag2 && currUser.Id == user.Id);
			}
			if (SR.GetCultureNames().Count((CultureInfo l) => l.Name != SR.KeyCultureInfo.Name) > 0)
			{
				yield return ChangeLanguageButton(htmlHelper, user);
			}
			if (actionDispatcherService.CheckAction((UserManager m) => m.Block(user)))
			{
				yield return BlockUserButton(htmlHelper, user);
			}
			if (actionDispatcherService.CheckAction((UserManager m) => m.UnBlock(user)))
			{
				yield return UnBlockUserButton(htmlHelper, user);
			}
		}
	}

	public void InsertItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		if (rootItem == null || rootItem.Uid != "DefaultActionsToolbar" || !rootItem.Items.Any((IActionItem item) => item != null && item.Uid == "UserProfileButtonActionsGroup") || !(rootItem.Items.FirstOrDefault((IActionItem item) => item != null && item.Uid == "MoreButtonToolbarGroup") is ActionToolbarGroup actionToolbarGroup))
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

	private ActionToolbarItem CreateVCardButton(HtmlHelper htmlHelper, EleWise.ELMA.Security.Models.IUser user)
	{
		return new ActionToolbarItem("ProfileActionGetVCard")
		{
			Text = SR.T("Экспорт  vCard"),
			IconUrl = "#vCard.svg",
			Url = htmlHelper.Url().Action("GetForUser", "Vcard", (object)new
			{
				area = "EleWise.ELMA.vCard.Web",
				id = user.Uid
			})
		};
	}

	private ActionToolbarItem BlockUserButton(HtmlHelper htmlHelper, EleWise.ELMA.Security.Models.IUser user)
	{
		IAuditEventArgs actionInfoFor = actionDispatcherService.GetActionInfoFor((UserManager m) => m.Block(user));
		if (actionInfoFor != null)
		{
			IContentDispatchAction eventAction = contentDispatchActionService.GetEventAction(actionInfoFor.Object, actionInfoFor.Action);
			string href = eventAction.GetHref(((ControllerContext)htmlHelper.get_ViewContext()).get_RequestContext(), actionInfoFor.ExtendedProperties.Values.ToArray());
			string arg = ((eventAction is IContentDispatchActionWithScriptMethod contentDispatchActionWithScriptMethod && !string.IsNullOrWhiteSpace(contentDispatchActionWithScriptMethod.ScriptMethodName)) ? $"{contentDispatchActionWithScriptMethod.ScriptMethodName}(\"{href}\");" : "window.navigateToUrl(url)");
			string arg2 = htmlHelper.Url().Action("CanBlockUser", "User", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Security",
				Id = user.Id
			});
			eventAction.OnRender(htmlHelper, actionInfoFor.ExtendedProperties.Values.ToArray());
			return new ActionToolbarItem("ProfileActionBlockUser")
			{
				Text = SR.T(eventAction.Name),
				IconUrl = "#admin.svg",
				Click = $"elma.profile.CheckBlock('{arg2}', '{arg}')"
			};
		}
		return null;
	}

	private ActionToolbarItem UnBlockUserButton(HtmlHelper htmlHelper, EleWise.ELMA.Security.Models.IUser user)
	{
		IAuditEventArgs actionInfoFor = actionDispatcherService.GetActionInfoFor((UserManager m) => m.UnBlock(user));
		if (actionInfoFor != null)
		{
			IContentDispatchAction eventAction = contentDispatchActionService.GetEventAction(actionInfoFor.Object, actionInfoFor.Action);
			string href = eventAction.GetHref(((ControllerContext)htmlHelper.get_ViewContext()).get_RequestContext(), actionInfoFor.ExtendedProperties.Values.ToArray());
			string arg = htmlHelper.Url().Action("CanBlockUser", "User", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Security",
				Id = user.Id
			});
			eventAction.OnRender(htmlHelper, actionInfoFor.ExtendedProperties.Values.ToArray());
			return new ActionToolbarItem("ProfileActionUnBlockUser")
			{
				Text = SR.T(eventAction.Name),
				IconUrl = "#unlock.svg",
				Click = $"elma.profile.CheckBlock('{arg}', '{href}')"
			};
		}
		return null;
	}

	private ActionToolbarItem ChangePasswordButton(HtmlHelper htmlHelper, EleWise.ELMA.Security.Models.IUser user)
	{
		return new ActionToolbarItem("ProfileActionChangePassword")
		{
			Text = SR.T("Сменить пароль"),
			IconUrl = "#change.svg",
			Click = ((object)htmlHelper.OpenPopup("ChangePassword", "ClearChangePassword();")).ToString(),
			OnRender = delegate(HtmlHelper html)
			{
				html.RegisterContent("ChangePassword", delegate
				{
					//IL_0026: Unknown result type (might be due to invalid IL or missing references)
					//IL_002b: Unknown result type (might be due to invalid IL or missing references)
					//IL_0040: Expected O, but got Unknown
					HtmlHelper obj = html;
					EleWise.ELMA.Security.Models.IUser user2 = user;
					ViewDataDictionary val = new ViewDataDictionary(htmlHelper.get_ViewData());
					val.Add("id", (object)"ChangePassword");
					return PartialExtensions.Partial(obj, "ChangePasswordWindow", (object)user2, val);
				});
			}
		};
	}

	private ActionToolbarItem SetAbsenceButton(HtmlHelper htmlHelper, EleWise.ELMA.Security.Models.IUser user, bool hasAbsenceOwnPermission)
	{
		return new ActionToolbarItem("ProfileActionSetAbsence")
		{
			Text = SR.T("Отсутствия"),
			IconUrl = "#calendar.svg",
			Url = htmlHelper.Url().Action(hasAbsenceOwnPermission ? "OwnIndex" : "Index", "Absence", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Security"
			})
		};
	}

	private ActionToolbarItem CreateReplacementButton(HtmlHelper htmlHelper, EleWise.ELMA.Security.Models.IUser user, bool hasReplacementOwnPermission)
	{
		return new ActionToolbarItem("ProfileActionCreateReplacement")
		{
			Text = SR.T("Замещения"),
			IconUrl = "#replacement.svg",
			Url = htmlHelper.Url().Action(hasReplacementOwnPermission ? "OwnIndex" : "Index", "Replacement", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Security"
			})
		};
	}

	private ActionToolbarItem ChangeLanguageButton(HtmlHelper htmlHelper, EleWise.ELMA.Security.Models.IUser user)
	{
		string url = htmlHelper.Url().Action("LanguageSelector", "User", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Security",
			userId = user.Id
		});
		return new ActionToolbarItem("ProfileActionChangeLocale")
		{
			Text = SR.T("Язык интерфейса"),
			IconUrl = "#change.svg",
			Click = ((object)htmlHelper.RefreshPopup("LanguageSettingsPopup", url)).ToString(),
			OnRender = delegate(HtmlHelper html)
			{
				html.RegisterContent("LanguageSettingsPopup", (dynamic h) => html.PopupWindow("LanguageSettingsPopup", SR.T("Выберите язык интерфейса"), (object d) => MvcHtmlString.Create(" ")));
			}
		};
	}
}
