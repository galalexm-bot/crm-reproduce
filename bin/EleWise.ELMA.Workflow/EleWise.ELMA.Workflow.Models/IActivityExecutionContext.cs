using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Workflow.Models;

public interface IActivityExecutionContext : IAutoImplement
{
	[DisplayName(typeof(__Resources_IActivityExecutionContext), "P_QueueItem_DisplayName")]
	[UseImplementationType]
	IWorkflowQueueItem QueueItem { get; set; }

	[UseImplementationType]
	[DisplayName(typeof(__Resources_IActivityExecutionContext), "P_Bookmark_DisplayName")]
	IWorkflowBookmark Bookmark { get; set; }

	[UseImplementationType]
	[DisplayName(typeof(__Resources_IActivityExecutionContext), "P_Instance_DisplayName")]
	IWorkflowInstance Instance { get; set; }

	[DisplayName(typeof(__Resources_IActivityExecutionContext), "P_Element_DisplayName")]
	Element Element { get; set; }
}
