using Microsoft.Practices.ObjectBuilder;

namespace EleWise.ELMA.CAB;

public class Controller
{
	[Dependency(/*Could not decode attribute arguments.*/)]
	public WorkItem WorkItem { get; set; }

	public State State => (WorkItem == null) ? null : WorkItem.State;
}
