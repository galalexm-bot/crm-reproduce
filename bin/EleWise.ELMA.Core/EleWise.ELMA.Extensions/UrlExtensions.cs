using System;
using Bridge.Html5;

namespace EleWise.ELMA.Extensions;

public static class UrlExtensions
{
	public static bool IsAbsolute(this Uri uri)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		return new RegExp("^(?:[a-z]+:)?//", "i").Test(((object)uri).ToString());
	}
}
