using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Orleans.Runtime;

namespace EleWise.ELMA.Orleans.CodeGeneration;

internal static class SyntaxFactoryExtensions
{
	public static TypeSyntax GetTypeSyntax(this Type type, bool includeNamespace = true, bool includeGenericParameters = true)
	{
		return type.GetTypeSyntax(null, includeNamespace, includeGenericParameters);
	}

	public static TypeSyntax GetTypeSyntax(this Type type, Type[] genericArguments, bool includeNamespace = true, bool includeGenericParameters = true)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		if (type == typeof(void))
		{
			return (TypeSyntax)(object)SyntaxFactory.PredefinedType(SyntaxFactory.Token((SyntaxKind)8318));
		}
		return SyntaxFactory.ParseTypeName(type.GetParseableName(genericArguments, new TypeFormattingOptions((string)null, includeNamespace, includeGenericParameters, true, '.', true)), 0, true);
	}

	public static NameSyntax GetNameSyntax(this Type type, bool includeNamespace = true)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		return SyntaxFactory.ParseName(type.GetParseableName(new TypeFormattingOptions((string)null, includeNamespace, true, true, '.', true)), 0, true);
	}

	public static SimpleNameSyntax GetNameSyntax(this MethodInfo method)
	{
		string unadornedMethodName = method.GetUnadornedMethodName();
		if (method.IsGenericMethod)
		{
			IEnumerable<TypeSyntax> source = from arg in method.GetGenericArguments()
				select arg.GetTypeSyntax();
			return (SimpleNameSyntax)(object)unadornedMethodName.ToGenericName().AddTypeArgumentListArguments(source.ToArray());
		}
		return (SimpleNameSyntax)(object)unadornedMethodName.ToIdentifierName();
	}

	public static ParenthesizedExpressionSyntax GetBindingFlagsParenthesizedExpressionSyntax(SyntaxKind operationKind, params BindingFlags[] bindingFlags)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		if (bindingFlags.Length < 2)
		{
			throw new ArgumentOutOfRangeException("bindingFlags", $"Can't create parenthesized binary expression with {bindingFlags.Length} arguments");
		}
		MemberAccessExpressionSyntax instance = ((ExpressionSyntax)(object)((ExpressionSyntax)(object)SyntaxFactory.IdentifierName("System")).Member("Reflection")).Member("BindingFlags");
		BinaryExpressionSyntax val = SyntaxFactory.BinaryExpression(operationKind, (ExpressionSyntax)(object)((ExpressionSyntax)(object)instance).Member(bindingFlags[0].ToString()), (ExpressionSyntax)(object)((ExpressionSyntax)(object)instance).Member(bindingFlags[1].ToString()));
		for (int i = 2; i < bindingFlags.Length; i++)
		{
			val = SyntaxFactory.BinaryExpression(operationKind, (ExpressionSyntax)(object)val, (ExpressionSyntax)(object)((ExpressionSyntax)(object)instance).Member(bindingFlags[i].ToString()));
		}
		return SyntaxFactory.ParenthesizedExpression((ExpressionSyntax)(object)val);
	}

	public static ArrayTypeSyntax GetArrayTypeSyntax(this Type type, bool includeNamespace = true)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		return SyntaxFactory.ArrayType(SyntaxFactory.ParseTypeName(type.GetParseableName(new TypeFormattingOptions((string)null, includeNamespace, true, true, '.', true)), 0, true)).AddRankSpecifiers((ArrayRankSpecifierSyntax[])(object)new ArrayRankSpecifierSyntax[1] { SyntaxFactory.ArrayRankSpecifier(default(SeparatedSyntaxList<ExpressionSyntax>)).AddSizes((ExpressionSyntax[])(object)new ExpressionSyntax[1] { (ExpressionSyntax)SyntaxFactory.OmittedArraySizeExpression() }) });
	}

	public static MethodDeclarationSyntax GetDeclarationSyntax(this MethodInfo method, bool needModifiers = true)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		MethodDeclarationSyntax val = SyntaxFactory.MethodDeclaration(method.ReturnType.GetTypeSyntax(), method.Name.ToIdentifier()).WithParameterList(SyntaxFactory.ParameterList(default(SeparatedSyntaxList<ParameterSyntax>)).AddParameters(method.GetParameterListSyntax()));
		if (method.IsGenericMethodDefinition)
		{
			val = val.WithTypeParameterList(SyntaxFactory.TypeParameterList(default(SeparatedSyntaxList<TypeParameterSyntax>)).AddParameters(method.GetTypeParameterListSyntax()));
			Type[] genericArguments = method.GetGenericArguments();
			List<TypeParameterConstraintClauseSyntax> list = new List<TypeParameterConstraintClauseSyntax>();
			Type[] array = genericArguments;
			foreach (Type genericParameter in array)
			{
				list.AddRange(GetTypeParameterConstraints(genericParameter));
			}
			if (list.Count > 0)
			{
				val = val.AddConstraintClauses(list.ToArray());
			}
		}
		if (needModifiers)
		{
			if (method.IsPublic)
			{
				val = val.AddModifiers((SyntaxToken[])(object)new SyntaxToken[1] { SyntaxFactory.Token((SyntaxKind)8343) });
			}
			else if (method.IsPrivate)
			{
				val = val.AddModifiers((SyntaxToken[])(object)new SyntaxToken[1] { SyntaxFactory.Token((SyntaxKind)8344) });
			}
			else if (method.IsFamily)
			{
				val = val.AddModifiers((SyntaxToken[])(object)new SyntaxToken[1] { SyntaxFactory.Token((SyntaxKind)8346) });
			}
		}
		return val;
	}

	public static ConstructorDeclarationSyntax GetDeclarationSyntax(this ConstructorInfo constructor, string typeName)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		ConstructorDeclarationSyntax val = SyntaxFactory.ConstructorDeclaration(typeName.ToIdentifier()).WithParameterList(SyntaxFactory.ParameterList(default(SeparatedSyntaxList<ParameterSyntax>)).AddParameters(constructor.GetParameterListSyntax()));
		if (constructor.IsPublic)
		{
			val = val.AddModifiers((SyntaxToken[])(object)new SyntaxToken[1] { SyntaxFactory.Token((SyntaxKind)8343) });
		}
		else if (constructor.IsPrivate)
		{
			val = val.AddModifiers((SyntaxToken[])(object)new SyntaxToken[1] { SyntaxFactory.Token((SyntaxKind)8344) });
		}
		else if (constructor.IsFamily)
		{
			val = val.AddModifiers((SyntaxToken[])(object)new SyntaxToken[1] { SyntaxFactory.Token((SyntaxKind)8346) });
		}
		return val;
	}

	public static string GetOrCreateName(this ParameterInfo parameter, int parameterIndex)
	{
		string text = parameter.Name;
		if (string.IsNullOrWhiteSpace(text))
		{
			text = string.Format(CultureInfo.InvariantCulture, "arg{0:G}", parameterIndex);
		}
		return text;
	}

	public static ParameterSyntax[] GetParameterListSyntax(this MethodInfo method)
	{
		return method.GetParameters().Select((ParameterInfo parameter, int parameterIndex) => SyntaxFactory.Parameter(parameter.GetOrCreateName(parameterIndex).ToIdentifier()).WithType(parameter.ParameterType.GetTypeSyntax())).ToArray();
	}

	public static TypeParameterSyntax[] GetTypeParameterListSyntax(this MethodInfo method)
	{
		return (from parameter in method.GetGenericArguments()
			select SyntaxFactory.TypeParameter(parameter.Name)).ToArray();
	}

	public static ParameterSyntax[] GetParameterListSyntax(this ConstructorInfo constructor)
	{
		return (from parameter in constructor.GetParameters()
			select SyntaxFactory.Parameter(parameter.Name.ToIdentifier()).WithType(parameter.ParameterType.GetTypeSyntax())).ToArray();
	}

	public static TypeParameterConstraintClauseSyntax[] GetTypeConstraintSyntax(this Type type)
	{
		TypeInfo typeInfo = type.GetTypeInfo();
		if (typeInfo.IsGenericTypeDefinition)
		{
			List<TypeParameterConstraintClauseSyntax> list = new List<TypeParameterConstraintClauseSyntax>();
			Type[] genericArguments = typeInfo.GetGenericArguments();
			foreach (Type genericParameter in genericArguments)
			{
				list.AddRange(GetTypeParameterConstraints(genericParameter));
			}
			return list.ToArray();
		}
		return (TypeParameterConstraintClauseSyntax[])(object)new TypeParameterConstraintClauseSyntax[0];
	}

	private static TypeParameterConstraintClauseSyntax[] GetTypeParameterConstraints(Type genericParameter)
	{
		List<TypeParameterConstraintClauseSyntax> list = new List<TypeParameterConstraintClauseSyntax>();
		List<TypeParameterConstraintSyntax> list2 = new List<TypeParameterConstraintSyntax>();
		GenericParameterAttributes genericParameterAttributes = genericParameter.GetTypeInfo().GenericParameterAttributes;
		if (genericParameterAttributes.HasFlag(GenericParameterAttributes.ReferenceTypeConstraint))
		{
			list2.Add((TypeParameterConstraintSyntax)(object)SyntaxFactory.ClassOrStructConstraint((SyntaxKind)8868));
		}
		else if (genericParameterAttributes.HasFlag(GenericParameterAttributes.NotNullableValueTypeConstraint))
		{
			list2.Add((TypeParameterConstraintSyntax)(object)SyntaxFactory.ClassOrStructConstraint((SyntaxKind)8869));
		}
		Type[] genericParameterConstraints = genericParameter.GetTypeInfo().GetGenericParameterConstraints();
		foreach (Type type in genericParameterConstraints)
		{
			if (!(type == typeof(ValueType)))
			{
				list2.Add((TypeParameterConstraintSyntax)(object)SyntaxFactory.TypeConstraint(type.GetTypeSyntax()));
			}
		}
		if (genericParameterAttributes.HasFlag(GenericParameterAttributes.DefaultConstructorConstraint) && !genericParameterAttributes.HasFlag(GenericParameterAttributes.NotNullableValueTypeConstraint))
		{
			list2.Add((TypeParameterConstraintSyntax)(object)SyntaxFactory.ConstructorConstraint());
		}
		if (list2.Count > 0)
		{
			list.Add(SyntaxFactory.TypeParameterConstraintClause(genericParameter.Name).AddConstraints(list2.ToArray()));
		}
		return list.ToArray();
	}

	public static MemberAccessExpressionSyntax Member(this ExpressionSyntax instance, string member)
	{
		return instance.Member(member.ToIdentifierName());
	}

	public static QualifiedNameSyntax Qualify(this NameSyntax instance, string member)
	{
		return instance.Qualify(member.ToIdentifierName());
	}

	public static MemberAccessExpressionSyntax Member(this ExpressionSyntax instance, string member, params Type[] genericTypes)
	{
		return instance.Member(member.ToGenericName().AddTypeArgumentListArguments(genericTypes.Select((Type _) => _.GetTypeSyntax()).ToArray()));
	}

	public static MemberAccessExpressionSyntax Member<TInstance, T>(this ExpressionSyntax instance, Expression<Func<TInstance, T>> member, params Type[] genericTypes)
	{
		if (member.Body is MethodCallExpression methodCallExpression)
		{
			if (genericTypes != null && genericTypes.Length != 0)
			{
				return instance.Member(methodCallExpression.Method.Name, genericTypes);
			}
			return instance.Member(methodCallExpression.Method.Name.ToIdentifierName());
		}
		if (member.Body is MemberExpression memberExpression)
		{
			if (genericTypes != null && genericTypes.Length != 0)
			{
				return instance.Member(memberExpression.Member.Name, genericTypes);
			}
			return instance.Member(memberExpression.Member.Name.ToIdentifierName());
		}
		throw new ArgumentException("Expression type unsupported.");
	}

	public static InvocationExpressionSyntax Invoke<T>(this Expression<Func<T>> expression)
	{
		if (expression.Body is MethodCallExpression methodCallExpression)
		{
			Type declaringType = methodCallExpression.Method.DeclaringType;
			return SyntaxFactory.InvocationExpression((ExpressionSyntax)(object)SyntaxFactory.MemberAccessExpression((SyntaxKind)8689, (ExpressionSyntax)(object)declaringType.GetNameSyntax(), methodCallExpression.Method.GetNameSyntax()));
		}
		throw new ArgumentException("Expression type unsupported.");
	}

	public static InvocationExpressionSyntax Invoke(this Expression<Action> expression, ExpressionSyntax instance = null)
	{
		if (expression.Body is MethodCallExpression methodCallExpression)
		{
			if (instance == null && methodCallExpression.Method.IsStatic)
			{
				instance = (ExpressionSyntax)(object)methodCallExpression.Method.DeclaringType.GetNameSyntax();
			}
			return SyntaxFactory.InvocationExpression((ExpressionSyntax)(object)SyntaxFactory.MemberAccessExpression((SyntaxKind)8689, instance, (SimpleNameSyntax)(object)methodCallExpression.Method.Name.ToIdentifierName()));
		}
		throw new ArgumentException("Expression type unsupported.");
	}

	public static InvocationExpressionSyntax Invoke<T>(this Expression<Action<T>> expression, ExpressionSyntax instance = null)
	{
		if (expression.Body is MethodCallExpression methodCallExpression)
		{
			Type declaringType = methodCallExpression.Method.DeclaringType;
			return SyntaxFactory.InvocationExpression((ExpressionSyntax)(object)SyntaxFactory.MemberAccessExpression((SyntaxKind)8689, (ExpressionSyntax)(((object)instance) ?? ((object)declaringType.GetNameSyntax())), (SimpleNameSyntax)(object)methodCallExpression.Method.Name.ToIdentifierName()));
		}
		throw new ArgumentException("Expression type unsupported.");
	}

	public static MemberAccessExpressionSyntax Member(this ExpressionSyntax instance, IdentifierNameSyntax member)
	{
		return SyntaxFactory.MemberAccessExpression((SyntaxKind)8689, instance, (SimpleNameSyntax)(object)member);
	}

	public static MemberAccessExpressionSyntax Member(this ExpressionSyntax instance, GenericNameSyntax member)
	{
		return SyntaxFactory.MemberAccessExpression((SyntaxKind)8689, instance, (SimpleNameSyntax)(object)member);
	}

	public static QualifiedNameSyntax Qualify(this NameSyntax instance, IdentifierNameSyntax member)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return SyntaxFactory.QualifiedName(instance, (SimpleNameSyntax)(object)member).WithDotToken(SyntaxFactory.Token((SyntaxKind)8218));
	}
}
