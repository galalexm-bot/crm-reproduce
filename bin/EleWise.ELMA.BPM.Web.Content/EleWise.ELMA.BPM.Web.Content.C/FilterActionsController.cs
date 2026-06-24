using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.BPM.Web.Content.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Content.Models;
using EleWise.ELMA.BPM.Web.Security.Services;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Html.EditableList;

namespace EleWise.ELMA.BPM.Web.Content.Controllers;

public class FilterActionsController : BPMController<IFilterActionLink, long>
{
	public FilterMenuProvider FilterMenuProvider { get; set; }

	public PermissionsModelService PermissionsModelService { get; set; }

	public ContentActionRegistry ContentActionRegistry { get; set; }

	[HttpGet]
	public ActionResult AddLink(Guid TypeUid, long ParentFilterFolderId, Guid? code)
	{
		IFilterFolder filterFolder = FilterFolderManager.Instance.Load(ParentFilterFolderId);
		FilterActionLinkModel filterActionLinkModel = new FilterActionLinkModel();
		InstanceOf<IFilterActionLink> instanceOf = new InstanceOf<IFilterActionLink>();
		instanceOf.New.ObjectsType = new ReferenceOnEntityType
		{
			TypeUid = TypeUid
		};
		instanceOf.New.ParentFolder = filterFolder;
		instanceOf.New.Code = code;
		filterActionLinkModel.ActionLink = instanceOf.New;
		FilterActionLinkModel filterActionLinkModel2 = filterActionLinkModel;
		filterActionLinkModel2.ActionLink.FilterType = filterFolder.FilterType;
		return (ActionResult)(object)((Controller)this).PartialView("EditForm", (object)filterActionLinkModel2);
	}

	[HttpGet]
	public ActionResult EditLink(long id)
	{
		IFilterActionLink action = EntityManager<IFilterActionLink>.Instance.Load(id);
		FilterActionLinkModel filterActionLinkModel = new FilterActionLinkModel
		{
			ActionLink = action,
			Link = LinkModel.Create(ContentActionRegistry, action.ActionTypeProviderId, action.ActionId)
		};
		IEnumerable<IFilterActionLinkReadOnlyExtension> extensionPoints = ComponentManager.Current.GetExtensionPoints<IFilterActionLinkReadOnlyExtension>();
		filterActionLinkModel.Link.ReadOnly = extensionPoints.Any((IFilterActionLinkReadOnlyExtension p) => p.MustBeReadOnly(action));
		return (ActionResult)(object)((Controller)this).PartialView("EditForm", (object)filterActionLinkModel);
	}

