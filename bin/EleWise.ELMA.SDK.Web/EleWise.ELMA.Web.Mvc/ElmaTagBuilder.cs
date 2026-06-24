using System.Text.RegularExpressions;

namespace EleWise.ELMA.Web.Mvc;

public static class ElmaTagBuilder
{
	public static string CreateSanitizedId(string originalId, string invalidCharReplacement = "_")
	{
		return Regex.Replace(originalId, "[^A-Za-zА-Яа-я0-9:_-]", "_");
	}

	public static string CreateValidJsFunctionName(string originalName)
	{
		return Regex.Replace(originalName, "[^A-Za-zА-Яа-я0-9_$]", "_");
	}
}
