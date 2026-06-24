using System;

namespace EleWise.ELMA.TestFramework.BDD;

internal interface IBDDRunner
{
	void RunScenario(string name, params IStep[] steps);

	void RunScenario<T>(string name, Func<T> modelCreator, params IStep[] steps);
}
