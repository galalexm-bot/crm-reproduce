using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Web.Mvc;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Web.Mvc.Security;

public class AllPermissionsAttribute : BasePermissionAttribute
{
	private readonly IEnumerable<Guid> permisssionsIds;

	private readonly Type _entityType;

	public IEnumerable<Guid> PermisssionsIds => permisssionsIds;

	public Type EntityType => _entityType;

	public AllPermissionsAttribute(IEnumerable<Guid> permisssionsIds)
	{
		this.permisssionsIds = permisssionsIds;
	}

	public AllPermissionsAttribute(params string[] permisssionsIds)
	{
		this.permisssionsIds = permisssionsIds.Select((string p) => Guid.Parse(p));
	}

	public AllPermissionsAttribute(Type entityType, params string[] permissionsIds)
		: this(permissionsIds)
	{
		_entityType = entityType;
	}

	public override void OnActionExecuting(ActionExecutingContext filterContext)
	{
		try
		{
			if (PermisssionsIds.All((Guid p) => CheckPermission(p)))
			{
				PermissionActionResultImpl.CheckInstanceAttributePermission(filterContext, Inverse: false, BasePermissionAttribute.SecurityService, BasePermissionAttribute.PermissionManagmentService);
			}
		}
		catch (SecurityException securityException)
		{
			filterContext.set_Result(PermissionActionResultImpl.AccessDeniedResult(securityException, ((ControllerContext)filterContext).get_Controller()));
		}
	}

	private bool CheckPermission(Guid permissionId)
	{
		Permission permission = BasePermissionAttribute.PermissionManagmentService.GetPermission(permissionId);
		if (permission == null)
		{
			throw new InvalidOperationException(SR.T("Невозможно найти привилегию по Id {0}", permissionId));
		}
		if (permission.PermissionType == PermissionType.Global && !BasePermissionAttribute.SecurityService.HasPermission(permission))
		{
			throw new SecurityException(SR.T("Отсутствует привилегия \"{0}\"", SR.T(permission.Name)));
		}
		if (permission.PermissionType == PermissionType.EntityType && (EntityType != null || permission.EntityType != null) && !BasePermissionAttribute.SecurityService.HasPermission(permission, EntityType ?? permission.EntityType))
		{
			throw new SecurityException(SR.T("Отсутствует привилегия \"{0}\"", SR.T(permission.Name)));
		}
		return true;
	}

	public override bool HasPermission()
	{
		foreach (Guid permisssionsId in PermisssionsIds)
		{
			Permission permission = BasePermissionAttribute.PermissionManagmentService.GetPermission(permisssionsId);
			if (permission == null)
			{
				throw new InvalidOperationException(SR.T("Невозможно найти привилегию по Id {0}", permisssionsId));
			}
			if (permission.PermissionType != PermissionType.Global)
			{
				return false;
			}
			if (!BasePermissionAttribute.SecurityService.HasPermission(permission))
			{
				return false;
			}
		}
		return true;
	}
}