	[HttpPost]
	public ActionResult SaveLink(FilterActionLinkModel model, LinkModel linkModel, EditableListModel access, EditableListModel pageAccess)
	{
		string error = null;
		if (string.IsNullOrEmpty(linkModel.ActionTypeProviderId) || string.IsNullOrEmpty(linkModel.ActionId))
		{
			error = SR.T("Не выбрано действие, ссылка не будет сохранена.");
		}
		else
		{
			model.ActionLink.ActionTypeProviderId = linkModel.ActionTypeProviderId;
			model.ActionLink.ActionId = linkModel.ActionId;
			if (access != null && access.Items != null)
			{
				PermissionsModelService.BindPermissionsFromModel(model.ActionLink, access, delegate(ICollection<IInstanceSettingsPermissionHolder> holders, IEnumerable<IInstanceSettingsPermissionHolder> newHolders)
				{
					new List<IInstanceSettingsPermissionHolder>();
					holders.SyncFrom(newHolders, (IInstanceSettingsPermissionHolder v1, IInstanceSettingsPermissionHolder v2) => v1.TypeRoleId == v2.TypeRoleId && v1.PermissionId == v2.PermissionId && object.Equals(v1.Assigned, v2.Assigned), null, delegate(IInstanceSettingsPermissionHolder v)
					{
						if (v is IEntity)
						{
							((IEntity)v).Delete();
						}
					});
				});
			}
			model.ActionLink.Save();
			if (pageAccess != null && pageAccess.Items != null && long.TryParse(model.ActionLink.ActionId, out var result))
			{
				IPageBase pageBase = EntityManager<IPageBase>.Instance.LoadOrNull(result);
				if (pageBase != null)
				{
					PermissionsModelService.BindPermissionsFromModel(pageBase, pageAccess, delegate(ICollection<IInstanceSettingsPermissionHolder> holders, IEnumerable<IInstanceSettingsPermissionHolder> newHolders)
					{
						new List<IInstanceSettingsPermissionHolder>();
						holders.SyncFrom(newHolders, (IInstanceSettingsPermissionHolder v1, IInstanceSettingsPermissionHolder v2) => v1.TypeRoleId == v2.TypeRoleId && v1.PermissionId == v2.PermissionId && object.Equals(v1.Assigned, v2.Assigned), null, delegate(IInstanceSettingsPermissionHolder v)
						{
							if (v is IEntity)
							{
								((IEntity)v).Delete();
							}
						});
					});
					pageBase.Save();
				}
			}
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			message = SR.T("Новая ссылка сохранена"),
			error = error,
			tree = FilterMenuProvider.BuildJson(model.ActionLink.ObjectsType.TypeUid, model.ActionLink.Code)
		}, (JsonRequestBehavior)0);
	}

	public ActionResult PageAccessTab(string actionId)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		if (long.TryParse(actionId, out var result))
		{
			return (ActionResult)(object)((Controller)this).PartialView("PageAccessTab", (object)result);
		}
		ContentResult val = new ContentResult();
		val.set_Content(SR.T("Страница не задана"));
		return (ActionResult)val;
	}

	public ActionResult DeleteLink(Guid TypeUid, long Id, Guid? code)
	{
		string message = string.Empty;
		string error = string.Empty;
		object tree = new object();
		try
		{
			EntityManager<IFilterActionLink>.Instance.Load(Id).Delete();
			message = SR.T("Ссылка удалена");
			tree = FilterMenuProvider.BuildJson(TypeUid, code);
		}
		catch (Exception ex)
		{
			error = SR.T("Ошибка удаления: ") + ex.Message;
		}
		return (ActionResult)(object)((Controller)this).Json((object)new { message, error, tree }, (JsonRequestBehavior)0);
	}

	[HttpPost]
	public ActionResult FilterInFavorites(long id, string activeMenuItemCode)
	{
		Guid guid = Guid.Empty;
		Guid? code = null;
		IFilterFavoriteMenuExtension filterFavoriteMenuExtension = ComponentManager.Current.GetExtensionPoints<IFilterFavoriteMenuExtension>().FirstOrDefault((IFilterFavoriteMenuExtension p) => p.HasMenuItemCode(activeMenuItemCode));
		if (filterFavoriteMenuExtension != null)
		{
			guid = filterFavoriteMenuExtension.GetFilterTreeTypeUid();
			code = filterFavoriteMenuExtension.GetFilterTreeCode();
		}
		if (guid == Guid.Empty)
		{
			return SuccessJson();
		}
		IPageBase pageBase = EntityManager<IPageBase>.Instance.LoadOrNull(id);
		if (pageBase != null)
		{
			ReferenceOnEntityType referenceOnEntityType = new ReferenceOnEntityType
			{
				TypeUid = guid
			};
			IFilterFolder filterFolder = FilterFolderManager.Instance.LoadFavoriteFilterFolder(referenceOnEntityType, code);
			if (filterFolder == null)
			{
				filterFolder = FilterFolderManager.Instance.LoadOrCreateFavoriteFilterFolders(referenceOnEntityType, code).FirstOrDefault((IFilterFolder f) => f.ParentFolder == null);
			}
			IFilterActionLink filterActionLink = (from f in FilterFolderManager.Instance.LoadFavoriteFilters(referenceOnEntityType, code)
				where f.ParentFolder != null
				select f).Cast<IFilterActionLink>().FirstOrDefault((IFilterActionLink f) => f.ActionId == id.ToString());
			if (filterActionLink == null)
			{
				filterActionLink = FilterActionLinkManager.Instance.Create();
				filterActionLink.ActionTypeProviderId = "PagesLinkTypeProvider";
				filterActionLink.ActionId = id.ToString();
				filterActionLink.ObjectsType = referenceOnEntityType;
				filterActionLink.FilterType = FilterType.FavoriteFilter;
				filterActionLink.Name = pageBase.Name;
				filterActionLink.ParentFolder = filterFolder;
				filterActionLink.Code = code;
				AssignPermissions(filterActionLink);
				filterActionLink.Save();
			}
			else
			{
				FilterActionLinkManager.Instance.Delete(filterActionLink);
			}
		}
		return SuccessJson();
	}

	private void AssignPermissions(IFilterActionLink actionLink)
	{
		EleWise.ELMA.Security.Models.IUser currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		long userMask = UserSecuritySetHelper.GetUserMask(currentUser.Id);
		InstanceOf<IFilterPermission> instanceOf = new InstanceOf<IFilterPermission>();
		instanceOf.New.Filter = actionLink;
		instanceOf.New.PermissionId = EleWise.ELMA.Common.PermissionProvider.FilterViewPermission.Id;
		instanceOf.New.TypeRoleId = CommonRoleTypes.User.Id;
		instanceOf.New.User = currentUser;
		instanceOf.New.UserSecuritySetCacheId = userMask;
		IFilterPermission @new = instanceOf.New;
		actionLink.Permissions.Add(@new);
	}
}
