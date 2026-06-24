using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;

namespace EleWise.ELMA.Tasks.Models;

public class QuestionTaskHistoryModel : HistoryBaseModel, IQuestionedHistoryModel, IHistoryBaseModel, ITaskHistoryBaseModel
{
	public IQuestion Question { get; set; }

	public QuestionTaskHistoryModel([NotNull] EntityActionEventArgs originalEvent, string actionTheme)
		: base(originalEvent, actionTheme)
	{
	}
}
