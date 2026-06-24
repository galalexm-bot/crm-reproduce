using System;
using System.Collections.Generic;
using EleWise.ELMA.Hubs;
using Microsoft.AspNet.SignalR.Hubs;

namespace EleWise.ELMA.Web.Hubs;

internal class HubConnectionContextWrapper<THubClient, THubClientProxy> : IHubConnectionContextWrapper<THubClient> where THubClient : IClient
{
	private readonly IHubConnectionContext<THubClientProxy> hubConnectionContext;

	private readonly Func<object, IClient> wrapperFactory;

	public THubClient All => (THubClient)wrapperFactory(((IHubConnectionContext<_003F>)(object)hubConnectionContext).get_All());

	public HubConnectionContextWrapper(IHubConnectionContext<dynamic> hubConnectionContext)
	{
		wrapperFactory = HubClientProxyHelper.GetProxyWrapperFactory(typeof(THubClient));
		this.hubConnectionContext = (IHubConnectionContext<THubClientProxy>)(object)new TypedHubConnectionContext<_003F>((IHubConnectionContext<object>)hubConnectionContext);
	}

	public THubClient AllExcept(params string[] excludeConnectionIds)
	{
		return (THubClient)wrapperFactory(((IHubConnectionContext<_003F>)(object)hubConnectionContext).AllExcept(excludeConnectionIds));
	}

	public THubClient Client(string connectionId)
	{
		return (THubClient)wrapperFactory(((IHubConnectionContext<_003F>)(object)hubConnectionContext).Client(connectionId));
	}

	public THubClient Clients(IList<string> connectionIds)
	{
		return (THubClient)wrapperFactory(((IHubConnectionContext<_003F>)(object)hubConnectionContext).Clients(connectionIds));
	}

	public THubClient Group(string groupName, params string[] excludeConnectionIds)
	{
		return (THubClient)wrapperFactory(((IHubConnectionContext<_003F>)(object)hubConnectionContext).Group(groupName, excludeConnectionIds));
	}

	public THubClient Groups(IList<string> groupNames, params string[] excludeConnectionIds)
	{
		return (THubClient)wrapperFactory(((IHubConnectionContext<_003F>)(object)hubConnectionContext).Groups(groupNames, excludeConnectionIds));
	}

	public THubClient User(string userId)
	{
		return (THubClient)wrapperFactory(((IHubConnectionContext<_003F>)(object)hubConnectionContext).User(userId));
	}

	public THubClient Users(IList<string> userIds)
	{
		return (THubClient)wrapperFactory(((IHubConnectionContext<_003F>)(object)hubConnectionContext).Users(userIds));
	}
}
