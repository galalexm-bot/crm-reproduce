using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.Web.Service;

[Service(Scope = ServiceScope.Shell)]
internal sealed class ContentActionUtilsService : IContentActionUtilsService
{
	private readonly IModuleService moduleService;

	private readonly IComponentManager componentManager;

	public ContentActionUtilsService(IModuleService moduleService, IComponentManager componentManager)
	{
		this.moduleService = moduleService;
		this.componentManager = componentManager;
	}

	public string GetCategory(Type declaringType)
	{
		return moduleService.GetModuleByType(declaringType)?.DisplayName;
	}

	public Func<RequestContext, bool> PermissionDelegate(MethodInfo methodInfo)
	{
		List<BasePermissionAttribute> permissionAttributes = methodInfo.GetCustomAttributes(typeof(BasePermissionAttribute), inherit: true).Union(methodInfo.DeclaringType.GetCustomAttributes(typeof(BasePermissionAttribute), inherit: true)).Cast<BasePermissionAttribute>()
			.ToList();
		if (permissionAttributes.Count == 0)
		{
			return null;
		}
		return (RequestContext r) => permissionAttributes.All((BasePermissionAttribute a) => a.HasPermission());
	}

	public IEnumerable<Type> GetBaseControllerTypes()
	{
		return componentManager.GetExtensionPointTypes(typeof(IBaseController));
	}
}
