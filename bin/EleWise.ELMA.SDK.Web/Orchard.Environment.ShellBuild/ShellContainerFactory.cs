using System;
using System.IO;
using System.Linq;
using System.Web.Hosting;
using System.Web.Http.Controllers;
using System.Web.Mvc;
using Autofac;
using Autofac.Builder;
using Autofac.Core;
using Autofac.Features.Indexed;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using Orchard.Environment.AutofacUtil.DynamicProxy2;
using Orchard.Environment.Configuration;
using Orchard.Environment.Descriptor.Models;
using Orchard.Environment.ShellBuilders.Models;

namespace Orchard.Environment.ShellBuilders;

public class ShellContainerFactory : IShellContainerFactory
{
	private readonly ILifetimeScope _lifetimeScope;

	private readonly IShellContainerRegistrations _shellContainerRegistrations;

	public ShellContainerFactory(ILifetimeScope lifetimeScope, IShellContainerRegistrations shellContainerRegistrations)
	{
		_lifetimeScope = lifetimeScope;
		_shellContainerRegistrations = shellContainerRegistrations;
	}

	public ILifetimeScope CreateContainer(ShellSettings settings, ShellBlueprint blueprint)
	{
		ILifetimeScope intermediateScope = _lifetimeScope.BeginLifetimeScope((Action<ContainerBuilder>)delegate(ContainerBuilder builder)
		{
			foreach (DependencyBlueprint item in blueprint.Dependencies.Where((DependencyBlueprint t) => typeof(IModule).IsAssignableFrom(t.Type)))
			{
				RegisterType(builder, item).Keyed<IModule>((object)item.Type).InstancePerDependency();
			}
		});
		return intermediateScope.BeginLifetimeScope((object)"shell", (Action<ContainerBuilder>)delegate(ContainerBuilder builder)
		{
			DynamicProxyContext dynamicProxyContext = new DynamicProxyContext();
			RegistrationExtensions.Register<DynamicProxyContext>(builder, (Func<IComponentContext, DynamicProxyContext>)((IComponentContext ctx) => dynamicProxyContext));
			RegistrationExtensions.Register<ShellSettings>(builder, (Func<IComponentContext, ShellSettings>)((IComponentContext ctx) => settings));
			RegistrationExtensions.Register<ShellDescriptor>(builder, (Func<IComponentContext, ShellDescriptor>)((IComponentContext ctx) => blueprint.Descriptor));
			RegistrationExtensions.Register<ShellBlueprint>(builder, (Func<IComponentContext, ShellBlueprint>)((IComponentContext ctx) => blueprint));
			IIndex<Type, IModule> val = ResolutionExtensions.Resolve<IIndex<Type, IModule>>((IComponentContext)(object)intermediateScope);
			foreach (DependencyBlueprint item2 in blueprint.Dependencies.Where((DependencyBlueprint t) => typeof(IModule).IsAssignableFrom(t.Type)))
			{
				ModuleRegistrationExtensions.RegisterModule(builder, val.get_Item(item2.Type));
			}
			foreach (DependencyBlueprint item3 in blueprint.Dependencies.Where((DependencyBlueprint t) => typeof(IDependency).IsAssignableFrom(t.Type)))
			{
				IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle> val2 = RegisterType(builder, item3).EnableDynamicProxy<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>(dynamicProxyContext).InstancePerLifetimeScope();
				foreach (Type item4 in from itf in item3.Type.GetInterfaces()
					where typeof(IDependency).IsAssignableFrom(itf) && !typeof(IEventHandler).IsAssignableFrom(itf)
					select itf)
				{
					val2 = RegistrationExtensions.AsSelf<object, ConcreteReflectionActivatorData>(val2.As(new Type[1] { item4 }));
					if (typeof(ISingletonDependency).IsAssignableFrom(item4))
					{
						val2.SetScope<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>(ServiceScope.Shell);
					}
					else if (typeof(IUnitOfWorkDependency).IsAssignableFrom(item4))
					{
						val2.SetScope<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>(ServiceScope.UnitOfWork);
					}
					else if (typeof(ITransientDependency).IsAssignableFrom(item4))
					{
						val2 = val2.InstancePerDependency();
					}
				}
				if (typeof(IEventHandler).IsAssignableFrom(item3.Type))
				{
					Type[] interfaces = item3.Type.GetInterfaces();
					foreach (Type type in interfaces)
					{
						if (type.GetInterface(typeof(IEventHandler).Name) != null)
						{
							val2 = val2.Named<IEventHandler>(type.Name);
						}
					}
				}
			}
			foreach (ControllerBlueprint controller in blueprint.Controllers)
			{
				string text = (controller.AreaName + "/" + controller.ControllerName).ToLowerInvariant();
				Type type2 = controller.Type;
				RegisterType(builder, controller).EnableDynamicProxy<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>(dynamicProxyContext).Keyed<IController>((object)text).Keyed<IController>((object)type2)
					.WithMetadata("ControllerType", (object)controller.Type)
					.InstancePerDependency();
			}
			foreach (ControllerBlueprint httpController in blueprint.HttpControllers)
			{
				string text2 = (httpController.AreaName + "/" + httpController.ControllerName).ToLowerInvariant();
				Type type3 = httpController.Type;
				RegisterType(builder, httpController).EnableDynamicProxy<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>(dynamicProxyContext).Keyed<IHttpController>((object)text2).Keyed<IHttpController>((object)type3)
					.WithMetadata("ControllerType", (object)httpController.Type)
					.InstancePerDependency();
			}
			_shellContainerRegistrations.Registrations(builder);
			string text3 = HostingEnvironment.MapPath("~/Config/HostComponents.config");
			if (File.Exists(text3))
			{
				ModuleRegistrationExtensions.RegisterModule(builder, (IModule)(object)new HostComponentsConfigModule(text3));
			}
		});
	}

	private IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle> RegisterType(ContainerBuilder builder, ShellBlueprintItem item)
	{
		return RegistrationExtensions.WithProperty<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>(RegistrationExtensions.RegisterType(builder, item.Type), "Feature", (object)item.Feature).WithMetadata("Feature", (object)item.Feature);
	}
}
