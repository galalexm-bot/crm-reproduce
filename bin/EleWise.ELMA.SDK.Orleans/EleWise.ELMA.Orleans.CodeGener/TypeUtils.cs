using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Orleans.Runtime;

namespace EleWise.ELMA.Orleans.CodeGeneration;

internal static class TypeUtils
{
	private static readonly ConcurrentDictionary<Tuple<string, TypeFormattingOptions>, string> ParseableNameCache = new ConcurrentDictionary<Tuple<string, TypeFormattingOptions>, string>();

	public static string GetUnadornedTypeName(this Type type)
	{
		int num = type.Name.IndexOf('`');
		return ((num > 0) ? type.Name.Substring(0, num) : type.Name).TrimEnd('&');
	}

	public static string GetUnadornedMethodName(this MethodInfo method)
	{
		int num = method.Name.IndexOf('`');
		if (num <= 0)
		{
			return method.Name;
		}
		return method.Name.Substring(0, num);
	}

	public static string GetParseableName(this Type type, TypeFormattingOptions options = null)
	{
		return type.GetParseableName(null, options);
	}

	public static string GetParseableName(this Type type, Type[] genericParameters, TypeFormattingOptions options = null)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		options = (TypeFormattingOptions)(((object)options) ?? ((object)new TypeFormattingOptions((string)null, true, true, true, '.', true)));
		return ParseableNameCache.GetOrAdd(Tuple.Create<string, TypeFormattingOptions>(type.FullName + ((genericParameters != null) ? (";" + string.Join(";", genericParameters.Select((Type t) => t.FullName))) : ""), options), delegate
		{
			StringBuilder stringBuilder = new StringBuilder();
			TypeInfo typeInfo = type.GetTypeInfo();
			GetParseableName(type, stringBuilder, new Queue<Type>(genericParameters ?? (typeInfo.IsGenericTypeDefinition ? typeInfo.GetGenericArguments() : typeInfo.GenericTypeArguments)), options);
			return stringBuilder.ToString();
		});
	}

	private static void GetParseableName(Type type, StringBuilder builder, Queue<Type> typeArguments, TypeFormattingOptions options)
	{
		TypeInfo typeInfo = type.GetTypeInfo();
		if (typeInfo.IsArray)
		{
			builder.AppendFormat("{0}[{1}]", typeInfo.GetElementType().GetParseableName(options), string.Concat(from _ in Enumerable.Range(0, type.GetArrayRank() - 1)
				select ','));
			return;
		}
		if (typeInfo.IsGenericParameter)
		{
			if (options.get_IncludeGenericTypeParameters())
			{
				builder.Append(type.GetUnadornedTypeName());
			}
			return;
		}
		if (typeInfo.DeclaringType != null)
		{
			GetParseableName(typeInfo.DeclaringType, builder, typeArguments, options);
			builder.Append(options.get_NestedTypeSeparator());
		}
		else if (!string.IsNullOrWhiteSpace(type.Namespace) && options.get_IncludeNamespace())
		{
			string text = type.Namespace;
			if (options.get_NestedTypeSeparator() != '.')
			{
				text = text.Replace('.', options.get_NestedTypeSeparator());
			}
			if (options.get_IncludeGlobal())
			{
				builder.AppendFormat("global::");
			}
			builder.AppendFormat("{0}{1}", text, options.get_NestedTypeSeparator());
		}
		if (type.IsConstructedGenericType)
		{
			string identifier = type.GetUnadornedTypeName() + options.get_NameSuffix();
			builder.Append(EscapeIdentifier(identifier));
			List<Type> list = (from _ in Enumerable.Range(0, Math.Min(typeInfo.GetGenericArguments().Count(), typeArguments.Count))
				select typeArguments.Dequeue()).ToList();
			if (list.Count > 0 && options.get_IncludeTypeParameters())
			{
				string arg = string.Join(",", list.Select((Type generic) => generic.GetParseableName(options)));
				builder.AppendFormat("<{0}>", arg);
			}
		}
		else if (typeInfo.IsGenericTypeDefinition)
		{
			string identifier2 = type.GetUnadornedTypeName() + options.get_NameSuffix();
			builder.Append(EscapeIdentifier(identifier2));
			List<Type> list2 = (from _ in Enumerable.Range(0, Math.Min(type.GetGenericArguments().Count(), typeArguments.Count))
				select typeArguments.Dequeue()).ToList();
			if (list2.Count > 0 && options.get_IncludeTypeParameters())
			{
				string arg2 = string.Join(",", list2.Select((Type _) => (!options.get_IncludeGenericTypeParameters()) ? string.Empty : _.ToString()));
				builder.AppendFormat("<{0}>", arg2);
			}
		}
		else
		{
			builder.Append(EscapeIdentifier(type.GetUnadornedTypeName() + options.get_NameSuffix()));
		}
	}

	private static string EscapeIdentifier(string identifier)
	{
		switch (identifier)
		{
		case "abstract":
		case "add":
		case "base":
		case "bool":
		case "break":
		case "byte":
		case "case":
		case "catch":
		case "char":
		case "checked":
		case "class":
		case "const":
		case "continue":
		case "decimal":
		case "default":
		case "delegate":
		case "do":
		case "double":
		case "else":
		case "enum":
		case "event":
		case "explicit":
		case "extern":
		case "false":
		case "finally":
		case "fixed":
		case "float":
		case "for":
		case "foreach":
		case "get":
		case "goto":
		case "if":
		case "implicit":
		case "in":
		case "int":
		case "interface":
		case "internal":
		case "lock":
		case "long":
		case "namespace":
		case "new":
		case "null":
		case "object":
		case "operator":
		case "out":
		case "override":
		case "params":
		case "partial":
		case "private":
		case "protected":
		case "public":
		case "readonly":
		case "ref":
		case "remove":
		case "return":
		case "sbyte":
		case "sealed":
		case "set":
		case "short":
		case "sizeof":
		case "static":
		case "string":
		case "struct":
		case "switch":
		case "this":
		case "throw":
		case "true":
		case "try":
		case "typeof":
		case "uint":
		case "ulong":
		case "unsafe":
		case "ushort":
		case "using":
		case "virtual":
		case "where":
		case "while":
			return "@" + identifier;
		default:
			return identifier;
		}
	}
}
