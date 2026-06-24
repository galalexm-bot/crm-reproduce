using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.TestFramework.Core;
using EleWise.ELMA.TestFramework.Notification;
using EleWise.ELMA.TestFramework.Results;

namespace EleWise.ELMA.TestFramework.BDD;

internal sealed class Scenario : IScenario
{
	private readonly IStep[] steps;

	private readonly string _003CName_003Ek__BackingField;

	public string Name => _003CName_003Ek__BackingField;

	public Scenario(string name, IStep[] steps)
	{
		_003CName_003Ek__BackingField = name;
		this.steps = steps;
	}

	public void Execute(IScenarioExecutionContext context)
	{
		IScenarioProgressNotifier scenarioProgressNotifier = TestContext.Current.Notifier as IScenarioProgressNotifier;
		scenarioProgressNotifier?.ScenarioStarted(new ScenarioInfo
		{
			Name = Name
		});
		int num = steps.Length;
		for (int i = 0; i < num; i++)
		{
			IStep step2 = (context.CurrentStep = steps[i]);
			if (step2 is IExecutableStep executableStep)
			{
				StepResult stepResult = new StepResult(step2)
				{
					Id = $"{TestContext.Current.CurrentResult.Id}_{i}"
				};
				TestContext.Current.SetResult(stepResult);
				scenarioProgressNotifier?.StepStarted(new StepInfo
				{
					Name = step2.Name,
					Type = step2.Type,
					Number = i + 1,
					Total = num
				});
				try
				{
					executableStep.Execute(context);
				}
				catch (System.Exception ex)
				{
					System.Exception ex2 = new System.Exception(SR.T("Выполнение шага завершилось с ошибкой"), ex);
					stepResult.Failed = 1;
					stepResult.Exception = ex2;
					throw ex2;
				}
				finally
				{
					TestContext.Current.PopResult();
					scenarioProgressNotifier?.StepFinished(stepResult);
				}
				continue;
			}
			throw new System.Exception(SR.T("Невозможно выполнить шаг сценария: шаг {0} не является {1}", step2.Name, typeof(IExecutableStep)));
		}
		scenarioProgressNotifier?.ScenarioFinished(new ScenarioResult(this));
	}
}
