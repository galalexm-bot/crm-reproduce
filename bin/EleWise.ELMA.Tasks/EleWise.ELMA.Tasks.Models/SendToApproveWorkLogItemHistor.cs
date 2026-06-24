using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Components;

namespace EleWise.ELMA.Tasks.Models;

public class SendToApproveWorkLogItemHistoryModel : HistoryBaseModel, IEditedHistoryModel<IWorkLogItem>, IHistoryBaseModel, ITaskHistoryBaseModel
{
	public IList<PropertyMetadata> ChangedProperties { get; set; }

	public IWorkLogItem OldEntity { get; set; }

	public IWorkLogItem NewEntity { get; set; }

	public List<Guid> BaseProperties
	{
		get
		{
			List<Guid> list = WorkLogItemActionHelper.BaseProperties();
			list.Add(InterfaceActivator.PropertyUid((IWorkLogItem m) => m.Status));
			return list;
		}
	}

	public SendToApproveWorkLogItemHistoryModel([NotNull] EntityActionEventArgs originalEvent, string actionTheme)
		: base(originalEvent, actionTheme)
	{
	}
}
