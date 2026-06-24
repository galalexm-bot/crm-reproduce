using System;
using System.Threading.Tasks;
using EleWise.ELMA.Events;
using EleWise.ELMA.Model;

namespace EleWise.ELMA.UI.Events;

internal interface IComponentMetadataPublishingEventHandler : IEventHandler
{
	Task PublicationSuccess(Guid componentMetadataUid, UIMetadataPublishResult result);

	Task PublicationError(Guid componentMetadataUid, Exception exception);
}
