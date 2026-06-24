using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Audit;
using EleWise.ELMA.Tasks.Components;

namespace EleWise.ELMA.Tasks.Models;

public class ApprovalWorkLogItemHistoryModel : HistoryBaseModel, ICommentedHistoryModel, IHistoryBaseModel, IEditedHistoryModel<IWorkLogItem>, ITaskHistoryBaseModel
{
	public IComment Comment { get; set; }

	public IList<PropertyMetadata> ChangedProperties { get; set; }

	public IWorkLogItem OldEntity { get; set; }

	public IWorkLogItem NewEntity { get; set; }

	public List<WorkLogItemInfo> Info { get; set; }

	public List<Guid> BaseProperties
	{
		get
		{
			List<Guid> list = WorkLogItemActionHelper.BaseProperties();
			list.Add(InterfaceActivator.PropertyUid((IWorkLogItem m) => m.Status));
			return list;
		}
	}

	public ApprovalWorkLogItemHistoryModel([NotNull] EntityActionEventArgs originalEvent, string actionTheme)
		: base(originalEvent, actionTheme)
	{
		Info = (originalEvent as WorkLogItemActionEventArgs)?.Infos.ToList() ?? new List<WorkLogItemInfo>();
	}
}
