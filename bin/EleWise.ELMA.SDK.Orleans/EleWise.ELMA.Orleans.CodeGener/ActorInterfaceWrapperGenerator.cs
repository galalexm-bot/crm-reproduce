using System;
using System.Collections.Generic;
using System.Reflection;
using EleWise.ELMA.ActorModel;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace EleWise.ELMA.Orleans.CodeGeneration;

internal static class ActorInterfaceWrapperGenerator
{
	internal const string Prefix = "ActorToProxy_";

	internal const string InversePrefix = "ProxyToActor_";

	internal const string Suffix = "_Wrapper";

	public static TypeDeclarationSyntax[] Generate(Type actorInterfaceType, Type actorImplementationType)
	{
		string text = actorInterfaceType.Name + "_Proxy";
		string parseableName = actorInterfaceType.GetParseableName();
		MemberDeclarationSyntax[] invokeMethodsSyntaxes2 = GenerateInvokeMethods(actorInterfaceType);
		return (TypeDeclarationSyntax[])(object)new ClassDeclarationSyntax[2]
		{
			GenerateWrapperClass("ActorToProxy_" + actorImplementationType.Name + "_Wrapper", parseableName, text, invokeMethodsSyntaxes2),
			GenerateWrapperClass("ProxyToActor_" + actorImplementationType.Name + "_Wrapper", text, parseableName, invokeMethodsSyntaxes2)
		};
		ClassDeclarationSyntax GenerateWrapperClass(string wrapperClassName, string fromInterfaceTypeName, string toInterfaceTypeName, MemberDeclarationSyntax[] invokeMethodsSyntaxes)
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0115: Unknown result type (might be due to invalid IL or missing references)
			//IL_011b: Unknown result type (might be due to invalid IL or missing references)
			return SyntaxFactory.ClassDeclaration(wrapperClassName).AddModifiers((SyntaxToken[])(object)new SyntaxToken[1] { SyntaxFactory.Token((SyntaxKind)8345) }).AddBaseListTypes((BaseTypeSyntax[])(object)new BaseTypeSyntax[2]
			{
				(BaseTypeSyntax)SyntaxFactory.SimpleBaseType(SyntaxFactory.ParseTypeName("global::EleWise.ELMA.ActorModel.Abstractions.ActorInterfaceWrapper<" + toInterfaceTypeName + ">", 0, true)),
				(BaseTypeSyntax)SyntaxFactory.SimpleBaseType(SyntaxFactory.ParseTypeName(fromInterfaceTypeName, 0, true))
			})
				.AddConstraintClauses(actorInterfaceType.GetTypeConstraintSyntax())
				.AddMembers((MemberDeclarationSyntax[])(object)new MemberDeclarationSyntax[1] { (MemberDeclarationSyntax)SyntaxFactory.ConstructorDeclaration(SyntaxFactory.Identifier(wrapperClassName)).AddModifiers((SyntaxToken[])(object)new SyntaxToken[1] { SyntaxFactory.Token((SyntaxKind)8343) }).WithParameterList(SyntaxFactory.ParameterList(default(SeparatedSyntaxList<ParameterSyntax>)).AddParameters((ParameterSyntax[])(object)new ParameterSyntax[1] { SyntaxFactory.Parameter(SyntaxFactory.Identifier("actor")).WithType(SyntaxFactory.ParseTypeName(toInterfaceTypeName, 0, true)) }))
					.WithInitializer(SyntaxFactory.ConstructorInitializer((SyntaxKind)8889, SyntaxFactory.ArgumentList(default(SeparatedSyntaxList<ArgumentSyntax>)).AddArguments((ArgumentSyntax[])(object)new ArgumentSyntax[1] { SyntaxFactory.Argument((ExpressionSyntax)(object)SyntaxFactory.IdentifierName("actor")) })))
					.WithBody(SyntaxFactory.Block(default(SyntaxList<StatementSyntax>))) })
				.AddMembers(invokeMethodsSyntaxes);
		}
	}

	private static MemberDeclarationSyntax[] GenerateInvokeMethods(Type interfaceType)
	{
		IdentifierNameSyntax instance = SyntaxFactory.IdentifierName("Actor");
		MethodInfo[] methods = ActorInterfaceUtils.GetMethods(interfaceType);
		List<MemberDeclarationSyntax> list = new List<MemberDeclarationSyntax>();
		MethodInfo[] array = methods;
		foreach (MethodInfo methodInfo in array)
		{
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
			MethodDeclarationSyntax item = methodInfo.GetDeclarationSyntax().AddBodyStatements(list2.ToArray());
			list.Add((MemberDeclarationSyntax)(object)item);
		}
		return list.ToArray();
	}
}
