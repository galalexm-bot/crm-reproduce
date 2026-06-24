using System;
using System.Collections.Concurrent;
using EleWise.ELMA.Hubs;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace EleWise.ELMA.Web.Hubs;

internal sealed class HubContextWrapper<T> : IHubContextWrapper<T> where T : IClient
{
	private readonly IHubContext signalrContext;

	private static readonly ConcurrentDictionary<Type, Func<IHubConnectionContext<dynamic>, object>> HubConnectionContextWrapperActivators = new ConcurrentDictionary<Type, Func<IHubConnectionContext<object>, object>>();

	public IHubConnectionContextWrapper<T> Clients => (IHubConnectionContextWrapper<T>)HubConnectionContextWrapperActivators.GetOrAdd(typeof(T), delegate(Type type)
	{
		Type proxyType = HubClientProxyHelper.GetProxyType(type);
		Type hubConnectionContextWrapper = typeof(HubConnectionContextWrapper<, >).MakeGenericType(type, proxyType);
		return (IHubConnectionContext<dynamic> param) => Activator.CreateInstance(hubConnectionContextWrapper, param);
	})(signalrContext.get_Clients());

	public IGroupManagerWrapper Groups => new GroupManagerWrapper(signalrContext.get_Groups());

	public HubContextWrapper(IHubContext signalrContext)
	{
		this.signalrContext = signalrContext;
	}
}
