using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Workflow.Processes.Web.Models;

public class StartWorkflowElementParametersModel
{
	public IEntity ContextDict { get; set; }

	public FormViewItem View { get; set; }
}
