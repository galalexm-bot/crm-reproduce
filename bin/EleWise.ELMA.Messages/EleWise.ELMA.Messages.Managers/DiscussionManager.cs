using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Messages.Managers;

public class DiscussionManager : EntityManager<IDiscussion, long>
{
	public new static DiscussionManager Instance => Locator.GetServiceNotNull<DiscussionManager>();
}
