using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.Actions;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.BPM.Web.Security.Services;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Web.Mvc.Html.EditableList;

namespace EleWise.ELMA.BPM.Web.Common.Services;

[Service(Scope = ServiceScope.Shell)]
public class WatchListService
{
	public PermissionsModelService PermissionsModelService { get; set; }

	public PermissionRoleTypeSelectorModel CreateNew(string popupId, string permissionPopupName, UrlHelper url)
	{
		PermissionRoleTypeSelectorModel permissionRoleTypeSelectorModel = new PermissionRoleTypeSelectorModel();
		permissionRoleTypeSelectorModel.PopupId = popupId;
		permissionRoleTypeSelectorModel.Title = SR.T("Выбор наблюдателя");
		permissionRoleTypeSelectorModel.TypeRoles = new PermissionRoleType[1] { CommonRoleTypes.User };
		permissionRoleTypeSelectorModel.SelectedTypeRole = CommonRoleTypes.User;
		permissionRoleTypeSelectorModel.ObjectId = "theGriupId";
		permissionRoleTypeSelectorModel.SubmitScript = $"elma.appendFromPermissionPopup('{permissionPopupName}')";
		permissionRoleTypeSelectorModel.CreatePopup = true;
		permissionRoleTypeSelectorModel.OrganizationTreeModel = PermissionsModelService.CreateOrganizationTreeModel(popupId);
		permissionRoleTypeSelectorModel.GroupsTreeModel = PermissionsModelService.CreateGroupsModel(popupId);
		permissionRoleTypeSelectorModel.ExtGroupsTreeModel = PermissionsModelService.CreateExtGroupsModel(popupId);
		permissionRoleTypeSelectorModel.UserModel = PermissionsModelService.CreateUserModel(popupId, url);
		return permissionRoleTypeSelectorModel;
	}

	public IEnumerable<AssignedRoleTypeModel> CreateAssignedRoleTypeModel(Guid typeUid, object entityId = null)
	{
		return from u in (from w in WatchManager.Instance.GetWatches(typeUid, entityId, onlyForEntity: true).ToList()
				select w.User).Distinct()
			select new WatchAssignedRoleTypeModel(CommonRoleTypes.User, u)
			{
				DisableDelete = !WatchManager.Instance.CheckAction((WatchManager m) => m.DeleteWatchesByUser(u, entityId, typeUid), InterfaceActivator.TypeOf<IWatch>())
			};
	}

	[Transaction]
	public virtual void SaveFromModel(Guid typeUid, EditableListModel model, object entityId = null)
	{
		IEnumerable<EleWise.ELMA.Security.Models.IUser> newWatches = (from i in model.Items
			select new
			{
				a = PermissionsModelService.GetAssignedEntity(i, null),
				i = i
			} into i
			where i.a.Item1 is EleWise.ELMA.Security.Models.IUser
			select (EleWise.ELMA.Security.Models.IUser)i.a.Item1).Distinct();
		List<IWatch> watches = WatchManager.Instance.GetWatchByUser(typeUid, null, entityId);
		List<IWatch> list = watches.Where((IWatch w) => !newWatches.Any((EleWise.ELMA.Security.Models.IUser nw) => nw.Id == w.User.Id)).ToList();
		list.ForEach(delegate(IWatch w)
		{
			w.Delete();
		});
		List<EleWise.ELMA.Security.Models.IUser> list2 = newWatches.Where((EleWise.ELMA.Security.Models.IUser w) => !watches.Any((IWatch nw) => nw.User.Id == w.Id)).ToList();
		list2.ForEach(delegate(EleWise.ELMA.Security.Models.IUser w)
		{
			WatchManager.Instance.CreateWatchByUser(typeUid, entityId, w);
		});
		IWatchNotifier watchNotifier = ComponentManager.Current.GetExtensionPoints<IWatchNotifier>().FirstOrDefault((IWatchNotifier p) => p.IsAvailable(typeUid));
		if (watchNotifier != null && entityId != null)
		{
			EleWise.ELMA.Security.Models.IUser currentUser = AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
			watchNotifier.Notify(entityId, list2.Where((EleWise.ELMA.Security.Models.IUser u) => u.Id != currentUser.Id), from w in list
				select w.User into u
				where u.Id != currentUser.Id
				select u);
		}
	}
}
