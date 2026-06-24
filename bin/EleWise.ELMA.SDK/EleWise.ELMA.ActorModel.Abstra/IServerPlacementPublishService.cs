using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EleWise.ELMA.ActorModel.Abstractions;

public interface IServerPlacementPublishService
{
	Task Publish<T>(Func<T, Task> action, bool ignoreError, Action<Guid, Exception> errorAction) where T : IServerPlacementActor;

	Task<IReadOnlyDictionary<Guid, TRes>> Publish<T, TRes>(Func<T, Task<TRes>> action, bool ignoreError, Action<Guid, Exception> errorAction) where T : IServerPlacementActor;
}
