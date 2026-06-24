using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Tasks.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Extensions;

public static class QuestionExtensions
{
	public const string QUESTIONS = "Question/";

	public static MvcHtmlString AddQuestionPopup(this HtmlHelper html, QuestionModel model)
	{
		using (IEnumerator<ITaskActionRenderer> enumerator = (from e in ComponentManager.Current.GetExtensionPoints<ITaskActionRenderer>()
			where e.CanRender(model)
			select e).GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				return enumerator.Current.Render(html, model);
			}
		}
		return PartialExtensions.Partial(html, "Question/PopupQuestionEditor", (object)model);
	}

	public static MvcHtmlString Question(this HtmlHelper html, IQuestion model)
	{
		return PartialExtensions.Partial(html, "Question/View", (object)model);
	}

	public static MvcHtmlString AnswerPopup(this HtmlHelper html, AnswerModel model)
	{
		return PartialExtensions.Partial(html, "Question/PopupAnswerEditor", (object)model);
	}

	public static MvcHtmlString QuestionTableRow(this HtmlHelper html, IQuestion model)
	{
		return PartialExtensions.Partial(html, "Question/TableViewRow", (object)model);
	}

	public static MvcHtmlString QuestionsTable(this HtmlHelper html, List<IQuestion> model, string redirectUrl = null)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		ViewDataDictionary val = new ViewDataDictionary(html.get_ViewData());
		val.Add("redirectUrl", (object)redirectUrl);
		ViewDataDictionary val2 = val;
		return PartialExtensions.Partial(html, "Question/QuestionsTable", (object)model, val2);
	}

	public static MvcHtmlString AnswerTableRow(this HtmlHelper html, IAnswer model)
	{
		return PartialExtensions.Partial(html, "Question/AnswerTableViewRow", (object)model);
	}

	public static bool IsAnswerer(this HtmlHelper html, IQuestion model)
	{
		return QuestionManager.Instance.IsAnswerer(model);
	}

	public static bool IsAuthor(this HtmlHelper html, IQuestion model)
	{
		return QuestionManager.Instance.IsAuthor(model);
	}
}
