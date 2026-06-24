using System;
using Autofac.Builder;
using EleWise.ELMA.ComponentModel;
using SG9KiyIbtdgGDf12qr;

namespace Autofac;

public static class AutofacExtensions
{
	public static void SetScope<TLimit, TActivatorData, TRegistrationStyle>(this IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> register, ServiceScope scope)
	{
		switch (scope)
		{
		case ServiceScope.Application:
			register.SingleInstance();
			break;
		case ServiceScope.Shell:
			register.SingleInstance();
			break;
		case ServiceScope.Transient:
			register.InstancePerDependency();
			break;
		case ServiceScope.UnitOfWork:
			register.InstancePerMatchingLifetimeScope(new object[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x76DDDCC) });
			break;
		default:
			throw new InvalidOperationException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105197908) + scope);
		}
	}
}
