using System;
using System.Collections.Generic;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Services;

public interface IWorkflowQueueService
{
	void TerminateItem(Guid executionUid);

	void ProcessItemAsync(IWorkflowQueueItem item);

	void ProcessItemAsync(long itemId);

	void ProcessItemAsync(long itemId, long instanceId, TimeSpan? timeout);

	void ProcessItemAsyncAfterCommit(IWorkflowQueueItem item);

	void ProcessItemAsyncAfterCommit(long itemId);

	void ProcessItem(IWorkflowQueueItem item);

	void ProcessItem(IWorkflowQueueItem item, TimeSpan? timeout);

	void ProcessItem(long itemId);

	void ProcessItem(long itemId, TimeSpan? timeout);

	IEnumerable<WorkflowQueueItemExecutionInfo> GetCurrentExecutions();

	IEnumerable<WorkflowQueueItemExecutionInfo> GetGlobalExecutions();

	IList<IWorkflowQueueItem> WaitWhileQueued(IWorkflowInstance instance, TimeSpan? waitTime = null);
}
