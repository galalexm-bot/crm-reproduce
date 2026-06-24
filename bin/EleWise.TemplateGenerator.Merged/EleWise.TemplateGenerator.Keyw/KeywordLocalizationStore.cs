using System.Collections.Generic;
using EleWise.TemplateGenerator.Localizations;

namespace EleWise.TemplateGenerator.Keywords;

public class KeywordLocalizationStore
{
	private Dictionary<string, KeywordType> words = new Dictionary<string, KeywordType>();

	internal KeywordLocalizationStore(IEnumerable<IGeneratorLocalization> localizations)
	{
		if (localizations == null)
		{
			return;
		}
		foreach (IGeneratorLocalization localization in localizations)
		{
			foreach (KeyValuePair<string, KeywordType> keyword in localization.Keywords)
			{
				words[keyword.Key.ToUpper()] = keyword.Value;
			}
		}
	}

	public KeywordType? CheckWord(string word)
	{
		if (words.TryGetValue(word.ToUpper(), out var value))
		{
			return value;
		}
		return null;
	}
}
