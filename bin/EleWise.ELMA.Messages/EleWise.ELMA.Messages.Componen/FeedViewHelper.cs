using System;
using EleWise.ELMA.Web.Components;

namespace EleWise.ELMA.Messages.Components.Feed;

public static class FeedViewHelper
{
	[Obsolete("Метод устарел. Используйте EleWise.ELMA.Web.Components.FormattingHelper.DateToString(runtimeDateTime)")]
	public static string DateToString(DateTime runtimeDateTime)
	{
		return FormattingHelper.DateToString(runtimeDateTime);
	}
}
