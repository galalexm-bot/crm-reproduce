using System.Collections.Generic;
using EleWise.TemplateGenerator.Functions;
using EleWise.TemplateGenerator.Keywords;

namespace EleWise.TemplateGenerator.Localizations;

public class GeneratorLocalizationsContainer
{
	private KeywordLocalizationStore keywordLocalizationStore = new KeywordLocalizationStore(null);

	private FunctionLocalizationStore functionLocalizationStore = new FunctionLocalizationStore(null);

	private List<IGeneratorLocalization> localizations = new List<IGeneratorLocalization>();

	public KeywordLocalizationStore KeywordLocalizationStore => keywordLocalizationStore;

	public FunctionLocalizationStore FunctionLocalizationStore => functionLocalizationStore;

	public void Add(IGeneratorLocalization localization)
	{
		localizations.Add(localization);
		keywordLocalizationStore = new KeywordLocalizationStore(localizations);
		functionLocalizationStore = new FunctionLocalizationStore(localizations);
	}
}
