using System;
using EleWise.ELMA.Web.Components;

namespace EleWise.ELMA.Messages.Web.Components.Feed;

public static class FeedContentHelper
{
	[Obsolete("Нужно использовать метод из серверного модуля EleWise.ELMA.Web.Components.FormattingHelper.DateToString()")]
	public static string DateToString(DateTime runtimeDateTime)
	{
		return FormattingHelper.DateToString(runtimeDateTime);
	}
}
