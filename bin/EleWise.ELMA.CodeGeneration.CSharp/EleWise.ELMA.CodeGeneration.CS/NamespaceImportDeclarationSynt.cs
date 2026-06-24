namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class NamespaceImportDeclarationSyntax : MemberSyntax
{
	private readonly string _name;

	public NamespaceImportDeclarationSyntax(string name)
	{
		_name = IdentifierNameSyntax.EscapeIdentifier(name);
	}

	protected override void InternalGenerate()
	{
		GenerationContext.Current.Write("using ").Write(_name).WriteLine(";");
	}
}
