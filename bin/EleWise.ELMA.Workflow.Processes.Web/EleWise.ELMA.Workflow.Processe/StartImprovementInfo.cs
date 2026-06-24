using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Models.Forms;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Models;

public class StartImprovementInfo : FormViewModel
{
	public string Caption { get; set; }

	[DisplayName(typeof(StartImprovementInfo_SR), "Name")]
	[Required(true)]
	[RequiredField]
	public string Name { get; set; }

	[DisplayName(typeof(StartImprovementInfo_SR), "Header")]
	[Required(true)]
	[RequiredField]
	public IProcessHeader Header { get; set; }

	public IWorkflowInstance Instance { get; set; }

	public ITaskBase Task { get; set; }

	[DisplayName(typeof(StartImprovementInfo_SR), "Description")]
	[Required(true)]
	[RequiredField]
	public string Description { get; set; }

	public string PopupId { get; set; }

	public IImprovementProcessSettings Settings { get; set; }
}
