using System;

namespace EleWise.ELMA.IntegrationModules.Workflow.BPMN.Diagrams.Shapes;

[Serializable]
internal class IntegrationModuleHintShape : IntegrationModuleShape
{
	protected override float DefaultWidth => 24f;

	protected override float DefaultHeight => 24f;

	protected override float Radius => 4f;
}
