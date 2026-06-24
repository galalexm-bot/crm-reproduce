using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ActorModel;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Attributes;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Orleans.Placements;
using EleWise.ELMA.Orleans.Runtime;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Orleans.Concurrency;
using Orleans.Placement;

namespace EleWise.ELMA.Orleans.CodeGeneration;

internal static class GrainClassWrapperGenerator
{
	private const string Prefix = "";

	private const string Suffix = "_Grain";

	private static readonly Type startingAvailablePlacementAttributeType;

	static GrainClassWrapperGenerator()
	{
		startingAvailablePlacementAttributeType = typeof(StatelessWorkerAttribute).Assembly.GetType("EleWise.ELMA.ActorModel.Attributes.StartingAvailablePlacementAttribute");
	}

	internal static TypeDeclarationSyntax Generate(Type interfaceType, Type actorType)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		TypeInfo typeInfo = actorType.GetTypeInfo();
		TypeParameterSyntax[] array = (TypeParameterSyntax[])(typeInfo.IsGenericTypeDefinition ? ((Array)(from _ in typeInfo.GetGenericArguments()
			select SyntaxFactory.TypeParameter(_.ToString())).ToArray()) : ((Array)new TypeParameterSyntax[0]));
		AttributeListSyntax val = SyntaxFactory.AttributeList(default(SeparatedSyntaxList<AttributeSyntax>)).AddAttributes((AttributeSyntax[])(object)new AttributeSyntax[1] { SyntaxFactory.Attribute(typeof(ExcludeFromCodeCoverageAttribute).GetNameSyntax()) });
		if (typeInfo.GetCustomAttribute<StatelessWorkerAttribute>() != null)
		{
			val = val.AddAttributes((AttributeSyntax[])(object)new AttributeSyntax[1] { SyntaxFactory.Attribute(typeof(StatelessWorkerAttribute).GetNameSyntax()) });
		}
		if (typeInfo.GetCustomAttribute(startingAvailablePlacementAttributeType) != null)
		{
			val = val.AddAttributes((AttributeSyntax[])(object)new AttributeSyntax[1] { SyntaxFactory.Attribute(typeof(RandomPlacementAttribute).GetNameSyntax()) });
		}
		if (typeof(IServerPlacementActor).IsAssignableFrom(interfaceType))
		{
			val = val.AddAttributes((AttributeSyntax[])(object)new AttributeSyntax[1] { SyntaxFactory.Attribute(typeof(SiloPlacementAttribute).GetNameSyntax()) });
		}
		FeatureFlagManagedAttribute customAttribute = interfaceType.GetCustomAttribute<FeatureFlagManagedAttribute>();
		if (customAttribute != null)
		{
			val = val.AddAttributes((AttributeSyntax[])(object)new AttributeSyntax[1] { SyntaxFactory.Attribute(typeof(FeatureFlagManagedPlacementAttribute).GetNameSyntax(), SyntaxFactory.AttributeArgumentList(SyntaxFactory.SeparatedList<AttributeArgumentSyntax>().Add(SyntaxFactory.AttributeArgument((ExpressionSyntax)(object)SyntaxFactory.LiteralExpression((SyntaxKind)8750, SyntaxFactory.Literal(customAttribute.FeatureFlagName)))).Add(SyntaxFactory.AttributeArgument((ExpressionSyntax)(object)SyntaxFactory.LiteralExpression((SyntaxKind)(customAttribute.DefaultEnabled ? 8752 : 8753)))))) });
		}
		string text = actorType.Name + "_Grain";
		string text2 = string.Concat("global::" + interfaceType.Namespace + ".", interfaceType.Name, "_Proxy");
		TypeSyntax val2 = SyntaxFactory.ParseTypeName("global::EleWise.ELMA.Orleans.ActorProxy<" + text2 + ">", 0, true);
		TypeSyntax val3 = SyntaxFactory.ParseTypeName(interfaceType.Name + "_Grain", 0, true);
		ClassDeclarationSyntax val4 = SyntaxFactory.ClassDeclaration(text).AddModifiers((SyntaxToken[])(object)new SyntaxToken[1] { SyntaxFactory.Token((SyntaxKind)8343) }).AddBaseListTypes((BaseTypeSyntax[])(object)new BaseTypeSyntax[2]
		{
			(BaseTypeSyntax)SyntaxFactory.SimpleBaseType(val2),
			(BaseTypeSyntax)SyntaxFactory.SimpleBaseType(val3)
		})
			.AddConstraintClauses(actorType.GetTypeConstraintSyntax())
			.AddMembers((MemberDeclarationSyntax[])(object)new MemberDeclarationSyntax[1] { (MemberDeclarationSyntax)SyntaxFactory.ConstructorDeclaration(SyntaxFactory.Identifier(text)).AddModifiers((SyntaxToken[])(object)new SyntaxToken[1] { SyntaxFactory.Token((SyntaxKind)8343) }).WithParameterList(SyntaxFactory.ParameterList(default(SeparatedSyntaxList<ParameterSyntax>)).AddParameters((ParameterSyntax[])(object)new ParameterSyntax[1] { SyntaxFactory.Parameter(SyntaxFactory.Identifier("actor")).WithType(SyntaxFactory.ParseTypeName(text2, 0, true)) }).AddParameters(OrleansServiceCollectionHelper.ActorProxyConstructorParameters.Select((ParameterInfo parameter) => SyntaxFactory.Parameter(SyntaxFactory.Identifier(parameter.Name)).WithType(parameter.ParameterType.GetTypeSyntax())).ToArray()))
				.WithInitializer(SyntaxFactory.ConstructorInitializer((SyntaxKind)8889, SyntaxFactory.ArgumentList(default(SeparatedSyntaxList<ArgumentSyntax>)).AddArguments((ArgumentSyntax[])(object)new ArgumentSyntax[1] { SyntaxFactory.Argument((ExpressionSyntax)(object)SyntaxFactory.IdentifierName("actor")) }).AddArguments(OrleansServiceCollectionHelper.ActorProxyConstructorParameters.Select((ParameterInfo parameter) => SyntaxFactory.Argument((ExpressionSyntax)(object)SyntaxFactory.IdentifierName(parameter.Name))).ToArray())))
				.WithBody(SyntaxFactory.Block(default(SyntaxList<StatementSyntax>))) })
			.AddMembers(GenerateInvokeMethods(interfaceType, actorType))
			.AddAttributeLists((AttributeListSyntax[])(object)new AttributeListSyntax[1] { val });
		if (array.Length != 0)
		{
			val4 = val4.AddTypeParameterListParameters(array);
		}
		return (TypeDeclarationSyntax)(object)val4;
	}

	private static MemberDeclarationSyntax[] GenerateInvokeMethods(Type interfaceType, Type actorType)
	{
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		CastExpressionSyntax instance = SyntaxFactory.CastExpression(SyntaxFactory.ParseTypeName(string.Concat("global::" + interfaceType.Namespace + ".", interfaceType.Name, "_Proxy"), 0, true), (ExpressionSyntax)(object)SyntaxFactory.IdentifierName("ActorWrapper"));
		MethodInfo[] methods = ActorInterfaceUtils.GetMethods(interfaceType);
		List<MemberDeclarationSyntax> list = new List<MemberDeclarationSyntax>();
		MethodInfo[] array = methods;
		foreach (MethodInfo methodInfo in array)
		{
			Type[] types = (from parameter in methodInfo.GetParameters()
				select parameter.ParameterType).ToArray();
			MethodInfo element = actorType.GetMethod(methodInfo.Name, BindingFlags.Instance | BindingFlags.Public, null, types, null) ?? actorType.GetMethod(interfaceType.FullName + "." + methodInfo.Name, BindingFlags.Instance | BindingFlags.NonPublic, null, types, null);
			List<StatementSyntax> list2 = new List<StatementSyntax>();
			InvocationExpressionSyntax val = SyntaxFactory.InvocationExpression((ExpressionSyntax)(object)((ExpressionSyntax)(object)instance).Member(methodInfo.Name));
			if (methodInfo.IsGenericMethodDefinition)
			{
				throw new NotSupportedException();
			}
			ParameterInfo[] parameters = methodInfo.GetParameters();
			foreach (ParameterInfo parameterInfo in parameters)
			{
				val = val.AddArgumentListArguments((ArgumentSyntax[])(object)new ArgumentSyntax[1] { SyntaxFactory.Argument((ExpressionSyntax)(object)parameterInfo.Name.ToIdentifierName()) });
			}
			if (methodInfo.ReturnType == typeof(void))
			{
				list2.Add((StatementSyntax)(object)SyntaxFactory.ExpressionStatement((ExpressionSyntax)(object)val));
			}
			else
			{
				list2.Add((StatementSyntax)(object)SyntaxFactory.ReturnStatement((ExpressionSyntax)(object)val));
			}
			MethodDeclarationSyntax val2 = methodInfo.GetDeclarationSyntax().AddBodyStatements(list2.ToArray());
			if (element.IsDefined(typeof(TransactionAttribute)))
			{
				AttributeListSyntax val3 = SyntaxFactory.AttributeList(default(SeparatedSyntaxList<AttributeSyntax>)).AddAttributes((AttributeSyntax[])(object)new AttributeSyntax[1] { SyntaxFactory.Attribute(typeof(TransactionAttribute).GetNameSyntax()) });
				val2 = val2.AddAttributeLists((AttributeListSyntax[])(object)new AttributeListSyntax[1] { val3 });
			}
			list.Add((MemberDeclarationSyntax)(object)val2);
		}
		return list.ToArray();
	}
}
