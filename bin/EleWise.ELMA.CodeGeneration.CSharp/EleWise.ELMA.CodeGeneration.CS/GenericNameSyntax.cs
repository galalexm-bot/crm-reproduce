using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class GenericNameSyntax : IdentifierNameSyntax
{
	private readonly TypeSyntax[] _typeArguments;

	public string Identifier => _identifier;

	public TypeSyntax[] TypeArguments => _typeArguments;

	public GenericNameSyntax(IdentifierNameSyntax identifier, IEnumerable<TypeSyntax> typeArguments)
		: base(identifier)
	{
		_typeArguments = typeArguments.ToArrayOrEmpty();
	}

	public GenericNameSyntax(string identifier, IEnumerable<TypeSyntax> typeArguments, bool escape = true)
		: base(identifier, escape)
	{
		_typeArguments = typeArguments.ToArrayOrEmpty();
	}

	internal override void GenerateInternal()
	{
		GenerationContext.Current.Write(_identifier).If(_typeArguments.Length != 0, delegate(GenerationContext _)
		{
			_.Write("<").WriteComaSeparated(_typeArguments).Write(">");
		});
	}

	public override string ToString()
	{
		return _identifier + ((_typeArguments.Length != 0) ? ("<" + string.Join(", ", _typeArguments.AsEnumerable()) + ">") : null);
	}
}
