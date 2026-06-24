using System;
using System.Collections.Generic;
using EleWise.ELMA.Hubs;
using Microsoft.AspNet.SignalR.Hubs;

namespace EleWise.ELMA.Web.Hubs;

internal sealed class HubCallerConnectionContextWrapper<THubClient, THubClientProxy> : HubConnectionContextWrapper<THubClient, THubClientProxy>, IHubCallerConnectionContextWrapper<THubClient>, IHubConnectionContextWrapper<THubClient>, IHubCallerConnectionContext<object>, IHubConnectionContext<object> where THubClient : IClient
{
	private readonly IHubCallerConnectionContext<THubClientProxy> hubCallerConnectionContext;

	private readonly Func<object, IClient> wrapperFactory;

	public THubClient Caller => (THubClient)wrapperFactory(((IHubCallerConnectionContext<_003F>)(object)hubCallerConnectionContext).get_Caller());

	public dynamic CallerState => ((IHubCallerConnectionContext<_003F>)(object)hubCallerConnectionContext).get_CallerState();

	public THubClient Others => (THubClient)wrapperFactory(((IHubCallerConnectionContext<_003F>)(object)hubCallerConnectionContext).get_Others());

	object Caller => Caller;

	dynamic CallerState => CallerState;

	object Others => Others;

	object All => base.All;

	public HubCallerConnectionContextWrapper(IHubCallerConnectionContext<dynamic> hubCallerConnectionContext)
		: base((IHubConnectionContext<dynamic>)(object)hubCallerConnectionContext)
	{
		wrapperFactory = HubClientProxyHelper.GetProxyWrapperFactory(typeof(THubClient));
		this.hubCallerConnectionContext = (IHubCallerConnectionContext<THubClientProxy>)(object)new TypedHubCallerConnectionContext<_003F>((IHubCallerConnectionContext<object>)hubCallerConnectionContext);
	}

	public THubClient OthersInGroup(string groupName)
	{
		return (THubClient)wrapperFactory(((IHubCallerConnectionContext<_003F>)(object)hubCallerConnectionContext).OthersInGroup(groupName));
	}

	public THubClient OthersInGroups(IList<string> groupNames)
	{
		return (THubClient)wrapperFactory(((IHubCallerConnectionContext<_003F>)(object)hubCallerConnectionContext).OthersInGroups(groupNames));
	}

	object IHubCallerConnectionContext<object>.OthersInGroup(string groupName)
	{
		return OthersInGroup(groupName);
	}

	object IHubCallerConnectionContext<object>.OthersInGroups(IList<string> groupNames)
	{
		return OthersInGroups(groupNames);
	}

	object IHubConnectionContext<object>.AllExcept(params string[] excludeConnectionIds)
	{
		return AllExcept(excludeConnectionIds);
	}

	object IHubConnectionContext<object>.Client(string connectionId)
	{
		return Client(connectionId);
	}

	object IHubConnectionContext<object>.Clients(IList<string> connectionIds)
	{
		return Clients(connectionIds);
	}

	object IHubConnectionContext<object>.Group(string groupName, params string[] excludeConnectionIds)
	{
		return Group(groupName, excludeConnectionIds);
	}

	object IHubConnectionContext<object>.Groups(IList<string> groupNames, params string[] excludeConnectionIds)
	{
		return Groups(groupNames, excludeConnectionIds);
	}

	object IHubConnectionContext<object>.User(string userId)
	{
		return User(userId);
	}

	object IHubConnectionContext<object>.Users(IList<string> userIds)
	{
		return Users(userIds);
	}
}
