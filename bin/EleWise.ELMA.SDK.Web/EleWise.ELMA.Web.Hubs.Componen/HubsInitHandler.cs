using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Web.Routing;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Hubs.Internal;
using EleWise.ELMA.Web.Service.v1;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using Newtonsoft.Json;
using Owin;

namespace EleWise.ELMA.Web.Hubs.Components;

[Component(Type = ComponentType.Web)]
internal class HubsInitHandler : IInitHandler
{
	private const int MaxMessageSize = 20971520;

	private readonly IAutofacDependencyResolver autofacDependencyResolver;

	private readonly IRuntimeApplication runtimeApplication;

	private readonly AuthorizationService authorizationService;

	private const string HostReferencedAssembliesKey = "host.ReferencedAssemblies";

	public HubsInitHandler(IAutofacDependencyResolver autofacDependencyResolver, IRuntimeApplication runtimeApplication, AuthorizationService authorizationService)
	{
		this.autofacDependencyResolver = autofacDependencyResolver;
		this.runtimeApplication = runtimeApplication;
		this.authorizationService = authorizationService;
	}

	public void Init()
	{
	}

	public void InitComplete()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		if (runtimeApplication.GetType() != typeof(RuntimeApplication))
		{
			return;
		}
		JsonSerializer serializer = new JsonSerializer();
		serializer.set_ReferenceLoopHandling((ReferenceLoopHandling)1);
		((Collection<JsonConverter>)(object)serializer.get_Converters()).Add((JsonConverter)(object)SimpleTypesConverter.Instance);
		((Collection<JsonConverter>)(object)serializer.get_Converters()).Add((JsonConverter)(object)ViewItemConverter.Instance);
		GlobalHost.set_DependencyResolver((IDependencyResolver)autofacDependencyResolver);
		GlobalHost.get_DependencyResolver().Register(typeof(JsonSerializer), (Func<object>)(() => serializer));
		GlobalHost.get_DependencyResolver().Register(typeof(IUserIdProvider), (Func<object>)(() => new HubUserIdProvider(authorizationService)));
		GlobalHost.get_DependencyResolver().Register(typeof(IHubDescriptorProvider), (Func<object>)(() => new HubDescriptorProvider()));
		GlobalHost.get_DependencyResolver().Register(typeof(IHubActivator), (Func<object>)(() => new HubActivator(GlobalHost.get_DependencyResolver())));
		GlobalHost.get_Configuration().set_MaxIncomingWebSocketMessageSize((int?)20971520);
		RouteCollectionExtensions.MapOwinPath(RouteTable.Routes, "/signalr", (Action<IAppBuilder>)delegate(IAppBuilder app)
		{
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Expected O, but got Unknown
			List<Assembly> list = (from assembly in AppDomain.CurrentDomain.GetAssemblies()
				where assembly.GetName().Name == "EleWise.ELMA.SignalRHubs"
				select assembly).ToList();
			if (app.get_Properties().ContainsKey("host.ReferencedAssemblies") && app.get_Properties()["host.ReferencedAssemblies"] is IEnumerable<Assembly> collection)
			{
				list.AddRange(collection);
			}
			app.get_Properties()["host.ReferencedAssemblies"] = list;
			HubConfiguration val = new HubConfiguration();
			val.set_EnableDetailedErrors(true);
			HubConfiguration val2 = val;
			OwinExtensions.RunSignalR(app, val2);
			Locator.GetService<ICacheService>()?.Insert("EleWise.ELMA.Web.Hubs.Components.HubsInitHandler.InitComplete.HubIsRunning", value: true);
		});
	}
}
