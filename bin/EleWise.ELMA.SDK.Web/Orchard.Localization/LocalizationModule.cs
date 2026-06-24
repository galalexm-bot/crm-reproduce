using System;
using System.Collections.Concurrent;
using System.Reflection;
using Autofac;
using Autofac.Core;

namespace Orchard.Localization;

public class LocalizationModule : Module
{
	private readonly ConcurrentDictionary<string, Localizer> _localizerCache;

	public LocalizationModule()
	{
		_localizerCache = new ConcurrentDictionary<string, Localizer>();
	}

	protected override void Load(ContainerBuilder builder)
	{
		RegistrationExtensions.RegisterType<Text>(builder).As<IText>().InstancePerDependency();
	}

	protected override void AttachToComponentRegistration(IComponentRegistry componentRegistry, IComponentRegistration registration)
	{
		PropertyInfo userProperty = FindUserProperty(registration.get_Activator().get_LimitType());
		if (!(userProperty != null))
		{
			return;
		}
		string scope = registration.get_Activator().get_LimitType().FullName;
		registration.add_Activated((EventHandler<ActivatedEventArgs<object>>)delegate(object sender, ActivatedEventArgs<object> e)
		{
			if (!(e.get_Instance().GetType().FullName != scope))
			{
				Localizer orAdd = _localizerCache.GetOrAdd(scope, (string key) => LocalizationUtilities.Resolve(e.get_Context(), scope));
				userProperty.SetValue(e.get_Instance(), orAdd, null);
			}
		});
	}

	private static PropertyInfo FindUserProperty(Type type)
	{
		return type.GetProperty("T", typeof(Localizer));
	}
}
