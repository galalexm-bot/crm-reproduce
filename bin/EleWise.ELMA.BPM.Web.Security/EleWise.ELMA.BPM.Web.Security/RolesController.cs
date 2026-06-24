using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.BPM.Web.Security.Controllers;

[Permission("0B298062-9DE5-46E5-8D1D-C46B3680809A")]
public class RolesController : BPMController<IUserGroup, long>
{
	public enum RoleTarget
	{
		Permission,
		GroupUser,
		User
	}

	public UserGroupManager UserGroupManager { get; set; }

	public GroupPermissionManager GroupPermissionManager { get; set; }

	public new IUnitOfWorkManager UnitOfWorkManager { get; set; }

	public IPermissionManagmentService PermissionManagmentService { get; set; }

	public ActionResult Index()
	{
		return (ActionResult)(object)((Controller)this).View();
	}

	[HttpGet]
	public ActionResult AssignRoles(string id, RoleTarget roleTarget, string redirectAction, string redirectController, string redirectArea, string callback)
	{
		ICollection<IUserGroup> roles = UserGroupManager.FindAll();
		AssignRolesModel assignRolesModel = new AssignRolesModel
		{
			Roles = roles,
			RedirectAction = redirectAction,
			RedirectController = redirectController,
			RedirectArea = redirectArea,
			Callback = callback
		};
		return (ActionResult)(object)((Controller)this).PartialView((object)assignRolesModel);
	}

	[HttpPost]
	public ActionResult AssignRoles(string id, RoleTarget roleTarget, long[] roles, string redirectAction, string redirectController, string redirectArea, string callback)
	{
		if (roleTarget == RoleTarget.Permission)
		{
			if (!Guid.TryParse(id, out var result))
			{
				return (ActionResult)(object)((Controller)this).HttpNotFound();
			}
			Permission permission = PermissionManagmentService.GetPermission(result);
			if (permission == null)
			{
				return (ActionResult)(object)((Controller)this).HttpNotFound();
			}
			if (roles == null || !roles.Any())
			{
				base.Notifier.Warning(SR.T("Не выбранна ни одна группа."));
				return (ActionResult)(object)((Controller)this).RedirectToAction(redirectAction, redirectController, (object)new
				{
					area = redirectArea,
					callback = callback
				});
			}
			IEnumerable<IUserGroup> rolesToAssing = roles.Select((long roleId) => UserGroupManager.Load(roleId));
			UnitOfWorkManager.Execute((Action)delegate
			{
				rolesToAssing.ForEach(delegate(IUserGroup r)
				{
					GroupPermissionManager.GrantPermission(r, permission);
				});
			});
			string text = string.Join(", ", rolesToAssing.Select((IUserGroup r) => r.Name).ToArray());
			base.Notifier.Information(MvcHtmlString.Create(SR.T("Назначены роли {0} на привилегию {1} модуля {2}", text, permission.Name, SR.T(permission.Category))));
			return (ActionResult)(object)((Controller)this).RedirectToAction(redirectAction, redirectController, (object)new
			{
				area = redirectArea,
				callback = callback
			});
		}
		throw new NotImplementedException();
	}

	[HttpPost]
	public ActionResult RemoveRole(string id, RoleTarget roleTarget, long roleId, string redirectAction, string redirectController, string redirectArea, string callback)
	{
		if (!Guid.TryParse(id, out var result))
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		try
		{
			Permission permission = PermissionManagmentService.GetPermission(result);
			if (permission == null)
			{
				return (ActionResult)(object)((Controller)this).HttpNotFound();
			}
			if (roleTarget == RoleTarget.Permission)
			{
				IUserGroup userGroup = UserGroupManager.Load(roleId);
				GroupPermissionManager.RemovePermission(userGroup, permission);
				base.Notifier.Information(MvcHtmlString.Create(SR.T("Удалена роль {0} из привилегии {1} модуля {2}", userGroup.Name, permission.Name, SR.T(permission.Category))));
				return (ActionResult)(object)((Controller)this).RedirectToAction(redirectAction, redirectController, (object)new
				{
					area = redirectArea,
					callback = callback
				});
			}
		}
		catch (Exception exception)
		{
			FormNotifierExtensions.Error(base.Notifier, exception);
			return (ActionResult)(object)((Controller)this).RedirectToAction(redirectAction, redirectController, (object)new
			{
				area = redirectArea,
				callback = callback
			});
		}
		throw new NotImplementedException();
	}
}
