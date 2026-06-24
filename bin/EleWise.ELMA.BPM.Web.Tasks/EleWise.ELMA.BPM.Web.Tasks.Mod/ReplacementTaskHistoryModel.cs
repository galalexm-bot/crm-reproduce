using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class ReplacementTaskHistoryModel : HistoryBaseModel, ICommentedHistoryModel, IHistoryBaseModel, IAttachedHistoryModel, IEditedHistoryModel<IEntity>, ITaskHistoryBaseModel
{
	public IComment Comment { get; set; }

	public ICollection<IAttachment> Attachments { get; set; }

	public IEntity OldEntity { get; set; }

	public IEntity NewEntity { get; set; }

	public IList<PropertyMetadata> ChangedProperties { get; set; }

	public List<Guid> Exceptions { get; set; }

	public IReplacementTask ReplacementTask { get; set; }

	public IUser Executor { get; set; }

	public IUser ExecutorReplaced { get; set; }

	public ReplacementTaskHistoryModel([NotNull] EntityActionEventArgs originalEvent)
		: base(originalEvent, SR.T("Переназначение по замещению"))
	{
	}
}
