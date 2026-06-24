using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Web.Hosting;
using System.Web.Http;
using System.Web.Http.Dependencies;
using System.Web.Http.Dispatcher;
using System.Web.Http.Filters;
using System.Web.Mvc;
using Autofac;
using Autofac.Builder;
using Autofac.Core;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Web.Orchard.Data;
using EleWise.ELMA.Web.Orchard.Enviroment;
using EleWise.ELMA.Web.Orchard.Enviroment.Configuration;
using EleWise.ELMA.Web.Orchard.Enviroment.ShellBuilders;
using EleWise.ELMA.Web.Orchard.Mvc.ViewEngines;
using Orchard.Caching;
using Orchard.Commands;
using Orchard.ContentManagement;
using Orchard.ContentManagement.MetaData;
using Orchard.Core.Settings.Descriptor;
using Orchard.Core.Settings.Metadata;
using Orchard.Core.Settings.Services;
using Orchard.Data;
using Orchard.DisplayManagement.Descriptors.ShapeTemplateStrategy;
using Orchard.Environment;
using Orchard.Environment.Configuration;
using Orchard.Environment.Descriptor;
using Orchard.Environment.Extensions;
using Orchard.Environment.Extensions.Compilers;
using Orchard.Environment.Extensions.Folders;
using Orchard.Environment.Extensions.Loaders;
using Orchard.Environment.ShellBuilders;
using Orchard.Exceptions;
using Orchard.FileSystems.AppData;
using Orchard.FileSystems.Dependencies;
using Orchard.FileSystems.LockFile;
using Orchard.FileSystems.VirtualPath;
using Orchard.FileSystems.WebSite;
using Orchard.Mvc;
using Orchard.Mvc.DataAnnotations;
using Orchard.Mvc.Filters;
using Orchard.Mvc.ModelBinders;
using Orchard.Mvc.Routes;
using Orchard.Mvc.ViewEngines;
using Orchard.Mvc.ViewEngines.Razor;
using Orchard.Mvc.ViewEngines.ThemeAwareness;
using Orchard.Services;
using Orchard.Settings;
using Orchard.Tasks;
using Orchard.Themes;
using Orchard.WebApi;
using Orchard.WebApi.Filters;

namespace EleWise.ELMA.Web.Orchard;

