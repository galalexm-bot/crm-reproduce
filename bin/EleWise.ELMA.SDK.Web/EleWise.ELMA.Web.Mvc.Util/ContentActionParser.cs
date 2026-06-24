using System.Collections.Generic;
using EleWise.ELMA.Web.Mvc.Extensions;

namespace EleWise.ELMA.Web.Mvc.Util;

public static class ContentActionParser
{
	public static Dictionary<string, string> Parser(string contentAction)
	{
		return contentAction.FromJson<Dictionary<string, string>>();
	}
}
