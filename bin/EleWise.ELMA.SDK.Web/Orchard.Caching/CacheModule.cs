using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Autofac;
using Autofac.Core;

namespace Orchard.Caching;

public class CacheModule : Module
{
	protected override void Load(ContainerBuilder builder)
	{
		RegistrationExtensions.RegisterType<DefaultCacheManager>(builder).As<ICacheManager>().InstancePerDependency();
	}

	protected override void AttachToComponentRegistration(IComponentRegistry componentRegistry, IComponentRegistration registration)
	{
		if (registration.get_Activator().get_LimitType().GetConstructors()
			.Any((ConstructorInfo x) => x.GetParameters().Any((ParameterInfo xx) => xx.ParameterType == typeof(ICacheManager))))
		{
			registration.add_Preparing((EventHandler<PreparingEventArgs>)delegate(object sender, PreparingEventArgs e)
			{
				//IL_0032: Unknown result type (might be due to invalid IL or missing references)
				//IL_0038: Expected O, but got Unknown
				//IL_003d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0043: Expected O, but got Unknown
				TypedParameter val = new TypedParameter(typeof(ICacheManager), (object)ResolutionExtensions.Resolve<ICacheManager>(e.get_Context(), (Parameter[])(object)new Parameter[1] { (Parameter)new TypedParameter(typeof(Type), (object)registration.get_Activator().get_LimitType()) }));
				e.set_Parameters(e.get_Parameters().Concat((IEnumerable<Parameter>)(object)new TypedParameter[1] { val }));
			});
		}
	}
}
