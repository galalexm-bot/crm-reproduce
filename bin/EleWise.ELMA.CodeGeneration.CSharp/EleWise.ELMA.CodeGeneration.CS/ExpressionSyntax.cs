namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public abstract class ExpressionSyntax : SyntaxNode
{
	internal readonly ExpressionSyntaxPriority _priority;

	internal ExpressionSyntax(ExpressionSyntaxPriority priority)
	{
		_priority = priority;
	}

	internal abstract void GenerateInternal();

	internal override void Generate()
	{
		bool condition = _priority.NeedBrackets((GenerationContext.Current.ParentNode as ExpressionSyntax)?._priority);
		GenerationContext.Current.If(condition, delegate(GenerationContext _)
		{
			_.Write("(");
		}).Call(delegate
		{
			GenerateInternal();
		}).If(condition, delegate(GenerationContext _)
		{
			_.Write(")");
		});
	}
}
