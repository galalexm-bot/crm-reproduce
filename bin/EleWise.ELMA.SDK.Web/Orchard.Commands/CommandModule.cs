using System.Linq;
using Autofac;
using Autofac.Core;

namespace Orchard.Commands;

public class CommandModule : Module
{
	protected override void AttachToComponentRegistration(IComponentRegistry componentRegistry, IComponentRegistration registration)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		if (registration.get_Services().Contains((Service)new TypedService(typeof(ICommandHandler))) && !registration.get_Metadata().ContainsKey(typeof(CommandHandlerDescriptor).FullName))
		{
			CommandHandlerDescriptor value = new CommandHandlerDescriptorBuilder().Build(registration.get_Activator().get_LimitType());
			registration.get_Metadata().Add(typeof(CommandHandlerDescriptor).FullName, value);
		}
	}
}
