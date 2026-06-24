using System;
using EleWise.ELMA.TestFramework.Results;

namespace EleWise.ELMA.TestFramework.Notification;

internal interface IScenarioProgressNotifier
{
	Action OnScenarioStart { get; set; }

	Action OnScenarioEnd { get; set; }

	Action OnStepStart { get; set; }

	Action OnStepEnd { get; set; }

	void ScenarioStarted(IScenarioInfo scenario);

	void ScenarioFinished(IScenarioResult scenario);

	void StepStarted(IStepInfo step);

	void StepFinished(IStepResult step);
}
