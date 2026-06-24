using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Context;

public static class IAbstractBoundVariableServiceExtensions
{
	public static T GetOrAdd<T>([NotNull] this IAbstractBoundVariableService contextObjects, [NotNull] string name, [NotNull] Func<T> factory)
	{
		Contract.ArgumentNotNull(contextObjects, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939506480));
		Contract.ArgumentNotNullOrEmpty(name, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420742352));
		Contract.ArgumentNotNull(factory, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4785BC0D ^ 0x4787B471));
		if (contextObjects.TryGetValue<T>(name, out var value))
		{
			return value;
		}
		value = factory();
		contextObjects.Set(name, value);
		return value;
	}
}
