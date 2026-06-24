using System;
using EleWise.ELMA.Model.Types.Settings;

namespace EleWise.ELMA.Messages.Models;

[Serializable]
public class FeedMessagesSettings
{
	private int commentsCount;

	private int messagesCount;

	public bool PostCommentEnterKey { get; set; }

	[Int32Settings(MinValue = 0, MaxValue = 50, DefaultValueStr = "10")]
	public int CommentsCount
	{
		get
		{
			return commentsCount;
		}
		set
		{
			if (value < 0)
			{
				value = 0;
			}
			if (value > 50)
			{
				value = 50;
			}
			commentsCount = value;
		}
	}

	[Int32Settings(MinValue = 5, MaxValue = 50, DefaultValueStr = "10")]
	public int MessagesCount
	{
		get
		{
			return messagesCount;
		}
		set
		{
			if (value < 5)
			{
				value = 5;
			}
			if (value > 50)
			{
				value = 50;
			}
			messagesCount = value;
		}
	}

	public FeedMessagesSettings()
	{
		PostCommentEnterKey = true;
		CommentsCount = 10;
		MessagesCount = 10;
	}
}
