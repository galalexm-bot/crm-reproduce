using System;
using EleWise.ELMA.Workflow.Diagrams.Elements.Gateways;

namespace EleWise.ELMA.Workflow.Diagrams.Activities.Gateways;

public interface IGatewayActivity
{
	GatewayStartType GatewayStartType { get; }

	GatewayType GatewayType { get; }

	Guid PairGatewayUid { get; }
}
