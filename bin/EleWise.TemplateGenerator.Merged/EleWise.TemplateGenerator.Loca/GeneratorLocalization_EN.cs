using System.Collections.Generic;
using EleWise.TemplateGenerator.Keywords;

namespace EleWise.TemplateGenerator.Localizations;

public class GeneratorLocalization_EN : IGeneratorLocalization
{
	public Dictionary<string, KeywordType> Keywords => new Dictionary<string, KeywordType>
	{
		{
			"AND",
			KeywordType.And
		},
		{
			"OR",
			KeywordType.Or
		},
		{
			"IF",
			KeywordType.If
		},
		{
			"THEN",
			KeywordType.Then
		},
		{
			"ELSE",
			KeywordType.Else
		},
		{
			"END",
			KeywordType.End
		},
		{
			"FOR",
			KeywordType.Block
		},
		{
			"TRUE",
			KeywordType.True
		},
		{
			"FALSE",
			KeywordType.False
		},
		{
			"IN",
			KeywordType.In
		},
		{
			"NULL",
			KeywordType.Null
		}
	};

	public Dictionary<string, string> Functions => new Dictionary<string, string>();
}
