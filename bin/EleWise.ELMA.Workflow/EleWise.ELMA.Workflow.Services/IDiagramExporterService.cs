using System.IO;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Services;

public interface IDiagramExporterService
{
	Stream ExportDiagramWorkflowProcess(IWorkflowProcess workflowProcess);

	Stream ExportDiagramWorkflowInstance(IWorkflowInstance instance);
}
