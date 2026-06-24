namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class SnippetExpressionSyntax : ExpressionSyntax
{
	private readonly string _text;

	public SnippetExpressionSyntax(string text)
		: base(ExpressionSyntaxPriority.SnippetExpression)
	{
		_text = text;
	}

	internal override void GenerateInternal()
	{
		GenerationContext.Current.Write(_text);
	}
}
