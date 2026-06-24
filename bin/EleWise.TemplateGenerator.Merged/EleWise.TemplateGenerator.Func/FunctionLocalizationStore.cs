using System.Collections.Generic;
using EleWise.TemplateGenerator.Localizations;

namespace EleWise.TemplateGenerator.Functions;

public class FunctionLocalizationStore
{
	private Dictionary<string, string> names = new Dictionary<string, string>();

	internal FunctionLocalizationStore(IEnumerable<IGeneratorLocalization> localizations)
	{
		if (localizations == null)
		{
			return;
		}
		foreach (IGeneratorLocalization localization in localizations)
		{
			foreach (KeyValuePair<string, string> function in localization.Functions)
			{
				names[function.Key.ToUpper()] = function.Value;
			}
		}
	}

	public string CheckName(string name)
	{
		if (names.TryGetValue(name.ToUpper(), out var value))
		{
			return value;
		}
		return null;
	}
}
