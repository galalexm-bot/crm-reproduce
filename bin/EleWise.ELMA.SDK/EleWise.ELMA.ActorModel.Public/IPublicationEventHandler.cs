using System;
using EleWise.ELMA.Events;

namespace EleWise.ELMA.ActorModel.Publication;

internal interface IPublicationEventHandler : IEventHandler
{
	void Complete(Guid publicationToken);

	void Error(Guid publicationToken, Exception exception);
}
