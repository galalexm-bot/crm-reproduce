using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Autofac;
using Autofac.Core;
using Orchard.Environment.Extensions.Models;

namespace Orchard.DisplayManagement.Descriptors.ShapeAttributeStrategy;

public class ShapeAttributeBindingModule : Module
{
	private readonly List<ShapeAttributeOccurrence> _occurrences = new List<ShapeAttributeOccurrence>();

	protected override void Load(ContainerBuilder builder)
	{
		RegistrationExtensions.RegisterInstance<List<ShapeAttributeOccurrence>>(builder, _occurrences).As<IEnumerable<ShapeAttributeOccurrence>>();
	}

	protected override void AttachToComponentRegistration(IComponentRegistry componentRegistry, IComponentRegistration registration)
	{
		ShapeAttributeOccurrence[] array = registration.get_Activator().get_LimitType().GetMethods()
			.SelectMany((MethodInfo mi) => from sa in mi.GetCustomAttributes(typeof(ShapeAttribute), inherit: false).OfType<ShapeAttribute>()
				select new ShapeAttributeOccurrence(sa, mi, registration, () => GetFeature(registration)))
			.ToArray();
		if (array.Any())
		{
			_occurrences.AddRange(array);
		}
	}

	private static Feature GetFeature(IComponentRegistration registration)
	{
		if (!registration.get_Metadata().TryGetValue("Feature", out var value))
		{
			return null;
		}
		return value as Feature;
	}
}
