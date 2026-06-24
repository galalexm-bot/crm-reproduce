using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.DynamicProxy;

[ServiceContract]
public interface IMiddlewareService
{
	InvocationContext CreateContext(MethodInfo method, System.Type targetType, object[] arguments, Dictionary<string, object> contextVars, Func<InvocationContext, System.Threading.Tasks.Task> next = null);

	System.Threading.Tasks.Task Proceed(InvocationContext invContext);
}
