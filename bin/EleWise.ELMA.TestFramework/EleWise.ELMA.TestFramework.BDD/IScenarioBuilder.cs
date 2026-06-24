namespace EleWise.ELMA.TestFramework.BDD;

internal interface IScenarioBuilder
{
	IScenarioBuilder WithName(string name);

	IScenarioBuilder WithSteps(params IStep[] steps);

	IScenario Build();
}
