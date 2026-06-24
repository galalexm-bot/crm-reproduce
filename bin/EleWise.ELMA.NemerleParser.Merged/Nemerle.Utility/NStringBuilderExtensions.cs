using System;
using System.Collections.Generic;
using System.Text;
using Nemerle.Builtins;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Utility;

[Extension]
[Extension]
[Extension]
[Extension]
[Extension]
[Extension]
[Extension]
[Extension]
[Extension]
[Extension]
[Extension]
[Extension]
[Extension]
public static class NStringBuilderExtensions
{
	private sealed class _N_closureOf_AppendNTimes_25461<T>
	{
		internal StringBuilder _N_builder_25470;

		internal T _N_a_25468;

		internal string _N_seperator_25466;

		internal _N_closureOf_AppendNTimes_25461()
		{
		}
	}

	private sealed class _N_closureOf_AppendNTimes_25494
	{
		internal StringBuilder _N_builder_25503;

		internal Function<StringBuilder, StringBuilder> _N_append_25501;

		internal string _N_seperator_25499;

		internal _N_closureOf_AppendNTimes_25494()
		{
		}
	}

	[Extension]
	public static void AppendSeq<T>(this StringBuilder builder, IEnumerable<T> seq, string seperator)
	{
		bool flag = true;
		IEnumerator<T> enumerator = seq.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				T val = default(T);
				T current = enumerator.Current;
				val = current;
				if (flag)
				{
					flag = false;
				}
				else
				{
					builder.Append(seperator);
				}
				builder.Append(val);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
	}

	[Extension]
	public static void AppendSeq<T>(this StringBuilder builder, IEnumerable<T> seq, string seperator, Function<T, string> convert)
	{
		bool flag = true;
		IEnumerator<T> enumerator = seq.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				T val = default(T);
				T current = enumerator.Current;
				val = current;
				if (flag)
				{
					flag = false;
				}
				else
				{
					builder.Append(seperator);
				}
				string value = convert.apply(val);
				builder.Append(value);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
	}

	[Extension]
	public static void AppendSeqByConvert<T>(this StringBuilder builder, IEnumerable<T> seq, string seperator, FunctionVoid<T> convert)
	{
		bool flag = true;
		IEnumerator<T> enumerator = seq.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				T val = default(T);
				T current = enumerator.Current;
				val = current;
				if (flag)
				{
					flag = false;
				}
				else
				{
					builder.Append(seperator);
				}
				convert.apply_void(val);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
	}

	[Extension]
	public static void AppendSeq<T>(this StringBuilder builder, list<T> seq, string seperator)
	{
		StringBuilder stringBuilder = builder.AppendList(seq, seperator);
	}

	[Extension]
	public static StringBuilder AppendList<T>(this StringBuilder builder, list<T> l, string seperator)
	{
		T val = default(T);
		StringBuilder result;
		while (true)
		{
			if (l is list<T>.Cons)
			{
				if ((object)((list<T>.Cons)l).tl == list<T>.Nil._N_constant_object)
				{
					val = ((list<T>.Cons)l).hd;
					result = builder.Append(val);
					break;
				}
				val = ((list<T>.Cons)l).hd;
				list<T> list = ((list<T>.Cons)l).tl;
				StringBuilder stringBuilder = builder.Append(val).Append(seperator);
				list<T> obj = list;
				seperator = seperator;
				l = obj;
				builder = stringBuilder;
				continue;
			}
			if ((object)l == list<T>.Nil._N_constant_object)
			{
				result = builder;
				break;
			}
			throw new MatchFailureException();
		}
		return result;
	}

	[Extension]
	public static StringBuilder AppendList<T>(this StringBuilder builder, list<T> l, Function<StringBuilder, T, StringBuilder> append, string seperator)
	{
		T val = default(T);
		StringBuilder result;
		while (true)
		{
			if (l is list<T>.Cons)
			{
				if ((object)((list<T>.Cons)l).tl == list<T>.Nil._N_constant_object)
				{
					val = ((list<T>.Cons)l).hd;
					result = append.apply(builder, val);
					break;
				}
				val = ((list<T>.Cons)l).hd;
				list<T> list = ((list<T>.Cons)l).tl;
				StringBuilder stringBuilder = append.apply(builder, val).Append(seperator);
				list<T> obj = list;
				Function<StringBuilder, T, StringBuilder> obj2 = append;
				seperator = seperator;
				append = obj2;
				l = obj;
				builder = stringBuilder;
				continue;
			}
			if ((object)l == list<T>.Nil._N_constant_object)
			{
				result = builder;
				break;
			}
			throw new MatchFailureException();
		}
		return result;
	}

	[Extension]
	public static StringBuilder AppendWhen(this StringBuilder builder, bool condition, Function<StringBuilder, StringBuilder> append)
	{
		return (!condition) ? builder : append.apply(builder);
	}

