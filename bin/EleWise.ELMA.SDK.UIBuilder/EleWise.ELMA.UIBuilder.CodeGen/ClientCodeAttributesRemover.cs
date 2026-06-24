using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace EleWise.ELMA.UIBuilder.CodeGeneration;

internal class ClientCodeAttributesRemover : CSharpSyntaxRewriter
{
	private static SyntaxList<AttributeListSyntax> emptyAttrList;

	private const string ModuleAttributeName = "Module";

	private const string BridgeNamespaceName = "Bridge";

	public ClientCodeAttributesRemover()
		: base(true)
	{
	}

	public override SyntaxNode VisitClassDeclaration(ClassDeclarationSyntax node)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		BaseListSyntax baseList = ((BaseTypeDeclarationSyntax)node).get_BaseList();
		if (baseList == null || !((IEnumerable<BaseTypeSyntax>)(object)baseList.get_Types()).Any((BaseTypeSyntax t) => ((object)t.get_Type()).ToString().EndsWith("IDataClass")))
		{
			return ((CSharpSyntaxRewriter)this).VisitClassDeclaration(node);
		}
		ClassDeclarationSyntax val = node.WithAttributeLists(emptyAttrList);
		return ((CSharpSyntaxRewriter)this).VisitClassDeclaration(val);
	}

	public override SyntaxNode VisitPropertyDeclaration(PropertyDeclarationSyntax node)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		PropertyDeclarationSyntax val = node.WithAttributeLists(emptyAttrList);
		return ((CSharpSyntaxRewriter)this).VisitPropertyDeclaration(val);
	}

	public override SyntaxNode VisitFieldDeclaration(FieldDeclarationSyntax node)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		FieldDeclarationSyntax val = node.WithAttributeLists(emptyAttrList);
		return ((CSharpSyntaxRewriter)this).VisitFieldDeclaration(val);
	}

	public override SyntaxNode VisitAttribute(AttributeSyntax node)
	{
		if (AttributeNameMatches(node, "Module"))
		{
			return null;
		}
		return ((CSharpSyntaxRewriter)this).VisitAttribute(node);
	}

	public override SyntaxNode VisitUsingDirective(UsingDirectiveSyntax node)
	{
		if (((object)node.get_Name()).ToString().StartsWith("Bridge"))
		{
			return null;
		}
		return ((CSharpSyntaxRewriter)this).VisitUsingDirective(node);
	}

	private static bool AttributeNameMatches(AttributeSyntax attribute, string attributeName)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		SyntaxToken identifier = GetSimpleNameOfAttribute(attribute).get_Identifier();
		return ((SyntaxToken)(ref identifier)).get_Text().StartsWith(attributeName);
	}

	private static SimpleNameSyntax GetSimpleNameOfAttribute(AttributeSyntax node)
	{
		NameSyntax name = node.get_Name();
		object obj = ((name is IdentifierNameSyntax) ? name : null);
		NameSyntax name2 = node.get_Name();
		QualifiedNameSyntax val = (QualifiedNameSyntax)(object)((name2 is QualifiedNameSyntax) ? name2 : null);
		if (obj == null)
		{
			obj = ((val != null) ? val.get_Right() : null) ?? ((AliasQualifiedNameSyntax)/*isinst with value type is only supported in some contexts*/).get_Name();
		}
		return (SimpleNameSyntax)obj;
	}
}
