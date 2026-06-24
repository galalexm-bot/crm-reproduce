using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Tasks.Components;

namespace EleWise.ELMA.Tasks.Models;

public class RedirectTaskHistoryModel : HistoryBaseModel, ICommentedHistoryModel, IHistoryBaseModel, IEditedHistoryModel<ITaskBase>, ITaskHistoryBaseModel
{
	public IComment Comment { get; set; }

	public IList<PropertyMetadata> ChangedProperties { get; set; }

	public ITaskBase OldEntity { get; set; }

	public ITaskBase NewEntity { get; set; }

	public List<Guid> BaseProperties => TaskActionHelper.BaseProperties();

	public RedirectTaskHistoryModel([NotNull] EntityActionEventArgs originalEvent, string actionTheme)
		: base(originalEvent, actionTheme)
	{
	}
}
