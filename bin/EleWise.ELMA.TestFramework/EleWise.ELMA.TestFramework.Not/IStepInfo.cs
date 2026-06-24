using EleWise.ELMA.TestFramework.BDD;

namespace EleWise.ELMA.TestFramework.Notification;

internal interface IStepInfo
{
	string Name { get; set; }

	int Number { get; set; }

	int Total { get; set; }

	StepType Type { get; set; }
}
