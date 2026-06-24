using System.Collections.Generic;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Integration.History;

public class QuestionCalendarEventHistoryModel : HistoryBaseModel, IQuestionedHistoryModel, IHistoryBaseModel, IAttachedHistoryModel, ICalendarEventHistoryModel
{
	public IQuestion Question { get; set; }

	public ICollection<IAttachment> Attachments { get; set; }

	public QuestionCalendarEventHistoryModel(EntityActionEventArgs originalEvent, string actionTheme)
		: base(originalEvent, actionTheme)
	{
	}
}
