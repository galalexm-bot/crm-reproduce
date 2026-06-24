using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Components;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.BPM.Web.Calendar.Components;

internal class CalendarCommentHistoryPartMerge : CommentAttachmentHistoryPartMerge
{
	protected override bool CheckEntity(HtmlHelper html, IEntity entity)
	{
		return entity is ICalendarEvent;
	}
}
