using System;
using System.Collections.Generic;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;

public static class TimeOfExecutionExtensions
{
	public static void ReplaceContextVars(this TimeOfExecution timeOfExecution, Dictionary<Guid, Guid> replaceContextVarMap)
	{
		if (replaceContextVarMap.TryGetValue(timeOfExecution.PropertyUid, out var value))
		{
			timeOfExecution.PropertyUid = value;
		}
		foreach (Recipient recipient in timeOfExecution.Recipients)
		{
			if (replaceContextVarMap.TryGetValue(recipient.PropertyUid, out value))
			{
				recipient.PropertyUid = value;
			}
		}
	}
}
