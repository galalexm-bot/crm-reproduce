using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Tasks.Components;

namespace EleWise.ELMA.Tasks.Models;

public class StatusChangeWorkLogItemHistoryModel : HistoryBaseModel, ICommentedHistoryModel, IHistoryBaseModel, IEditedHistoryModel<IWorkLogItem>, ITaskHistoryBaseModel
{
	public IList<PropertyMetadata> ChangedProperties { get; set; }

	public IWorkLogItem OldEntity { get; set; }

	public IWorkLogItem NewEntity { get; set; }

	public List<Guid> BaseProperties => WorkLogItemActionHelper.BaseProperties();

	public IComment Comment { get; set; }

	public StatusChangeWorkLogItemHistoryModel([NotNull] EntityActionEventArgs originalEvent, string actionTheme)
		: base(originalEvent, actionTheme)
	{
	}
}
