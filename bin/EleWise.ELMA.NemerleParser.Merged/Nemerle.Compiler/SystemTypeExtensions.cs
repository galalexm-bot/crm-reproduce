using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Internal;

namespace Nemerle.Compiler;

[Nemerle.Internal.Extension]
public static class SystemTypeExtensions
{
	private sealed class _N__N_lambda__17551__17582 : Function<Type, string>
	{
		[SpecialName]
		public static readonly _N__N_lambda__17551__17582 Instance = new _N__N_lambda__17551__17582();

		[SpecialName]
		public sealed override string apply(Type _N__17550)
		{
			return _N__17550.Name;
		}
	}

	private sealed class _N__N_lambda__17556__17592 : Function<string, string>
	{
		[SpecialName]
		public static readonly _N__N_lambda__17556__17592 Instance = new _N__N_lambda__17556__17592();

		[SpecialName]
		public sealed override string apply(string x)
		{
			return Convert.ToString(x);
		}
	}

	[Nemerle.Internal.Extension]
	public static string TypeFullName(this Type t)
	{
		Type type = null;
		object result;
		if (t.FullName != null)
		{
			if (!t.ContainsGenericParameters)
			{
				result = t.FullName;
			}
			else
			{
				Type[] genericArguments = t.GetGenericArguments();
				string text = ((!(t.Namespace == "")) ? (t.Namespace + ".") : "");
				string[] obj = new string[5]
				{
					Convert.ToString(text),
					Convert.ToString(t.Name),
					"[",
					null,
					null
				};
				Function<Type, string> instance = _N__N_lambda__17551__17582.Instance;
				IEnumerable<string> source = genericArguments.Map(instance);
				Function<string, string> instance2 = _N__N_lambda__17556__17592.Instance;
				obj[3] = string.Join(", ", source.MapToArray(instance2));
				obj[4] = "]";
				result = string.Concat(obj);
			}
		}
		else
		{
			type = t;
			while (type.HasElementType)
			{
				type = type.GetElementType();
			}
			if (type.IsNested)
			{
				result = t.Name;
			}
			else
			{
				string text = t.ToString();
				result = ((type.IsPrimitive || type.Equals(typeof(void)) || type.Equals(typeof(TypedReference))) ? text : text);
			}
		}
		return (string)result;
	}
}
