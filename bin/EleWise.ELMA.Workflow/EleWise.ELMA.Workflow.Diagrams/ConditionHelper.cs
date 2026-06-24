using System.Collections.Generic;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Services;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Diagrams.Activities.Helpers;

public static class ConditionHelper
{
	public static bool Evaluate(Condition condition, IWorkflowInstance instance, Dictionary<string, object> parameters = null)
	{
		if (condition == null)
		{
			return false;
		}
		switch (condition.Type)
		{
		case ConditionType.Table:
			return ConditionTableEvaluator.CheckConditionTable(condition.Table, instance.Context, parameters);
		case ConditionType.Script:
		{
			object obj = Locator.GetServiceNotNull<IWorkflowScriptingService>().ExecuteScript(instance, condition.ScriptName, parameters);
			if (obj is bool)
			{
				return (bool)obj;
			}
			Logger.Log.Error(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-935313063 ^ -935255889), instance.Name, instance.Id, SR.T(instance.Process.Name), instance.Process.Id));
			break;
		}
		}
		return false;
	}
}
