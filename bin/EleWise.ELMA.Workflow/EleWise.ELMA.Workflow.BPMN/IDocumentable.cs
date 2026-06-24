using System.Collections.Generic;
using System.Drawing;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Workflow.Diagrams;
using EleWise.ELMA.Workflow.Models;
using Nevron.Diagram;

namespace EleWise.ELMA.Workflow.BPMN;

public interface IDocumentable
{
	string Name { get; }

	string ChapterName { get; }

	string HtmlHeader(ProcessContext context, int orgStructVersion, bool subFolders, WorkflowDiagram diagram, GenerationSettings gs = null);

	string HtmlBody(Element element, List<ProcessContext> contexts, int orgStructVersion, bool subFolders, WorkflowDiagram diagram, IWorkflowProcess wp = null, GenerationSettings gs = null);

	string HtmlFooter();

	Bitmap GetBitmap(WorkflowDiagram diagram, NShape shape);
}
