using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Messages.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IFeedModelEntityMapper
{
	FeedModel MapEntity(IEntity entity, FeedModel originalModel);
}
