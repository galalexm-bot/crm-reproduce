using System;
using System.Collections.Generic;
using System.Linq;
using Autofac;
using Autofac.Builder;
using Autofac.Core;
using Castle.DynamicProxy;
using EleWise.ELMA.Collections;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Events.Impl;

public class EventsRegistrationSource : IRegistrationSource
{
	private readonly DefaultProxyBuilder _proxyBuilder;

	internal static EventsRegistrationSource NiEqXRGLKLnX7F6M9itt;

	public bool IsAdapterForIndividualComponents => false;

	public EventsRegistrationSource()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		LmKRFiGLkRZrrKZiAA7H();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				_proxyBuilder = new DefaultProxyBuilder();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public IEnumerable<IComponentRegistration> RegistrationsFor(Service service, Func<Service, IEnumerable<IComponentRegistration>> registrationAccessor)
	{
		IServiceWithType val = (IServiceWithType)(object)((service is IServiceWithType) ? service : null);
		if (val == null)
		{
			return (IEnumerable<IComponentRegistration>)(object)new IComponentRegistration[0];
		}
		Type serviceType = val.get_ServiceType();
		if (serviceType.IsInterface && typeof(IEventHandler).IsAssignableFrom(serviceType) && serviceType != typeof(IEventHandler))
		{
			_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4_0();
			CS_0024_003C_003E8__locals0.interfaceProxyType = _proxyBuilder.CreateInterfaceProxyTypeWithoutTarget(serviceType, new Type[0], ProxyGenerationOptions.Default);
			return (IEnumerable<IComponentRegistration>)(object)new IComponentRegistration[1] { RegistrationBuilder.CreateRegistration<object, SimpleActivatorData, SingleRegistrationStyle>(RegistrationBuilder.ForDelegate<object>((Func<IComponentContext, IEnumerable<Parameter>, object>)delegate(IComponentContext ctx, IEnumerable<Parameter> parameters)
			{
				IEventBus[] eventBuses = ResolutionExtensions.Resolve<IEnumerable<IEventBus>>(ctx).Distinct(new ObjectTypeEqualityComparer<IEventBus>()).ToArray();
				IEventBusAsync[] eventBusesAsync = ResolutionExtensions.Resolve<IEnumerable<IEventBusAsync>>(ctx).Distinct(new ObjectTypeEqualityComparer<IEventBusAsync>()).ToArray();
				IInterceptor[] array = (IInterceptor[])(object)new IInterceptor[1]
				{
					new EventsInterceptor(eventBuses, eventBusesAsync)
				};
				object[] args = new object[2] { array, null };
				return Activator.CreateInstance(CS_0024_003C_003E8__locals0.interfaceProxyType, args);
			}).As((Service[])(object)new Service[1] { service })) };
		}
		return (IEnumerable<IComponentRegistration>)(object)new IComponentRegistration[0];
	}

	internal static void LmKRFiGLkRZrrKZiAA7H()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool hgBumoGLXh4wMaFWkfAM()
	{
		return NiEqXRGLKLnX7F6M9itt == null;
	}

	internal static EventsRegistrationSource Ve8We9GLTJFwZK3UjpYj()
	{
		return NiEqXRGLKLnX7F6M9itt;
	}
}
