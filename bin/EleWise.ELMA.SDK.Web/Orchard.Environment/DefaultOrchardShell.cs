using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac.Features.OwnedInstances;
using EleWise.ELMA.Logging;
using Microsoft.Owin.Builder;
using Orchard.Environment.Configuration;
using Orchard.Exceptions;
using Orchard.Mvc.ModelBinders;
using Orchard.Mvc.Routes;
using Orchard.Owin;
using Orchard.Tasks;
using Orchard.UI;
using Orchard.WebApi.Routes;
using Owin;

namespace Orchard.Environment;

public class DefaultOrchardShell : IOrchardShell
{
	private readonly IWorkContextAccessor _workContextAccessor;

	private readonly IEnumerable<IRouteProvider> _routeProviders;

	private readonly IEnumerable<IHttpRouteProvider> _httpRouteProviders;

	private readonly IRoutePublisher _routePublisher;

	private readonly IEnumerable<IModelBinderProvider> _modelBinderProviders;

	private readonly IModelBinderPublisher _modelBinderPublisher;

	private readonly ISweepGenerator _sweepGenerator;

	private readonly IEnumerable<IOwinMiddlewareProvider> _owinMiddlewareProviders;

	private readonly ShellSettings _shellSettings;

	public ILogger Logger { get; set; }

	public ISweepGenerator Sweep => _sweepGenerator;

	public DefaultOrchardShell(IWorkContextAccessor workContextAccessor, IEnumerable<IRouteProvider> routeProviders, IEnumerable<IHttpRouteProvider> httpRouteProviders, IRoutePublisher routePublisher, IEnumerable<IModelBinderProvider> modelBinderProviders, IModelBinderPublisher modelBinderPublisher, ISweepGenerator sweepGenerator, IEnumerable<IOwinMiddlewareProvider> owinMiddlewareProviders, ShellSettings shellSettings)
	{
		_workContextAccessor = workContextAccessor;
		_routeProviders = routeProviders;
		_httpRouteProviders = httpRouteProviders;
		_routePublisher = routePublisher;
		_modelBinderProviders = modelBinderProviders;
		_modelBinderPublisher = modelBinderPublisher;
		_sweepGenerator = sweepGenerator;
		_owinMiddlewareProviders = owinMiddlewareProviders;
		_shellSettings = shellSettings;
		Logger = NullLogger.Instance;
	}

	public void Activate()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		AppBuilder val = new AppBuilder();
		val.get_Properties()["host.AppName"] = _shellSettings.Name;
		foreach (OwinMiddlewareRegistration item in _owinMiddlewareProviders.SelectMany((IOwinMiddlewareProvider p) => p.GetOwinMiddlewares()).OrderBy((OwinMiddlewareRegistration obj) => obj.Priority, new FlatPositionComparer()))
		{
			item.Configure((IAppBuilder)(object)val);
		}
		((IAppBuilder)(object)val).UseOrchard();
		Func<IDictionary<string, object>, Task> pipeline = AppBuilderExtensions.Build((IAppBuilder)(object)val);
		List<RouteDescriptor> list = new List<RouteDescriptor>();
		list.AddRange(_routeProviders.SelectMany((IRouteProvider provider) => provider.GetRoutes()));
		list.AddRange(_httpRouteProviders.SelectMany((IHttpRouteProvider provider) => provider.GetRoutes()));
		_routePublisher.Publish(list, pipeline);
		_modelBinderPublisher.Publish(_modelBinderProviders.SelectMany((IModelBinderProvider provider) => provider.GetModelBinders()));
		using (IWorkContextScope workContextScope = _workContextAccessor.CreateWorkContextScope())
		{
			Owned<IOrchardShellEvents> val2 = workContextScope.Resolve<Owned<IOrchardShellEvents>>();
			try
			{
				val2.get_Value().Activated();
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		_sweepGenerator.Activate();
	}

	public void Terminate()
	{
		Owned<IOrchardShellEvents> events;
		SafelyTerminate(delegate
		{
			using IWorkContextScope workContextScope = _workContextAccessor.CreateWorkContextScope();
			events = workContextScope.Resolve<Owned<IOrchardShellEvents>>();
			try
			{
				SafelyTerminate(delegate
				{
					events.get_Value().Terminating();
				});
			}
			finally
			{
				if (events != null)
				{
					((IDisposable)events).Dispose();
				}
			}
		});
		SafelyTerminate(delegate
		{
			_sweepGenerator.Terminate();
		});
	}

	private void SafelyTerminate(Action action)
	{
		try
		{
			action();
		}
		catch (Exception ex)
		{
			if (ex.IsFatal())
			{
				throw;
			}
			Logger.Error(ex, "An unexpected error occured while terminating the Shell");
		}
	}
}
