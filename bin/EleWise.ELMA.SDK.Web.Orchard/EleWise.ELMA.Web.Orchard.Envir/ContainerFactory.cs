using System;
using System.Linq;
using System.Web.Http.Controllers;
using System.Web.Mvc;
using Autofac;
using Autofac.Builder;
using Autofac.Core;
using Autofac.Features.Indexed;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Web.Mvc.Controllers;
using Orchard;
using Orchard.Environment;
using Orchard.Environment.AutofacUtil.DynamicProxy2;
using Orchard.Environment.Configuration;
using Orchard.Environment.Descriptor.Models;
using Orchard.Environment.ShellBuilders;
using Orchard.Environment.ShellBuilders.Models;

namespace EleWise.ELMA.Web.Orchard.Enviroment.ShellBuilders;

public class ContainerFactory : IShellContainerFactory
{
	private readonly IShellContainerRegistrations shellContainerRegistrations;

	private readonly ComponentManager componentManager;

	private readonly ILifetimeScopeAccessor lifetimeScopeAccessor;

	private readonly Type controllerForPropetiesInjectionBaseType = typeof(BaseController);

	private readonly ServiceScope[] componentScopes = new ServiceScope[3]
	{
		ServiceScope.Shell,
		ServiceScope.Transient,
		ServiceScope.UnitOfWork
	};

	public ILogger Logger { get; set; }

	public ContainerFactory(IShellContainerRegistrations shellContainerRegistrations, ComponentManager componentManager, ILifetimeScopeAccessor lifetimeScopeAccessor)
	{
		this.shellContainerRegistrations = shellContainerRegistrations;
		this.componentManager = componentManager;
		this.lifetimeScopeAccessor = lifetimeScopeAccessor;
		Logger = NullLogger.Instance;
	}

