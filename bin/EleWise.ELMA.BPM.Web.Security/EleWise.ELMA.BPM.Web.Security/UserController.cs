using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Security;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Security.Extensions;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.BPM.Web.Security.Portlets;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Components;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Security.Types.Settings;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Binders;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Html.EditableList;
using EleWise.ELMA.Web.Mvc.Models;
using EleWise.ELMA.Web.Mvc.Models.Boxes;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Models.Trees;
using EleWise.ELMA.Web.Mvc.Security;
using EleWise.ELMA.Web.Mvc.Services;
using Newtonsoft.Json;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Security.Controllers;

[RouteArea("EleWise.ELMA.BPM.Web.Security")]
public class UserController : BPMController<EleWise.ELMA.Security.Models.IUser, long>
{
	private Guid userGroupUID = InterfaceActivator.UID<IUserGroup>();

	public OrganizationItemManager OrganizationItemManager { get; set; }

	public AbsenceManager AbsenceManager { get; set; }

	public IPermissionManagmentService PermissionManagmentService { get; set; }

	public UserManager UserManager { get; set; }

	public PersonalGroupManager PersonalGroupManager { get; set; }

	public UserGroupManager UserGroupManager { get; set; }

	public UserCryptoProfileManager UserCryptoProfileManager { get; set; }

	public UserSecurityProfileManager UserSecurityProfileManager { get; set; }

	public ReplacementManager ReplacementManager { get; set; }

	public EntityUrlResolverService EntityUrlResolverService { get; set; }

	public AuthCryptoProviderService AuthCryptoProviderService { get; set; }

	internal IEnumerable<ICryptoProviderUserProfileWeb> CPUserProfileWebs => ComponentManager.Current.GetExtensionPoints<ICryptoProviderUserProfileWeb>();

	[NotNull]
	public new IUnitOfWorkManager UnitOfWorkManager => Locator.GetServiceNotNull<IUnitOfWorkManager>();

	[ContentItem(Name = "SR.M('Пользователи')", Image24 = "~/Content/IconPack/user.svg")]
	[Permission("DCD48F8C-BC6F-48BE-A9FF-25C4FAB101DC")]
	public ActionResult Index()
	{
		return (ActionResult)(object)((Controller)this).RedirectToAction("List");
	}

	public ActionResult UsersHomePortlet(UsersHomePortletPersonalization settings)
	{
		return (ActionResult)(object)((Controller)this).PartialView("User/UsersHomePortlet", (object)settings);
	}

	public ActionResult CanCreateUser()
	{
		string reason = "";
		bool canCreateNewUser = ((UserManager)base.Manager).CanCreateNewUser(out reason);
		return (ActionResult)(object)((Controller)this).Json((object)new { canCreateNewUser, reason });
	}

	public ActionResult CanUnBlockUser()
	{
		string reason = "";
		bool canUnBlockUser = ((UserManager)base.Manager).CanUnBlockUser(out reason);
		return (ActionResult)(object)((Controller)this).Json((object)new { canUnBlockUser, reason });
	}

	[Permission("2C44BA05-91A6-49E4-89C1-84AC5B371B7F")]
	public ActionResult Create()
	{
		IUserGroupFilter userGroupFilter = InterfaceActivator.Create<IUserGroupFilter>();
		userGroupFilter.AddToNewUser = true;
		IEnumerable<IUserGroup> groups = (from g in UserGroupManager.Find(userGroupFilter, FetchOptions.All)
			where g.TypeUid == Guid.Empty || g.TypeUid == userGroupUID
			select g).Where(delegate(IUserGroup g)
		{
			uint? maxGroupUsersCount = UserGroupManager.GetMaxGroupUsersCount(g);
			return !maxGroupUsersCount.HasValue || maxGroupUsersCount.Value > ((ICollection<EleWise.ELMA.Security.Models.IUser>)g.Users).Count;
		});
		EditUserModel editUserModel = new EditUserModel
		{
			User = InterfaceActivator.Create<EleWise.ELMA.Security.Models.IUser>(),
			Groups = groups
		};
		editUserModel.OrganizationText = editUserModel.GetOrganizationText();
		editUserModel.TimeZone = TZ.ServerTimeZone.GetHashCode().ToString();
		return (ActionResult)(object)((Controller)this).View("Create", (object)editUserModel);
	}

	protected void SaveUserModel(EditUserModel model, EditableListModel groups)
	{
		SaveUserModel(model, groups, forceSaveGroups: false);
	}

	private void SaveUserModel(EditUserModel model, EditableListModel groups, bool forceSaveGroups)
	{
		if (int.TryParse(model.TimeZone, out var targetTimeZoneHashCode))
		{
			if (targetTimeZoneHashCode == TZ.ServerTimeZone.GetHashCode())
			{
				model.User.TimeZoneData = null;
			}
			else
			{
				TimeZoneModel timeZoneModel = TZ.TimeZones.FirstOrDefault((TimeZoneModel tz) => tz.GetHashCode() == targetTimeZoneHashCode);
				if (timeZoneModel != null)
				{
					model.User.TimeZoneData = timeZoneModel.ToJson();
				}
			}
		}
		if ((forceSaveGroups || base.SecurityService.HasPermission(PermissionProvider.AccessManagmentPermission)) && groups != null && groups.Items != null)
		{
			((UserManager)base.Manager).SaveUserWithGroups(model.User, model.Password, groups.Items.Select((EditableListItem i) => i.Value.FromJson<long>()), (IUserGroup g) => g.TypeUid == Guid.Empty || g.TypeUid == userGroupUID);
		}
		else
		{
			((UserManager)base.Manager).Save(model.User, model.Password);
		}
		JsonSerializer jsonSerializer = new JsonSerializer();
		if (base.SecurityService.HasPermission(PermissionProvider.UserManagmentPermission) && model.User != null && !string.IsNullOrWhiteSpace(model.OrganizationJson) && !model.User.IsNew())
		{
			List<IOrganizationItem> organizationItems = (from pm in (PermissionModel[])jsonSerializer.Deserialize(model.OrganizationJson, typeof(PermissionModel[]))
				where pm.ObjectType == PermissionObjectType.Organization
				select OrganizationItemManager.Load(pm.Id)).ToList();
			model.User.SetAppointments(organizationItems);
		}
		if (model.NotificationFlowSettings != null && model.User != null)
		{
			model.NotificationFlowSettings.ForEach(delegate(NotificationFlowSettings a)
			{
				a.Name = (string.IsNullOrWhiteSpace(a.Name) ? null : a.Name);
			});
			Locator.GetServiceNotNull<IBLOBStore>().Save($"UserNotificationSettings_{model.User.Id}", ClassSerializationHelper.SerializeObject(model.NotificationFlowSettings));
		}
	}

	private MvcHtmlString UserNameAlreadyExistsExceptionMessage(UserNameAlreadyExistsException ex)
	{
		string text = ex.Message.HtmlEncode();
		string text2 = "";
		if (ex.Users != null)
		{
			text2 = (from EleWise.ELMA.Security.Models.IUser u in ex.Users
				select string.Format("<a href=\"javascript: showUserInfo('{0}')\">{2}{1}</a>", u.Id, u.UserName.HtmlEncode(), HtmlExtensions.Image(((Controller)this).get_Url().ObjectIcon(ObjectIconFormat.x16, u.Status), new
				{
					alt = ModelHelper.GetEnumDisplayName(u.Status)
				}))).ToCommaSeparatedString();
			if (!string.IsNullOrEmpty(text2))
			{
				text2 = ": <br>" + text2;
			}
		}
		return MvcHtmlString.Create(text + text2);
	}

	[HttpPost]
	[Permission("2C44BA05-91A6-49E4-89C1-84AC5B371B7F")]
	[TransactionAction]
	public ActionResult Create(EditUserModel model, EditableListModel groups)
	{
		if (groups == null)
		{
			groups = new EditableListModel();
		}
		bool forceSaveGroups = false;
		if (groups.Items == null || !base.SecurityService.HasPermission(PermissionProvider.AccessManagmentPermission))
		{
			IUserGroupFilter userGroupFilter = InterfaceActivator.Create<IUserGroupFilter>();
			userGroupFilter.AddToNewUser = true;
			groups.Items = from g in (from g in UserGroupManager.Find(userGroupFilter, FetchOptions.All)
					where g.TypeUid == Guid.Empty || g.TypeUid == userGroupUID
					select g).Where(delegate(IUserGroup g)
				{
					uint? maxGroupUsersCount2 = UserGroupManager.GetMaxGroupUsersCount(g);
					return !maxGroupUsersCount2.HasValue || maxGroupUsersCount2.Value > ((ICollection<EleWise.ELMA.Security.Models.IUser>)g.Users).Count;
				})
				select new EditableListItem
				{
					Value = g.Id.ToString()
				};
			forceSaveGroups = true;
		}
		if (((Controller)this).get_ModelState().get_IsValid())
		{
			try
			{
				foreach (IUserSettingsModelHandler extensionPoint in ComponentManager.Current.GetExtensionPoints<IUserSettingsModelHandler>())
				{
					extensionPoint.Process(model.User, model.Settings);
				}
				string text = (model.Password.IsNullOrEmpty() ? "" : model.Password);
				Pair<bool, string> pair = PasswordChangeHelper.ValidatePassword(model.User, null, text, text);
				if (!pair.First)
				{
					throw new Exception(pair.Second);
				}
				SaveUserModel(model, groups, forceSaveGroups);
				return (ActionResult)(object)((Controller)this).RedirectToAction("List");
			}
			catch (UserNameAlreadyExistsException ex)
			{
				UnitOfWorkManager.RollbackCurrent(string.Empty);
				base.Notifier.Error(UserNameAlreadyExistsExceptionMessage(ex));
			}
			catch (Exception exception)
			{
				UnitOfWorkManager.RollbackCurrent(string.Empty);
				FormNotifierExtensions.Error(base.Notifier, exception);
			}
		}
		if (groups != null && groups.Items != null)
		{
			long[] array = groups.Items.Select((EditableListItem i) => i.Value.FromJson<long>()).ToArray();
			ICollection<IUserGroup> userGroups = UserGroupManager.FindByIdArray(array);
			model.Groups = (from id in array
				select userGroups.FirstOrDefault((IUserGroup g) => g.Id == id) into g
				where g != null && (g.TypeUid == Guid.Empty || g.TypeUid == userGroupUID)
				select g).Where(delegate(IUserGroup g)
			{
				uint? maxGroupUsersCount = UserGroupManager.GetMaxGroupUsersCount(g);
				return !maxGroupUsersCount.HasValue || maxGroupUsersCount.Value > ((ICollection<EleWise.ELMA.Security.Models.IUser>)g.Users).Count;
			});
		}
		return (ActionResult)(object)((Controller)this).View((object)model);
	}

