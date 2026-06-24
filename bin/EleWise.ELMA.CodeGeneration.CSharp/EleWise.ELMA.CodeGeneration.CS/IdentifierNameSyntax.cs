namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class IdentifierNameSyntax : ExpressionSyntax
{
	protected readonly string _identifier;

	public IdentifierNameSyntax(IdentifierNameSyntax identifier)
		: base(ExpressionSyntaxPriority.Identifier)
	{
		_identifier = identifier._identifier;
	}

	public IdentifierNameSyntax(string identifier, bool escape = true)
		: base(ExpressionSyntaxPriority.Identifier)
	{
		_identifier = (escape ? EscapeIdentifier(identifier) : identifier);
	}

	internal override void GenerateInternal()
	{
		GenerationContext.Current.Write(_identifier);
	}

	public override string ToString()
	{
		return _identifier;
	}

	public static string EscapeIdentifier(string identifier)
	{
		identifier = identifier.Trim();
		int num = identifier.IndexOf('\0');
		if (num >= 0)
		{
			identifier = identifier.Substring(0, num);
		}
		if (!IsKeyword(identifier))
		{
			return identifier;
		}
		return "@" + identifier;
	}

	private static bool IsKeyword(string text)
	{
		switch (text)
		{
		case "bool":
		case "byte":
		case "sbyte":
		case "short":
		case "ushort":
		case "int":
		case "uint":
		case "long":
		case "ulong":
		case "double":
		case "float":
		case "decimal":
		case "string":
		case "char":
		case "void":
		case "object":
		case "typeof":
		case "sizeof":
		case "null":
		case "true":
		case "false":
		case "if":
		case "else":
		case "while":
		case "for":
		case "foreach":
		case "do":
		case "switch":
		case "case":
		case "default":
		case "lock":
		case "try":
		case "throw":
		case "catch":
		case "finally":
		case "goto":
		case "break":
		case "continue":
		case "return":
		case "public":
		case "private":
		case "internal":
		case "protected":
		case "static":
		case "readonly":
		case "sealed":
		case "const":
		case "fixed":
		case "stackalloc":
		case "volatile":
		case "new":
		case "override":
		case "abstract":
		case "virtual":
		case "event":
		case "extern":
		case "ref":
		case "out":
		case "in":
		case "is":
		case "as":
		case "params":
		case "__arglist":
		case "__makeref":
		case "__reftype":
		case "__refvalue":
		case "this":
		case "base":
		case "namespace":
		case "using":
		case "class":
		case "struct":
		case "interface":
		case "enum":
		case "delegate":
		case "checked":
		case "unchecked":
		case "unsafe":
		case "operator":
		case "implicit":
		case "explicit":
			return true;
		default:
			return false;
		}
	}
}
