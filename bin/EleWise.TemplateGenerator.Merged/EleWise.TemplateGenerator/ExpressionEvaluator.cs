using System;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using EleWise.TemplateGenerator.Adl;
using EleWise.TemplateGenerator.Adl.Tree;
using EleWise.TemplateGenerator.DataSources;

namespace EleWise.TemplateGenerator;

public class ExpressionEvaluator
{
	private Expression expression;

	public IGeneratorProvider Provider { get; set; }

	public Expression Expression => expression;

	public ExpressionEvaluator(string expressionText, IGeneratorProvider provider = null)
	{
		Provider = provider ?? GlobalGeneratorSettings.DefaultProvider;
		expression = Parse(expressionText);
	}

	public FormatedValue Evaluate(object dataSourceObject)
	{
		return Evaluate(Provider.ConvertObjectToDataSource(dataSourceObject));
	}

	public FormatedValue Evaluate(IGeneratorDataSource dataSource)
	{
		if (Provider == null)
		{
			throw new NullReferenceException("Provider == null");
		}
		if (Expression == null)
		{
			throw new NullReferenceException("Expression == null");
		}
		GenerationContext generationContext = new GenerationContext();
		generationContext.DataSource = dataSource;
		generationContext.Localization = Provider.Localization;
		generationContext.ExpressionEvaluator = Provider.CreateExpressionEvaluator(generationContext);
		generationContext.FunctionEvaluator = Provider.CreateFunctionEvaluator(generationContext);
		generationContext.FormatProvider = Provider.CreateFormatProvider(generationContext);
		return generationContext.ExpressionEvaluator.Evaluate(Expression);
	}

	protected virtual Expression Parse(string expressionText)
	{
		if (Provider == null)
		{
			throw new NullReferenceException("Provider == null");
		}
		CommonTokenStream commonTokenStream = new CommonTokenStream(new AdlLexer(new ANTLRStringStream(expressionText))
		{
			IsProgramMode = true,
			KeywordLocalizationStore = Provider.Localization.KeywordLocalizationStore
		});
		return new AdlWalker(new CommonTreeNodeStream(new AdlParser(commonTokenStream).detachedExpression().Tree)
		{
			TokenStream = commonTokenStream
		}).detachedExpression().Expression;
	}
}
