using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Messages.Components.Feed;

[Service]
public class FeedModelMappingService : IFeedModelMappingService
{
	private IEnumerable<IFeedModelEntityMapper> ModelMappers => ComponentManager.Current.GetExtensionPoints<IFeedModelEntityMapper>();

	FeedModel IFeedModelMappingService.Map(IEntity entity)
	{
		return ModelMappers.Aggregate(null, (FeedModel feedModel, IFeedModelEntityMapper mapper) => mapper.MapEntity(entity, feedModel));
	}
}
