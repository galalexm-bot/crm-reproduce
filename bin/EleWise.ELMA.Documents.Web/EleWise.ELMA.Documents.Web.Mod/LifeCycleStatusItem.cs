using EleWise.ELMA.Documents.Models;

namespace EleWise.ELMA.Documents.Web.Models;

public class LifeCycleStatusItem
{
	public ILifeCycleStatus Status { get; set; }

	public ILifeCycleTransition Transition { get; set; }
}
