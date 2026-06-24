using System;
using EleWise.ELMA.RPA.DTO.Models;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.RPA.Models;

public class ExecutingRPAProcessData : IWorkflowExecuteData
{
	private IWorkflowBookmark bookmark;

	public TaskDTO Task { get; set; }

	public Guid SchedulerTaskUid { get; set; }

	public IWorkflowBookmark Bookmark => bookmark;

	public ExecutingRPAProcessData(IWorkflowBookmark bookmark)
	{
		this.bookmark = bookmark;
	}
}
