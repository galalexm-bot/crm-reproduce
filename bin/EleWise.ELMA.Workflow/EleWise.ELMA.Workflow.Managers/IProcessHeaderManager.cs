using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Managers;

internal interface IProcessHeaderManager : IEntityManager<IProcessHeader, long>, IEntityManager<IProcessHeader>, IEntityManager
{
	long GetPublishingVersionNumber(long headerId);
}
