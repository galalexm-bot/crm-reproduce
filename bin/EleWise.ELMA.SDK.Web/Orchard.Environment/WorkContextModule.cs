using System;
using Autofac;
using Autofac.Builder;
using Autofac.Core;
using EleWise.ELMA.ComponentModel;

namespace Orchard.Environment;

public class WorkContextModule : Module
{
	protected override void Load(ContainerBuilder builder)
	{
		RegistrationExtensions.RegisterType<WorkContextAccessor>(builder).As<IWorkContextAccessor>().As<ILogicalWorkContextAccessor>()
			.SetScope<WorkContextAccessor, ConcreteReflectionActivatorData, SingleRegistrationStyle>(ServiceScope.Shell);
		RegistrationExtensions.Register<WorkContextImplementation>(builder, (Func<IComponentContext, WorkContextImplementation>)((IComponentContext ctx) => new WorkContextImplementation(ResolutionExtensions.Resolve<IComponentContext>(ctx)))).As<WorkContext>().SetScope<WorkContextImplementation, SimpleActivatorData, SingleRegistrationStyle>(ServiceScope.UnitOfWork);
		RegistrationExtensions.RegisterGeneric(builder, typeof(WorkValues<>)).SetScope<object, ReflectionActivatorData, DynamicRegistrationStyle>(ServiceScope.UnitOfWork);
		RegistrationExtensions.RegisterSource(builder, (IRegistrationSource)(object)new WorkRegistrationSource());
	}
}
