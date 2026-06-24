using System;
using System.Threading.Tasks;
using EleWise.ELMA.Events;

namespace EleWise.ELMA.Model.Events.Publication;

internal interface IFunctionMetadataPublishingEventHandler : IEventHandler
{
	Task Complete(Guid functionMetadataUid, UIMetadataPublishResult result);

	Task Error(Guid functionMetadataUid, Exception exception);
}
