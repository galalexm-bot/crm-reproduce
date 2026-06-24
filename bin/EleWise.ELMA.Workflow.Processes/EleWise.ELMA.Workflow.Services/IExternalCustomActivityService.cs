using System;

namespace EleWise.ELMA.Workflow.Services;

[Obsolete("Не использовать! Указанный API не зафиксирован и может быть изменен или удален в любой момент!", false)]
public interface IExternalCustomActivityService
{
	Guid GetAvailableServer();

	Guid GetAvailableServer(Guid customActivityHeaderUid);

	bool CanExecute(Guid serverUid, long customActivityId);

	void Execute(Guid serverUid, long workflowQueueItemId);
}
