using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Messages.ExtensionPoints;

public interface IFeedModelMappingService
{
	FeedModel Map(IEntity entity);
}
