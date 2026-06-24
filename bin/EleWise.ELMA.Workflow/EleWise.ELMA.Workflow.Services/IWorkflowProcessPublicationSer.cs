using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Services;

internal interface IWorkflowProcessPublicationService
{
	void Publish(IProcessHeader processHeader, string comment, bool generateDocumentation, bool isEmulation);
}
