using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface ISwimlaneChangedExecHandler
{
	void Execute(IWorkflowInstance instance, SwimlaneElement startSwimlane, SwimlaneElement endSwimlane, Element startElement, Element endElement, List<IUser> endSwimlaneUsers);
}
