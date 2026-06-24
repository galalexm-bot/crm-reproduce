using System.Collections.Generic;
using EleWise.ELMA.TestFramework.BDD;

namespace EleWise.ELMA.TestFramework.Results;

internal sealed class ScenarioResult : TestSuiteResult, IScenarioResult
{
	private IScenario _003CScenario_003Ek__BackingField;

	private System.Collections.Generic.ICollection<IStepResult> _003CSteps_003Ek__BackingField;

	public IScenario Scenario
	{
		get
		{
			return _003CScenario_003Ek__BackingField;
		}
		set
		{
			_003CScenario_003Ek__BackingField = value;
		}
	}

	public System.Collections.Generic.ICollection<IStepResult> Steps
	{
		get
		{
			return _003CSteps_003Ek__BackingField;
		}
		set
		{
			_003CSteps_003Ek__BackingField = value;
		}
	}

	public ScenarioResult(IScenario scenario)
	{
		Scenario = scenario;
		Steps = (System.Collections.Generic.ICollection<IStepResult>)new List<IStepResult>();
		base.Name = Scenario.Name;
	}
}
