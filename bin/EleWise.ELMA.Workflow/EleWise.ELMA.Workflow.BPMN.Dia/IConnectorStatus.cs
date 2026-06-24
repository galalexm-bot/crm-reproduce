using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Connectors;

[ExtensionPoint(ComponentType.All)]
public interface IConnectorStatus
{
	Guid Uid { get; }

	string DisplayName { get; }

	bool DefaultFirstConnector { get; }

	bool DefaultSecondConnector { get; }

	List<Type> ElementTypes { get; }

	string DefaultConnectorDisplayName { get; }

	bool DefaultNthConnector(int nth);
}
