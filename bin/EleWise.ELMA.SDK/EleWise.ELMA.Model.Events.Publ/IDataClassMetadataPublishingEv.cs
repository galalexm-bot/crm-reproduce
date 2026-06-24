using System;
using System.Threading.Tasks;
using EleWise.ELMA.Events;

namespace EleWise.ELMA.Model.Events.Publication;

internal interface IDataClassMetadataPublishingEventHandler : IEventHandler
{
	Task Complete(Guid publicationToken, UIMetadataPublishResult result);

	Task Error(Guid publicationToken, Exception exception);
}
