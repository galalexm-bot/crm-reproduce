namespace EleWise.ELMA.TestFramework.BDD;

internal interface IScenario
{
	string Name { get; }

	void Execute(IScenarioExecutionContext сontext);
}
