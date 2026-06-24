using System;

namespace EleWise.ELMA.Workflow.Processes.Web.Models;

public class SwimlaneChangesViewModel
{
	public Guid SwimlaneUid { get; set; }

	public string SwimlaneStatus { get; set; }

	public bool HasActiveElementInside { get; set; }

	public SwimlaneViewModel OldSwimlane { get; set; }

	public SwimlaneViewModel NewSwimlane { get; set; }
}
