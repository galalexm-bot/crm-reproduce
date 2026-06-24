using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;

namespace EleWise.ELMA.CRM.Models;

public class CommentMarketingBaseHistoryModel : HistoryBaseModel, ICommentedHistoryModel, IHistoryBaseModel, IMarketingBaseHistoryBaseModel, IMultiCommentHistoryModel
{
	public IComment Comment { get; set; }

	public ICollection<IComment> Comments { get; set; }

	public CommentMarketingBaseHistoryModel([NotNull] EntityActionEventArgs originalEvent, string actionTheme)
		: base(originalEvent, actionTheme)
	{
	}
}
