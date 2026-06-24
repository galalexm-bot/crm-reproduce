using System;
using System.Runtime.CompilerServices;
using System.Text;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Compiler.Parsetree;
using Nemerle.Core;
using Nemerle.Utility;

namespace Nemerle.Compiler;

public static class Util
{
	private sealed class _N__N_lambda__46560__46567 : Function<string, PExpr, PExpr>
	{
		[SpecialName]
		public static readonly _N__N_lambda__46560__46567 Instance = new _N__N_lambda__46560__46567();

		[SpecialName]
		public sealed override PExpr apply(string name, PExpr expr)
		{
			return (expr != null) ? ((PExpr)new PExpr.Member(Macros.QuotationChoose(expr), new Splicable.Name(new Name(name, -1, ManagerClass.Instance.MacroColors.UseContext)))) : ((PExpr)new PExpr.Ref(new Name(name, -1, null)));
		}
	}

	[Obsolete("Use ManagerClass.GetNewId() instead.")]
	public static int next_id(ManagerClass mgr)
	{
		return mgr.GetNewId();
	}

	public static T ice<T>(string msg = "(see backtrace)")
	{
		//Discarded unreachable code: IL_0007
		throw new ICE(msg);
	}

	public static bool is_capitalized(string s)
	{
		int num = s.LastIndexOf('.');
		return char.IsUpper(s[checked(num + 1)]);
	}

	public static string tmpname(string kind)
	{
		StringBuilder stringBuilder = new StringBuilder("_N_").Append(kind).Append("_");
		escape_in_buffer(stringBuilder, kind, 3);
		return stringBuilder.Append(ManagerClass.Instance.GetNewId()).ToString();
	}

	private static void escape_in_buffer(StringBuilder sb, string str, int offset)
	{
		int num = 0;
		checked
		{
			for (num = 0; num < str.Length; num++)
			{
				if (!char.IsLetterOrDigit(str[num]))
				{
					sb[num + offset] = '_';
				}
			}
		}
	}

	public static string Escape(string str)
	{
		StringBuilder stringBuilder = new StringBuilder(str);
		escape_in_buffer(stringBuilder, str, 0);
		return stringBuilder.ToString();
	}

	public static string StripGenericMark(string str)
	{
		string result;
		if (str.IndexOf('`') == -1)
		{
			result = str;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			bool flag = true;
			CharEnumerator enumerator = str.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					char current = enumerator.Current;
					char c = current;
					if (c == '`')
					{
						flag = false;
					}
					else if (flag)
					{
						stringBuilder.Append(c);
					}
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			result = stringBuilder.ToString();
		}
		return result;
	}

	public static option<Nemerle.Builtins.Tuple<list<string>, Name>> QidOfExpr(PExpr expr)
	{
		return qidl_of_expr(expr);
	}

	internal static PExpr ExprOfQid(string fullname)
	{
		return PExpr.FromQualifiedIdentifier(ManagerClass.Instance, fullname);
	}

	public static PExpr ExprOfList(list<string> parts)
	{
		return expr_of_qidl(parts);
	}

	internal static option<Nemerle.Builtins.Tuple<list<string>, Name>> qidl_of_expr(PExpr expr)
	{
		PExpr pExpr = expr;
		list<string> tl = list<string>.Nil._N_constant_object;
		object result;
		while (true)
		{
			if (pExpr is PExpr.Ref)
			{
				Name name = ((PExpr.Ref)pExpr).name;
				result = new option<Nemerle.Builtins.Tuple<list<string>, Name>>.Some(new Nemerle.Builtins.Tuple<list<string>, Name>(new list<string>.Cons(name.idl, tl), name));
				break;
			}
			if (pExpr is PExpr.Member)
			{
				if (((PExpr.Member)pExpr).member is Splicable.Name)
				{
					PExpr obj = ((PExpr.Member)pExpr).obj;
					string idl = ((Splicable.Name)((PExpr.Member)pExpr).member).body.idl;
					PExpr pExpr2 = obj;
					tl = new list<string>.Cons(idl, tl);
					pExpr = pExpr2;
					continue;
				}
				if (((PExpr.Member)pExpr).member is Splicable.HalfId)
				{
					PExpr obj = ((PExpr.Member)pExpr).obj;
					Name name = ((Splicable.HalfId)((PExpr.Member)pExpr).member).prefix;
					PExpr pExpr3 = obj;
					tl = new list<string>.Cons(name.idl, tl);
					pExpr = pExpr3;
					continue;
				}
			}
			else if (pExpr is PExpr.ToComplete)
			{
				Name name = ((PExpr.ToComplete)pExpr).body;
				result = new option<Nemerle.Builtins.Tuple<list<string>, Name>>.Some(new Nemerle.Builtins.Tuple<list<string>, Name>(new list<string>.Cons(name.Id, tl), name));
				break;
			}
			result = option<Nemerle.Builtins.Tuple<list<string>, Name>>.None._N_constant_object;
			break;
		}
		return (option<Nemerle.Builtins.Tuple<list<string>, Name>>)result;
	}

	public static string QidOfList(list<string> l)
	{
		return qid_of_list(l);
	}

	internal static string qid_of_list(list<string> l)
	{
		return NString.Concat(".", l);
	}

	internal static PExpr expr_of_qidl(list<string> parts)
	{
		Function<string, PExpr, PExpr> instance = _N__N_lambda__46560__46567.Instance;
		return NList.FoldLeft(parts, null, instance);
	}

	public static PExpr set(Location loc, PExpr expr)
	{
		expr.Location = loc;
		return expr;
	}
}
