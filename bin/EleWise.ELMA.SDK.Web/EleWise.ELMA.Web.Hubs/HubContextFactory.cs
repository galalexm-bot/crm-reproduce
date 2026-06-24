using System;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Hubs;
using EleWise.ELMA.Hubs.Attributes;
using Microsoft.AspNet.SignalR;

namespace EleWise.ELMA.Web.Hubs;

[Service(EnableInterceptors = false, InjectProperties = false)]
internal sealed class HubContextFactory : IHubContextFactory
{
	private readonly ICacheService cacheService;

	public HubContextFactory(ICacheService cacheService)
	{
		this.cacheService = cacheService;
	}

	public IHubContextWrapper<TClient> GetContext<THub, TClient>() where TClient : IClient
	{
		if (!cacheService.TryGetValue<bool>("EleWise.ELMA.Web.Hubs.Components.HubsInitHandler.InitComplete.HubIsRunning", out var value) || !value)
		{
			return null;
		}
		Type typeFromHandle = typeof(THub);
		HubNameAttribute attribute = AttributeHelper<HubNameAttribute>.GetAttribute(typeFromHandle, inherited: false);
		string text = ((attribute != null) ? attribute.HubName : typeFromHandle.Name.ToLowerFirstChar());
		return new HubContextWrapper<TClient>(GlobalHost.get_ConnectionManager().GetHubContext(text));
	}
}
