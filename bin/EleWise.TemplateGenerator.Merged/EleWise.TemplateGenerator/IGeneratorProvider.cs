using EleWise.TemplateGenerator.DataSources;
using EleWise.TemplateGenerator.Expressions;
using EleWise.TemplateGenerator.Formats;
using EleWise.TemplateGenerator.Functions;
using EleWise.TemplateGenerator.Localizations;

namespace EleWise.TemplateGenerator;

public interface IGeneratorProvider
{
	GeneratorLocalizationsContainer Localization { get; }

	int? TemplateTimeZoneOffset { get; set; }

	IGeneratorDataSource ConvertObjectToDataSource(object dataSourceObject);

	IGeneratorGlobalDataSource ConvertObjectToGlobalDataSource(object dataSourceObject);

	IGeneratorExpressionEvaluator CreateExpressionEvaluator(GenerationContext context);

	IGeneratorFunctionEvaluator CreateFunctionEvaluator(GenerationContext context);

	IGeneratorFormatProvider CreateFormatProvider(GenerationContext context);
}
