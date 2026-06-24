using System;
using System.ComponentModel;
using System.Threading.Tasks;
using EleWise.ELMA.Hubs;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace EleWise.ELMA.Web.Hubs;

[EditorBrowsable(EditorBrowsableState.Never)]
public abstract class HubProxy<THub, TClient> : IHub, IUntrackedDisposable, IDisposable where THub : IHub where TClient : IClient
{
	protected readonly HubBase<TClient> Hub;

	public HubCallerContext Context
	{
		get
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			return (HubCallerContext)Hub.Context;
		}
		set
		{
			Hub.Context = HubWrappers.Wrap(value);
		}
	}

	public IHubCallerConnectionContext<dynamic> Clients
	{
		get
		{
			return (IHubCallerConnectionContext<object>)Hub.Clients;
		}
		set
		{
			Hub.Clients = HubWrappers.Wrap<TClient>(value);
		}
	}

	public IGroupManager Groups
	{
		get
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			return (IGroupManager)Hub.Groups;
		}
		set
		{
			Hub.Groups = HubWrappers.Wrap(value);
		}
	}

	protected HubProxy(THub hub)
	{
		Hub = hub as HubBase<TClient>;
		if (Hub == null)
		{
			throw new ArgumentException(SR.T("Ошибка приведения '{0}' к '{1}'", hub.GetType().FullName, typeof(HubBase<TClient>).FullName));
		}
	}

	public void Dispose()
	{
		Hub.Dispose();
	}

	public Task OnConnected()
	{
		return Hub.OnConnected();
	}

	public Task OnReconnected()
	{
		return Hub.OnReconnected();
	}

	public Task OnDisconnected(bool stopCalled)
	{
		return Hub.OnDisconnected(stopCalled);
	}
}
