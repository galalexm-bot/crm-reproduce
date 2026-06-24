using Autofac;

namespace Orchard.ContentManagement;

public class ContentModule : Module
{
	protected override void Load(ContainerBuilder builder)
	{
		RegistrationExtensions.RegisterType<DefaultContentQuery>(builder).As<IContentQuery>().InstancePerDependency();
	}
}
