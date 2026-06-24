using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Models;

namespace EleWise.ELMA.BPM.Web.Common.Extensions;

public static class CommentExtensions
{
	public static MvcHtmlString AddCommentPopup(this HtmlHelper html, CommentWithAttachments commentWithAttachmets)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_002e: Expected O, but got Unknown
		ViewDataDictionary val = new ViewDataDictionary(html.get_ViewData());
		TemplateInfo val2 = new TemplateInfo();
		val2.set_HtmlFieldPrefix(commentWithAttachmets.HtmlPrefix);
		val.set_TemplateInfo(val2);
		return PartialExtensions.Partial(html, "Comment/PopupCommentEditor", (object)commentWithAttachmets, val);
	}

	public static MvcHtmlString AddFastCommentForm(this HtmlHelper html, CommentWithAttachments commentWithAttachmets)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_005c: Expected O, but got Unknown
		ViewDataDictionary viewData = html.get_ViewData();
		viewData.set_Item("CreatorRequest", (object)true.ToString());
		viewData.set_Item("CreatorPrefix", (object)commentWithAttachmets.HtmlPrefix);
		commentWithAttachmets.UseFastCommentForm = true;
		ViewDataDictionary val = new ViewDataDictionary(viewData);
		TemplateInfo val2 = new TemplateInfo();
		val2.set_HtmlFieldPrefix(commentWithAttachmets.HtmlPrefix);
		val.set_TemplateInfo(val2);
		return PartialExtensions.Partial(html, "Comment/FastCommentEditor", (object)commentWithAttachmets, val);
	}

	public static MvcHtmlString CommentList(this HtmlHelper html, IEnumerable<IComment> comments)
	{
		return PartialExtensions.Partial(html, "Comment/List", (object)comments);
	}

	public static string PreformattedText(this HtmlHelper helper, string text)
	{
		if (string.IsNullOrEmpty(text))
		{
			return "";
		}
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		do
		{
			int num2 = text.IndexOf("  ", num);
			int num3;
			if (num2 != -1)
			{
				stringBuilder.Append(ReplaceBreaks(helper.Encode(text.Substring(num, num2 - num))));
				stringBuilder.Append(" &nbsp;&nbsp;");
				int i;
				for (i = 2; num2 + i < text.Length && text[num2 + i] == ' '; i++)
				{
					stringBuilder.Append("&nbsp;");
				}
				num3 = num2 + i;
			}
			else
			{
				stringBuilder.Append(ReplaceBreaks(helper.Encode(text.Substring(num))));
				num3 = text.Length;
			}
			num = num3;
		}
		while (num < text.Length);
		return Regex.Replace(stringBuilder.ToString(), "(((http[s]?|ftp|gopher|telnet|file|notes|ms-help):\\//)([^\\s]*))", "<a href=\"$&\" target=\"new\" >$&</a>");
	}

	private static string ReplaceBreaks(string t)
	{
		return t.Replace("\n", "\n<br/>");
	}
}