	[Permission("2C44BA05-91A6-49E4-89C1-84AC5B371B7F")]
	public ActionResult Edit(long? id)
	{
		if (!id.HasValue)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("List");
		}
		EleWise.ELMA.Security.Models.IUser user = base.Manager.LoadOrNull(id.Value);
		long[] ids = UserGroupManager.GetGroupsByUser(user.Id, recursive: false).ToArray();
		EditUserModel editUserModel = new EditUserModel
		{
			User = user,
			Groups = UserGroupManager.GetGroupsByIds(ids, userGroupUID),
			Settings = InterfaceActivator.Create<IUserSettingsModel>()
		};
		if (editUserModel.User == null)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("List");
		}
		editUserModel.OrganizationText = editUserModel.GetOrganizationText();
		editUserModel.TimeZone = editUserModel.User.TimeZone.GetHashCode().ToString();
		base.ViewTitle = SR.T("Редактирование пользователя {0}", editUserModel.User.GetFullName());
		((ControllerBase)this).get_ViewData().set_Item("self", (object)(GetCurrentUser().Id == editUserModel.User.Id));
		byte[] array = Locator.GetServiceNotNull<IBLOBStore>().LoadOrNull($"UserNotificationSettings_{id}");
		if (array != null)
		{
			try
			{
				editUserModel.NotificationFlowSettings = ClassSerializationHelper.DeserializeObject(array) as NotificationFlowSettings[];
			}
			catch
			{
			}
		}
		return (ActionResult)(object)((Controller)this).View("Edit", (object)editUserModel);
	}

	[HttpPost]
	[Permission("2C44BA05-91A6-49E4-89C1-84AC5B371B7F")]
	[TransactionAction]
	public ActionResult Edit(EditUserModel model, EditableListModel groups)
	{
		if (((Controller)this).get_ModelState().get_IsValid())
		{
			try
			{
				foreach (IUserSettingsModelHandler extensionPoint in ComponentManager.Current.GetExtensionPoints<IUserSettingsModelHandler>())
				{
					extensionPoint.Process(model.User, model.Settings);
				}
				SaveUserModel(model, groups);
				return (ActionResult)(object)((Controller)this).RedirectToAction("Profile", (object)new
				{
					id = model.User.Id
				});
			}
			catch (UserNameAlreadyExistsException ex)
			{
				UnitOfWorkManager.RollbackCurrent(string.Empty);
				base.Notifier.Error(UserNameAlreadyExistsExceptionMessage(ex));
			}
			catch (Exception exception)
			{
				UnitOfWorkManager.RollbackCurrent(string.Empty);
				FormNotifierExtensions.Error(base.Notifier, exception);
			}
		}
		if (groups != null && groups.Items != null)
		{
			long[] array = groups.Items.Select((EditableListItem i) => i.Value.FromJson<long>()).ToArray();
			ICollection<IUserGroup> userGroups = UserGroupManager.FindByIdArray(array);
			model.Groups = (from id in array
				select userGroups.FirstOrDefault((IUserGroup g) => g.Id == id) into g
				where g != null && (g.TypeUid == Guid.Empty || g.TypeUid == userGroupUID)
				select g).Where(delegate(IUserGroup g)
			{
				uint? maxGroupUsersCount = UserGroupManager.GetMaxGroupUsersCount(g);
				return !maxGroupUsersCount.HasValue || maxGroupUsersCount.Value > ((ICollection<EleWise.ELMA.Security.Models.IUser>)g.Users).Count;
			});
		}
		((ControllerBase)this).get_ViewData().set_Item("self", (object)(GetCurrentUser().Id == model.User.Id));
		return (ActionResult)(object)((Controller)this).View((object)model);
	}

	[Permission("90A5014F-1DB1-4BF7-9DC3-AA059114BCB0", Inverse = true)]
	public ActionResult CurrentEdit()
	{
		return Edit(GetCurrentUser().Id);
	}

	[HttpPost]
	[Permission("90A5014F-1DB1-4BF7-9DC3-AA059114BCB0", Inverse = true)]
	[TransactionAction]
	public ActionResult CurrentEdit(EditUserModel model, EditableListModel groups)
	{
		EleWise.ELMA.Security.Models.IUser currentUser = GetCurrentUser();
		if (model.User == null || currentUser == null)
		{
			base.Notifier.Error(SR.T("Не определен текущий пользователь"));
			return (ActionResult)(object)((Controller)this).RedirectToAction("CurrentProfile");
		}
		if (model.User.Id != currentUser.Id)
		{
			base.Notifier.Error(SR.T("Невозможно редактирование чужого профиля"));
			return (ActionResult)(object)((Controller)this).RedirectToAction("CurrentProfile");
		}
		if (((Controller)this).get_ModelState().get_IsValid())
		{
			try
			{
				foreach (IUserSettingsModelHandler extensionPoint in ComponentManager.Current.GetExtensionPoints<IUserSettingsModelHandler>())
				{
					extensionPoint.Process(model.User, model.Settings);
				}
				SaveUserModel(model, groups);
				((Controller)this).get_Response().Cookies.Remove("ElmaUserTimeZoneOffset");
				HttpCookie httpCookie = new HttpCookie("ElmaUserTimeZoneOffset");
				httpCookie.Value = model.User.TimeZone.Offset.ToString();
				((Controller)this).get_Response().Cookies.Add(httpCookie);
				return (ActionResult)(object)((Controller)this).RedirectToAction("CurrentProfile");
			}
			catch (Exception exception)
			{
				UnitOfWorkManager.RollbackCurrent(string.Empty);
				FormNotifierExtensions.Error(base.Notifier, exception);
			}
		}
		if (groups != null && groups.Items != null)
		{
			long[] array = groups.Items.Select((EditableListItem i) => i.Value.FromJson<long>()).ToArray();
			ICollection<IUserGroup> userGroups = UserGroupManager.FindByIdArray(array);
			model.Groups = (from id in array
				select userGroups.FirstOrDefault((IUserGroup g) => g.Id == id) into g
				where g != null && (g.TypeUid == Guid.Empty || g.TypeUid == userGroupUID)
				select g).Where(delegate(IUserGroup g)
			{
				uint? maxGroupUsersCount = UserGroupManager.GetMaxGroupUsersCount(g);
				return !maxGroupUsersCount.HasValue || maxGroupUsersCount.Value > ((ICollection<EleWise.ELMA.Security.Models.IUser>)g.Users).Count;
			});
		}
		((ControllerBase)this).get_ViewData().set_Item("self", (object)true);
		return (ActionResult)(object)((Controller)this).View("Edit", (object)model);
	}

	public ActionResult AssignGroups()
	{
		IEnumerable<IUserGroup> enumerable = UserGroupManager.FindAll().Where(delegate(IUserGroup g)
		{
			uint? maxGroupUsersCount = UserGroupManager.GetMaxGroupUsersCount(g);
			return !maxGroupUsersCount.HasValue || maxGroupUsersCount.Value > UserGroupManager.GetLicensedGroupUsers((IEnumerable)g.Users);
		});
		return (ActionResult)(object)((Controller)this).PartialView((object)enumerable);
	}

	[EntityListLink(typeof(EleWise.ELMA.Security.Models.IUser))]
	[Permission("DCD48F8C-BC6F-48BE-A9FF-25C4FAB101DC")]
	public ActionResult List()
	{
		try
		{
			if (((EleWise.ELMA.Security.Models.IUser)Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser()).Uid == SecurityConstants.AdminUserUid)
			{
				List<string> list = ((UserManager)base.Manager).CheckDuplicateUserName();
				if (list.Any())
				{
					string s = SR.T("В системе присутствуют пользователи с одинаковыми логинами");
					string s2 = string.Join(", ", list.ToArray());
					base.Notifier.Warning(MvcHtmlString.Create(string.Format("{0}. {2}: <br> {1}", s.HtmlEncode(), s2.HtmlEncode(), SR.T("Для предотвращения конфликтов следует переименовать дублирующиеся учетные записи").HtmlEncode())));
				}
			}
		}
		catch (Exception ex)
		{
			EleWise.ELMA.Logging.Logger.Log.Warn($"CheckDuplicateUserName Error: {ex.Message}");
		}
		return (ActionResult)(object)((Controller)this).View();
	}

	[CustomGridAction]
	[Permission("DCD48F8C-BC6F-48BE-A9FF-25C4FAB101DC")]
	public ActionResult Grid(GridCommand command, [Bind(Prefix = "DataFilter")] IUserFilter filter, long? orgItemId)
	{
		if (filter == null)
		{
			filter = InterfaceActivator.Create<IUserFilter>();
			filter.OrganizationItemFindMode = OrganizationItemFindMode.ByItem;
			if (orgItemId.HasValue)
			{
				filter.OrganizationItem = OrganizationItemManager.LoadOrNull(orgItemId.Value);
			}
		}
		GridData<EleWise.ELMA.Security.Models.IUser, IUserFilter> gridData = CreateGridData(command, filter);
		return (ActionResult)(object)((Controller)this).PartialView((object)gridData);
	}

	[HttpGet]
	public ActionResult LanguageSelector(long userId)
	{
		EleWise.ELMA.Security.Models.IUser user = base.Manager.LoadOrNull(userId);
		ILocalizationService serviceNotNull = Locator.GetServiceNotNull<ILocalizationService>();
		string selectedCulture = ((user == null) ? serviceNotNull.Load().Name : serviceNotNull.Load(user).Name);
		LanguageSelectorModel languageSelectorModel = new LanguageSelectorModel
		{
			SelectedCulture = selectedCulture,
			UserId = userId
		};
		return (ActionResult)(object)((Controller)this).PartialView("Editors/LanguageSelector", (object)languageSelectorModel);
	}

	[HttpPost]
	public ActionResult SaveLanguage(LanguageSelectorModel model)
	{
		EleWise.ELMA.Security.Models.IUser user = base.Manager.LoadOrNull(model.UserId);
		EleWise.ELMA.Security.Models.IUser currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		ILocalizationService serviceNotNull = Locator.GetServiceNotNull<ILocalizationService>();
		if (user == null || user.Id == currentUser.Id)
		{
			serviceNotNull.Save(new CultureInfo(model.SelectedCulture));
		}
		else
		{
			if (!base.SecurityService.HasPermission(PermissionProvider.UserManagmentPermission))
			{
				throw new SecurityException(SR.T("Отсутствует привилегия \"{0}\"", PermissionProvider.UserManagmentPermission.Name));
			}
			serviceNotNull.Save(new CultureInfo(model.SelectedCulture), user);
		}
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl());
	}

	private ActionResult RequireParameter<T>(T value, string name, Func<T, ActionResult> hasParameter)
	{
		if (!EqualityComparer<T>.Default.Equals(value, default(T)))
		{
			return hasParameter(value);
		}
		return ErrorJson(SR.T("Обязательный параметр '{0}' отсутствовал в форме запроса", name));
	}

	private ICollection<IOrganizationItem> ParseOrganizationItems(string json, PermissionObjectType objectType = PermissionObjectType.Organization)
	{
		JsonSerializer jsonSerializer = new JsonSerializer();
		return OrganizationItemManager.FindByIdArray((from pm in jsonSerializer.Deserialize<PermissionModel[]>(json)
			where pm.ObjectType == objectType
			select pm.Id).ToArray());
	}

	[HttpPost]
	public ActionResult SaveAuthCryptoProvider(CryptoProviderSelectorModel model)
	{
		EleWise.ELMA.Security.Models.IUser user = base.Manager.LoadOrNull(model.UserId);
		Guid selectedProviderUid = model.SelectedProviderUid;
		Guid digitalSignatureTypeUid = model.SelectedDigitalSignatureTypeUid;
		bool num = selectedProviderUid == Guid.Empty;
		bool flag = digitalSignatureTypeUid == Guid.Empty;
		if (num)
		{
			if (!flag)
			{
				throw new Exception(SR.T("Для криптопровайдера по умолчанию должен быть установлен тип электронной подписи по умолчанию"));
			}
		}
		else if (!AuthCryptoProviderService.GetDigitalSignatureTypesByProviderUid(selectedProviderUid).Any((IDigitalSignatureType t) => t.Uid == digitalSignatureTypeUid))
		{
			throw new Exception(SR.T("Выбранный тип электронной подписи не поддерживается выбранным криптопровайдером"));
		}
		if (user != null)
		{
			UserCryptoProfileManager.SetUserAuthCryptoProviderUid(user, model.SelectedProviderUid);
			UserCryptoProfileManager.SetUserAuthDigitalSignatureTypeUid(user, model.SelectedDigitalSignatureTypeUid);
		}
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl());
	}

	public ActionResult CryptoProviderUserProfileEdit(Guid? providerUid, long? userId)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		if (!providerUid.HasValue || !userId.HasValue)
		{
			return (ActionResult)new EmptyResult();
		}
		ICryptoProviderUserProfileWeb cryptoProviderUserProfileWeb = CPUserProfileWebs.FirstOrDefault((ICryptoProviderUserProfileWeb p) => p.ProviderUid == providerUid.Value);
		if (cryptoProviderUserProfileWeb == null)
		{
			return (ActionResult)new EmptyResult();
		}
		EleWise.ELMA.Security.Models.IUser user = UserManager.LoadOrNull(userId.Value);
		if (user == null)
		{
			return (ActionResult)new EmptyResult();
		}
		return (ActionResult)(object)((Controller)this).Content(((object)cryptoProviderUserProfileWeb.RenderEdit(GetHtmlHelper(), user)).ToString());
	}

	[HttpPost]
	[Permission("2C44BA05-91A6-49E4-89C1-84AC5B371B7F")]
	public ActionResult SaveUserOrganization(long objectId, string json)
	{
		return RequireParameter(json, LinqUtils.NameOf((Expression<Func<object, object>>)((object x) => json)), delegate(string value)
		{
			EleWise.ELMA.Security.Models.IUser user = base.Manager.LoadOrNull(objectId);
			user?.SetAppointments(ParseOrganizationItems(value));
			return (ActionResult)((user != null) ? ((object)((Controller)this).Json((object)new { }, (JsonRequestBehavior)0)) : ((object)ErrorJson(SR.T("Пользователь с указанным id не найден"))));
		});
	}

	[HttpPost]
	[Permission("2C44BA05-91A6-49E4-89C1-84AC5B371B7F")]
	public ActionResult SetUserOrganization(string json)
	{
		return RequireParameter(json, LinqUtils.NameOf((Expression<Func<object, object>>)((object x) => json)), delegate(string jsonText)
		{
			string text = string.Join(", ", from o in ParseOrganizationItems(jsonText)
				select o.Name into x
				orderby x
				select x);
			if (string.IsNullOrEmpty(text))
			{
				bool flag = base.SecurityService.HasPermission(PermissionProvider.UserManagmentPermission);
				text = string.Format("---{0}", flag ? SR.T("Назначить") : "");
			}
			else
			{
				text = text.HtmlEncode();
			}
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				positionText = text,
				jsonText = jsonText
			}, "text/html", (JsonRequestBehavior)0);
		});
	}

	public ActionResult ContactInfoEditor(long? id)
	{
		if (!id.HasValue)
		{
			return (ActionResult)(object)((Controller)this).PartialView("Editors/ContactInfoEditor");
		}
		return (ActionResult)(object)((Controller)this).PartialView("Editors/ContactInfoEditor", (object)base.Manager.Load(id.Value));
	}

	public ActionResult DocumentPersonalEditor(long? id)
	{
		if (!id.HasValue)
		{
			return (ActionResult)(object)((Controller)this).PartialView("Editors/DocumentPersonalEditor");
		}
		return (ActionResult)(object)((Controller)this).PartialView("Editors/DocumentPersonalEditor", (object)base.Manager.Load(id.Value));
	}

	public ActionResult TaskPersonalEditor(long? id)
	{
		EleWise.ELMA.Security.Models.IUser user = (id.HasValue ? base.Manager.Load(id.Value) : null);
		return (ActionResult)(object)((Controller)this).PartialView("Editors/TaskPersonalEditor", (object)user);
	}

	public ActionResult CanBlockUser(long id)
	{
		if (ReplacementManager.FindPlannedReplacement(null, base.Manager.Load(id), DateTime.Today, null).Count <= 0)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				needConfirm = false,
				denny = false
			});
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			needConfirm = true,
			denny = !base.SecurityService.HasPermission(PermissionProvider.ReplacementUsePermission)
		});
	}

	public ActionResult BlockUser(long? id)
	{
		if (!id.HasValue)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("List");
		}
		EleWise.ELMA.Security.Models.IUser user = base.Manager.LoadOrNull(id.Value);
		if (user == null)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("List");
		}
		IBlockUserModel blockUserModel = InterfaceActivator.Create<IBlockUserModel>();
		blockUserModel.BlockUser = user;
		return (ActionResult)(object)((Controller)this).PartialView((object)blockUserModel);
	}

	[HttpPost]
	[Permission("2C44BA05-91A6-49E4-89C1-84AC5B371B7F")]
	public ActionResult BlockUser(IBlockUserModel model)
	{
		EleWise.ELMA.Security.Models.IUser blockUser = model.BlockUser;
		if (blockUser == null)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("List");
		}
		try
		{
			ComponentManager.Current.GetExtensionPoints<IBlockUserActionExtension>().ForEach(delegate(IBlockUserActionExtension e)
			{
				e.HandleModel(model);
			});
			blockUser.Block();
			base.Notifier.Information(SR.T("Учетная запись пользователя {0} успешно блокирована", blockUser.FullName));
		}
		catch (Exception ex)
		{
			base.Notifier.Error(SR.T("Ошибка при блокировке пользователя {0}. Текст ошибки: {1}", blockUser.FullName, ex.Message));
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Profile", new RouteValueDictionary { { "id", blockUser.Id } });
	}

	[HttpPost]
	[Permission("2C44BA05-91A6-49E4-89C1-84AC5B371B7F")]
	public ActionResult UnBlockUser(long? id)
	{
		if (!id.HasValue)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("List");
		}
		EleWise.ELMA.Security.Models.IUser user = base.Manager.LoadOrNull(id.Value);
		if (user == null)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("List");
		}
		try
		{
			user.UnBlock();
			base.Notifier.Information(SR.T("Учетная запись пользователя {0} успешно разблокирована", user.FullName));
		}
		catch (Exception ex)
		{
			base.Logger.Error("UnBlockUser error", ex);
			Exception ex2 = ex;
			while (ex2 is TargetInvocationException && ex2.InnerException != null)
			{
				ex2 = ex2.InnerException;
			}
			base.Notifier.Error(SR.T("Не удалось разблокировать пользователя {0}. Текст ошибки: {1}", user.FullName, ex2.Message));
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Profile", new RouteValueDictionary { { "id", id } });
	}

	public ActionResult Profile(string id)
	{
		EleWise.ELMA.Security.Models.IUser user = GetUser(id);
		if (user == null)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("List");
		}
		UserModel userModel = CreateUserModel(user);
		userModel.ShowActions = true;
		return (ActionResult)(object)((Controller)this).View((object)userModel);
	}

	public ActionResult PhotoPartial(long? id, int? width, int? height, string @class = "", string style = "")
	{
		EleWise.ELMA.Security.Models.IUser user = (id.HasValue ? base.Manager.LoadOrNull(id) : null);
		((ControllerBase)this).get_ViewData().Add("width", (object)(width.HasValue ? width.Value : 120));
		((ControllerBase)this).get_ViewData().Add("height", (object)(height.HasValue ? height.Value : 120));
		((ControllerBase)this).get_ViewData().Add("class", (object)@class);
		((ControllerBase)this).get_ViewData().Add("style", (object)style);
		return (ActionResult)(object)((Controller)this).PartialView("User/Photo", (object)user);
	}

	[AuthenticationFilter(NotRequired = true)]
	public ActionResult Photo(long id, string uid)
	{
		EleWise.ELMA.Security.Models.IUser user = base.Manager.Load(id);
		try
		{
			if (user.Photo != null && !string.IsNullOrEmpty(user.Photo.Name) && user.Photo.ContentLocation != null)
			{
				bool flag = uid == user.Photo.Uid.ToString("N");
				if (!flag)
				{
					flag = base.AuthenticationService.GetCurrentUser() != null;
				}
				if (flag)
				{
					return (ActionResult)(object)File(user.Photo, new BinaryFileCachingOptions
					{
						MaxAge = TimeSpan.FromDays(30.0)
					});
				}
			}
		}
		catch (Exception exception)
		{
			base.Logger.Warn(SR.T("Ошибка получения файла профиля. Id = {0}, Uid = {1}", id, uid), exception);
		}
		return (ActionResult)(object)((Controller)this).Redirect("~/Content/IconPack/no_photo.svg");
	}

	private UserModel CreateUserModel(EleWise.ELMA.Security.Models.IUser user, bool needManagment = true)
	{
		IAbsence todayAbsence = AbsenceManager.GetTodayAbsence(user);
		UserModel userModel = new UserModel
		{
			User = user
		};
		if (todayAbsence == null)
		{
			userModel.IsAbsence = false;
		}
		else
		{
			userModel.IsAbsence = true;
			userModel.DateEndAbsence = todayAbsence.EndDate;
		}
		if (user.ReplacementMode != 0)
		{
			userModel.IsReplacement = true;
			userModel.ReplacementUser = user.ReplacementUser;
			userModel.CurrentReplacement = ReplacementManager.FindPlannedReplacement(user, user.ReplacementUser, DateTime.Today, null).FirstOrDefault();
		}
		userModel.IsCurrentProfile = user == GetCurrentUser();
		userModel.HasUserManagmentPermission = base.SecurityService.HasPermission(PermissionProvider.UserManagmentPermission);
		userModel.TrustedDevicesManagementPermission = base.SecurityService.HasPermission(PermissionProvider.TrustedDevicesManagementPermission);
		userModel.CanEdit = (userModel.IsCurrentProfile ? (!base.SecurityService.HasPermission(PermissionProvider.DenyEditPersonalDataPermission)) : userModel.HasUserManagmentPermission);
		userModel.IsDisallowLogon = UserSecurityProfileManager.Load(user).DisallowLogon;
		if (needManagment && base.SecurityService.HasPermission(PermissionProvider.AccessManagmentPermission))
		{
			userModel.ShowGroups = true;
			long[] ids = UserGroupManager.GetGroupsByUser(user.Id).ToArray();
			userModel.Groups = UserGroupManager.GetGroupsByIds(ids, userGroupUID).ToArray();
			userModel.UserGroups = UserGroupManager.GetGroupsByUser(user.Id, recursive: false).ToArray();
			userModel.ShowPermissions = true;
			Permission[] array2 = (userModel.Permissions = (from p in PermissionManagmentService.GetPermissions()
				where p.PermissionType == PermissionType.Global && base.SecurityService.HasPermission(user, p)
				select p).ToArray());
		}
		userModel.Blocks = ComponentManager.Current.GetExtensionPoints<IProfileBlockInfoProvider>().ToList();
		return userModel;
	}

	public ActionResult CurrentProfile()
	{
		EleWise.ELMA.Security.Models.IUser currentUser = GetCurrentUser();
		EleWise.ELMA.Security.Models.IUser user = base.Manager.Load(currentUser.Id);
		UserModel userModel = CreateUserModel(user);
		userModel.ShowActions = true;
		userModel.IsCurrentProfile = true;
		return (ActionResult)(object)((Controller)this).View("Profile", (object)userModel);
	}

	[HttpGet]
	public ActionResult SimpleProfileInfo(string id)
	{
		EleWise.ELMA.Security.Models.IUser user = GetUser(id);
		if (user == null)
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		return (ActionResult)(object)((Controller)this).PartialView("User/Views/SimpleProfile", (object)CreateUserModel(user, needManagment: false));
	}

	[HttpGet]
	public ActionResult ProfileInfo(string id)
	{
		EleWise.ELMA.Security.Models.IUser user = GetUser(id);
		if (user == null)
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		UserModel userModel = CreateUserModel(user, needManagment: false);
		return (ActionResult)(object)((Controller)this).PartialView("User/Views/Profile", (object)userModel);
	}

	[HttpPost]
	public ActionResult ChangePassword(EleWise.ELMA.Security.Models.IUser user, string curPassword, string newPassword, string confirmPassword)
	{
		Pair<bool, string> pair = PasswordChangeHelper.ChangePassword(user, curPassword, newPassword, confirmPassword);
		if (pair.First)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = true
			}, (JsonRequestBehavior)1);
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = false,
			error = pair.Second
		}, (JsonRequestBehavior)1);
	}

	public ActionResult ChangePassword(long id, string popupId)
	{
		EleWise.ELMA.Security.Models.IUser user = base.Manager.Load(id);
		((ControllerBase)this).get_ViewData().set_Item("id", (object)popupId);
		return (ActionResult)(object)((Controller)this).PartialView("Editors/ChangePassword", (object)user);
	}

	[Permission("C34E0E87-C1FB-4407-9802-ABE6E9BC7B7D")]
	public ActionResult TrustedDevicesCurrentEdit()
	{
		EleWise.ELMA.Security.Models.IUser user = (EleWise.ELMA.Security.Models.IUser)base.AuthenticationService.GetCurrentUser();
		return TrustedDevicesEdit(user.Id);
	}

	[AllPermissions(new string[] { "2C44BA05-91A6-49E4-89C1-84AC5B371B7F", "C34E0E87-C1FB-4407-9802-ABE6E9BC7B7D" })]
	public ActionResult TrustedDevicesEdit(long id)
	{
		EleWise.ELMA.Security.Models.IUser user = base.Manager.Load(id);
		return (ActionResult)(object)((Controller)this).View("TrustedDevicesEdit", (object)new UserTrustedDevicesModel(((Controller)this).get_HttpContext(), user, AuthCryptoProviderService.GetUserProviderUid(user)));
	}

	[Permission("2C44BA05-91A6-49E4-89C1-84AC5B371B7F")]
	public ActionResult SetForcedChangePassword(long? id)
	{
		if (!id.HasValue)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("List");
		}
		EleWise.ELMA.Security.Models.IUser user = base.Manager.LoadOrNull(id.Value);
		if (user == null)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("List");
		}
		string text = string.Empty;
		try
		{
			UserSecurityProfileManager.SetForcedChangePassword(user);
		}
		catch (Exception ex)
		{
			text = SR.T("Не удалось установить принудительную смену пароля для пользователя {0}. Текст ошибки: {1}", user.FullName, ex.Message);
			base.Logger.Error(text);
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = string.IsNullOrEmpty(text),
			error = text
		});
	}

	[Permission("2C44BA05-91A6-49E4-89C1-84AC5B371B7F")]
	public ActionResult ResetForcedChangePassword(long? id)
	{
		if (!id.HasValue)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("List");
		}
		EleWise.ELMA.Security.Models.IUser user = base.Manager.LoadOrNull(id.Value);
		if (user == null)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("List");
		}
		string text = string.Empty;
		try
		{
			UserSecurityProfileManager.ResetForcedChangePassword(user);
		}
		catch (Exception ex)
		{
			text = SR.T("Не удалось сбросить принудительную смену пароля для пользователя {0}. Текст ошибки: {1}", user.FullName, ex.Message);
			base.Logger.Error(text);
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = string.IsNullOrEmpty(text),
			error = text
		});
	}

	[Permission("2C44BA05-91A6-49E4-89C1-84AC5B371B7F")]
	public ActionResult AllowLogon(long userId)
	{
		EleWise.ELMA.Security.Models.IUser user = base.Manager.LoadOrNull(userId);
		if (user != null)
		{
			UserSecurityProfileManager.AllowLogon(user);
			base.Notifier.Information(SR.T("Вход для учетной записи пользователя {0} успешно разблокирован", user.FullName));
		}
		else
		{
			base.Notifier.Warning(SR.T("Не удалось разблокировать вход пользователя в систему"));
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Profile", new RouteValueDictionary { { "id", userId } });
	}

	private EleWise.ELMA.Security.Models.IUser GetUser(string id)
	{
		if (id.IsNullOrEmpty())
		{
			return null;
		}
		EleWise.ELMA.Security.Models.IUser user = null;
		if (long.TryParse(id, out var result))
		{
			return base.Manager.LoadOrNull(result);
		}
		if (Guid.TryParse(id, out var result2))
		{
			return base.Manager.LoadOrNull(result2);
		}
		return UserManager.LoadByLogin(id);
	}

	[Permission("DCD48F8C-BC6F-48BE-A9FF-25C4FAB101DC")]
	public ActionResult OrganizationTree()
	{
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		FetchOptions all = FetchOptions.All;
		all.FetchRelations = new List<string>
		{
			LinqUtils.NameOf((Expression<Func<IOrganizationItem, object>>)((IOrganizationItem i) => i.ParentItem)),
			LinqUtils.NameOf((Expression<Func<IOrganizationItem, object>>)((IOrganizationItem i) => i.Users))
		};
		ICollection<IOrganizationItem> items = OrganizationItemManager.Find(all);
		IOrganizationItem arg = items.First((IOrganizationItem i) => i.ParentItem == null);
		UrlHelper url = new UrlHelper(((ControllerBase)this).get_ControllerContext().get_RequestContext());
		Func<EleWise.ELMA.Security.Models.IUser, TreeMenuNode> makeUserNode = (EleWise.ELMA.Security.Models.IUser u) => new TreeMenuNode
		{
			id = u.Id.ToString(),
			text = u.FirstName + " " + u.LastName,
			Checked = false,
			checkable = false,
			href = url.Entity(u),
			icon = url.UserPhotoUrl(u, 32)
		};
		Func<IOrganizationItem, TreeMenuNode> makeNode = null;
		makeNode = delegate(IOrganizationItem i)
		{
			IEnumerable<TreeMenuNode> enumerable = from item in items
				where item.ParentItem == i
				select makeNode(item);
			ICollection<EleWise.ELMA.Security.Models.IUser> users = (ICollection<EleWise.ELMA.Security.Models.IUser>)i.Users;
			ICollection<EleWise.ELMA.Security.Models.IUser> collection = users ?? new List<EleWise.ELMA.Security.Models.IUser>();
			if (i.User != null)
			{
				TreeMenuNode treeMenuNode = makeUserNode(i.User);
				treeMenuNode.children = ((IEnumerable<EleWise.ELMA.Security.Models.IUser>)i.Users).Select(makeUserNode).ToList();
				enumerable = new TreeMenuNode[1] { treeMenuNode }.Union(enumerable);
			}
			else if (collection.Count > 0)
			{
				enumerable = collection.Select(makeUserNode).Union(enumerable);
			}
			return new TreeMenuNode
			{
				id = i.Id.ToString(),
				text = i.Name,
				Checked = false,
				checkable = false,
				expanded = (i.ParentItem == null),
				href = null,
				icon = OrgstructItemIcon(i.ItemType),
				children = enumerable.ToList()
			};
		};
		TreeMenuNode item2 = makeNode(arg);
		TreeModel treeModel = new TreeModel
		{
			Id = "UserOrganizationTree",
			Children = new List<TreeMenuNode> { item2 },
			HtmlAttributes = new
			{
				style = "height:auto;overflow: visible"
			},
			SaveState = false,
			HighlightPath = false,
			ShowExpandCollapseButtons = true
		};
		return (ActionResult)(object)((Controller)this).View((object)treeModel);
	}

	private string OrgstructItemIcon(OrganizationItemType itemType)
	{
		return itemType switch
		{
			OrganizationItemType.Department => "#department.svg", 
			OrganizationItemType.NestedStructure => "#company.svg", 
			OrganizationItemType.EmployeeGroup => "#users.svg", 
			_ => "#user.svg", 
		};
	}

	protected IEntity ParseJavaScript(string script, Type entityType)
	{
		try
		{
			IObjectLink objectLink = ComponentManager.Current.GetExtensionPoints<IObjectLink>().FirstOrDefault((IObjectLink l) => l.CheckType(entityType));
			if (objectLink != null)
			{
				IEntityManager entityManager = EntityHelper.GetEntityManager(entityType);
				Match match = Regex.Match(script, "^\\s*(\\w+)\\s*\\((.*)\\)");
				string text = objectLink.Url(((Controller)this).get_Request().RequestContext, entityManager.Create());
				if (text != null)
				{
					text = text.Replace("javascript:", "");
					Match match2 = Regex.Match(text, "^\\s*(\\w+)\\s*\\((.*)\\)");
					if (match.Groups.Count >= 2 && match2.Groups.Count >= 2)
					{
						string value = match.Groups[1].Value;
						string value2 = match2.Groups[1].Value;
						if (value != null && value.Equals(value2, StringComparison.Ordinal) && match.Groups.Count >= 3)
						{
							long num = Convert.ToInt64(match.Groups[2].Value.Replace("'", "").Replace("\"", ""));
							return (IEntity)entityManager.LoadOrNull(num);
						}
					}
				}
			}
		}
		catch (Exception)
		{
		}
		return null;
	}

	public IEntity ParseEntityUrl(string url)
	{
		if (string.IsNullOrEmpty(url))
		{
			return null;
		}
		IEntity entity;
		if (url.StartsWith("javascript:", StringComparison.OrdinalIgnoreCase))
		{
			string script = url.Replace("javascript:", "");
			entity = ParseJavaScript(script, InterfaceActivator.TypeOf<EleWise.ELMA.Security.Models.IUser>());
			if (entity != null)
			{
				return entity;
			}
			entity = ParseJavaScript(script, InterfaceActivator.TypeOf<IUserGroup>());
			if (entity != null)
			{
				return entity;
			}
		}
		entity = EntityUrlResolverService.ParseEntityUrl(url, InterfaceActivator.UID<EleWise.ELMA.Security.Models.IUser>(), out var metadata);
		if (entity != null)
		{
			return entity;
		}
		return EntityUrlResolverService.ParseEntityUrl(url, userGroupUID, out metadata);
	}

	public JsonResult Select(string text, string id = null, int max = 100, string filterProviderUid = null, string filterProviderData = null, bool checkReplacement = false, bool showBlock = false, long? currentSelected = null)
	{
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		IList<AutocompleteItem> list;
		if (ParseEntityUrl(text) is EleWise.ELMA.Security.Models.IUser user)
		{
			list = new AutoCompleteUserItem[1] { AutoCompleteUserItem.GetItem(((Controller)this).get_Url(), user, checkReplacement) };
		}
		else if (!string.IsNullOrEmpty(id))
		{
			List<EleWise.ELMA.Security.Models.IUser> users = UserManager.FindByIdArray(StringParseHelper.GetIdsFromString(id), CreateUserFilter(null, filterProviderUid, filterProviderData, showBlock), new FetchOptions(0, 0, ListSortDirection.Ascending, "FullName")).ToList();
			list = AutoCompleteUserItem.GetItems(((Controller)this).get_Url(), users, checkReplacement);
		}
		else
		{
			IUserFilter filter = CreateUserFilter(text, filterProviderUid, filterProviderData, showBlock);
			IEnumerable<EleWise.ELMA.Security.Models.IUser> enumerable = base.Manager.Find(filter, new FetchOptions(0, max, LinqUtils.NameOf((Expression<Func<EleWise.ELMA.Security.Models.IUser, object>>)((EleWise.ELMA.Security.Models.IUser u) => u.FullName))));
			list = ((IEnumerable<AutocompleteItem>)enumerable.EntitySelectGroup((IEnumerable<EleWise.ELMA.Security.Models.IUser> l) => AutoCompleteUserItem.GetItems(((Controller)this).get_Url(), l, checkReplacement), (EntitySelectGroup g) => new AutoCompleteUserItem
			{
				DropDownText = g.StyleHeader,
				ViewText = g.Header,
				Text = g.Header,
				VirtualItem = true,
				ListItemClass = "object-separator separator-gray"
			})).ToList();
			if (currentSelected.HasValue && !enumerable.Any((EleWise.ELMA.Security.Models.IUser u) => u.Id == currentSelected.Value))
			{
				EleWise.ELMA.Security.Models.IUser user2 = base.Manager.LoadOrNull(currentSelected.Value);
				if (user2 != null)
				{
					list.Insert(0, AutoCompleteUserItem.GetItem(((Controller)this).get_Url(), user2, checkReplacement));
				}
			}
		}
		JsonResult val = new JsonResult();
		val.set_Data((object)list);
		val.set_JsonRequestBehavior((JsonRequestBehavior)0);
		return val;
	}

	public JsonResult SelectWithGroups(string text, string id = null, int max = 5, string filterProviderUid = null, string filterProviderData = null, bool checkReplacement = false, string selectPopupId = null, string selectPopupUrl = null, bool showBlock = false)
	{
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected O, but got Unknown
		IEntity entity = ParseEntityUrl(text);
		IList<AutocompleteItem> data;
		if (entity is EleWise.ELMA.Security.Models.IUser)
		{
			data = new AutoCompleteUserItem[1] { AutoCompleteUserItem.GetItem(((Controller)this).get_Url(), (EleWise.ELMA.Security.Models.IUser)entity, checkReplacement, valueWithType: true) };
		}
		else if (entity is IUserGroup)
		{
			data = new AutoCompleteUserGroupItem[1] { AutoCompleteUserGroupItem.GetItem(((Controller)this).get_Url(), (IUserGroup)entity, valueWithType: true) };
		}
		else if (!string.IsNullOrEmpty(id))
		{
			string[] array = id.Split('_');
			List<long> list = new List<long>();
			List<long> list2 = new List<long>();
			string[] array2 = array;
			foreach (string value in array2)
			{
				string text2 = BaseEntityUserTypeSelector.ExtractFullPrefix(value);
				if (text2 == BaseEntityUserTypeSelector.GetFullPrefix("User"))
				{
					list.Add(BaseEntityUserTypeSelector.GetObjectId(text2, value));
				}
				if (text2 == BaseEntityUserTypeSelector.GetFullPrefix("UserGroup"))
				{
					list2.Add(BaseEntityUserTypeSelector.GetObjectId(text2, value));
				}
			}
			IOrderedEnumerable<EleWise.ELMA.Security.Models.IUser> users = from i in base.Manager.FindByIdArray(list.ToArray())
				orderby i.FullName
				select i;
			IOrderedEnumerable<IUserGroup> users2 = from g in UserGroupManager.FindByIdArray(list2.ToArray())
				orderby g.Name
				select g;
			data = AutoCompleteUserItem.GetItems(((Controller)this).get_Url(), users, checkReplacement, valueWithType: true).Cast<AutocompleteItem>().Concat(AutoCompleteUserGroupItem.GetItems(((Controller)this).get_Url(), users2, valueWithType: true))
				.ToArray();
		}
		else
		{
			IUserFilter filter = CreateUserFilter(text, filterProviderUid, filterProviderData, showBlock);
			List<EleWise.ELMA.Security.Models.IUser> list3 = base.Manager.Find(filter, new FetchOptions(0, max + 1, LinqUtils.NameOf((Expression<Func<EleWise.ELMA.Security.Models.IUser, object>>)((EleWise.ELMA.Security.Models.IUser u) => u.FullName)))).ToList();
			bool num = list3.Count > max;
			if (num)
			{
				list3.RemoveAt(max);
			}
			List<AutoCompleteUserItem> list4 = list3.EntitySelectGroup((IEnumerable<EleWise.ELMA.Security.Models.IUser> l) => AutoCompleteUserItem.GetItems(((Controller)this).get_Url(), l, checkReplacement, valueWithType: true), (EntitySelectGroup g) => new AutoCompleteUserItem
			{
				DropDownText = g.StyleHeader,
				ViewText = g.Header,
				Text = g.Header,
				VirtualItem = true,
				ListItemClass = "object-separator separator-gray"
			}).ToList();
			if (num)
			{
				list4.Add(AutoCompleteUserItem.GetLastItem(selectPopupId, selectPopupUrl, text));
			}
			IUserGroupFilter filter2 = CreateUserGroupFilter(text, filterProviderUid, filterProviderData);
			List<IUserGroup> list5 = UserGroupManager.Find(filter2, new FetchOptions(0, max + 1, LinqUtils.NameOf((Expression<Func<IUserGroup, object>>)((IUserGroup u) => u.Name)))).ToList();
			bool num2 = list5.Count > max;
			if (num2)
			{
				list5.RemoveAt(max);
			}
			List<AutoCompleteUserGroupItem> list6 = list5.EntitySelectGroup((IEnumerable<IUserGroup> l) => AutoCompleteUserGroupItem.GetItems(((Controller)this).get_Url(), l, valueWithType: true), (EntitySelectGroup g) => new AutoCompleteUserGroupItem
			{
				DropDownText = g.StyleHeader,
				ViewText = g.Header,
				Text = g.Header,
				VirtualItem = true,
				ListItemClass = "object-separator separator-gray"
			}).ToList();
			if (num2)
			{
				list6.Add(AutoCompleteUserGroupItem.GetLastItem(selectPopupId, selectPopupUrl, text));
			}
			data = list4.Cast<AutocompleteItem>().If(list4.Count > 0, (IEnumerable<AutocompleteItem> l) => l.Concat(Enumerable.Repeat(AutoCompleteSeparatorItem.GetItem(SR.T("Группы пользователей")), 1))).Concat(list6)
				.ToArray();
		}
		JsonResult val = new JsonResult();
		val.set_Data((object)data);
		val.set_JsonRequestBehavior((JsonRequestBehavior)0);
		return val;
	}

	protected static void ApplyFilterProviders(IEntityFilter filter, string filterProviderUid, string filterProviderData)
	{
		if (!string.IsNullOrEmpty(filterProviderUid))
		{
			Guid uid = new Guid(filterProviderUid);
			ComponentManager.Current.GetExtensionPoints<IEntityFilterProvider>().FirstOrDefault((IEntityFilterProvider p) => p.ProviderUid == uid)?.ApplyFilter(filter, filterProviderData);
		}
	}

	public static IUserFilter CreateUserFilter(string text, string filterProviderUid, string filterProviderData, bool showBlock)
	{
		IUserFilter userFilter = InterfaceActivator.Create<IUserFilter>();
		userFilter.SearchString = text;
		userFilter.ShowBlock = showBlock;
		ApplyFilterProviders(userFilter, filterProviderUid, filterProviderData);
		return userFilter;
	}

	private IPersonalGroupFilter CreatePersonalGroupFilter(EleWise.ELMA.Security.Models.IUser owner)
	{
		IPersonalGroupFilter personalGroupFilter = InterfaceActivator.Create<IPersonalGroupFilter>();
		personalGroupFilter.Owner = owner;
		return personalGroupFilter;
	}

	public static IUserGroupFilter CreateUserGroupFilter(string text, string filterProviderUid, string filterProviderData)
	{
		IUserGroupFilter userGroupFilter = InterfaceActivator.Create<IUserGroupFilter>();
		userGroupFilter.SearchString = text;
		ApplyFilterProviders(userGroupFilter, filterProviderUid, filterProviderData);
		return userGroupFilter;
	}

	public ActionResult PopupEntity(string inputId, [JsonBinder] ICollection<SelectListItem> selected, bool multiselect, string filterProviderUid = null, string filterProviderData = null, bool checkReplacement = false, bool showBlock = false, [JsonBinder] ICollection<SelectButtonSetting> ButtonSettings = null)
	{
		if (string.IsNullOrEmpty(inputId))
		{
			throw new ArgumentNullException("inputId");
		}
		EleWise.ELMA.Security.Models.IUser currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		UserPopupSelectorModel model = new UserPopupSelectorModel
		{
			InputId = inputId,
			MultiSelect = multiselect,
			FilterProviderUid = filterProviderUid,
			FilterProviderData = filterProviderData,
			CheckReplacement = checkReplacement,
			ShowBlock = showBlock,
			SelectButtonSettings = ButtonSettings,
			OrgItemOnlyCheckBoxId = $"cb_{inputId}",
			PersonalGroups = PersonalGroupManager.Find(CreatePersonalGroupFilter(currentUser), FetchOptions.All)
		};
		IUserFilter filter = CreateUserFilter(null, filterProviderUid, filterProviderData, showBlock);
		ICollection<EleWise.ELMA.Security.Models.IUser> users = base.Manager.Find(filter, FetchOptions.All);
		model.AvalibleItems = (from i in AutoCompleteUserItem.GetItems(((Controller)this).get_Url(), users, checkReplacement).Select(delegate(AutoCompleteUserItem i)
			{
				UserPopupSelectListItem obj2 = new UserPopupSelectListItem
				{
					AutoCompleteUserItem = i
				};
				((SelectListItem)obj2).set_Value(i.Value);
				((SelectListItem)obj2).set_Text(i.Text);
				return (SelectListItem)(object)obj2;
			})
			where !string.IsNullOrEmpty(i.get_Text())
			select i).ToList();
		if (selected != null && selected.Any())
		{
			if (multiselect)
			{
				model.SelectedItems = selected.Join(model.AvalibleItems, (SelectListItem i) => i.get_Value(), (SelectListItem i) => i.get_Value(), (SelectListItem i1, SelectListItem i2) => i2).ToArray();
				model.AvalibleItems = model.AvalibleItems.Where((SelectListItem a) => model.SelectedItems.All((SelectListItem s) => s.get_Value() != a.get_Value())).ToList();
			}
			else
			{
				SelectListItem selectedItem = selected.FirstOrDefault();
				if (selectedItem != null)
				{
					SelectListItem val = model.AvalibleItems.FirstOrDefault((SelectListItem a) => a.get_Value() == selectedItem.get_Value());
					if (val != null)
					{
						val.set_Selected(true);
					}
				}
			}
		}
		if (model.SelectedItems == null)
		{
			model.SelectedItems = new List<SelectListItem>();
		}
		model.UserSelectListItemsAvailable = from i in (from UserPopupSelectListItem item in model.AvalibleItems
				select new UserPopupSelectListItem
				{
					Available = true,
					AutoCompleteUserItem = item.AutoCompleteUserItem
				}).Concat(from UserPopupSelectListItem item in model.SelectedItems
				select new UserPopupSelectListItem
				{
					Available = false,
					AutoCompleteUserItem = item.AutoCompleteUserItem
				})
			orderby i.AutoCompleteUserItem.ShortName
			select i;
		model.GroupUsers = (from i in AutoCompleteUserItem.GetItems(((Controller)this).get_Url(), model.PersonalGroups.SelectMany((IPersonalGroup g) => (IEnumerable<EleWise.ELMA.Security.Models.IUser>)g.Users), checkReplacement)
			where !string.IsNullOrEmpty(i.Text)
			select i).Select(delegate(AutoCompleteUserItem i)
		{
			UserPopupSelectListItem obj = new UserPopupSelectListItem
			{
				AutoCompleteUserItem = i
			};
			((SelectListItem)obj).set_Value(i.Value);
			((SelectListItem)obj).set_Text(i.Text);
			obj.Available = false;
			return obj;
		}).Distinct(new UserPopupSelectItemComparator()).Except(model.UserSelectListItemsAvailable, new UserPopupSelectItemComparator());
		return (ActionResult)(object)((Controller)this).PartialView("User/UserSelectPopup", (object)model);
	}

	public ActionResult PopupEntityWithGroups(string inputId, [JsonBinder] ICollection<SelectListItem> selected, string filterProviderUid = null, string filterProviderData = null, bool checkReplacement = false, string ObjectPrefix = null, string SearchString = null, bool showBlock = false)
	{
		if (string.IsNullOrEmpty(inputId))
		{
			throw new ArgumentNullException("inputId");
		}
		UserPopupSelectorModel model = new UserPopupSelectorModel
		{
			InputId = inputId,
			FilterProviderUid = filterProviderUid,
			FilterProviderData = filterProviderData,
			CheckReplacement = checkReplacement,
			ComplexExecutor = true,
			SelectedExecutorType = ObjectPrefix,
			SearchString = SearchString,
			ShowBlock = showBlock
		};
		IUserFilter filter = CreateUserFilter(SearchString, filterProviderUid, filterProviderData, showBlock);
		IUserGroupFilter filter2 = CreateUserGroupFilter(SearchString, filterProviderUid, filterProviderData);
		ICollection<EleWise.ELMA.Security.Models.IUser> users = base.Manager.Find(filter, new FetchOptions(0, 0, LinqUtils.NameOf((Expression<Func<EleWise.ELMA.Security.Models.IUser, object>>)((EleWise.ELMA.Security.Models.IUser u) => u.FullName))));
		ICollection<IUserGroup> source = UserGroupManager.Find(filter2, new FetchOptions(0, 0, LinqUtils.NameOf((Expression<Func<IUserGroup, object>>)((IUserGroup u) => u.Name))));
		model.AvalibleItems = (from i in AutoCompleteUserItem.GetItems(((Controller)this).get_Url(), users, checkReplacement).Select(delegate(AutoCompleteUserItem i)
			{
				UserPopupSelectListItem obj = new UserPopupSelectListItem
				{
					AutoCompleteUserItem = i
				};
				((SelectListItem)obj).set_Value(string.Format("{0}{1}", BaseEntityUserTypeSelector.GetFullPrefix("User"), i.Value));
				((SelectListItem)obj).set_Text(i.Text);
				return (SelectListItem)(object)obj;
			}).Union(((IEnumerable<IUserGroup>)source).Select((Func<IUserGroup, SelectListItem>)delegate(IUserGroup i)
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				//IL_0025: Unknown result type (might be due to invalid IL or missing references)
				//IL_0032: Expected O, but got Unknown
				SelectListItem val = new SelectListItem();
				val.set_Value(string.Format("{0}{1}", BaseEntityUserTypeSelector.GetFullPrefix("UserGroup"), i.GetId()));
				val.set_Text(i.Name);
				return val;
			}))
			where !string.IsNullOrEmpty(i.get_Text())
			select i).ToList();
		if (selected != null && selected.Any())
		{
			model.SelectedItems = selected.Join(model.AvalibleItems, (SelectListItem i) => i.get_Value(), (SelectListItem i) => i.get_Value(), (SelectListItem i1, SelectListItem i2) => i2).ToArray();
			model.AvalibleItems = model.AvalibleItems.Where((SelectListItem a) => model.SelectedItems.All((SelectListItem s) => s.get_Value() != a.get_Value())).ToList();
		}
		return (ActionResult)(object)((Controller)this).PartialView("User/ComplexExecuterSelectPopup", (object)model);
	}

	public ActionResult PopupSearch(string SearchString, IOrganizationItem OrganizationItem, string filterProviderUid = null, string filterProviderData = null, bool checkReplacement = false, bool showBlock = false)
	{
		IUserFilter userFilter = CreateUserFilter(SearchString, filterProviderUid, filterProviderData, showBlock);
		userFilter.OrganizationItem = OrganizationItem;
		ICollection<EleWise.ELMA.Security.Models.IUser> source = base.Manager.Find(userFilter, FetchOptions.All);
		return (ActionResult)(object)((Controller)this).Json((object)source.Select((EleWise.ELMA.Security.Models.IUser u) => u.Id.ToString()).ToArray());
	}

	public ActionResult PopupEntityFetch(string inputId, [JsonBinder] ICollection<SelectListItem> selected, bool multiselect, string filterProviderUid = null, string filterProviderData = null, bool checkReplacement = false, bool showBlock = false)
	{
		if (string.IsNullOrEmpty(inputId))
		{
			throw new ArgumentNullException("inputId");
		}
		UserPopupSelectorModel model = new UserPopupSelectorModel
		{
			Id = "EntitySelecor" + inputId,
			InputId = inputId,
			MultiSelect = multiselect,
			FilterProviderUid = filterProviderUid,
			FilterProviderData = filterProviderData,
			CheckReplacement = checkReplacement,
			ShowBlock = showBlock,
			PageSize = 20,
			OrgItemOnlyCheckBoxId = $"cb_{inputId}",
			RouteValues = new RouteValueDictionary(CreateEntitySelectRouteValues(filterProviderUid, filterProviderData)),
			PersonalGroups = PersonalGroupManager.Find(CreatePersonalGroupFilter(base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>()), FetchOptions.All)
		};
		IUserFilter filter = CreateUserFilter(null, filterProviderUid, filterProviderData, showBlock);
		ICollection<EleWise.ELMA.Security.Models.IUser> users = base.Manager.Find(filter, new FetchOptions(0, model.PageSize, "ShortName"));
		model.AvalibleItems = (from i in AutoCompleteUserItem.GetItems(((Controller)this).get_Url(), users, checkReplacement).Select(delegate(AutoCompleteUserItem i)
			{
				UserPopupSelectListItem obj3 = new UserPopupSelectListItem
				{
					AutoCompleteUserItem = i
				};
				((SelectListItem)obj3).set_Value(i.Value);
				((SelectListItem)obj3).set_Text(i.Text);
				return (SelectListItem)(object)obj3;
			})
			where !string.IsNullOrEmpty(i.get_Text())
			select i).ToList();
		if (selected != null && selected.Any())
		{
			if (multiselect)
			{
				List<SelectListItem> list = new List<SelectListItem>();
				foreach (SelectListItem item3 in selected)
				{
					List<long> list2 = new List<long>();
					if (long.TryParse(item3.get_Value(), out var result))
					{
						list2.Add(result);
					}
					foreach (EleWise.ELMA.Security.Models.IUser item4 in base.Manager.FindByIdArray(list2.ToArray()))
					{
						AutoCompleteUserItem item2 = AutoCompleteUserItem.GetItem(((Controller)this).get_Url(), item4, checkReplacement);
						if (item2 != null)
						{
							UserPopupSelectListItem obj = new UserPopupSelectListItem
							{
								AutoCompleteUserItem = item2
							};
							((SelectListItem)obj).set_Value(item2.Value);
							((SelectListItem)obj).set_Text(item2.Text);
							list.Add((SelectListItem)(object)obj);
						}
					}
				}
				model.SelectedItems = list;
				model.AvalibleItems = model.AvalibleItems.Where((SelectListItem a) => model.SelectedItems.All((SelectListItem s) => s.get_Value() != a.get_Value())).ToList();
			}
			else
			{
				SelectListItem selectedItem = selected.FirstOrDefault();
				if (selectedItem != null)
				{
					SelectListItem val = model.AvalibleItems.FirstOrDefault((SelectListItem a) => a.get_Value() == selectedItem.get_Value());
					if (val != null)
					{
						val.set_Selected(true);
					}
				}
			}
		}
		if (model.SelectedItems == null)
		{
			model.SelectedItems = new List<SelectListItem>();
		}
		model.UserSelectListItemsAvailable = from i in (from UserPopupSelectListItem item in model.AvalibleItems
				select new UserPopupSelectListItem
				{
					Available = true,
					AutoCompleteUserItem = item.AutoCompleteUserItem
				}).Concat(from UserPopupSelectListItem item in model.SelectedItems
				select new UserPopupSelectListItem
				{
					Available = false,
					AutoCompleteUserItem = item.AutoCompleteUserItem
				})
			orderby i.AutoCompleteUserItem.ShortName
			select i;
		model.GroupUsers = (from i in AutoCompleteUserItem.GetItems(((Controller)this).get_Url(), model.PersonalGroups.SelectMany((IPersonalGroup g) => (IEnumerable<EleWise.ELMA.Security.Models.IUser>)g.Users), checkReplacement)
			where !string.IsNullOrEmpty(i.Text)
			select i).Select(delegate(AutoCompleteUserItem i)
		{
			UserPopupSelectListItem obj2 = new UserPopupSelectListItem
			{
				AutoCompleteUserItem = i
			};
			((SelectListItem)obj2).set_Value(i.Value);
			((SelectListItem)obj2).set_Text(i.Text);
			obj2.Available = false;
			return obj2;
		}).Distinct(new UserPopupSelectItemComparator()).Except(model.UserSelectListItemsAvailable, new UserPopupSelectItemComparator());
		return (ActionResult)(object)((Controller)this).PartialView("User/UserSelectPopup", (object)model);
	}

	public ActionResult PopupFetch(int pageNum, int pageSize, string filterProviderUid = null, string filterProviderData = null, bool checkReplacement = false, bool showBlock = false)
	{
		return PopupSearchFetch(string.Empty, null, pageNum, pageSize, filterProviderUid, filterProviderData, checkReplacement, showBlock);
	}

	public ActionResult PopupSearchFetch(string SearchString, IOrganizationItem OrganizationItem, int pageNum, int pageSize, string filterProviderUid = null, string filterProviderData = null, bool checkReplacement = false, bool showBlock = false, bool onlyFromOrgItem = false)
	{
		IUserFilter userFilter = CreateUserFilter(SearchString, filterProviderUid, filterProviderData, showBlock);
		userFilter.OrganizationItem = OrganizationItem;
		if (onlyFromOrgItem)
		{
			userFilter.OrganizationItemFindMode = OrganizationItemFindMode.ByItem;
		}
		FetchOptions fetchOptions = new FetchOptions(pageSize * pageNum, pageSize);
		ICollection<EleWise.ELMA.Security.Models.IUser> users = base.Manager.Find(userFilter, fetchOptions);
		var enumerable = from item in AutoCompleteUserItem.GetItems(((Controller)this).get_Url(), users, checkReplacement)
			select new
			{
				Value = item.Value,
				Text = item.Text,
				ShortName = item.ShortName,
				Positions = (item.Positions ?? ""),
				AbsenceText = (item.AbsenceText ?? ""),
				ListItemClass = item.ListItemClass,
				IconUrl = item.IconUrl,
				Available = true
			};
		return (ActionResult)(object)((Controller)this).Json((object)enumerable);
	}

	public ActionResult PopupSearchWithGroupsFetch(string searchString, IOrganizationItem organizationItem, string filterProviderUid = null, string filterProviderData = null, bool checkReplacement = false, bool showBlock = false)
	{
		IUserFilter userFilter = CreateUserFilter(searchString, filterProviderUid, filterProviderData, showBlock);
		userFilter.OrganizationItem = ((organizationItem == null || organizationItem.IsNew()) ? null : organizationItem);
		ICollection<EleWise.ELMA.Security.Models.IUser> users = base.Manager.Find(userFilter, FetchOptions.All);
		EleWise.ELMA.Security.Models.IUser currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		IPersonalGroupFilter personalGroupFilter = CreatePersonalGroupFilter(currentUser);
		personalGroupFilter.SearchString = searchString;
		var value = from @group in PersonalGroupManager.Find(personalGroupFilter, FetchOptions.All)
			select new
			{
				Id = @group.Id,
				Name = @group.Name,
				IconUrl = ((Controller)this).get_Url().Image("#users.svg"),
				Users = JsonConvert.SerializeObject((object)(from i in AutoCompleteUserItem.GetItems(((Controller)this).get_Url(), (IEnumerable<EleWise.ELMA.Security.Models.IUser>)@group.Users)
					select new { i.Positions, i.Value, i.ListItemClass, i.IconUrl, i.AbsenceText, i.ShortName }))
			};
		var value2 = from item in AutoCompleteUserItem.GetItems(((Controller)this).get_Url(), users, checkReplacement)
			select new
			{
				Value = item.Value,
				Text = item.Text,
				ShortName = item.ShortName,
				Positions = (item.Positions ?? ""),
				AbsenceText = (item.AbsenceText ?? ""),
				ListItemClass = item.ListItemClass,
				IconUrl = item.IconUrl,
				Available = true
			};
		Dictionary<string, IEnumerable<object>> dictionary = new Dictionary<string, IEnumerable<object>>();
		dictionary.Add("UsersItems", value2);
		dictionary.Add("GroupsItems", value);
		return (ActionResult)(object)((Controller)this).Json((object)dictionary);
	}

	public ActionResult PopupSearchWithGroups(string SearchString, IOrganizationItem OrganizationItem, string filterProviderUid = null, string filterProviderData = null, bool checkReplacement = false, bool showBlock = false)
	{
		IUserFilter userFilter = CreateUserFilter(SearchString, filterProviderUid, filterProviderData, showBlock);
		userFilter.OrganizationItem = OrganizationItem;
		IUserGroupFilter filter = CreateUserGroupFilter(SearchString, filterProviderUid, filterProviderData);
		ICollection<EleWise.ELMA.Security.Models.IUser> source = base.Manager.Find(userFilter, FetchOptions.All);
		ICollection<IUserGroup> source2 = UserGroupManager.Find(filter, FetchOptions.All);
		return (ActionResult)(object)((Controller)this).Json((object)source.Select((EleWise.ELMA.Security.Models.IUser u) => string.Format("{0}{1}", BaseEntityUserTypeSelector.GetFullPrefix("User"), u.Id)).Union(source2.Select((IUserGroup g) => string.Format("{0}{1}", BaseEntityUserTypeSelector.GetFullPrefix("UserGroup"), g.Id))).ToArray());
	}

	public static void CalculateEntityFilterProvider(EntitySettings settings, ViewAttributes viewAttributes, out string filterProviderUid, out string filterProviderData)
	{
		EntityUserSettings entityUserSettings = settings as EntityUserSettings;
		if (viewAttributes.EntityFilterProvider == Guid.Empty && entityUserSettings != null && entityUserSettings.Workers != null && entityUserSettings.Workers.Count > 0)
		{
			viewAttributes.EntityFilterProvider = UserTypeFilterProvider.UID;
			viewAttributes.EntityFilterData = "";
		}
		filterProviderUid = ((viewAttributes.EntityFilterProvider != Guid.Empty) ? viewAttributes.EntityFilterProvider.ToString() : null);
		filterProviderData = viewAttributes.EntityFilterData;
	}

	public static dynamic CreateEntitySelectRouteValues(EntitySettings settings, ViewAttributes viewAttributes)
	{
		CalculateEntityFilterProvider(settings, viewAttributes, out var filterProviderUid, out var filterProviderData);
		return CreateEntitySelectRouteValues(filterProviderUid, filterProviderData);
	}

	public static dynamic CreateEntitySelectRouteValues(string filterProviderUid, string filterProviderData)
	{
		dynamic val = new ExpandoObject();
		val.area = "EleWise.ELMA.BPM.Web.Security";
		if (!string.IsNullOrEmpty(filterProviderUid))
		{
			val.filterProviderUid = filterProviderUid;
			val.filterProviderData = filterProviderData;
		}
		return val;
	}
}
