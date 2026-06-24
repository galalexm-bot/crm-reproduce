using EleWise.ELMA.Model.Scripts;

namespace EleWise.ELMA.Workflow.Diagrams.Elements;

public interface IFlowConnector
{
	Condition Condition { get; set; }
}
