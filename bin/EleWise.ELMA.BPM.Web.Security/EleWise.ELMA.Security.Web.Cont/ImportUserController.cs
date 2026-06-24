using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Security.Web.Controllers.Models;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html.EditableList;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.Security.Web.Controllers;

[RouteArea("EleWise.ELMA.BPM.Web.Security")]
[Permission("2C44BA05-91A6-49E4-89C1-84AC5B371B7F")]
public class ImportUserController : BPMController
{
	public ExternalMembershipImportManager ExternalMembershipImportManager { get; set; }

	public UserGroupManager UserGroupManager { get; set; }

	public IExternalMembershipManager ExternalMembershipManager { get; set; }

	private List<ImportUserModel> ConvertUsers(IEnumerable<IUser> list, Guid authProviderGuid)
	{
		Dictionary<Guid, string> instanceUids = ExternalMembershipManager.GetAllName();
		return (from user in list
			where !string.IsNullOrWhiteSpace(user.UserName)
			select user into i
			orderby i.UserName
			select i).Select(delegate(IUser user)
		{
			EleWise.ELMA.Security.Models.IUser user2 = UserManager.Instance.LoadByLogin(user.UserName);
			InElmaUserType inElmaUser = InElmaUserType.None;
			if (user2 != null)
			{
				inElmaUser = ((user2.AuthProviderGuid == Guid.Empty) ? InElmaUserType.Exist : ((!(user2.AuthProviderGuid == authProviderGuid)) ? ((!instanceUids.ContainsKey(user2.AuthProviderGuid)) ? InElmaUserType.Exist : InElmaUserType.ExistAndRegisterAnother) : InElmaUserType.ExistAndRegister));
			}
			IUser user3 = user2;
			return new ImportUserModel(user3 ?? user, inElmaUser);
		}).ToList();
	}

	public ActionResult Import(Guid authProviderGuid)
	{
		((ControllerBase)this).get_ViewData().set_Item("authProviderGuid", (object)authProviderGuid);
		List<ImportUserModel> listData;
		string providerName;
		try
		{
			listData = ConvertUsers(ExternalMembershipManager.FindUsers(null, authProviderGuid), authProviderGuid);
			providerName = ExternalMembershipManager.Name(authProviderGuid);
		}
		catch (Exception ex)
		{
			EleWise.ELMA.Logging.Logger.Log.Error(ex.Message, ex);
			FormNotifierExtensions.Error(base.Notifier, ex);
			return (ActionResult)(object)((Controller)this).View("ImportUser/Import", (string)null);
		}
		IUserGroupFilter userGroupFilter = InterfaceActivator.Create<IUserGroupFilter>();
		userGroupFilter.AddToNewUser = true;
		ICollection<IUserGroup> source = UserGroupManager.Find(userGroupFilter, FetchOptions.All);
		EditableListModel groups = new EditableListModel
		{
			Items = from g in source.Where((IUserGroup g) => g.TypeUid == Guid.Empty || g.TypeUid == InterfaceActivator.UID<IUserGroup>()).Where(delegate(IUserGroup g)
				{
					uint? maxGroupUsersCount = UserGroupManager.GetMaxGroupUsersCount(g);
					return !maxGroupUsersCount.HasValue || maxGroupUsersCount.Value > ((ICollection<EleWise.ELMA.Security.Models.IUser>)g.Users).Count;
				})
				select new EditableListItem
				{
					Value = g.Id.ToString(CultureInfo.InvariantCulture),
					DisplayText = g.Name,
					Description = g.Description
				}
		};
		ImportUserInfoModel importUserInfoModel = new ImportUserInfoModel
		{
			SearchString = null,
			AuthProviderGuid = authProviderGuid,
			ListData = listData,
			ProviderName = providerName,
			Groups = groups
		};
		return (ActionResult)(object)((Controller)this).View("ImportUser/Import", (object)importUserInfoModel);
	}

	[HttpPost]
	public ActionResult Search(Guid authProviderGuid, string searchString)
	{
		try
		{
			List<ImportUserModel> listData = ConvertUsers(ExternalMembershipManager.FindUsers(searchString ?? "", authProviderGuid), authProviderGuid);
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = true,
				listData = listData
			});
		}
		catch (Exception ex)
		{
			EleWise.ELMA.Logging.Logger.Log.Error(ex.Message, ex);
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false,
				error = ex.Message
			});
		}
	}

	[HttpPost]
	public ActionResult DoImport(ImportUserGridModel model, EditableListModel groups)
	{
		if (model != null && model.Data != null && model.Data.Count > 0)
		{
			model.Groups = groups;
			ExternalMembershipImportManager.AddUsersToImport(model.Data.Select((ImportUserModel a) => a.UserName), groups.Items.Select((EditableListItem a) => a.Value.FromJson<long>()), model.AuthProviderGuid);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Import", "ImportUser", (object)new
		{
			authProviderGuid = model.AuthProviderGuid
		});
	}

	public ActionResult CheckImportProgress(Guid authProviderUid)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		JsonResult val = new JsonResult();
		val.set_Data((object)new
		{
			result = ExternalMembershipImportManager.CheckImportProgress(authProviderUid),
			licenseCount = new ImportUserInfoModel().LicenseCount
		});
		val.set_JsonRequestBehavior((JsonRequestBehavior)0);
		return (ActionResult)val;
	}
}
