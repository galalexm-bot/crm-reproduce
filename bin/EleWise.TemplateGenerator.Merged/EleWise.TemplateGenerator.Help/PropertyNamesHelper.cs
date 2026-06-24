using System.Linq;

namespace EleWise.TemplateGenerator.Helpers;

internal static class PropertyNamesHelper
{
	public static string[] GetPropertyNames(string name)
	{
		return (from s in name.Split(".".ToCharArray())
			select s.Trim()).ToArray();
	}
}
