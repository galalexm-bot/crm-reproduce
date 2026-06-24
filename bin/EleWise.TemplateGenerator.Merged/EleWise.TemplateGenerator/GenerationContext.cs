using System.Collections.Generic;
using EleWise.TemplateGenerator.DataSources;
using EleWise.TemplateGenerator.Expressions;
using EleWise.TemplateGenerator.Formats;
using EleWise.TemplateGenerator.Functions;
using EleWise.TemplateGenerator.Localizations;

namespace EleWise.TemplateGenerator;

public class GenerationContext
{
	public IGeneratorDataSource DataSource { get; set; }

	public IGeneratorGlobalDataSource GlobalDataSource { get; set; }

	public IGeneratorExpressionEvaluator ExpressionEvaluator { get; set; }

	public IGeneratorFunctionEvaluator FunctionEvaluator { get; set; }

	public IGeneratorFormatProvider FormatProvider { get; set; }

	public GeneratorLocalizationsContainer Localization { get; set; }

	public Dictionary<string, object> ExtendedProperties { get; set; }

	public GenerationContext()
	{
		ExtendedProperties = new Dictionary<string, object>();
	}
}
