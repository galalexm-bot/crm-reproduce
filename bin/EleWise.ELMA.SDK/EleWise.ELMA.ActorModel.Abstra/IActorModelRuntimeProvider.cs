using System;
using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.ActorModel.Abstractions;

public interface IActorModelRuntimeProvider : IActorModelRuntime, IProvider, IConfigurableProvider, IDisposable
{
	Guid LocalConnection { get; }

	IEnumerable<Guid> ActiveConnections { get; }
}
