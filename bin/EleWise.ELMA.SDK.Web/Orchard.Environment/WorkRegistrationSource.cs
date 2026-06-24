using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Autofac;
using Autofac.Builder;
using Autofac.Core;

namespace Orchard.Environment;

internal class WorkRegistrationSource : IRegistrationSource
{
	private static readonly MethodInfo CreateMetaRegistrationMethod = typeof(WorkRegistrationSource).GetMethod("CreateMetaRegistration", BindingFlags.Static | BindingFlags.NonPublic);

	public bool IsAdapterForIndividualComponents => true;

	private static bool IsClosingTypeOf(Type type, Type openGenericType)
	{
		if (type.IsGenericType)
		{
			return type.GetGenericTypeDefinition() == openGenericType;
		}
		return false;
	}

	public IEnumerable<IComponentRegistration> RegistrationsFor(Service service, Func<Service, IEnumerable<IComponentRegistration>> registrationAccessor)
	{
		Service obj = service;
		IServiceWithType val = (IServiceWithType)(object)((obj is IServiceWithType) ? obj : null);
		if (val == null || !IsClosingTypeOf(val.get_ServiceType(), typeof(Work<>)))
		{
			return Enumerable.Empty<IComponentRegistration>();
		}
		Type type = val.get_ServiceType().GetGenericArguments()[0];
		Service arg = val.ChangeType(type);
		MethodInfo registrationCreator = CreateMetaRegistrationMethod.MakeGenericMethod(type);
		return (from v in registrationAccessor(arg)
			select registrationCreator.Invoke(null, new object[2] { service, v })).Cast<IComponentRegistration>();
	}

	private static IComponentRegistration CreateMetaRegistration<T>(Service providedService, IComponentRegistration valueRegistration) where T : class
	{
		return RegistrationBuilder.CreateRegistration<Work<T>, SimpleActivatorData, SingleRegistrationStyle>(RegistrationExtensions.Targeting<Work<T>, SimpleActivatorData, SingleRegistrationStyle>(RegistrationBuilder.ForDelegate<Work<T>>((Func<IComponentContext, IEnumerable<Parameter>, Work<T>>)delegate(IComponentContext c, IEnumerable<Parameter> p)
		{
			IWorkContextAccessor workContextAccessor = ResolutionExtensions.Resolve<IWorkContextAccessor>(c);
			return new Work<T>(delegate(Work<T> w)
			{
				WorkContext context = workContextAccessor.GetContext();
				if (context == null)
				{
					return null;
				}
				WorkValues<T> workValues = context.Resolve<WorkValues<T>>();
				if (!workValues.Values.TryGetValue(w, out var value))
				{
					value = (T)workValues.ComponentContext.ResolveComponent(valueRegistration, p);
					workValues.Values[w] = value;
				}
				return value;
			});
		}).As((Service[])(object)new Service[1] { providedService }), valueRegistration));
	}
}
