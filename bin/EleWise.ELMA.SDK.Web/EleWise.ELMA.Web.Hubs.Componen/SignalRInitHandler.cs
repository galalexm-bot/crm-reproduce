using System;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Web.Service.v1;
using Microsoft.AspNet.SignalR;
using Owin;

namespace EleWise.ELMA.Web.Hubs.Components;

[Component(Type = ComponentType.Web)]
internal class SignalRInitHandler : IInitHandler
{
	private readonly IRuntimeApplication runtimeApplication;

	public AuthorizationService AuthorizationService { get; set; }

	public SignalRInitHandler(IRuntimeApplication runtimeApplication)
	{
		this.runtimeApplication = runtimeApplication;
	}

	public void Init()
	{
	}

	public void InitComplete()
	{
		if (!(runtimeApplication.GetType() != typeof(RuntimeApplication)))
		{
			GlobalHost.get_DependencyResolver().Register(typeof(IUserIdProvider), (Func<object>)(() => new HubUserIdProvider(AuthorizationService)));
			RouteCollectionExtensions.MapOwinPath(RouteTable.Routes, "/signalr", (Action<IAppBuilder>)delegate(IAppBuilder app)
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				//IL_000d: Expected O, but got Unknown
				HubConfiguration val = new HubConfiguration();
				val.set_EnableDetailedErrors(true);
				HubConfiguration val2 = val;
				OwinExtensions.RunSignalR(app, val2);
			});
		}
	}
}
