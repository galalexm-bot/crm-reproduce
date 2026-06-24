using System;
using System.Threading.Tasks;
using EleWise.ELMA.Events;

namespace EleWise.ELMA.Workflow;

internal interface ICustomActivityPublicationEventHandler : IEventHandler
{
	Task Complete(long customActivityId);

	Task Error(long customActivityId, Exception exception);
}
