using System;
using System.Threading.Tasks;
using EleWise.ELMA.Events;

namespace EleWise.ELMA.Workflow;

internal interface IWorkflowProcessPublicationEventHandler : IEventHandler
{
	Task Complete(long processHeaderId);

	Task Error(long processHeaderId, Exception exception);
}
