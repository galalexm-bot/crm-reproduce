using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.BPM.Web.Common.Services;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html.EditableList;

namespace EleWise.ELMA.BPM.Web.Common.Controllers;

public class WatchController : BPMController<IWatch, long>
{
	public WatchListService WatchListService { get; set; }

	[HttpGet]
	public ActionResult Info(Guid typeUid, string entityId, string watchPanel, string addWatchScript, string removeWatchScript)
	{
		object obj = ModelHelper.TryConvertEntityId(typeUid, entityId);
		WatchesModel watchesModel = new WatchesModel(typeUid, obj)
		{
			AddWatchScript = addWatchScript,
			RemoveWatchScript = removeWatchScript,
			WatchPanel = watchPanel
		};
		watchesModel.Watches = WatchManager.Instance.GetWatches(typeUid, obj);
		return (ActionResult)(object)((Controller)this).PartialView("Watch/IconInfo", (object)watchesModel);
	}

	[HttpGet]
	public ActionResult Settings(Guid typeUid, string entityId, string popupId, string callback)
	{
		object entityId2 = ModelHelper.TryConvertEntityId(typeUid, entityId);
		WatchListModel watchListModel = new WatchListModel(typeUid, entityId2)
		{
			PopupId = popupId,
			GlobalWatches = WatchManager.Instance.GetWatches(typeUid, null),
			Watches = WatchManager.Instance.GetWatches(typeUid, entityId2, onlyForEntity: true),
			Callback = callback
		};
		IUser user = base.AuthenticationService.GetCurrentUser<IUser>();
		watchListModel.CurrentInGlobalWatch = watchListModel.GlobalWatches.Any((IWatch w) => w.User.Id == user.Id);
		watchListModel.CurrentInWatch = watchListModel.Watches.Any((IWatch w) => w.User.Id == user.Id);
		watchListModel.GlobalWatchStatus = ((!watchListModel.CurrentInGlobalWatch) ? WatchStatus.NotWatch : WatchStatus.Watch);
		watchListModel.WatchStatus = ((!watchListModel.CurrentInWatch) ? WatchStatus.NotWatch : WatchStatus.Watch);
		IWatchProvider watchProvider = ComponentManager.Current.GetExtensionPoints<IWatchProvider>().FirstOrDefault((IWatchProvider p) => p.TypeUid.Contains(typeUid));
		if (watchProvider != null)
		{
			watchListModel.GlobalWatchDescription = string.Format(watchProvider.GlobalWatchDescription, watchListModel.Metadata.DisplayName);
			watchListModel.WatchDescription = string.Format(watchProvider.WatchDescription, watchListModel.EntityName);
		}
		return (ActionResult)(object)((Controller)this).PartialView((object)watchListModel);
	}

	[HttpPost]
	public ActionResult Settings(Guid entityTypeUid, string entityId, WatchStatus globalWatchStatus, WatchStatus watchStatus)
	{
		object entityId2 = ModelHelper.TryConvertEntityId(entityTypeUid, entityId);
		IUser currentUser = base.AuthenticationService.GetCurrentUser<IUser>();
		List<IWatch> watchByUser = WatchManager.Instance.GetWatchByUser(entityTypeUid, currentUser.Id, entityId2);
		List<IWatch> watchByUser2 = WatchManager.Instance.GetWatchByUser(entityTypeUid, currentUser.Id);
		if (watchStatus == WatchStatus.Watch)
		{
			if (watchByUser.Count == 0)
			{
				WatchManager.Instance.CreateWatchByUser(entityTypeUid, entityId2, currentUser);
			}
		}
		else
		{
			watchByUser.ForEach(delegate(IWatch w)
			{
				w.Delete();
			});
		}
		if (globalWatchStatus == WatchStatus.Watch)
		{
			if (watchByUser2.Count == 0)
			{
				WatchManager.Instance.CreateWatchByUser(entityTypeUid, null, currentUser);
			}
		}
		else
		{
			watchByUser2.ForEach(delegate(IWatch w)
			{
				w.Delete();
			});
		}
		return SuccessJson();
	}

	[HttpPost]
	public ActionResult AddWatch(Guid typeUid, string entityId)
	{
		object entityId2 = ModelHelper.TryConvertEntityId(typeUid, entityId);
		IUser currentUser = base.AuthenticationService.GetCurrentUser<IUser>();
		if (WatchManager.Instance.GetWatchByUser(typeUid, currentUser.Id, entityId2).Count == 0)
		{
			WatchManager.Instance.CreateWatchByUser(typeUid, entityId2, currentUser);
		}
		return SuccessJson();
	}

	[HttpPost]
	public ActionResult RemoveWatch(Guid typeUid, string entityId)
	{
		object entityId2 = ModelHelper.TryConvertEntityId(typeUid, entityId);
		IUser currentUser = base.AuthenticationService.GetCurrentUser<IUser>();
		WatchManager.Instance.GetWatchByUser(typeUid, currentUser.Id, entityId2).ForEach(delegate(IWatch w)
		{
			w.Delete();
		});
		return SuccessJson();
	}

	[HttpGet]
	public ActionResult List(Guid typeUid, string entityId, string popupId)
	{
		object entityId2 = ModelHelper.TryConvertEntityId(typeUid, entityId);
		WatchListInfoModel watchListInfoModel = new WatchListInfoModel(typeUid, entityId2)
		{
			PopupId = popupId
		};
		watchListInfoModel.Watches = from w in WatchManager.Instance.GetWatches(typeUid, entityId2)
			group w by w.User;
		return (ActionResult)(object)((Controller)this).PartialView((object)watchListInfoModel);
	}

	[HttpGet]
	public ActionResult FullListPopup(Guid typeUid, string entityId, Guid? permissiontoValidate, Guid? typeUidForPermission, string popupId, bool canEdit, string typeWatchesCaption)
	{
		object entityId2 = ModelHelper.TryConvertEntityId(typeUid, entityId);
		WatchListInfoModel watchListInfoModel = new WatchListInfoModel(typeUid, entityId2)
		{
			PermissionToValidate = permissiontoValidate,
			TypeUidForPermission = typeUidForPermission,
			PopupId = popupId,
			CanEdit = canEdit,
			TypeWatchesCaption = typeWatchesCaption
		};
		watchListInfoModel.RoleTypeSelectorModel = WatchListService.CreateNew("membersWatchListPopup", "watchListMembers", ((Controller)this).get_Url());
		watchListInfoModel.RoleTypeModels = WatchListService.CreateAssignedRoleTypeModel(typeUid, entityId2);
		watchListInfoModel.GlobalRoleTypeModels = (string.IsNullOrWhiteSpace(typeWatchesCaption) ? null : WatchListService.CreateAssignedRoleTypeModel(typeUid));
		return (ActionResult)(object)((Controller)this).PartialView((object)watchListInfoModel);
	}

	[HttpPost]
	[TransactionAction]
	public virtual ActionResult SaveList(Guid entityTypeUid, string entityId, [Bind(Prefix = "watchListMembers")] EditableListModel watchListMembers)
	{
		if (watchListMembers != null && watchListMembers.Items != null)
		{
			object entityId2 = ModelHelper.TryConvertEntityId(entityTypeUid, entityId);
			WatchListService.SaveFromModel(entityTypeUid, watchListMembers, entityId2);
		}
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl());
	}

	[HttpGet]
	public ActionResult ProfileInfo()
	{
		AllWatchesInfo allWatchesInfo = new AllWatchesInfo();
		allWatchesInfo.Init();
		return (ActionResult)(object)((Controller)this).PartialView("Watch/ProfileInfo", (object)allWatchesInfo);
	}
}
