using EleWise.ELMA.TestFramework.Core;

namespace EleWise.ELMA.TestFramework.BDD;

internal interface IScenarioExecutionContext
{
	IScenario CurrentScenario { get; set; }

	IStep CurrentStep { get; set; }

	TestContext TestContext { get; set; }

	object Model { get; set; }
}
