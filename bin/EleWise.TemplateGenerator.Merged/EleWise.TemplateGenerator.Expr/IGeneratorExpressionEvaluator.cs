using EleWise.TemplateGenerator.Adl.Tree;

namespace EleWise.TemplateGenerator.Expressions;

public interface IGeneratorExpressionEvaluator
{
	FormatedValue Evaluate(Expression expression);
}
