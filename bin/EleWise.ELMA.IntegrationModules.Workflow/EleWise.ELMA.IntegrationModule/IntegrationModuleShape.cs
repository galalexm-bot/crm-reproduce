using System;
using System.Drawing;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Tasks;

namespace EleWise.ELMA.IntegrationModules.Workflow.BPMN.Diagrams.Shapes;

[Serializable]
internal class IntegrationModuleShape : TaskShape
{
	protected override Color StrokeColor => Color.FromArgb(202, 188, 124);

	protected override Color StartColor => Color.FromArgb(194, 226, 201);

	protected override Color EndColor => Color.FromArgb(230, 219, 170);
}
