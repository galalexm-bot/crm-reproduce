using System;
using System.Security;
using System.Web.Mvc;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Web.Mvc.Security;

public class PermissionAttribute : BasePermissionAttribute
{
	private readonly Guid permisssionId;

	private readonly Type entityType;

	public bool Inverse { get; set; }

	public Guid PermisssionId => permisssionId;

	public Type EntityType => entityType;

	public PermissionAttribute()
	{
		permisssionId = Guid.Empty;
	}

	public PermissionAttribute(Guid permissionId)
	{
		permisssionId = permissionId;
	}

	public PermissionAttribute(string permissionId)
	{
		permisssionId = Guid.Parse(permissionId);
	}

	public PermissionAttribute(string permissionId, Type entityType)
		: this(permissionId)
	{
		this.entityType = entityType;
	}

	public override void OnActionExecuting(ActionExecutingContext filterContext)
	{
		try
		{
			if (PermisssionId != Guid.Empty)
			{
				Permission permission = BasePermissionAttribute.PermissionManagmentService.GetPermission(PermisssionId);
				if (permission == null)
				{
					throw new InvalidOperationException(SR.T("Невозможно найти привилегию по Id {0}", PermisssionId));
				}
				if (permission.PermissionType == PermissionType.Global && (!BasePermissionAttribute.SecurityService.HasPermission(permission) ^ Inverse))
				{
					throw new SecurityException(SR.T("Отсутствует привилегия \"{0}\"", SR.T(permission.Name)));
				}
				if (permission.PermissionType == PermissionType.EntityType && (EntityType != null || permission.EntityType != null) && (!BasePermissionAttribute.SecurityService.HasPermission(permission, EntityType ?? permission.EntityType) ^ Inverse))
				{
					throw new SecurityException(SR.T("Отсутствует привилегия \"{0}\"", SR.T(permission.Name)));
				}
			}
			PermissionActionResultImpl.CheckInstanceAttributePermission(filterContext, Inverse, BasePermissionAttribute.SecurityService, BasePermissionAttribute.PermissionManagmentService);
		}
		catch (SecurityException securityException)
		{
			filterContext.set_Result(PermissionActionResultImpl.AccessDeniedResult(securityException, ((ControllerContext)filterContext).get_Controller()));
		}
	}

	public override bool HasPermission()
	{
		if (PermisssionId == Guid.Empty)
		{
			return false;
		}
		Permission permission = BasePermissionAttribute.PermissionManagmentService.GetPermission(PermisssionId);
		if (permission == null)
		{
			throw new InvalidOperationException(SR.T("Невозможно найти привилегию по Id {0}", PermisssionId));
		}
		if (permission.PermissionType == PermissionType.Global)
		{
			return BasePermissionAttribute.SecurityService.HasPermission(permission) ^ Inverse;
		}
		if (permission.PermissionType == PermissionType.EntityType)
		{
			if (EntityType != null || permission.EntityType != null)
			{
				return BasePermissionAttribute.SecurityService.HasPermission(permission, EntityType ?? permission.EntityType) ^ Inverse;
			}
			return false;
		}
		return false;
	}
}
