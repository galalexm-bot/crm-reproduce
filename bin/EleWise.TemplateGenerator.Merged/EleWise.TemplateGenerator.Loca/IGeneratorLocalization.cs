using System.Collections.Generic;
using EleWise.TemplateGenerator.Keywords;

namespace EleWise.TemplateGenerator.Localizations;

public interface IGeneratorLocalization
{
	Dictionary<string, KeywordType> Keywords { get; }

	Dictionary<string, string> Functions { get; }
}
