using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Tasks.Components;

namespace EleWise.ELMA.Tasks.Models;

public class ChangeControlTaskHistoryModel : HistoryBaseModel, IEditedHistoryModel<ITask>, IHistoryBaseModel, ICommentedHistoryModel, ITaskHistoryBaseModel
{
	public IList<PropertyMetadata> ChangedProperties { get; set; }

	public ITask OldEntity { get; set; }

	public ITask NewEntity { get; set; }

	public IComment Comment { get; set; }

	public List<Guid> BaseProperties => TaskActionHelper.BaseProperties();

	public ChangeControlTaskHistoryModel([NotNull] EntityActionEventArgs originalEvent, string actionTheme)
		: base(originalEvent, actionTheme)
	{
	}
}
