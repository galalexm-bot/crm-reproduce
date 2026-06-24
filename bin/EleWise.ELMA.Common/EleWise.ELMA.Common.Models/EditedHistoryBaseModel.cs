using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Common.Models;

public abstract class EditedHistoryBaseModel<TEntity> : HistoryBaseModel, IEditedHistoryModel<TEntity>, IHistoryBaseModel where TEntity : class, IEntity
{
	public TEntity OldEntity { get; set; }

	public TEntity NewEntity { get; set; }

	public IList<PropertyMetadata> ChangedProperties { get; set; }

	public List<Guid> BaseProperties { get; set; }

	public EditedHistoryBaseModel([NotNull] EntityActionEventArgs originalEvent, string actionTheme)
		: base(originalEvent, actionTheme)
	{
	}
}
