using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Workflow.Diagrams.Elements.Gateways;

public enum GatewayType
{
	[DisplayName(typeof(__Resources_GatewayType), "P_Xor_DisplayName")]
	Xor,
	[DisplayName(typeof(__Resources_GatewayType), "P_Or_DisplayName")]
	Or,
	[DisplayName(typeof(__Resources_GatewayType), "P_And_DisplayName")]
	And
}
