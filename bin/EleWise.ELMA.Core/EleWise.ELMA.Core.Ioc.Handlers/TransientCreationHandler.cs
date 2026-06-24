using System;
using System.Collections;
using System.Collections.Generic;
using EleWise.ELMA.Ioc.Abstract;
using EleWise.ELMA.Ioc.Abstract.Handlers;
using EleWise.ELMA.Ioc.Models;

namespace EleWise.ELMA.Core.Ioc.Handlers;

internal sealed class TransientCreationHandler : ITransientCreationHandler, IHandler
{
	public object AfterCreate(IComponentRegistration componentRegistration)
	{
		IScopeContext scope = componentRegistration.get_Scope();
		if (scope.get_Registry().GetResolver(typeof(System.Collections.Generic.IEnumerable<IIocModule>)) == null)
		{
			return componentRegistration.get_Instance();
		}
		IRegistration registration = null;
		System.Collections.Generic.IEnumerator<IIocModule> enumerator = scope.Resolve<System.Collections.Generic.IEnumerable<IIocModule>>().GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				IIocModule current = enumerator.get_Current();
				if (registration == null)
				{
					registration = new Registration(componentRegistration.get_Instance(), componentRegistration.get_Type());
				}
				current.OnComponentResolved(registration);
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		return componentRegistration.get_Instance();
	}
}
