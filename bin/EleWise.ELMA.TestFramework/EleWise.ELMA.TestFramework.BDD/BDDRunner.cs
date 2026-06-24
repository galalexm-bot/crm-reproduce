using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.TestFramework.Core;
using EleWise.ELMA.TestFramework.Results;

namespace EleWise.ELMA.TestFramework.BDD;

internal class BDDRunner : IBDDRunner
{
	public void RunScenario(string name, params IStep[] steps)
	{
		IScenario scenario = ConfigureScenario().WithName(name).WithSteps(steps).Build();
		IScenarioExecutionContext scenarioExecutionContext = CreateContext();
		scenarioExecutionContext.CurrentScenario = scenario;
		scenario.Execute(scenarioExecutionContext);
		TestContext.Current.ScenarioCount++;
		ScenarioResult scenarioResult = new ScenarioResult(scenario)
		{
			Id = $"Scenario_{TestContext.Current.ScenarioCount}"
		};
		TestContext.Current.SetResult(scenarioResult);
		try
		{
			scenario.Execute(scenarioExecutionContext);
		}
		catch (System.Exception ex)
		{
			System.Exception ex2 = new System.Exception(SR.T("В процессе выполнения сценария возникла ошибка"), ex);
			scenarioResult.Failed = 1;
			scenarioResult.Exception = ex2;
			throw ex2;
		}
		finally
		{
			TestContext.Current.PopResult();
		}
	}

	public void RunScenario<T>(string name, Func<T> modelCreator, params IStep[] steps)
	{
		IScenario scenario = ConfigureScenario().WithName(name).WithSteps(steps).Build();
		IScenarioExecutionContext scenarioExecutionContext = CreateContext();
		scenarioExecutionContext.CurrentScenario = scenario;
		TestContext.Current.ScenarioCount++;
		ScenarioResult scenarioResult = new ScenarioResult(scenario)
		{
			Id = $"Scenario_{TestContext.Current.ScenarioCount}"
		};
		TestContext.Current.SetResult(scenarioResult);
		try
		{
			scenarioExecutionContext.Model = modelCreator.Invoke();
			scenario.Execute(scenarioExecutionContext);
		}
		catch (System.Exception ex)
		{
			System.Exception ex2 = new System.Exception(SR.T("В процессе выполнения сценария возникла ошибка"), ex);
			scenarioResult.Failed = 1;
			scenarioResult.Exception = ex2;
			throw ex2;
		}
		finally
		{
			TestContext.Current.PopResult();
		}
	}

	private IScenarioBuilder ConfigureScenario()
	{
		return new ScenarioBuilder();
	}

	private IScenarioExecutionContext CreateContext()
	{
		return ScenarioExecutionContext.Current = new ScenarioExecutionContext();
	}
}