	public ILifetimeScope CreateContainer(ShellSettings settings, ShellBlueprint blueprint)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		IContainer val = ResolutionExtensions.Resolve<IContainer>((IComponentContext)(object)lifetimeScopeAccessor.Current);
		ILifetimeScope val2 = ((ILifetimeScope)val).BeginLifetimeScope((object)"init-shell-modules");
		try
		{
			ContainerBuilder val3 = new ContainerBuilder();
			foreach (DependencyBlueprint item in blueprint.Dependencies.Where((DependencyBlueprint t) => typeof(IModule).IsAssignableFrom(t.Type)))
			{
				RegisterType(val3, item).Keyed<IModule>((object)item.Type).InstancePerDependency();
			}
			val3.Update(val);
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
		val2 = ((ILifetimeScope)val).BeginLifetimeScope((object)"init-shell");
		try
		{
			ContainerBuilder val4 = new ContainerBuilder();
			DynamicProxyContext dynamicProxyContext = new DynamicProxyContext();
			RegistrationExtensions.Register<DynamicProxyContext>(val4, (Func<IComponentContext, DynamicProxyContext>)((IComponentContext ctx) => dynamicProxyContext));
			RegistrationExtensions.Register<ShellSettings>(val4, (Func<IComponentContext, ShellSettings>)((IComponentContext ctx) => settings));
			RegistrationExtensions.Register<ShellDescriptor>(val4, (Func<IComponentContext, ShellDescriptor>)((IComponentContext ctx) => blueprint.Descriptor));
			RegistrationExtensions.Register<ShellBlueprint>(val4, (Func<IComponentContext, ShellBlueprint>)((IComponentContext ctx) => blueprint));
			IIndex<Type, IModule> val5 = ResolutionExtensions.Resolve<IIndex<Type, IModule>>((IComponentContext)(object)val);
			foreach (DependencyBlueprint item2 in blueprint.Dependencies.Where((DependencyBlueprint t) => typeof(IModule).IsAssignableFrom(t.Type)))
			{
				ModuleRegistrationExtensions.RegisterModule(val4, val5.get_Item(item2.Type));
				if (Logger.IsDebugEnabled())
				{
					Logger.DebugFormat("Register module {0}", val5.get_Item(item2.Type));
				}
			}
			foreach (DependencyBlueprint item3 in blueprint.Dependencies.Where((DependencyBlueprint t) => !Skip(t)))
			{
				IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle> val6 = RegisterType(val4, item3).EnableDynamicProxy<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>(dynamicProxyContext).InstancePerLifetimeScope();
				if (Logger.IsDebugEnabled())
				{
					Logger.DebugFormat("Registred type per lifetime scope {0}", item3.Type.FullName);
				}
				foreach (Type item4 in from itf in item3.Type.GetInterfaces()
					where typeof(IDependency).IsAssignableFrom(itf) && !typeof(IEventHandler).IsAssignableFrom(itf)
					select itf)
				{
					val6 = val6.As(new Type[1] { item4 });
					if (typeof(ISingletonDependency).IsAssignableFrom(item4))
					{
						val6.SetScope<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>(ServiceScope.Application);
						if (Logger.IsDebugEnabled())
						{
							Logger.DebugFormat("Registred type with scope shell {0}", item3.Type.FullName);
						}
					}
					else if (typeof(IUnitOfWorkDependency).IsAssignableFrom(item4))
					{
						val6.SetScope<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>(ServiceScope.UnitOfWork);
						if (Logger.IsDebugEnabled())
						{
							Logger.DebugFormat("Registred type with scope work {0}", item3.Type.FullName);
						}
					}
					else if (typeof(ITransientDependency).IsAssignableFrom(item4))
					{
						val6 = val6.InstancePerDependency();
						if (Logger.IsDebugEnabled())
						{
							Logger.DebugFormat("Registred type as transient {0}", item3.Type.FullName);
						}
					}
				}
				if (typeof(IEventHandler).IsAssignableFrom(item3.Type))
				{
					val6 = val6.As(new Type[1] { typeof(IEventHandler) });
					if (Logger.IsDebugEnabled())
					{
						Logger.DebugFormat("Registed type as event handler {0}", item3.Type.FullName);
					}
				}
			}
			if (blueprint.Controllers != null)
			{
				foreach (ControllerBlueprint controller in blueprint.Controllers)
				{
					string text = (controller.AreaName + "/" + controller.ControllerName).ToLowerInvariant();
					Type type = controller.Type;
					RegisterType(val4, controller).EnableDynamicProxy<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>(dynamicProxyContext).Keyed<IController>((object)text).Keyed<IController>((object)type)
						.WithMetadata("ControllerType", (object)controller.Type)
						.InstancePerDependency();
					if (Logger.IsDebugEnabled())
					{
						Logger.DebugFormat("Registed type as IController {0} with key {1}", controller.Type.FullName, text);
					}
				}
			}
			if (blueprint.HttpControllers != null)
			{
				foreach (ControllerBlueprint httpController in blueprint.HttpControllers)
				{
					string text2 = (httpController.AreaName + "/" + httpController.ControllerName).ToLowerInvariant();
					Type type2 = httpController.Type;
					RegisterType(val4, httpController).EnableDynamicProxy<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>(dynamicProxyContext).Keyed<IHttpController>((object)text2).Keyed<IHttpController>((object)type2)
						.WithMetadata("ControllerType", (object)httpController.Type)
						.InstancePerDependency();
					if (Logger.IsDebugEnabled())
					{
						Logger.DebugFormat("Registed type as IHttpController {0} with key {1}", httpController.Type.FullName, text2);
					}
				}
			}
			componentManager.AddShellComponents(val4);
			if (blueprint is ShellBlueprintWithComponents shellBlueprintWithComponents)
			{
				foreach (Type componentType in shellBlueprintWithComponents.ComponentTypes)
				{
					if (!componentManager.IsProcessedType(componentType))
					{
						if (componentManager.IsComponentType(componentType))
						{
							componentManager.ProcessShellComponent(componentType, null, val4, componentScopes);
						}
						if (componentManager.IsServiceType(componentType))
						{
							componentManager.ProcessShellService(componentType, val4, componentScopes);
						}
					}
				}
			}
			shellContainerRegistrations.Registrations(val4);
			val4.Update(val);
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
		lifetimeScopeAccessor.CurrentType = ServiceScope.Shell;
		return (ILifetimeScope)(object)val;
	}

	private bool Skip(DependencyBlueprint dependencyBlueprint)
	{
		if (dependencyBlueprint == null)
		{
			return true;
		}
		return ComponentManager.Current.GetExtensionPoints<ISkipDependency>().Any((ISkipDependency point) => point.Skip(dependencyBlueprint));
	}

	private IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle> RegisterType(ContainerBuilder builder, ShellBlueprintItem item)
	{
		IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle> val = RegistrationExtensions.WithProperty<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>(RegistrationExtensions.RegisterType(builder, item.Type), "Feature", (object)item.Feature).WithMetadata("Feature", (object)item.Feature);
		if (controllerForPropetiesInjectionBaseType.IsAssignableFrom(item.Type))
		{
			val = RegistrationExtensions.PropertiesAutowired<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>(val, (PropertyWiringOptions)1);
		}
		return val;
	}
}
