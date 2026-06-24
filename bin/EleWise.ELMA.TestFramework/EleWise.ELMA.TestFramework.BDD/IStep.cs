namespace EleWise.ELMA.TestFramework.BDD;

public interface IStep
{
	string Name { get; }

	StepType Type { get; }
}
