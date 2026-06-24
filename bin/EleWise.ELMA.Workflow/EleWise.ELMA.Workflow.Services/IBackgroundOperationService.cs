using System;
using System.Threading;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Models.BackgroundOperations;

namespace EleWise.ELMA.Workflow.Services;

public interface IBackgroundOperationService
{
	bool StartBackgroundOperation(IWorkflowQueueItem queueItem, Guid executionUid, Action<long, IBackgroundOperationResult, CancellationToken> onCompletedAction);

	void CancelBackgroundOperation(long[] ids);

	IWorkflowQueueItem CreateUserCallbackQueueItem(IWorkflowQueueItem backgroundQueueItem, IBackgroundOperationResult result);

	void ProcessBackgroundOperationsCancellation();

	int GetActiveOperationsCount();
}
