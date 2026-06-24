using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IEventTrigger
{
	Guid EventTriggerUid { get; }

	StartEventTriggerSettings GetEmptySettings();

	void ValidateSettings(StartEventTriggerSettings settings, out List<string> warnings, out List<string> errors);

	bool IsLinkedObject(object obj, StartEventTriggerSettings settings);

	void OnProcessPublish(IProcessHeader header, StartEventTriggerSettings settings, EventTrigger eventElement);

	void OnProcessDelete(IProcessHeader header);

	void OnWorkflowStartEventHandler();
}
