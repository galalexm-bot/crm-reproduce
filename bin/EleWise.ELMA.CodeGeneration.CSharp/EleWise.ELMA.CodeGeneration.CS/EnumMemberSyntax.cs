namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class EnumMemberSyntax : MemberSyntax
{
	private readonly string _name;

	private readonly ExpressionSyntax _expression;

	public EnumMemberSyntax(string name, ExpressionSyntax expression)
	{
		_name = IdentifierNameSyntax.EscapeIdentifier(name);
		_expression = expression;
	}

	protected override void InternalGenerate()
	{
		GenerationContext.Current.Write(_name).If(_expression != null, delegate(GenerationContext _)
		{
			_.Write(" = ").Write(_expression);
		});
	}
}
