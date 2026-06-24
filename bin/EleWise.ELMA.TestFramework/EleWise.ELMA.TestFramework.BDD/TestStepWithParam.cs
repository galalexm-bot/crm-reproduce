using System;

namespace EleWise.ELMA.TestFramework.BDD;

internal class TestStepWithParam<T> : IStep, IExecutableStep
{
	private readonly Action<T> action;

	private readonly string _003CName_003Ek__BackingField;

	private readonly StepType _003CType_003Ek__BackingField;

	public string Name => _003CName_003Ek__BackingField;

	public StepType Type => _003CType_003Ek__BackingField;

	public TestStepWithParam(Action<T> action, string name, StepType stepType)
	{
		this.action = action;
		_003CName_003Ek__BackingField = name;
		_003CType_003Ek__BackingField = stepType;
	}

	public void Execute(IScenarioExecutionContext context)
	{
		action.Invoke((T)context.Model);
	}
}
