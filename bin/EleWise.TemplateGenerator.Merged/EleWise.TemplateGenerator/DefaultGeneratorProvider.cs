using EleWise.TemplateGenerator.DataSources;
using EleWise.TemplateGenerator.Expressions;
using EleWise.TemplateGenerator.Formats;
using EleWise.TemplateGenerator.Functions;
using EleWise.TemplateGenerator.Localizations;

namespace EleWise.TemplateGenerator;

public class DefaultGeneratorProvider : IGeneratorProvider
{
	public GeneratorLocalizationsContainer Localization { get; set; }

	public int? TemplateTimeZoneOffset { get; set; }

	public DefaultGeneratorProvider()
	{
		Localization = new GeneratorLocalizationsContainer();
		Localization.Add(new GeneratorLocalization_EN());
		Localization.Add(new GeneratorLocalization_RU());
	}

	public virtual IGeneratorDataSource ConvertObjectToDataSource(object dataSourceObject)
	{
		return new DefaultObjectGeneratorDataSource(dataSourceObject);
	}

	public virtual IGeneratorGlobalDataSource ConvertObjectToGlobalDataSource(object dataSourceObject)
	{
		return new DefaultObjectGeneratorGlobalDataSource(dataSourceObject);
	}

	public virtual IGeneratorExpressionEvaluator CreateExpressionEvaluator(GenerationContext context)
	{
		return new GeneratorExpressionEvaluator(context);
	}

	public virtual IGeneratorFunctionEvaluator CreateFunctionEvaluator(GenerationContext context)
	{
		return new GeneratorFunctionEvaluator(context);
	}

	public virtual IGeneratorFormatProvider CreateFormatProvider(GenerationContext context)
	{
		return new GeneratorFormatProvider(context);
	}
}
