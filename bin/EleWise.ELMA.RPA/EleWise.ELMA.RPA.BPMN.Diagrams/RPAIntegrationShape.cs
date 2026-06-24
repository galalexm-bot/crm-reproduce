using System.Drawing;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;

namespace EleWise.ELMA.RPA.BPMN.Diagrams.Shapes.RPAIntegration;

internal class RPAIntegrationShape : BPMNRectangleShape
{
	protected override Color StrokeColor => Color.FromArgb(212, 125, 17);

	protected override Color StartColor => Color.FromArgb(255, 219, 179);

	protected override Color EndColor => Color.FromArgb(255, 219, 179);

	protected virtual DecoratorPosition RPAIntegrationDecoratorPosition => DecoratorPosition.Center;
}
