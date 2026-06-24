using System;
using System.Linq;
using System.Security;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Web.Mvc.Security;

public class FunctionPermissionAttribute : BasePermissionAttribute
{
	private readonly Guid functionPermissionProvider;

	private readonly string idParamName;

	private readonly Type entityType;

	private readonly Guid permisssionId;

	public FunctionPermissionAttribute(Guid functionPermissionProviderId, Type entityType, string idParamName, Guid permissionId)
	{
		functionPermissionProvider = functionPermissionProviderId;
		this.idParamName = idParamName;
		this.entityType = InterfaceActivator.TypeOf(entityType);
		permisssionId = permissionId;
	}

	public FunctionPermissionAttribute(string functionPermissionProviderId, Type entityType, string idParamName, string permissionId)
		: this(new Guid(functionPermissionProviderId), entityType, idParamName, new Guid(permissionId))
	{
	}

	public FunctionPermissionAttribute(string functionPermissionProviderId)
	{
		functionPermissionProvider = new Guid(functionPermissionProviderId);
	}

	public override void OnActionExecuting(ActionExecutingContext filterContext)
	{
		IFunctionPermissionProvider functionPermissionProvider = ComponentManager.Current.GetExtensionPoints<IFunctionPermissionProvider>().FirstOrDefault((IFunctionPermissionProvider p) => p.Uid == this.functionPermissionProvider);
		if (functionPermissionProvider == null)
		{
			return;
		}
		long result = 0L;
		if (((ControllerContext)filterContext).get_RouteData().Values.TryGetValue(idParamName, out var value) && !long.TryParse(value.ToString(), out result))
		{
			result = 0L;
		}
		if (result == 0L)
		{
			return;
		}
		try
		{
			functionPermissionProvider.CheckPermission(entityType, result, permisssionId);
		}
		catch (SecurityException securityException)
		{
			filterContext.set_Result(PermissionActionResultImpl.AccessDeniedResult(securityException, ((ControllerContext)filterContext).get_Controller()));
		}
	}

	public override bool HasPermission()
	{
		return true;
	}
}
