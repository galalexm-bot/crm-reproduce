using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Common.Models;

namespace EleWise.ELMA.BPM.Web.Common.Extensions;

public static class ReminderExtensions
{
	public static MvcHtmlString Reminder(this HtmlHelper html, ReminderModel model)
	{
		if (model != null && model.OriginalDate.HasValue)
		{
			return PartialExtensions.Partial(html, "Reminder", (object)model);
		}
		return MvcHtmlString.Empty;
	}
}
