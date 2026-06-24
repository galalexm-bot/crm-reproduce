using System;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Attributes;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace EleWise.ELMA.Orleans.CodeGeneration;

internal static class ActorProxyInterfaceGenerator
{
	internal const string Prefix = "";

	internal const string Suffix = "_Proxy";

	public static TypeDeclarationSyntax Generate(Type actorInterfaceType, Type actorImplementationType)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		TypeInfo typeInfo = actorInterfaceType.GetTypeInfo();
		TypeParameterSyntax[] array = (TypeParameterSyntax[])(typeInfo.IsGenericTypeDefinition ? ((Array)(from _ in typeInfo.GetGenericArguments()
			select SyntaxFactory.TypeParameter(_.ToString())).ToArray()) : ((Array)new TypeParameterSyntax[0]));
		AttributeListSyntax val = SyntaxFactory.AttributeList(default(SeparatedSyntaxList<AttributeSyntax>)).AddAttributes((AttributeSyntax[])(object)new AttributeSyntax[2]
		{
			CodeGeneratorCommon.GetGeneratedCodeAttributeSyntax(),
			SyntaxFactory.Attribute(typeof(ActorProxyToAttribute).GetNameSyntax()).AddArgumentListArguments((AttributeArgumentSyntax[])(object)new AttributeArgumentSyntax[3]
			{
				SyntaxFactory.AttributeArgument((ExpressionSyntax)(object)SyntaxFactory.TypeOfExpression(actorInterfaceType.GetTypeSyntax())),
				SyntaxFactory.AttributeArgument((ExpressionSyntax)(object)SyntaxFactory.TypeOfExpression(SyntaxFactory.ParseTypeName("ActorToProxy_" + actorImplementationType.Name + "_Wrapper", 0, true))),
				SyntaxFactory.AttributeArgument((ExpressionSyntax)(object)SyntaxFactory.TypeOfExpression(SyntaxFactory.ParseTypeName("ProxyToActor_" + actorImplementationType.Name + "_Wrapper", 0, true)))
			})
		});
		MethodDeclarationSyntax[] array2 = (from method in typeInfo.GetMethods()
			select method.GetDeclarationSyntax(needModifiers: false).WithSemicolonToken(SyntaxFactory.Token((SyntaxKind)8212))).ToArray();
		InterfaceDeclarationSyntax obj = SyntaxFactory.InterfaceDeclaration(typeInfo.Name + "_Proxy").AddModifiers((SyntaxToken[])(object)new SyntaxToken[1] { SyntaxFactory.Token((SyntaxKind)8343) });
		MemberDeclarationSyntax[] array3 = (MemberDeclarationSyntax[])(object)array2;
		InterfaceDeclarationSyntax val2 = obj.AddMembers(array3).AddConstraintClauses(actorInterfaceType.GetTypeConstraintSyntax()).AddAttributeLists((AttributeListSyntax[])(object)new AttributeListSyntax[1] { val });
		if (typeInfo.GetInterface(typeof(IServerPlacementActor).FullName) != null)
		{
			val2 = val2.AddBaseListTypes((BaseTypeSyntax[])(object)new BaseTypeSyntax[1] { (BaseTypeSyntax)SyntaxFactory.SimpleBaseType(typeof(IServerPlacementActor).GetTypeSyntax()) });
		}
		else if (typeInfo.GetInterface(typeof(IActorWithGuidCompoundKey).FullName) != null)
		{
			val2 = val2.AddBaseListTypes((BaseTypeSyntax[])(object)new BaseTypeSyntax[1] { (BaseTypeSyntax)SyntaxFactory.SimpleBaseType(typeof(IActorWithGuidCompoundKey).GetTypeSyntax()) });
		}
		else if (typeInfo.GetInterface(typeof(IActorWithGuidKey).FullName) != null)
		{
			val2 = val2.AddBaseListTypes((BaseTypeSyntax[])(object)new BaseTypeSyntax[1] { (BaseTypeSyntax)SyntaxFactory.SimpleBaseType(typeof(IActorWithGuidKey).GetTypeSyntax()) });
		}
		else if (typeInfo.GetInterface(typeof(IActorWithIntegerKey).FullName) != null)
		{
			val2 = val2.AddBaseListTypes((BaseTypeSyntax[])(object)new BaseTypeSyntax[1] { (BaseTypeSyntax)SyntaxFactory.SimpleBaseType(typeof(IActorWithIntegerKey).GetTypeSyntax()) });
		}
		else if (typeInfo.GetInterface(typeof(IActorWithStringKey).FullName) != null)
		{
			val2 = val2.AddBaseListTypes((BaseTypeSyntax[])(object)new BaseTypeSyntax[1] { (BaseTypeSyntax)SyntaxFactory.SimpleBaseType(typeof(IActorWithStringKey).GetTypeSyntax()) });
		}
		if (array.Length != 0)
		{
			val2 = val2.AddTypeParameterListParameters(array);
		}
		return (TypeDeclarationSyntax)(object)val2;
	}
}
