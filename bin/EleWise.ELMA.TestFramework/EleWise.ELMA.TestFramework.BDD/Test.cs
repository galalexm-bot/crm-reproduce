using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.TestFramework.BDD;

[Component(CreateInstancePerResolve = true)]
public class Test : IBDDTest
{
	public virtual void RunScenario(string name, params IStep[] steps)
	{
		new BDDRunner().RunScenario(name, steps);
	}

	public IStep Given(string name, Action setup)
	{
		return new Step(setup, name, StepType.GIVEN);
	}

	public IStep When(string name, Action action)
	{
		return new Step(action, name, StepType.WHEN);
	}

	public IStep Then(string name, Action assertion)
	{
		return new Step(assertion, name, StepType.THEN);
	}
}
public abstract class Test<T> : Test
{
	protected abstract Func<T> Model { get; }

	public override void RunScenario(string name, params IStep[] steps)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (steps.Length == 0)
		{
			throw new InvalidOperationException(SR.T("Сценарий должен содержать как минимум один шаг"));
		}
		new BDDRunner().RunScenario<T>(name, Model, steps);
	}

	public virtual IStep Given(string name, Action<T> setup)
	{
		return new TestStepWithParam<T>(setup, name, StepType.GIVEN);
	}

	public virtual IStep When(string name, Action<T> action)
	{
		return new TestStepWithParam<T>(action, name, StepType.WHEN);
	}

	public virtual IStep Then(string name, Action<T> assertion)
	{
		return new TestStepWithParam<T>(assertion, name, StepType.THEN);
	}
}
