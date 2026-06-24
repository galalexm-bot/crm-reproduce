using System.Collections.Generic;

namespace EleWise.ELMA.TestFramework.Results;

internal interface IScenarioResult
{
	System.Collections.Generic.ICollection<IStepResult> Steps { get; set; }
}