	[Extension]
	public static StringBuilder AppendUnless(this StringBuilder builder, bool condition, Function<StringBuilder, StringBuilder> append)
	{
		return (!condition) ? append.apply(builder) : builder;
	}

	[Extension]
	public static StringBuilder AppendNTimes<T>(this StringBuilder builder, int count, T a, string seperator)
	{
		_N_closureOf_AppendNTimes_25461<T> n_closureOf_AppendNTimes_ = new _N_closureOf_AppendNTimes_25461<T>();
		n_closureOf_AppendNTimes_._N_builder_25470 = builder;
		n_closureOf_AppendNTimes_._N_a_25468 = a;
		n_closureOf_AppendNTimes_._N_seperator_25466 = seperator;
		return _N_loop_25473(n_closureOf_AppendNTimes_, count);
	}

	[Extension]
	public static StringBuilder AppendNTimes(this StringBuilder builder, int count, Function<StringBuilder, StringBuilder> append, string seperator)
	{
		_N_closureOf_AppendNTimes_25494 n_closureOf_AppendNTimes_ = new _N_closureOf_AppendNTimes_25494();
		n_closureOf_AppendNTimes_._N_builder_25503 = builder;
		n_closureOf_AppendNTimes_._N_append_25501 = append;
		n_closureOf_AppendNTimes_._N_seperator_25499 = seperator;
		return _N_loop_25506(n_closureOf_AppendNTimes_, count);
	}

	[Extension]
	public static void AppendSeq<T>(this StringBuilder builder, IEnumerable<T> seq, string seperator, string indent, Function<T, string> convert)
	{
		bool flag = true;
		IEnumerator<T> enumerator = seq.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				T val = default(T);
				T current = enumerator.Current;
				val = current;
				if (flag)
				{
					flag = false;
				}
				else
				{
					int length = builder.Length;
					builder.Append(seperator);
					builder.Replace("\n", indent, length, seperator.Length);
				}
				string value = convert.apply(val).Replace("\n", indent);
				builder.Append(value);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
	}

	[Extension]
	public static void AppendSeq<T>(this StringBuilder builder, IEnumerable<T> seq, string seperator, string indent)
	{
		bool flag = true;
		IEnumerator<T> enumerator = seq.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				T val = default(T);
				T current = enumerator.Current;
				val = current;
				if (flag)
				{
					flag = false;
				}
				else
				{
					int length = builder.Length;
					builder.Append(seperator);
					builder.Replace("\n", indent, length, seperator.Length);
				}
				string value = val.ToString().Replace("\n", indent);
				builder.Append(value);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
	}

	[Extension]
	public static void AppendSeqByConvert<T>(this StringBuilder builder, IEnumerable<T> seq, string seperator, string indent, FunctionVoid<T> convert)
	{
		bool flag = true;
		IEnumerator<T> enumerator = seq.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				T val = default(T);
				T current = enumerator.Current;
				val = current;
				if (flag)
				{
					flag = false;
				}
				else
				{
					int length = builder.Length;
					builder.Append(seperator);
					builder.Replace("\n", indent, length, seperator.Length);
				}
				convert.apply_void(val);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
	}

	private static StringBuilder _N_loop_25473<T>(_N_closureOf_AppendNTimes_25461<T> _N_AppendNTimes_cp_25472, int cnt)
	{
		object result;
		if (cnt == 1)
		{
			result = _N_AppendNTimes_cp_25472._N_builder_25470.Append(_N_AppendNTimes_cp_25472._N_a_25468);
		}
		else
		{
			result = ((cnt <= 0) ? _N_AppendNTimes_cp_25472._N_builder_25470 : _N_loop_25473(_N_AppendNTimes_cp_25472, checked(cnt - 1)).Append(_N_AppendNTimes_cp_25472._N_seperator_25466).Append(_N_AppendNTimes_cp_25472._N_a_25468));
		}
		return (StringBuilder)result;
	}

	private static StringBuilder _N_loop_25506(_N_closureOf_AppendNTimes_25494 _N_AppendNTimes_cp_25505, int cnt)
	{
		object result;
		if (cnt == 1)
		{
			result = _N_AppendNTimes_cp_25505._N_append_25501.apply(_N_AppendNTimes_cp_25505._N_builder_25503);
		}
		else
		{
			result = ((cnt <= 0) ? _N_AppendNTimes_cp_25505._N_builder_25503 : _N_AppendNTimes_cp_25505._N_append_25501.apply(_N_loop_25506(_N_AppendNTimes_cp_25505, checked(cnt - 1)).Append(_N_AppendNTimes_cp_25505._N_seperator_25499)));
		}
		return (StringBuilder)result;
	}
}
