using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Messages.Web.Models;

public class InfoChannelMessageChild
{
	private bool? allowComment;

	public IChannelMessage Message { get; set; }

	public List<IUser> Recipients { get; set; }

	public ICommentActionModel CommentModel { get; set; }

	public InfoChannelMessageParent Parent { get; set; }

	public string URL { get; set; }

	public bool CompactView { get; set; }

	public IUser CreationAuthor { get; set; }

	public DateTime? CreationDate { get; set; }

	public string Subject { get; set; }

	public long Id { get; set; }

	public string FullMessageText { get; set; }

	public string FullMessageHtml { get; set; }

	public string ShortMessageHtml { get; set; }

	public string ShortMessageText { get; set; }

	public bool AllowComment
	{
		get
		{
			if (!allowComment.HasValue)
			{
				allowComment = ObjectId != 0;
			}
			return allowComment.Value;
		}
		set
		{
			allowComment = value;
		}
	}

	public bool AllowEdit { get; set; }

	public bool AllowDelete { get; set; }

	public long ObjectId { get; set; }

	public List<InfoChannelMessageChild> Messages { get; set; }

	public List<object> DiscussionObjects { get; set; }

	public List<IDiscussionObject> DiscussionObjectsOriginal { get; set; }

	public InfoChannelMessageChild()
	{
		CommentModel = InterfaceActivator.Create<ICommentActionModel>();
	}

	public static string ShortCutText(string text, int maxLength = 500, int maxParagraphCount = 5, bool isHtml = false)
	{
		if (string.IsNullOrEmpty(text))
		{
			return text;
		}
		string textOld = text;
		Func<string> func = () => (!(text == textOld)) ? (text + "...") : text;
		if (isHtml)
		{
			text = Regex.Replace(text, "(<br>)|(<br />)|(</p>)", "\n", RegexOptions.IgnoreCase);
			text = Regex.Replace(text, "</tr>", "; ", RegexOptions.IgnoreCase);
			text = Regex.Replace(text, "</td>", ": ", RegexOptions.IgnoreCase);
			text = Regex.Replace(text, "<.*?>", " ");
		}
		text = Regex.Replace(text.Trim(" \r\n\t".ToCharArray()).Replace("\r", ""), "(?=\\n)\\n+", "\n");
		if (string.IsNullOrEmpty(text))
		{
			return func();
		}
		string[] array = text.Split("\n".ToCharArray());
		if (array.Length > maxParagraphCount)
		{
			string[] array2 = new string[maxParagraphCount];
			for (int i = 0; i < maxParagraphCount; i++)
			{
				array2[i] = array[i];
			}
			text = string.Join("\r\n", array2);
		}
		if (text.Length <= maxLength)
		{
			return func();
		}
		text = text.Substring(0, Math.Min(maxLength, text.Length));
		MatchCollection matchCollection = Regex.Matches(text, "\\s|,|\\.|\\:|\\!|\\?|\\;|\\(|\\)|'|\\\"|-|\\+|=");
		if (matchCollection.Count != 0)
		{
			text = text.Substring(0, matchCollection[matchCollection.Count - 1].Index);
		}
		return func();
	}
}
