using System;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using Autofac;
using Autofac.Core;
using Orchard.Environment;
using Orchard.Environment.Configuration;

namespace Orchard.Wcf;

public class OrchardServiceHostFactory : ServiceHostFactory, IShim
{
	public IOrchardHostContainer HostContainer { get; set; }

	public OrchardServiceHostFactory()
	{
		OrchardHostContainerRegistry.RegisterShim(this);
	}

	public override ServiceHostBase CreateServiceHost(string constructorString, Uri[] baseAddresses)
	{
		if (constructorString == null)
		{
			throw new ArgumentNullException("constructorString");
		}
		if (constructorString == string.Empty)
		{
			throw new ArgumentOutOfRangeException("constructorString");
		}
		if (HostContainer == null)
		{
			throw new InvalidOperationException();
		}
		ShellSettings shellSettings = HostContainer.Resolve<IRunningShellTable>().Match(baseAddresses.First().Host, baseAddresses.First().LocalPath);
		IWorkContextAccessor workContextAccessor = ResolutionExtensions.Resolve<IWorkContextAccessor>((IComponentContext)(object)HostContainer.Resolve<IOrchardHost>().GetShellContext(shellSettings).LifetimeScope);
		WorkContext context = workContextAccessor.GetContext();
		IComponentRegistration registration;
		if (context == null)
		{
			using IWorkContextScope workContextScope = workContextAccessor.CreateWorkContextScope();
			ILifetimeScope lifetimeScope = workContextScope.Resolve<ILifetimeScope>();
			registration = GetRegistration(lifetimeScope, constructorString);
		}
		else
		{
			ILifetimeScope lifetimeScope2 = context.Resolve<ILifetimeScope>();
			registration = GetRegistration(lifetimeScope2, constructorString);
		}
		if (registration == null)
		{
			throw new InvalidOperationException();
		}
		if (!registration.get_Activator().get_LimitType().IsClass)
		{
			throw new InvalidOperationException();
		}
		return CreateServiceHost(workContextAccessor, registration, registration.get_Activator().get_LimitType(), baseAddresses);
	}

	private ServiceHost CreateServiceHost(IWorkContextAccessor workContextAccessor, IComponentRegistration registration, Type implementationType, Uri[] baseAddresses)
	{
		ServiceHost host = CreateServiceHost(implementationType, baseAddresses);
		host.Opening += delegate
		{
			host.Description.Behaviors.Add(new OrchardDependencyInjectionServiceBehavior(workContextAccessor, implementationType, registration));
		};
		return host;
	}

	private IComponentRegistration GetRegistration(ILifetimeScope lifetimeScope, string constructorString)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		IComponentRegistration result = default(IComponentRegistration);
		if (!((IComponentContext)lifetimeScope).get_ComponentRegistry().TryGetRegistration((Service)new KeyedService((object)constructorString, typeof(object)), ref result))
		{
			Type type = Type.GetType(constructorString, throwOnError: false);
			if (type != null)
			{
				((IComponentContext)lifetimeScope).get_ComponentRegistry().TryGetRegistration((Service)new TypedService(type), ref result);
			}
		}
		return result;
	}
}
