using System.Collections.Generic;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Events.Audit;

public interface IEditedHistoryModel<TEntity> : IHistoryBaseModel where TEntity : class, IEntity
{
	TEntity OldEntity { get; set; }

	TEntity NewEntity { get; set; }

	IList<PropertyMetadata> ChangedProperties { get; set; }
}
