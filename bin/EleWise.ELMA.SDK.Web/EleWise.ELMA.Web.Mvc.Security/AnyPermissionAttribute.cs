using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Web.Mvc;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Web.Mvc.Security;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
public class AnyPermissionAttribute : BasePermissionAttribute
{
	private readonly IEnumerable<Guid> permisssionsIds;

	private readonly Type _entityType;

	public IEnumerable<Guid> PermisssionsIds => permisssionsIds;

	public Type EntityType => _entityType;

	public bool Inverse { get; set; }

	public AnyPermissionAttribute(IEnumerable<Guid> permisssionsIds)
	{
		this.permisssionsIds = permisssionsIds;
	}

	public AnyPermissionAttribute(params string[] permisssionsIds)
	{
		this.permisssionsIds = permisssionsIds.Select((string p) => Guid.Parse(p));
	}

	public AnyPermissionAttribute(Type entityType, params string[] permissionsIds)
		: this(permissionsIds)
	{
		_entityType = entityType;
	}

	public override void OnActionExecuting(ActionExecutingContext filterContext)
	{
		try
		{
			if (PermisssionsIds.Any((Guid p) => CheckPermission(p)))
			{
				PermissionActionResultImpl.CheckInstanceAttributePermission(filterContext, Inverse, BasePermissionAttribute.SecurityService, BasePermissionAttribute.PermissionManagmentService);
				return;
			}
			throw new SecurityException();
		}
		catch (SecurityException)
		{
			string errorMsg = GetErrorMsg(BasePermissionAttribute.PermissionManagmentService);
			filterContext.set_Result(PermissionActionResultImpl.AccessDeniedResult(new SecurityException(errorMsg), ((ControllerContext)filterContext).get_Controller()));
		}
	}

	private bool CheckPermission(Guid permissionId)
	{
		Permission permission = BasePermissionAttribute.PermissionManagmentService.GetPermission(permissionId);
		if (permission == null)
		{
			throw new InvalidOperationException(SR.T("Невозможно найти привилегию по Id {0}", permissionId));
		}
		if (permission.PermissionType == PermissionType.Global && (!BasePermissionAttribute.SecurityService.HasPermission(permission) ^ Inverse))
		{
			return false;
		}
		if (permission.PermissionType == PermissionType.EntityType && (EntityType != null || permission.EntityType != null) && (!BasePermissionAttribute.SecurityService.HasPermission(permission, EntityType ?? permission.EntityType) ^ Inverse))
		{
			return false;
		}
		return true;
	}

	private string GetErrorMsg(IPermissionManagmentService permissionManagmentService)
	{
		string text = "";
		foreach (Guid permisssionsId in PermisssionsIds)
		{
			Permission permission = permissionManagmentService.GetPermission(permisssionsId);
			text = text + permission.Name + ", ";
		}
		text = text.Remove(text.Length - 2, 2);
		return SR.T("Нет ни одной из привилегий доступа ({0})", text);
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
			if (BasePermissionAttribute.SecurityService.HasPermission(permission) ^ Inverse)
			{
				return true;
			}
		}
		return false;
	}
}
