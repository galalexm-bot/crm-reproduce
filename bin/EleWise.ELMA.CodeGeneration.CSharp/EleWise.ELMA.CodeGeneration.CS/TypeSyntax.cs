using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.CodeGeneration.CSharp.Nodes;

public class TypeSyntax : GenericNameSyntax
{
	public TypeSyntax(string identifier, IEnumerable<TypeSyntax> typeArguments)
		: base(identifier, typeArguments, escape: false)
	{
	}

	public TypeSyntax(IdentifierNameSyntax identifier)
		: base(identifier, (identifier as GenericNameSyntax)?.TypeArguments)
	{
	}

	public static TypeSyntax ParseTypeName(string typeName)
	{
		switch (typeName)
		{
		case "System.Object":
			typeName = "object";
			break;
		case "System.Boolean":
			typeName = "bool";
			break;
		case "System.Char":
			typeName = "char";
			break;
		case "System.SByte":
			typeName = "sbyte";
			break;
		case "System.Byte":
			typeName = "byte";
			break;
		case "System.Int16":
			typeName = "short";
			break;
		case "System.UInt16":
			typeName = "ushort";
			break;
		case "System.Int32":
			typeName = "int";
			break;
		case "System.UInt32":
			typeName = "uint";
			break;
		case "System.Int64":
			typeName = "long";
			break;
		case "System.UInt64":
			typeName = "ulong";
			break;
		case "System.Decimal":
			typeName = "decimal";
			break;
		case "System.Single":
			typeName = "float";
			break;
		case "System.Double":
			typeName = "double";
			break;
		case "System.String":
			typeName = "string";
			break;
		}
		int num = typeName.IndexOf('<');
		if (num >= 0)
		{
			return new TypeSyntax(typeName.Remove(num), from t in typeName.Substring(num + 1, typeName.LastIndexOf('>') - num - 1).Split(',')
				select ParseTypeName(t));
		}
		return new TypeSyntax(typeName, null);
	}
}
