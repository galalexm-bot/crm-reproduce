using System;
using System.Threading.Tasks;
using EleWise.ELMA.Events;

namespace EleWise.ELMA.UIBuilder.Handler;

internal interface IModulePublishingEventHandler : IEventHandler
{
	Task PublicationSuccess(Guid moduleMetadataItemHeaderUid);

	Task PublicationError(Guid moduleMetadataItemHeaderUid, Exception exception);
}
