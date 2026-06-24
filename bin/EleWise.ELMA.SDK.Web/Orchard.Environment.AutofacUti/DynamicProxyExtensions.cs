using System;
using Autofac.Builder;
using Autofac.Core;
using Autofac.Features.Scanning;

namespace Orchard.Environment.AutofacUtil.DynamicProxy2;

public static class DynamicProxyExtensions
{
	public static IRegistrationBuilder<TLimit, TConcreteReflectionActivatorData, TRegistrationStyle> EnableDynamicProxy<TLimit, TConcreteReflectionActivatorData, TRegistrationStyle>(this IRegistrationBuilder<TLimit, TConcreteReflectionActivatorData, TRegistrationStyle> rb, DynamicProxyContext dynamicProxyContext) where TConcreteReflectionActivatorData : ConcreteReflectionActivatorData
	{
		dynamicProxyContext.EnableDynamicProxy<TLimit, TConcreteReflectionActivatorData, TRegistrationStyle>(rb);
		return rb;
	}

	public static IRegistrationBuilder<TLimit, ScanningActivatorData, TRegistrationStyle> EnableDynamicProxy<TLimit, TRegistrationStyle>(this IRegistrationBuilder<TLimit, ScanningActivatorData, TRegistrationStyle> rb, DynamicProxyContext dynamicProxyContext)
	{
		rb.get_ActivatorData().get_ConfigurationActions().Add(delegate(Type t, IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle> rb2)
		{
			rb2.EnableDynamicProxy<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>(dynamicProxyContext);
		});
		return rb;
	}

	public static void InterceptedBy<TService>(this IComponentRegistration cr)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		(DynamicProxyContext.From(cr) ?? throw new ApplicationException($"Component {cr.get_Activator().get_LimitType()} was not registered with EnableDynamicProxy")).AddInterceptorService(cr, (Service)new TypedService(typeof(TService)));
	}
}
