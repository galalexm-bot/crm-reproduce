using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.IntegrationModules.Workflow.Models;

internal sealed class IntegrationExecuteData : IIntegrationExecuteData, IWorkflowExecuteData
{
	private IWorkflowBookmark bookmark;

	private Guid connectorUid;

	private IWorkflowIntegrationBookmark integrationBookmark;

	public Guid ConnectorUid => connectorUid;

	public IWorkflowBookmark Bookmark => bookmark;

	public IWorkflowIntegrationBookmark IntegrationBookmark => integrationBookmark;

	public WebData WebData { get; set; }

	public IntegrationExecuteData(IWorkflowIntegrationBookmark integrationBookmark)
	{
		Contract.ArgumentNotNull(integrationBookmark, "integrationBookmark");
		bookmark = integrationBookmark.WorkflowBookmark;
		this.integrationBookmark = integrationBookmark;
	}

	public IntegrationExecuteData(IWorkflowBookmark bookmark, Guid connectorUid, IWorkflowIntegrationBookmark integrationBookmark)
	{
		Contract.ArgumentNotNull(bookmark, "bookmark");
		this.bookmark = bookmark;
		this.connectorUid = connectorUid;
		this.integrationBookmark = integrationBookmark;
	}
}
