using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Components;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Mvc.Binders;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.BPM.Web.Security.Controllers;

[RouteArea("EleWise.ELMA.BPM.Web.Security")]
public class PersonalGroupController : BPMController<IPersonalGroup, long>
{
	public UserManager UserManager { get; set; }

	[HttpPost]
	public ActionResult SelectorLoading(string text)
	{
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00af: Expected O, but got Unknown
		ICollection<IPersonalGroup> source = base.Manager.Find((IPersonalGroup f) => f.Owner == AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>());
		JsonResult val = new JsonResult();
		val.set_JsonRequestBehavior((JsonRequestBehavior)0);
		val.set_Data((object)new SelectList((IEnumerable)source.ToList(), "Id", "Name"));
		return (ActionResult)val;
	}

	[HttpGet]
	public ActionResult Exists(string name)
	{
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			exists = (!string.IsNullOrEmpty(name) && base.Manager.Find((IPersonalGroup f) => f.Owner == AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>() && f.Name == name).Any())
		}, (JsonRequestBehavior)0);
	}

	[HttpGet]
	public ActionResult GetMembers(IPersonalGroup group, bool checkReplacement = false, bool valueWithType = false, string filterProviderUid = null, string filterProviderData = null)
	{
		if (group.Owner == base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>() || base.SecurityService.HasPermission(PermissionProvider.UserManagmentPermission))
		{
			List<AutoCompleteEntityItem> list = new List<AutoCompleteEntityItem>();
			List<EleWise.ELMA.Security.Models.IUser> source = ((IEnumerable<EleWise.ELMA.Security.Models.IUser>)group.Users).ToList();
			if (!string.IsNullOrEmpty(filterProviderUid))
			{
				IUserFilter filter = UserController.CreateUserFilter(null, filterProviderUid, filterProviderData, showBlock: false);
				List<EleWise.ELMA.Security.Models.IUser> allowedUsers = UserManager.Find(filter, FetchOptions.All).ToList();
				source = ((IEnumerable<EleWise.ELMA.Security.Models.IUser>)group.Users).Where((EleWise.ELMA.Security.Models.IUser u) => allowedUsers.Any((EleWise.ELMA.Security.Models.IUser au) => au.Id == u.Id)).ToList();
			}
			AutoCompleteUserItem[] items = AutoCompleteUserItem.GetItems(((Controller)this).get_Url(), source.Where((EleWise.ELMA.Security.Models.IUser u) => u.Status != UserStatus.Blocked), checkReplacement, valueWithType);
			list.AddRange(items);
			if (valueWithType)
			{
				List<IUserGroup> users = ((IEnumerable<IUserGroup>)group.Groups).ToList();
				if (!string.IsNullOrEmpty(filterProviderUid))
				{
					IUserGroupFilter filter2 = UserController.CreateUserGroupFilter(null, filterProviderUid, filterProviderData);
					List<IUserGroup> allowedGroups = UserGroupManager.Instance.Find(filter2, FetchOptions.All).ToList();
					users = ((IEnumerable<IUserGroup>)group.Groups).Where((IUserGroup g) => allowedGroups.Any((IUserGroup ag) => ag.Id == g.Id)).ToList();
				}
				AutoCompleteUserGroupItem[] items2 = AutoCompleteUserGroupItem.GetItems(((Controller)this).get_Url(), users, valueWithType: true);
				list.AddRange(items2);
			}
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				results = list
			}, (JsonRequestBehavior)0);
		}
		throw new SecurityException();
	}

	public ActionResult PersonalGroupNamePopup(string inputId)
	{
		return (ActionResult)(object)((Controller)this).PartialView("PersonalGroupNamePopup", (object)inputId);
	}

	[HttpGet]
	public ActionResult Delete(IPersonalGroup group)
	{
		if (group.Owner == base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>() || base.SecurityService.HasPermission(PermissionProvider.UserManagmentPermission))
		{
			group.Delete();
			return (ActionResult)(object)((Controller)this).Json((object)new { }, (JsonRequestBehavior)0);
		}
		throw new SecurityException();
	}

	[HttpPost]
	public ActionResult SaveGroup(string name, [JsonBinder] ICollection<SelectListItem> users)
	{
		ICollection<IPersonalGroup> source = base.Manager.Find((IPersonalGroup f) => f.Owner == AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>() && f.Name == name);
		IPersonalGroup personalGroup = (source.Any() ? source.First() : InterfaceActivator.Create<IPersonalGroup>());
		personalGroup.Name = name;
		personalGroup.Owner = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		personalGroup.Users = (ISet<EleWise.ELMA.Security.Models.IUser>)(object)new HashedSet<EleWise.ELMA.Security.Models.IUser>();
		if (users.Any())
		{
			foreach (SelectListItem user2 in users)
			{
				if (long.TryParse(user2.get_Value(), out var result))
				{
					personalGroup.Users.Add(UserManager.Load(result));
					continue;
				}
				IEntity<long> entity = BaseEntityUserTypeSelector.LoadEntity(user2.get_Value());
				if (entity is EleWise.ELMA.Security.Models.IUser user)
				{
					personalGroup.Users.Add(user);
				}
				else if (entity is IUserGroup userGroup)
				{
					personalGroup.Groups.Add(userGroup);
				}
			}
		}
		personalGroup.Save();
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			id = personalGroup.Id,
			name = personalGroup.Name
		}, (JsonRequestBehavior)0);
	}
}
