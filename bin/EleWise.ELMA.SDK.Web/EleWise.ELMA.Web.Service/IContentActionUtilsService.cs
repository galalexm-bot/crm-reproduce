using System;
using System.Collections.Generic;
using System.Reflection;
using System.Web.Routing;

namespace EleWise.ELMA.Web.Service;

public interface IContentActionUtilsService
{
	string GetCategory(Type declaringType);

	Func<RequestContext, bool> PermissionDelegate(MethodInfo methodInfo);

	IEnumerable<Type> GetBaseControllerTypes();
}
