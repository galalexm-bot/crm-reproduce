using System.Collections.Generic;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;

public interface IConnectorSettingsExtensionElement
{
	IList<ConnectorSettingsExtension> ConnectorSettings { get; set; }
}
