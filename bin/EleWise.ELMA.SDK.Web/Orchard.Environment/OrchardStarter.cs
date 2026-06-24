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
using EleWise.ELMA.Logging;
using Orchard.Caching;
using Orchard.Commands;
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
using Orchard.Mvc.ViewEngines.Razor;
using Orchard.Mvc.ViewEngines.ThemeAwareness;
using Orchard.Services;
using Orchard.WebApi;
using Orchard.WebApi.Filters;

namespace Orchard.Environment;

public static class OrchardStarter
{
	public static IContainer CreateHostContainer(Action<ContainerBuilder> registrations)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected O, but got Unknown
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected O, but got Unknown
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected O, but got Unknown
		ExtensionLocations extensionLocations = new ExtensionLocations();
		ContainerBuilder val = new ContainerBuilder();
		RegistrationExtensions.RegisterInstance<ExtensionLocations>(val, extensionLocations);
		ModuleRegistrationExtensions.RegisterModule(val, (IModule)(object)new MvcModule());
		ModuleRegistrationExtensions.RegisterModule(val, (IModule)(object)new CommandModule());
		ModuleRegistrationExtensions.RegisterModule(val, (IModule)(object)new WorkContextModule());
		ModuleRegistrationExtensions.RegisterModule(val, (IModule)(object)new LoggingModule());
		ModuleRegistrationExtensions.RegisterModule(val, (IModule)(object)new CacheModule());
		RegistrationExtensions.RegisterType<DefaultCacheHolder>(val).As<ICacheHolder>().SingleInstance();
		RegistrationExtensions.RegisterType<DefaultCacheContextAccessor>(val).As<ICacheContextAccessor>().SingleInstance();
		RegistrationExtensions.RegisterType<DefaultParallelCacheContext>(val).As<IParallelCacheContext>().SingleInstance();
		RegistrationExtensions.RegisterType<DefaultAsyncTokenProvider>(val).As<IAsyncTokenProvider>().SingleInstance();
		RegistrationExtensions.RegisterType<DefaultHostEnvironment>(val).As<IHostEnvironment>().SingleInstance();
		RegistrationExtensions.RegisterType<DefaultHostLocalRestart>(val).As<IHostLocalRestart>().Named<IEventHandler>(typeof(IShellSettingsManagerEventHandler).Name)
			.SingleInstance();
		RegistrationExtensions.RegisterType<DefaultBuildManager>(val).As<IBuildManager>().SingleInstance();
		RegistrationExtensions.RegisterType<DynamicModuleVirtualPathProvider>(val).As<ICustomVirtualPathProvider>().SingleInstance();
		RegistrationExtensions.RegisterType<AppDataFolderRoot>(val).As<IAppDataFolderRoot>().SingleInstance();
		RegistrationExtensions.RegisterType<DefaultExtensionCompiler>(val).As<IExtensionCompiler>().SingleInstance();
		RegistrationExtensions.RegisterType<DefaultRazorCompilationEvents>(val).As<IRazorCompilationEvents>().SingleInstance();
		RegistrationExtensions.RegisterType<DefaultProjectFileParser>(val).As<IProjectFileParser>().SingleInstance();
		RegistrationExtensions.RegisterType<DefaultAssemblyLoader>(val).As<IAssemblyLoader>().SingleInstance();
		RegistrationExtensions.RegisterType<AppDomainAssemblyNameResolver>(val).As<IAssemblyNameResolver>().SingleInstance();
		RegistrationExtensions.RegisterType<GacAssemblyNameResolver>(val).As<IAssemblyNameResolver>().SingleInstance();
		RegistrationExtensions.RegisterType<OrchardFrameworkAssemblyNameResolver>(val).As<IAssemblyNameResolver>().SingleInstance();
		RegistrationExtensions.RegisterType<HttpContextAccessor>(val).As<IHttpContextAccessor>().InstancePerDependency();
		RegistrationExtensions.RegisterType<ViewsBackgroundCompilation>(val).As<IViewsBackgroundCompilation>().SingleInstance();
		RegistrationExtensions.RegisterType<DefaultExceptionPolicy>(val).As<IExceptionPolicy>().SingleInstance();
		RegistrationExtensions.RegisterType<DefaultCriticalErrorProvider>(val).As<ICriticalErrorProvider>().SingleInstance();
		RegisterVolatileProvider<WebSiteFolder, IWebSiteFolder>(val);
		RegisterVolatileProvider<AppDataFolder, IAppDataFolder>(val);
		RegisterVolatileProvider<DefaultLockFileManager, ILockFileManager>(val);
		RegisterVolatileProvider<Clock, IClock>(val);
		RegisterVolatileProvider<DefaultDependenciesFolder, IDependenciesFolder>(val);
		RegisterVolatileProvider<DefaultExtensionDependenciesManager, IExtensionDependenciesManager>(val);
		RegisterVolatileProvider<DefaultAssemblyProbingFolder, IAssemblyProbingFolder>(val);
		RegisterVolatileProvider<DefaultVirtualPathMonitor, IVirtualPathMonitor>(val);
		RegisterVolatileProvider<DefaultVirtualPathProvider, IVirtualPathProvider>(val);
		RegistrationExtensions.RegisterType<DefaultOrchardHost>(val).As<IOrchardHost>().As<IEventHandler>()
			.Named<IEventHandler>(typeof(IShellSettingsManagerEventHandler).Name)
			.Named<IEventHandler>(typeof(IShellDescriptorManagerEventHandler).Name)
			.SingleInstance();
		RegistrationExtensions.RegisterType<ShellSettingsManager>(val).As<IShellSettingsManager>().SingleInstance();
		RegistrationExtensions.RegisterType<ShellContextFactory>(val).As<IShellContextFactory>().SingleInstance();
		RegistrationExtensions.RegisterType<ShellDescriptorCache>(val).As<IShellDescriptorCache>().SingleInstance();
		RegistrationExtensions.RegisterType<CompositionStrategy>(val).As<ICompositionStrategy>().SingleInstance();
		RegistrationExtensions.RegisterType<ShellContainerRegistrations>(val).As<IShellContainerRegistrations>().SingleInstance();
		RegistrationExtensions.RegisterType<ExtensionLoaderCoordinator>(val).As<IExtensionLoaderCoordinator>().SingleInstance();
		RegistrationExtensions.RegisterType<ExtensionMonitoringCoordinator>(val).As<IExtensionMonitoringCoordinator>().SingleInstance();
		RegistrationExtensions.RegisterType<ExtensionManager>(val).As<IExtensionManager>().SingleInstance();
		RegistrationExtensions.RegisterType<ExtensionHarvester>(val).As<IExtensionHarvester>().SingleInstance();
		RegistrationExtensions.WithParameter<ModuleFolders, ConcreteReflectionActivatorData, SingleRegistrationStyle>(RegistrationExtensions.RegisterType<ModuleFolders>(val).As<IExtensionFolders>().SingleInstance(), (Parameter)new NamedParameter("paths", (object)extensionLocations.ModuleLocations));
		RegistrationExtensions.WithParameter<CoreModuleFolders, ConcreteReflectionActivatorData, SingleRegistrationStyle>(RegistrationExtensions.RegisterType<CoreModuleFolders>(val).As<IExtensionFolders>().SingleInstance(), (Parameter)new NamedParameter("paths", (object)extensionLocations.CoreLocations));
		RegistrationExtensions.WithParameter<ThemeFolders, ConcreteReflectionActivatorData, SingleRegistrationStyle>(RegistrationExtensions.RegisterType<ThemeFolders>(val).As<IExtensionFolders>().SingleInstance(), (Parameter)new NamedParameter("paths", (object)extensionLocations.ThemeLocations));
		RegistrationExtensions.RegisterType<CoreExtensionLoader>(val).As<IExtensionLoader>().SingleInstance();
		RegistrationExtensions.RegisterType<ReferencedExtensionLoader>(val).As<IExtensionLoader>().SingleInstance();
		RegistrationExtensions.RegisterType<PrecompiledExtensionLoader>(val).As<IExtensionLoader>().SingleInstance();
		RegistrationExtensions.RegisterType<DynamicExtensionLoader>(val).As<IExtensionLoader>().SingleInstance();
		RegistrationExtensions.RegisterType<RawThemeExtensionLoader>(val).As<IExtensionLoader>().SingleInstance();
		RegistrationExtensions.RegisterType<ShellContainerFactory>(val).As<IShellContainerFactory>().SingleInstance();
		RegistrationExtensions.RegisterType<RunningShellTable>(val).As<IRunningShellTable>().SingleInstance();
		RegistrationExtensions.RegisterType<DefaultOrchardShell>(val).As<IOrchardShell>().SetScope<DefaultOrchardShell, ConcreteReflectionActivatorData, SingleRegistrationStyle>(ServiceScope.Shell);
		registrations(val);
		string text = HostingEnvironment.MapPath("~/Config/HostComponents.config");
		if (File.Exists(text))
		{
			ModuleRegistrationExtensions.RegisterModule(val, (IModule)(object)new HostComponentsConfigModule(text));
		}
		IContainer val2 = val.Build((ContainerBuildOptions)0);
		if (HostingEnvironment.IsHosted)
		{
			foreach (ICustomVirtualPathProvider item in ResolutionExtensions.Resolve<IEnumerable<ICustomVirtualPathProvider>>((IComponentContext)(object)val2))
			{
				HostingEnvironment.RegisterVirtualPathProvider(item.Instance);
			}
		}
		ControllerBuilder.get_Current().SetControllerFactory((IControllerFactory)(object)new OrchardControllerFactory());
		((Collection<IFilterProvider>)(object)FilterProviders.get_Providers()).Add((IFilterProvider)(object)new OrchardFilterProvider());
		GlobalConfiguration.get_Configuration().get_Services().Replace(typeof(IHttpControllerSelector), (object)new DefaultOrchardWebApiHttpControllerSelector(GlobalConfiguration.get_Configuration()));
		GlobalConfiguration.get_Configuration().get_Services().Replace(typeof(IHttpControllerActivator), (object)new DefaultOrchardWebApiHttpControllerActivator(GlobalConfiguration.get_Configuration()));
		GlobalConfiguration.get_Configuration().set_DependencyResolver((IDependencyResolver)(object)new AutofacWebApiDependencyResolver((ILifetimeScope)(object)val2));
		GlobalConfiguration.get_Configuration().get_Filters().Add((IFilter)(object)new OrchardApiActionFilterDispatcher());
		GlobalConfiguration.get_Configuration().get_Filters().Add((IFilter)(object)new OrchardApiExceptionFilterDispatcher());
		GlobalConfiguration.get_Configuration().get_Filters().Add((IFilter)(object)new OrchardApiAuthorizationFilterDispatcher());
		((Collection<IViewEngine>)(object)ViewEngines.get_Engines()).Clear();
		((Collection<IViewEngine>)(object)ViewEngines.get_Engines()).Add((IViewEngine)(object)new ThemeAwareViewEngineShim());
		OrchardHostContainerRegistry.RegisterHostContainer(new DefaultOrchardHostContainer(val2));
		((Collection<ModelValidatorProvider>)(object)ModelValidatorProviders.get_Providers()).Clear();
		((Collection<ModelValidatorProvider>)(object)ModelValidatorProviders.get_Providers()).Add((ModelValidatorProvider)(object)new LocalizedModelValidatorProvider());
		return val2;
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