public static class OrchardStarter
{
	public static IContainer CreateHostContainer(Action<ContainerBuilder> registrations)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		ContainerBuilder val = new ContainerBuilder();
		BuildContainer(val, registrations);
		IContainer obj = val.Build((ContainerBuildOptions)0);
		OnBuildContainer(obj);
		return obj;
	}

	public static void OnBuildContainer(IContainer container)
	{
		if (HostingEnvironment.IsHosted)
		{
			foreach (ICustomVirtualPathProvider item in ResolutionExtensions.Resolve<IEnumerable<ICustomVirtualPathProvider>>((IComponentContext)(object)container))
			{
				HostingEnvironment.RegisterVirtualPathProvider(item.Instance);
			}
		}
		ControllerBuilder.get_Current().SetControllerFactory((IControllerFactory)(object)new OrchardControllerFactory());
		((Collection<IFilterProvider>)(object)FilterProviders.get_Providers()).Add((IFilterProvider)(object)new OrchardFilterProvider());
		GlobalConfiguration.get_Configuration().get_Services().Replace(typeof(IHttpControllerSelector), (object)new DefaultOrchardWebApiHttpControllerSelector(GlobalConfiguration.get_Configuration()));
		GlobalConfiguration.get_Configuration().get_Services().Replace(typeof(IHttpControllerActivator), (object)new DefaultOrchardWebApiHttpControllerActivator(GlobalConfiguration.get_Configuration()));
		GlobalConfiguration.get_Configuration().set_DependencyResolver((IDependencyResolver)(object)new AutofacWebApiDependencyResolver((ILifetimeScope)(object)container));
		GlobalConfiguration.get_Configuration().get_Filters().Add((IFilter)(object)new OrchardApiActionFilterDispatcher());
		GlobalConfiguration.get_Configuration().get_Filters().Add((IFilter)(object)new OrchardApiExceptionFilterDispatcher());
		GlobalConfiguration.get_Configuration().get_Filters().Add((IFilter)(object)new OrchardApiAuthorizationFilterDispatcher());
		((Collection<IViewEngine>)(object)ViewEngines.get_Engines()).Clear();
		((Collection<IViewEngine>)(object)ViewEngines.get_Engines()).Add((IViewEngine)(object)new ThemeAwareViewEngineShim());
		OrchardHostContainerRegistry.RegisterHostContainer(new DefaultOrchardHostContainer(container));
		((Collection<ModelValidatorProvider>)(object)ModelValidatorProviders.get_Providers()).Clear();
		((Collection<ModelValidatorProvider>)(object)ModelValidatorProviders.get_Providers()).Add((ModelValidatorProvider)(object)new LocalizedModelValidatorProvider());
	}

	public static void BuildContainer(ContainerBuilder builder, Action<ContainerBuilder> registrations)
	{
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Expected O, but got Unknown
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Expected O, but got Unknown
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Expected O, but got Unknown
		ExtensionLocations extensionLocations = new ExtensionLocations();
		RegistrationExtensions.RegisterInstance<ExtensionLocations>(builder, extensionLocations);
		ModuleRegistrationExtensions.RegisterModule(builder, (IModule)(object)new MvcModule());
		ModuleRegistrationExtensions.RegisterModule(builder, (IModule)(object)new CommandModule());
		ModuleRegistrationExtensions.RegisterModule(builder, (IModule)(object)new WorkContextModule());
		ModuleRegistrationExtensions.RegisterModule(builder, (IModule)(object)new CacheModule());
		RegistrationExtensions.RegisterType<ApplicationEnvironment>(builder).As<IApplicationEnvironment>().SingleInstance();
		RegistrationExtensions.RegisterType<RoutePublisher>(builder).As<IRoutePublisher>().InstancePerLifetimeScope();
		RegistrationExtensions.RegisterType<ModelBinderPublisher>(builder).As<IModelBinderPublisher>().InstancePerLifetimeScope();
		RegistrationExtensions.RegisterType<RazorViewEngineProvider>(builder).As<IViewEngineProvider>().As<IShapeTemplateViewEngine>()
			.SingleInstance();
		RegistrationExtensions.RegisterType<ThemedViewResultFilter>(builder).As<IFilterProvider>().InstancePerLifetimeScope();
		RegistrationExtensions.RegisterType<ThemeFilter>(builder).As<IFilterProvider>().InstancePerLifetimeScope();
		RegistrationExtensions.RegisterType<SweepGenerator>(builder).As<ISweepGenerator>().SingleInstance();
		RegistrationExtensions.RegisterType<SiteService>(builder).As<ISiteService>().InstancePerLifetimeScope();
		RegistrationExtensions.RegisterGeneric(builder, typeof(Repository<>)).As(new Type[1] { typeof(IRepository<>) }).InstancePerDependency();
		RegistrationExtensions.RegisterType<ContentDefinitionManager>(builder).As<IContentDefinitionManager>();
		RegistrationExtensions.RegisterType<Signals>(builder).As<ISignals>();
		RegistrationExtensions.RegisterType<DefaultContentManagerSession>(builder).As<IContentManagerSession>().SingleInstance();
		RegistrationExtensions.RegisterType<DefaultContentManager>(builder).As<IContentManager>().SingleInstance();
		RegistrationExtensions.RegisterType<DefaultCacheHolder>(builder).As<ICacheHolder>().SingleInstance();
		RegistrationExtensions.RegisterType<DefaultCacheContextAccessor>(builder).As<ICacheContextAccessor>().SingleInstance();
		RegistrationExtensions.RegisterType<DefaultParallelCacheContext>(builder).As<IParallelCacheContext>().SingleInstance();
		RegistrationExtensions.RegisterType<DefaultAsyncTokenProvider>(builder).As<IAsyncTokenProvider>().SingleInstance();
		RegistrationExtensions.RegisterType<DefaultHostEnvironment>(builder).As<IHostEnvironment>().SingleInstance();
		RegistrationExtensions.RegisterType<DefaultHostLocalRestart>(builder).As<IHostLocalRestart>().SingleInstance();
		RegistrationExtensions.RegisterType<DefaultBuildManager>(builder).As<IBuildManager>().SingleInstance();
		RegistrationExtensions.RegisterType<DynamicModuleVirtualPathProvider>(builder).As<ICustomVirtualPathProvider>().SingleInstance();
		RegistrationExtensions.RegisterType<AppDataFolderRoot>(builder).As<IAppDataFolderRoot>().SingleInstance();
		RegistrationExtensions.RegisterType<DefaultExtensionCompiler>(builder).As<IExtensionCompiler>().SingleInstance();
		RegistrationExtensions.RegisterType<DefaultRazorCompilationEvents>(builder).As<IRazorCompilationEvents>().SingleInstance();
		RegistrationExtensions.RegisterType<DefaultProjectFileParser>(builder).As<IProjectFileParser>().SingleInstance();
		RegistrationExtensions.RegisterType<DefaultAssemblyLoader>(builder).As<IAssemblyLoader>().SingleInstance();
		RegistrationExtensions.RegisterType<AppDomainAssemblyNameResolver>(builder).As<IAssemblyNameResolver>().SingleInstance();
		RegistrationExtensions.RegisterType<GacAssemblyNameResolver>(builder).As<IAssemblyNameResolver>().SingleInstance();
		RegistrationExtensions.RegisterType<OrchardFrameworkAssemblyNameResolver>(builder).As<IAssemblyNameResolver>().SingleInstance();
		RegistrationExtensions.RegisterType<HttpContextAccessor>(builder).As<IHttpContextAccessor>().SingleInstance();
		RegistrationExtensions.RegisterType<ViewsBackgroundCompilation>(builder).As<IViewsBackgroundCompilation>().SingleInstance();
		RegistrationExtensions.RegisterType<DefaultExceptionPolicy>(builder).As<IExceptionPolicy>().SingleInstance();
		RegistrationExtensions.RegisterType<DefaultCriticalErrorProvider>(builder).As<ICriticalErrorProvider>().SingleInstance();
		RegisterVolatileProvider<WebSiteFolder, IWebSiteFolder>(builder);
		RegisterVolatileProvider<AppDataFolder, IAppDataFolder>(builder);
		RegisterVolatileProvider<DefaultLockFileManager, ILockFileManager>(builder);
		RegisterVolatileProvider<Clock, IClock>(builder);
		RegisterVolatileProvider<DefaultDependenciesFolder, IDependenciesFolder>(builder);
		RegisterVolatileProvider<DefaultExtensionDependenciesManager, IExtensionDependenciesManager>(builder);
		RegisterVolatileProvider<DefaultAssemblyProbingFolder, IAssemblyProbingFolder>(builder);
		RegisterVolatileProvider<DefaultVirtualPathMonitor, IVirtualPathMonitor>(builder);
		RegisterVolatileProvider<DefaultVirtualPathProvider, IVirtualPathProvider>(builder);
		RegistrationExtensions.RegisterType<DefaultOrchardHost>(builder).As<DefaultOrchardHost>().As<IOrchardHost>()
			.As<IEventHandler>()
			.Named<IEventHandler>(typeof(IShellSettingsManagerEventHandler).Name)
			.Named<IEventHandler>(typeof(IShellDescriptorManagerEventHandler).Name)
			.SingleInstance();
		RegistrationExtensions.RegisterType<ELMAShellSettingsManager>(builder).As<ELMAShellSettingsManager>().As<IShellSettingsManager>()
			.SingleInstance();
		RegistrationExtensions.RegisterType<ShellContextFactory>(builder).As<IShellContextFactory>().SingleInstance();
		RegistrationExtensions.RegisterType<ShellDescriptorCache>(builder).As<IShellDescriptorCache>().SingleInstance();
		RegistrationExtensions.RegisterType<CompositionStrategy>(builder).As<CompositionStrategy>().SingleInstance();
		RegistrationExtensions.RegisterType<ComponentsCompositeStrategy>(builder).As<ICompositionStrategy>().SingleInstance();
		RegistrationExtensions.RegisterType<ShellDescriptorManager>(builder).As<IShellDescriptorManager>().SingleInstance();
		RegistrationExtensions.RegisterType<ShellContainerRegistrations>(builder).As<IShellContainerRegistrations>().SingleInstance();
		RegistrationExtensions.RegisterType<ExtensionMonitoringCoordinator>(builder).As<IExtensionMonitoringCoordinator>().SingleInstance();
		RegistrationExtensions.RegisterType<ExtensionLoaderCoordinator>(builder).As<IExtensionLoaderCoordinator>().SingleInstance();
		RegistrationExtensions.RegisterType<ExtensionManager>(builder).As<IExtensionManager>().SingleInstance();
		RegistrationExtensions.RegisterType<ExtensionHarvester>(builder).As<IExtensionHarvester>().SingleInstance();
		RegistrationExtensions.WithParameter<ModuleFolders, ConcreteReflectionActivatorData, SingleRegistrationStyle>(RegistrationExtensions.RegisterType<ModuleFolders>(builder).As<IExtensionFolders>().SingleInstance(), (Parameter)new NamedParameter("paths", (object)extensionLocations.ModuleLocations));
		RegistrationExtensions.WithParameter<CoreModuleFolders, ConcreteReflectionActivatorData, SingleRegistrationStyle>(RegistrationExtensions.RegisterType<CoreModuleFolders>(builder).As<IExtensionFolders>().SingleInstance(), (Parameter)new NamedParameter("paths", (object)extensionLocations.CoreLocations));
		RegistrationExtensions.WithParameter<ThemeFolders, ConcreteReflectionActivatorData, SingleRegistrationStyle>(RegistrationExtensions.RegisterType<ThemeFolders>(builder).As<IExtensionFolders>().SingleInstance(), (Parameter)new NamedParameter("paths", (object)extensionLocations.ThemeLocations));
		RegistrationExtensions.RegisterType<CoreExtensionLoader>(builder).As<IExtensionLoader>().SingleInstance();
		RegistrationExtensions.RegisterType<ReferencedExtensionLoader>(builder).As<IExtensionLoader>().SingleInstance();
		RegistrationExtensions.RegisterType<PrecompiledExtensionLoader>(builder).As<IExtensionLoader>().SingleInstance();
		RegistrationExtensions.RegisterType<DynamicExtensionLoader>(builder).As<IExtensionLoader>().SingleInstance();
		RegistrationExtensions.RegisterType<RawThemeExtensionLoader>(builder).As<IExtensionLoader>().SingleInstance();
		RegistrationExtensions.RegisterType<ContainerFactory>(builder).As<IShellContainerFactory>().SingleInstance();
		RegistrationExtensions.RegisterType<RazorSharedViewEngineProvider>(builder).As<IViewEngineProvider>().SingleInstance();
		RegistrationExtensions.RegisterType<WebFormSharedViewEngineProvider>(builder).As<IViewEngineProvider>().SingleInstance();
		RegistrationExtensions.RegisterType<RunningShellTable>(builder).As<IRunningShellTable>().SingleInstance();
		RegistrationExtensions.RegisterType<DefaultOrchardShell>(builder).As<IOrchardShell>().SetScope<DefaultOrchardShell, ConcreteReflectionActivatorData, SingleRegistrationStyle>(ServiceScope.Shell);
		RegistrationExtensions.RegisterType<SessionFlushTM>(builder).As<SessionFlushTM>().As<ITransactionManager>()
			.InstancePerLifetimeScope();
		RegistrationExtensions.RegisterType<ModuleEventsImpl>(builder).As<IEventHandler>().InstancePerLifetimeScope();
		registrations(builder);
		string text = HostingEnvironment.MapPath("~/Config/HostComponents.config");
		if (File.Exists(text))
		{
			ModuleRegistrationExtensions.RegisterModule(builder, (IModule)(object)new HostComponentsConfigModule(text));
		}
	}

	private static void RegisterVolatileProvider<TRegister, TService>(ContainerBuilder builder) where TService : IVolatileProvider
	{
		((IRegistrationBuilder<IVolatileProvider, ConcreteReflectionActivatorData, SingleRegistrationStyle>)(object)((IRegistrationBuilder<TService, ConcreteReflectionActivatorData, SingleRegistrationStyle>)(object)RegistrationExtensions.RegisterType<TRegister>(builder)).As<TService>()).As<IVolatileProvider>().SingleInstance();
	}

	public static IOrchardHost CreateHost(Action<ContainerBuilder> registrations)
	{
		return ResolutionExtensions.Resolve<IOrchardHost>((IComponentContext)(object)CreateHostContainer(registrations));
	}
}
