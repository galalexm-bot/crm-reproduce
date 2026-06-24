using System;
using System.Collections.Concurrent;
using EleWise.ELMA.Hubs;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace EleWise.ELMA.Web.Hubs;

public static class HubWrappers
{
	private static readonly ConcurrentDictionary<Type, Func<IHubConnectionContext<dynamic>, object>> HubCallerConnectionContextWrapperActivators = new ConcurrentDictionary<Type, Func<IHubConnectionContext<object>, object>>();

	public static IGroupManagerWrapper Wrap(IGroupManager value)
	{
		if (!(value is IGroupManagerWrapper result))
		{
			return new GroupManagerWrapper(value);
		}
		return result;
	}

	public static IHubCallerContextWrapper Wrap(HubCallerContext value)
	{
		if (!(value is IHubCallerContextWrapper result))
		{
			return new HubCallerContextWrapper(value);
		}
		return result;
	}

	public static IHubCallerConnectionContextWrapper<T> Wrap<T>(IHubCallerConnectionContext<object> value)
	{
		if (!(value is IHubCallerConnectionContextWrapper<T> result))
		{
			return (IHubCallerConnectionContextWrapper<T>)HubCallerConnectionContextWrapperActivators.GetOrAdd(typeof(T), delegate(Type type)
			{
				Type proxyType = HubClientProxyHelper.GetProxyType(type);
				Type hubCallerConnectionContextWrapper = typeof(HubCallerConnectionContextWrapper<, >).MakeGenericType(type, proxyType);
				return (IHubConnectionContext<dynamic> param) => (IHubCallerConnectionContextWrapper<T>)Activator.CreateInstance(hubCallerConnectionContextWrapper, param);
			})((IHubConnectionContext<object>)(object)value);
		}
		return result;
	}
}
