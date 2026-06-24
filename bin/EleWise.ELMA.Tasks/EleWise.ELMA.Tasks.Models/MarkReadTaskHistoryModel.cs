using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;

namespace EleWise.ELMA.Tasks.Models;

public class MarkReadTaskHistoryModel : HistoryBaseModel, ITaskHistoryBaseModel, IHistoryBaseModel
{
	public MarkReadTaskHistoryModel([NotNull] EntityActionEventArgs originalEvent, string actionTheme)
		: base(originalEvent, actionTheme)
	{
	}
}
