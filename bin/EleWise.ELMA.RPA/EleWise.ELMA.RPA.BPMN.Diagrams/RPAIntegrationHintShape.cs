using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;

namespace EleWise.ELMA.RPA.BPMN.Diagrams.Shapes.RPAIntegration;

internal class RPAIntegrationHintShape : RPAIntegrationShape
{
	protected override DecoratorPosition RPAIntegrationDecoratorPosition => DecoratorPosition.Center;

	protected override float DefaultWidth => 24f;

	protected override float DefaultHeight => 24f;

	protected override float Radius => 4f;
}
