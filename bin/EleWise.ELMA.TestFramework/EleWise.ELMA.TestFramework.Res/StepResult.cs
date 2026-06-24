using System;
using EleWise.ELMA.TestFramework.BDD;

namespace EleWise.ELMA.TestFramework.Results;

internal sealed class StepResult : TestSuiteResult, IStepResult
{
	private IStep _003CStep_003Ek__BackingField;

	public IStep Step
	{
		get
		{
			return _003CStep_003Ek__BackingField;
		}
		private set
		{
			_003CStep_003Ek__BackingField = value;
		}
	}

	public StepResult(IStep step)
	{
		Step = step;
		base.Name = System.Enum.GetName(typeof(StepType), (object)Step.Type) + ": " + Step.Name;
	}
}
