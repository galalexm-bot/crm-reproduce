using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Workflow.Validation;

namespace EleWise.ELMA.Workflow.Processes.Web.Models;

public class ChangeProcessVersionViewModel
{
	public WorkflowInstanceViewModel WorkflowModel { get; set; }

	public ChangeProcessVersionSummaryViewModel SummaryTable { get; set; }

	public IList<ProcessValidationMessage> ChangeRemarks { get; set; }

	public IList<SwimlaneChangesViewModel> SwimlaneChanges { get; set; }

	public ChangeProcessVersionResponseModel ResponseModel { get; set; }

	public ChangeProcessVersionViewModel()
	{
		WorkflowModel = new WorkflowInstanceViewModel();
		SummaryTable = new ChangeProcessVersionSummaryViewModel();
		ChangeRemarks = new List<ProcessValidationMessage>();
		SwimlaneChanges = new List<SwimlaneChangesViewModel>();
		ResponseModel = new ChangeProcessVersionResponseModel();
	}

	public bool HasCriticalIssues()
	{
		return ChangeRemarks.Any((ProcessValidationMessage p) => p.Type == ProcessValidationMessageType.Error);
	}
}
