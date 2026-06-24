using System;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ComponentModel;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Orleans;

namespace EleWise.ELMA.Orleans.CodeGeneration;

internal static class GrainInterfaceWrapperGenerator
{
	internal const string Prefix = "";

	internal const string Suffix = "_Grain";

	internal static TypeDeclarationSyntax Generate(Type actorType, Type actorImplementationType)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		TypeInfo typeInfo = actorType.GetTypeInfo();
		TypeParameterSyntax[] array = (TypeParameterSyntax[])(typeInfo.IsGenericTypeDefinition ? ((Array)(from _ in typeInfo.GetGenericArguments()
			select SyntaxFactory.TypeParameter(_.ToString())).ToArray()) : ((Array)new TypeParameterSyntax[0]));
		TypeSyntax val = SyntaxFactory.ParseTypeName(string.Concat("global::" + actorType.Namespace + ".", actorType.Name, "_Proxy"), 0, true);
		AttributeListSyntax val2 = SyntaxFactory.AttributeList(default(SeparatedSyntaxList<AttributeSyntax>)).AddAttributes((AttributeSyntax[])(object)new AttributeSyntax[3]
		{
			CodeGeneratorCommon.GetGeneratedCodeAttributeSyntax(),
			SyntaxFactory.Attribute(typeof(ComponentAttribute).GetNameSyntax()),
			SyntaxFactory.Attribute(typeof(GrainWrapperForAttribute).GetNameSyntax()).AddArgumentListArguments((AttributeArgumentSyntax[])(object)new AttributeArgumentSyntax[1] { SyntaxFactory.AttributeArgument((ExpressionSyntax)(object)SyntaxFactory.TypeOfExpression(val)) })
		});
		InterfaceDeclarationSyntax val3 = SyntaxFactory.InterfaceDeclaration(actorType.Name + "_Grain").AddModifiers((SyntaxToken[])(object)new SyntaxToken[1] { SyntaxFactory.Token((SyntaxKind)8343) }).AddBaseListTypes((BaseTypeSyntax[])(object)new BaseTypeSyntax[1] { (BaseTypeSyntax)SyntaxFactory.SimpleBaseType(val) })
			.AddConstraintClauses(actorType.GetTypeConstraintSyntax())
			.AddAttributeLists((AttributeListSyntax[])(object)new AttributeListSyntax[1] { val2 });
		if (actorType.GetInterface(typeof(IActorWithGuidCompoundKey).FullName) != null)
		{
			val3 = val3.AddBaseListTypes((BaseTypeSyntax[])(object)new BaseTypeSyntax[1] { (BaseTypeSyntax)SyntaxFactory.SimpleBaseType(typeof(IGrainWithGuidCompoundKey).GetTypeSyntax()) });
		}
		else if (actorType.GetInterface(typeof(IActorWithGuidKey).FullName) != null)
		{
			val3 = val3.AddBaseListTypes((BaseTypeSyntax[])(object)new BaseTypeSyntax[1] { (BaseTypeSyntax)SyntaxFactory.SimpleBaseType(typeof(IGrainWithGuidKey).GetTypeSyntax()) });
		}
		else if (actorType.GetInterface(typeof(IActorWithIntegerKey).FullName) != null)
		{
			val3 = val3.AddBaseListTypes((BaseTypeSyntax[])(object)new BaseTypeSyntax[1] { (BaseTypeSyntax)SyntaxFactory.SimpleBaseType(typeof(IGrainWithIntegerKey).GetTypeSyntax()) });
		}
		else if (actorType.GetInterface(typeof(IActorWithStringKey).FullName) != null)
		{
			val3 = val3.AddBaseListTypes((BaseTypeSyntax[])(object)new BaseTypeSyntax[1] { (BaseTypeSyntax)SyntaxFactory.SimpleBaseType(typeof(IGrainWithStringKey).GetTypeSyntax()) });
		}
		if (array.Length != 0)
		{
			val3 = val3.AddTypeParameterListParameters(array);
		}
		return (TypeDeclarationSyntax)(object)val3;
	}
}
