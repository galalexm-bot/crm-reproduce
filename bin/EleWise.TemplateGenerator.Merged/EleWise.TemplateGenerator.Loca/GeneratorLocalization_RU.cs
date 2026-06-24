using System.Collections.Generic;
using EleWise.TemplateGenerator.Keywords;

namespace EleWise.TemplateGenerator.Localizations;

public class GeneratorLocalization_RU : IGeneratorLocalization
{
	public Dictionary<string, KeywordType> Keywords => new Dictionary<string, KeywordType>
	{
		{
			"И",
			KeywordType.And
		},
		{
			"ИЛИ",
			KeywordType.Or
		},
		{
			"ЕСЛИ",
			KeywordType.If
		},
		{
			"ТО",
			KeywordType.Then
		},
		{
			"ИНАЧЕ",
			KeywordType.Else
		},
		{
			"КОНЕЦ",
			KeywordType.End
		},
		{
			"БЛОК",
			KeywordType.Block
		},
		{
			"ИСТИНА",
			KeywordType.True
		},
		{
			"ЛОЖЬ",
			KeywordType.False
		},
		{
			"В",
			KeywordType.In
		},
		{
			"ПУСТО",
			KeywordType.Null
		}
	};

	public Dictionary<string, string> Functions => new Dictionary<string, string>
	{
		{ "Количество", "Count" },
		{ "Индекс", "Index" },
		{ "Изображение", "Image" }
	};
}
