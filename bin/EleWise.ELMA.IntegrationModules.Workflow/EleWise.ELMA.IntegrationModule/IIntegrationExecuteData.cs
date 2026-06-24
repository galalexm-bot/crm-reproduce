using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.IntegrationModules.Workflow.Models;

public interface IIntegrationExecuteData : IWorkflowExecuteData
{
	Guid ConnectorUid { get; }

	IWorkflowIntegrationBookmark IntegrationBookmark { get; }

	WebData WebData { get; }
}
