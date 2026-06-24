using System;

namespace EleWise.ELMA.Workflow.Services;

public interface IWorkflowTrackingService
{
	void Add(Guid elementUid, bool executed);

	void Execute(Guid elementUid);
}
