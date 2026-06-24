namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class ArrayTypeExpression : TypeSyntax
{
	public ArrayTypeExpression(TypeSyntax elementType)
		: base(elementType)
	{
	}

	internal override void GenerateInternal()
	{
		base.GenerateInternal();
		GenerationContext.Current.Write("[]");
	}

	public override string ToString()
	{
		return base.ToString() + "[]";
	}
}
