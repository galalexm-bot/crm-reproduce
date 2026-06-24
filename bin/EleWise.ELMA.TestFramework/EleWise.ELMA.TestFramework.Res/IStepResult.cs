using EleWise.ELMA.TestFramework.BDD;

namespace EleWise.ELMA.TestFramework.Results;

internal interface IStepResult
{
	string Name { get; set; }

	IStep Step { get; }
}
