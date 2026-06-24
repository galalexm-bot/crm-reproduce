using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;

namespace EleWise.ELMA.Tasks.Models;

public class CommentTaskHistoryModel : HistoryBaseModel, ICommentedHistoryModel, IHistoryBaseModel, IAttachedHistoryModel, ITaskHistoryBaseModel, IMultiCommentHistoryModel
{
	public IComment Comment { get; set; }

	public ICollection<IAttachment> Attachments { get; set; }

	public ICollection<IComment> Comments { get; set; }

	public CommentTaskHistoryModel([NotNull] EntityActionEventArgs originalEvent, string actionTheme)
		: base(originalEvent, actionTheme)
	{
	}
}
