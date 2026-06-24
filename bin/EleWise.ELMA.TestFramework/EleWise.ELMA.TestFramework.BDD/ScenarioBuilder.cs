namespace EleWise.ELMA.TestFramework.BDD;

internal class ScenarioBuilder : IScenarioBuilder
{
	private string name;

	private IStep[] steps;

	public IScenarioBuilder WithName(string name)
	{
		this.name = name;
		return this;
	}

	public IScenarioBuilder WithSteps(params IStep[] steps)
	{
		this.steps = steps;
		return this;
	}

	public IScenario Build()
	{
		return new Scenario(name, steps);
	}
}
