using System;
using System.Threading.Tasks;

namespace EleWise.ELMA.Messages.Helpers;

internal interface IActorEventPublisher
{
	Task PublishActorEvent<T>(Guid eventId, string eventNamespace, T data);
}
