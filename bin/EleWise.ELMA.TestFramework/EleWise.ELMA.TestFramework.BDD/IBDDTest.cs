using System;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.TestFramework.BDD;

[ExtensionPoint]
public interface IBDDTest
{
	void RunScenario(string name, params IStep[] steps);

	IStep Given(string name, Action setup);

	IStep When(string name, Action action);

	IStep Then(string name, Action assertion);
}
