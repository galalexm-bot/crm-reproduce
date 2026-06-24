using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Collections;

[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[DebuggerNonUserCode]
public static class NList
{
	private sealed class _N_cmp__19535<T> : Function<T, T, int> where T : IComparable<T>
	{
		[SpecialName]
		public static readonly _N_cmp__19535<T> Instance = new _N_cmp__19535<T>();

		[SpecialName]
		public sealed override int apply(T x, T y)
		{
			return x.CompareTo(y);
		}
	}

	private sealed class _N__N_lambda__19842__19861<T> : Function<list<T>, list<T>, list<T>>
	{
		[SpecialName]
		public static readonly _N__N_lambda__19842__19861<T> Instance = new _N__N_lambda__19842__19861<T>();

		[SpecialName]
		public sealed override list<T> apply(list<T> _N__19840, list<T> _N__19841)
		{
			Function<T, list<T>, list<T>> instance = _N__N_lambda__19851__19871<T>.Instance;
			return FoldLeft(_N__19840, _N__19841, instance);
		}
	}

	private sealed class _N__N_lambda__19851__19871<T> : Function<T, list<T>, list<T>>
	{
		[SpecialName]
		public static readonly _N__N_lambda__19851__19871<T> Instance = new _N__N_lambda__19851__19871<T>();

		[SpecialName]
		public sealed override list<T> apply(T _N__19849, list<T> _N__19850)
		{
			return new list<T>.Cons(_N__19849, _N__19850);
		}
	}

	private sealed class _N_closureOf_Group_20490<T>
	{
		internal Function<T, T, int> _N_cmp_20495;

		internal _N_closureOf_Group_20490()
		{
		}
	}

	private sealed class _N__N_lambda__20758__20771<T> : Function<T, list<T>>
	{
		[SpecialName]
		public static readonly _N__N_lambda__20758__20771<T> Instance = new _N__N_lambda__20758__20771<T>();

		[SpecialName]
		public sealed override list<T> apply(T a)
		{
			return new list<T>.Cons(a, list<T>.Nil._N_constant_object);
		}
	}

	private sealed class _N_static_proxy_20785<T> : Function<list<T>, list<T>>
	{
		[SpecialName]
		public static readonly _N_static_proxy_20785<T> single_instance = new _N_static_proxy_20785<T>();

		[SpecialName]
		public sealed override list<T> apply(list<T> _N_sp_parm_20792)
		{
			return Rev(_N_sp_parm_20792);
		}

		private _N_static_proxy_20785()
		{
		}
	}

	private sealed class _N_closureOf_SubsetsPartitions_20831<T>
	{
		internal _N_closureOf_SubsetsPartitions_20831()
		{
		}
	}

	private sealed class _N__N_lambda__20873__20882<T> : Function<T, list<T>>
	{
		[SpecialName]
		public static readonly _N__N_lambda__20873__20882<T> Instance = new _N__N_lambda__20873__20882<T>();

		[SpecialName]
		public sealed override list<T> apply(T a)
		{
			return new list<T>.Cons(a, list<T>.Nil._N_constant_object);
		}
	}

	public static bool Equals<T>(list<T> x, list<T> y)
	{
		return x == y;
	}

	public static int Compare<T>(list<T> l1, list<T> l2, Function<T, T, int> cmp)
	{
		T val = default(T);
		T val2 = default(T);
		int result;
		while (true)
		{
			if ((object)l1 == list<T>.Nil._N_constant_object)
			{
				result = (((object)l2 != list<T>.Nil._N_constant_object) ? (-1) : 0);
				break;
			}
			if ((object)l2 == list<T>.Nil._N_constant_object)
			{
				result = 1;
				break;
			}
			if (l1 is list<T>.Cons && l2 is list<T>.Cons)
			{
				val = ((list<T>.Cons)l1).hd;
				list<T> list = ((list<T>.Cons)l1).tl;
				val2 = ((list<T>.Cons)l2).hd;
				list<T> list2 = ((list<T>.Cons)l2).tl;
				int num = cmp.apply(val, val2);
				if (num == 0)
				{
					list<T> obj = list;
					list<T> obj2 = list2;
					cmp = cmp;
					l2 = obj2;
					l1 = obj;
					continue;
				}
				result = num;
				break;
			}
			throw new ArgumentException("NList.Compare called for null list");
		}
		return result;
	}

	public static int Compare<T>(list<T> l1, list<T> l2) where T : IComparable<T>
	{
		Function<T, T, int> instance = _N_cmp__19535<T>.Instance;
		return Compare(l1, l2, instance);
	}

	public static list<T> RemoveDuplicates<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<T> lst)
	{
		T val = default(T);
		T val2 = default(T);
		if ((object)lst == null)
		{
			throw new ArgumentNullException("lst", "The ``NotNull'' contract of parameter ``lst'' has been violated. See lib\\list.n:767:51:767:54: .");
		}
		EqualityComparer<T> @default = EqualityComparer<T>.Default;
		list<T> list = lst;
		list<T> list2 = list<T>.Nil._N_constant_object;
		list<T> result;
		while (true)
		{
			if ((object)list == list<T>.Nil._N_constant_object)
			{
				result = list2.Reverse();
				break;
			}
			if (list is list<T>.Cons)
			{
				if ((object)((list<T>.Cons)list).tl == list<T>.Nil._N_constant_object)
				{
					val = ((list<T>.Cons)list).hd;
					result = new list<T>.Cons(val, list2).Reverse();
					break;
				}
				if (((list<T>.Cons)list).tl is list<T>.Cons)
				{
					val = ((list<T>.Cons)list).hd;
					list<T>.Cons cons = (list<T>.Cons)((list<T>.Cons)list).tl;
					val2 = ((list<T>.Cons)((list<T>.Cons)list).tl).hd;
					if (@default.Equals(val, val2))
					{
						list<T> obj = cons;
						list2 = list2;
						list = obj;
					}
					else
					{
						list<T> obj2 = cons;
						list2 = new list<T>.Cons(val, list2);
						list = obj2;
					}
					continue;
				}
				throw new MatchFailureException();
			}
			throw new MatchFailureException();
		}
		return result;
	}

	public static list<T> FromArray<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] T[] source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source", "The ``NotNull'' contract of parameter ``source'' has been violated. See lib\\list.n:791:37:791:43: .");
		}
		checked
		{
			int num = source.Length - 1;
			list<T> list = list<T>.Nil._N_constant_object;
			while (num >= 0)
			{
				int num2 = num - 1;
				list = new list<T>.Cons(source[num], list);
				num = num2;
			}
			return list;
		}
	}

	[Nemerle.Internal.Extension]
	public static list<T> ToListRev<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] this IEnumerable<T> seq)
	{
		if (seq == null)
		{
			throw new ArgumentNullException("seq", "The ``NotNull'' contract of parameter ``seq'' has been violated. See lib\\list.n:803:41:803:44: .");
		}
		list<T> list = list<T>.Nil._N_constant_object;
		IEnumerator<T> enumerator = seq.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				T val = default(T);
				T current = enumerator.Current;
				val = current;
				list = new list<T>.Cons(val, list);
			}
			return list;
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
	}

	[Nemerle.Internal.Extension]
	public static list<T> ToListRev<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] this IEnumerable<T> seq, Function<T, bool> filter)
	{
		if (seq == null)
		{
			throw new ArgumentNullException("seq", "The ``NotNull'' contract of parameter ``seq'' has been violated. See lib\\list.n:813:42:813:45: .");
		}
		list<T> list = list<T>.Nil._N_constant_object;
		IEnumerator<T> enumerator = seq.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				T val = default(T);
				T current = enumerator.Current;
				val = current;
				if (filter.apply(val))
				{
					list = new list<T>.Cons(val, list);
				}
			}
			return list;
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
	}

	public static list<T> ToList<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] IEnumerable<T> seq)
	{
		if (seq == null)
		{
			throw new ArgumentNullException("seq", "The ``NotNull'' contract of parameter ``seq'' has been violated. See lib\\list.n:824:34:824:37: .");
		}
		return seq.ToListRev().Rev();
	}

	[Nemerle.Internal.Extension]
	public static list<T> AsList<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] this IList<T> source)
	{
		int num = 0;
		list<T> list = null;
		if (source == null)
		{
			throw new ArgumentNullException("source", "The ``NotNull'' contract of parameter ``source'' has been violated. See lib\\list.n:829:39:829:45: .");
		}
		list = list<T>.Nil._N_constant_object;
		checked
		{
			for (num = source.Count - 1; num >= 0; num--)
			{
				list = new list<T>.Cons(source[num], list);
			}
			return list;
		}
	}

	public static list<T> ToList<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] IList<T> source, Function<T, bool> filter)
	{
		int num = 0;
		list<T> list = null;
		T val = default(T);
		if (source == null)
		{
			throw new ArgumentNullException("source", "The ``NotNull'' contract of parameter ``source'' has been violated. See lib\\list.n:839:32:839:38: .");
		}
		list = list<T>.Nil._N_constant_object;
		checked
		{
			for (num = source.Count - 1; num >= 0; num--)
			{
				val = source[num];
				if (filter.apply(val))
				{
					list = new list<T>.Cons(val, list);
				}
			}
			return list;
		}
	}

	public static list<T> ToList<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] IEnumerable<T> seq, Function<T, bool> filter)
	{
		if (seq == null)
		{
			throw new ArgumentNullException("seq", "The ``NotNull'' contract of parameter ``seq'' has been violated. See lib\\list.n:853:32:853:35: .");
		}
		return seq.ToListRev(filter).Rev();
	}

	public static bool IsEmpty<T>(list<T> lst)
	{
		return ((object)lst == list<T>.Nil._N_constant_object || (object)lst == null) ? true : false;
	}

	public static int Length<T>(list<T> x)
	{
		int num = 0;
		list<T> list = x;
		while (list is list<T>.Cons)
		{
			list = ((list<T>.Cons)list).tl;
			int num2 = checked(num + 1);
			list = list;
			num = num2;
		}
		return num;
	}

	public static T Head<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<T> l)
	{
		if ((object)l == null)
		{
			throw new ArgumentNullException("l", "The ``NotNull'' contract of parameter ``l'' has been violated. See lib\\list.n:885:32:885:33: .");
		}
		return l.Head;
	}

	public static T Hd<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<T> l)
	{
		if ((object)l == null)
		{
			throw new ArgumentNullException("l", "The ``NotNull'' contract of parameter ``l'' has been violated. See lib\\list.n:888:30:888:31: .");
		}
		return l.Head;
	}

	public static list<T> Tail<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<T> l)
	{
		if ((object)l == null)
		{
			throw new ArgumentNullException("l", "The ``NotNull'' contract of parameter ``l'' has been violated. See lib\\list.n:893:31:893:32: .");
		}
		return l.Tail;
	}

	public static list<T> Tl<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<T> l)
	{
		if ((object)l == null)
		{
			throw new ArgumentNullException("l", "The ``NotNull'' contract of parameter ``l'' has been violated. See lib\\list.n:900:29:900:30: .");
		}
		return l.Tail;
	}

	public static T Nth<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<T> l, int n)
	{
		T val = default(T);
		while (true)
		{
			if ((object)l == null)
			{
				throw new ArgumentNullException("l", "The ``NotNull'' contract of parameter ``l'' has been violated. See lib\\list.n:909:30:909:31: .");
			}
			if (!(l is list<T>.Cons))
			{
				break;
			}
			val = ((list<T>.Cons)l).hd;
			list<T> list = ((list<T>.Cons)l).tl;
			if (n == 0)
			{
				return val;
			}
			list<T> obj = list;
			n = checked(n - 1);
			l = obj;
		}
		if ((object)l == list<T>.Nil._N_constant_object)
		{
			throw new ArgumentOutOfRangeException("NList.Nth");
		}
		throw new MatchFailureException();
	}

	public static T Last<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<T> l)
	{
		T val = default(T);
		while (true)
		{
			if ((object)l == null)
			{
				throw new ArgumentNullException("l", "The ``NotNull'' contract of parameter ``l'' has been violated. See lib\\list.n:925:31:925:32: .");
			}
			if (!(l is list<T>.Cons))
			{
				break;
			}
			if ((object)((list<T>.Cons)l).tl == list<T>.Nil._N_constant_object)
			{
				return ((list<T>.Cons)l).hd;
			}
			list<T> list = ((list<T>.Cons)l).tl;
			l = list;
		}
		if ((object)l == list<T>.Nil._N_constant_object)
		{
			throw new ArgumentException("NList.Last called for empty list");
		}
		throw new MatchFailureException();
	}

	public static list<T> Rev<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<T> l)
	{
		T val = default(T);
		if ((object)l == null)
		{
			throw new ArgumentNullException("l", "The ``NotNull'' contract of parameter ``l'' has been violated. See lib\\list.n:938:30:938:31: .");
		}
		list<T> list = list<T>.Nil._N_constant_object;
		list<T> list2 = l;
		while (list2 is list<T>.Cons)
		{
			val = ((list<T>.Cons)list2).hd;
			list2 = ((list<T>.Cons)list2).tl;
			list<T> obj = new list<T>.Cons(val, list);
			list2 = list2;
			list = obj;
		}
		if ((object)list2 == list<T>.Nil._N_constant_object)
		{
			return list;
		}
		throw new MatchFailureException();
	}

	public static list<T> Append<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<T> x, list<T> y)
	{
		if ((object)x == null)
		{
			throw new ArgumentNullException("x", "The ``NotNull'' contract of parameter ``x'' has been violated. See lib\\list.n:953:33:953:34: .");
		}
		return RevAppend(Rev(x), y);
	}

	public static list<T> RevAppend<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<T> x, list<T> y)
	{
		T val = default(T);
		while (true)
		{
			if ((object)x == null)
			{
				throw new ArgumentNullException("x", "The ``NotNull'' contract of parameter ``x'' has been violated. See lib\\list.n:961:36:961:37: .");
			}
			if (!(x is list<T>.Cons))
			{
				break;
			}
			val = ((list<T>.Cons)x).hd;
			list<T> list = ((list<T>.Cons)x).tl;
			list<T> obj = list;
			y = new list<T>.Cons(val, y);
			x = obj;
		}
		if ((object)x == list<T>.Nil._N_constant_object)
		{
			return y;
		}
		throw new MatchFailureException();
	}

	[Nemerle.Internal.Extension]
	public static list<T> Concat<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] this list<list<T>> l)
	{
		if ((object)l == null)
		{
			throw new ArgumentNullException("l", "The ``NotNull'' contract of parameter ``l'' has been violated. See lib\\list.n:970:37:970:38: .");
		}
		return Rev(ConcatRev(l));
	}

	public static list<T> ConcatRev<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<list<T>> l)
	{
		if ((object)l == null)
		{
			throw new ArgumentNullException("l", "The ``NotNull'' contract of parameter ``l'' has been violated. See lib\\list.n:976:35:976:36: .");
		}
		list<T>.Nil n_constant_object = list<T>.Nil._N_constant_object;
		Function<list<T>, list<T>, list<T>> instance = _N__N_lambda__19842__19861<T>.Instance;
		return FoldLeft(l, n_constant_object, instance);
	}

	[Nemerle.Internal.Extension]
	public static list<T> Flatten<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] this list<list<T>> l)
	{
		if ((object)l == null)
		{
			throw new ArgumentNullException("l", "The ``NotNull'' contract of parameter ``l'' has been violated. See lib\\list.n:982:38:982:39: .");
		}
		return l.Concat();
	}

	public static list<T> Remove<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<T> l, T x)
	{
		T val = default(T);
		if ((object)l == null)
		{
			throw new ArgumentNullException("l", "The ``NotNull'' contract of parameter ``l'' has been violated. See lib\\list.n:990:33:990:34: .");
		}
		EqualityComparer<T> @default = EqualityComparer<T>.Default;
		list<T> list = list<T>.Nil._N_constant_object;
		list<T> list2 = l;
		while (true)
		{
			if ((object)list2 == list<T>.Nil._N_constant_object)
			{
				return Rev(list);
			}
			if (!(list2 is list<T>.Cons))
			{
				break;
			}
			val = ((list<T>.Cons)list2).hd;
			list2 = ((list<T>.Cons)list2).tl;
			list<T> obj = ((!@default.Equals(val, x)) ? new list<T>.Cons(val, list) : list);
			list2 = list2;
			list = obj;
		}
		throw new MatchFailureException();
	}

	public static Nemerle.Builtins.Tuple<list<T>, T> DivideLast<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<T> l)
	{
		T val = default(T);
		if ((object)l == null)
		{
			throw new ArgumentNullException("l", "The ``NotNull'' contract of parameter ``l'' has been violated. See lib\\list.n:1008:38:1008:39: .");
		}
		list<T> list = l;
		list<T> list2 = list<T>.Nil._N_constant_object;
		while (list is list<T>.Cons)
		{
			if ((object)((list<T>.Cons)list).tl == list<T>.Nil._N_constant_object)
			{
				val = ((list<T>.Cons)list).hd;
				return new Nemerle.Builtins.Tuple<list<T>, T>(Rev(list2), val);
			}
			val = ((list<T>.Cons)list).hd;
			list = ((list<T>.Cons)list).tl;
			list<T> obj = list;
			list2 = new list<T>.Cons(val, list2);
			list = obj;
		}
		throw new ArgumentException("NList.DivideLast called for empty list");
	}

	public static void Iter<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<T> l, FunctionVoid<T> f)
	{
		T val = default(T);
		while (true)
		{
			if ((object)l == null)
			{
				throw new ArgumentNullException("l", "The ``NotNull'' contract of parameter ``l'' has been violated. See lib\\list.n:1025:31:1025:32: .");
			}
			if (!(l is list<T>.Cons))
			{
				break;
			}
			val = ((list<T>.Cons)l).hd;
			list<T> list = ((list<T>.Cons)l).tl;
			f.apply_void(val);
			list<T> obj = list;
			f = f;
			l = obj;
		}
		if ((object)l == list<T>.Nil._N_constant_object)
		{
			return;
		}
		throw new MatchFailureException();
	}

	public static list<TOut> MapFiltered<T, TOut>(list<T> lst, Function<T, bool> predicate, Function<T, TOut> convert)
	{
		list<TOut>.Cons cons = null;
		T val = default(T);
		list<TOut>.Cons cons2 = null;
		cons = null;
		cons2 = null;
		list<T> list = lst;
		while (list is list<T>.Cons)
		{
			val = ((list<T>.Cons)list).hd;
			list = ((list<T>.Cons)list).tl;
			val = val;
			if (predicate.apply(val))
			{
				list<TOut>.Cons cons3 = new list<TOut>.Cons(convert.apply(val), list<TOut>.Nil._N_constant_object);
				if (cons == null)
				{
					cons = cons3;
					cons2 = cons3;
				}
				else
				{
					cons2.tl = cons3;
					cons2 = cons3;
				}
			}
			list = list;
		}
		return (!(cons == null)) ? ((list<TOut>)cons) : ((list<TOut>)list<TOut>.Nil._N_constant_object);
	}

	public static list<TOut> Map<T, TOut>(list<T> lst, Function<T, TOut> convert)
	{
		list<TOut>.Cons cons = null;
		list<TOut>.Cons cons2 = null;
		T val = default(T);
		cons = null;
		cons2 = null;
		list<T> list = lst;
		while (list is list<T>.Cons)
		{
			val = ((list<T>.Cons)list).hd;
			list = ((list<T>.Cons)list).tl;
			list<TOut>.Cons cons3 = new list<TOut>.Cons(convert.apply(val), list<TOut>.Nil._N_constant_object);
			if (cons == null)
			{
				cons = cons3;
				cons2 = cons3;
			}
			else
			{
				cons2.tl = cons3;
				cons2 = cons3;
			}
			list = list;
		}
		return (!(cons == null)) ? ((list<TOut>)cons) : ((list<TOut>)list<TOut>.Nil._N_constant_object);
	}

	public static list<TOut> RevMap<T, TOut>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<T> l, Function<T, TOut> convert)
	{
		T val = default(T);
		if ((object)l == null)
		{
			throw new ArgumentNullException("l", "The ``NotNull'' contract of parameter ``l'' has been violated. See lib\\list.n:1042:39:1042:40: .");
		}
		list<TOut> list = list<TOut>.Nil._N_constant_object;
		list<T> list2 = l;
		while (list2 is list<T>.Cons)
		{
			val = ((list<T>.Cons)list2).hd;
			list2 = ((list<T>.Cons)list2).tl;
			list<TOut> obj = new list<TOut>.Cons(convert.apply(val), list);
			list2 = list2;
			list = obj;
		}
		if ((object)list2 == list<T>.Nil._N_constant_object)
		{
			return list;
		}
		throw new MatchFailureException();
	}

	public static list<TOut> RevMapFiltered<T, TOut>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<T> l, Function<T, bool> predicate, Function<T, TOut> convert)
	{
		T val = default(T);
		if ((object)l == null)
		{
			throw new ArgumentNullException("l", "The ``NotNull'' contract of parameter ``l'' has been violated. See lib\\list.n:1056:47:1056:48: .");
		}
		list<TOut> list = list<TOut>.Nil._N_constant_object;
		list<T> list2 = l;
		while (list2 is list<T>.Cons)
		{
			val = ((list<T>.Cons)list2).hd;
			list2 = ((list<T>.Cons)list2).tl;
			if (predicate.apply(val))
			{
				list<TOut> obj = new list<TOut>.Cons(convert.apply(val), list);
				list2 = list2;
				list = obj;
			}
			else
			{
				list<TOut> obj2 = list;
				list2 = list2;
				list = obj2;
			}
		}
		if ((object)list2 == list<T>.Nil._N_constant_object)
		{
			return list;
		}
		throw new MatchFailureException();
	}

	public static TOut FoldLeft<T, TOut>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<T> l, TOut acc, Function<T, TOut, TOut> f)
	{
		T val = default(T);
		if ((object)l == null)
		{
			throw new ArgumentNullException("l", "The ``NotNull'' contract of parameter ``l'' has been violated. See lib\\list.n:1066:41:1066:42: .");
		}
		list<T> list = l;
		while (true)
		{
			if ((object)list == list<T>.Nil._N_constant_object)
			{
				return acc;
			}
			if (!(list is list<T>.Cons))
			{
				break;
			}
			val = ((list<T>.Cons)list).hd;
			list = ((list<T>.Cons)list).tl;
			acc = f.apply(val, acc);
			list = list;
		}
		throw new MatchFailureException();
	}

	public static TOut FoldRight<T, TOut>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<T> l, TOut acc, Function<T, TOut, TOut> f)
	{
		T val = default(T);
		if ((object)l == null)
		{
			throw new ArgumentNullException("l", "The ``NotNull'' contract of parameter ``l'' has been violated. See lib\\list.n:1076:42:1076:43: .");
		}
		TOut result;
		if ((object)l == list<T>.Nil._N_constant_object)
		{
			result = acc;
		}
		else
		{
			if (!(l is list<T>.Cons))
			{
				throw new MatchFailureException();
			}
			val = ((list<T>.Cons)l).hd;
			list<T> l2 = ((list<T>.Cons)l).tl;
			result = f.apply(val, FoldRight(l2, acc, f));
		}
		return result;
	}

	public static list<TOut> MapFromArray<T, TOut>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] T[] x, Function<T, TOut> f)
	{
		int num = 0;
		list<TOut>.Cons cons = null;
		list<TOut>.Cons cons2 = null;
		T val = default(T);
		if (x == null)
		{
			throw new ArgumentNullException("x", "The ``NotNull'' contract of parameter ``x'' has been violated. See lib\\list.n:1083:45:1083:46: .");
		}
		cons = null;
		cons2 = null;
		for (num = 0; num < x.Length; num = checked(num + 1))
		{
			val = x[num];
			list<TOut>.Cons cons3 = new list<TOut>.Cons(f.apply(val), list<TOut>.Nil._N_constant_object);
			if (cons == null)
			{
				cons = cons3;
				cons2 = cons3;
			}
			else
			{
				cons2.tl = cons3;
				cons2 = cons3;
			}
		}
		return (!(cons == null)) ? ((list<TOut>)cons) : ((list<TOut>)list<TOut>.Nil._N_constant_object);
	}

	public static void Iter2<T, TOut>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<T> a, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<TOut> b, FunctionVoid<T, TOut> f)
	{
		T val = default(T);
		TOut val2 = default(TOut);
		while (true)
		{
			if ((object)b == null)
			{
				throw new ArgumentNullException("b", "The ``NotNull'' contract of parameter ``b'' has been violated. See lib\\list.n:1090:62:1090:63: .");
			}
			if ((object)a == null)
			{
				throw new ArgumentNullException("a", "The ``NotNull'' contract of parameter ``a'' has been violated. See lib\\list.n:1090:38:1090:39: .");
			}
			if ((object)a == list<T>.Nil._N_constant_object)
			{
				if ((object)b != list<TOut>.Nil._N_constant_object)
				{
					break;
				}
				return;
			}
			if (a is list<T>.Cons && b is list<TOut>.Cons)
			{
				val = ((list<T>.Cons)a).hd;
				list<T> list = ((list<T>.Cons)a).tl;
				val2 = ((list<TOut>.Cons)b).hd;
				list<TOut> list2 = ((list<TOut>.Cons)b).tl;
				f.apply_void(new Nemerle.Builtins.Tuple<T, TOut>(val, val2));
				list<T> obj = list;
				list<TOut> obj2 = list2;
				f = f;
				b = obj2;
				a = obj;
				continue;
			}
			break;
		}
		throw new ArgumentException("NList.Iter2");
	}

	public static list<TOut> Map2<T, TSecond, TOut>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<T> x, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<TSecond> y, Function<T, TSecond, TOut> f)
	{
		T val = default(T);
		TSecond val2 = default(TSecond);
		if ((object)y == null)
		{
			throw new ArgumentNullException("y", "The ``NotNull'' contract of parameter ``y'' has been violated. See lib\\list.n:1098:70:1098:71: .");
		}
		if ((object)x == null)
		{
			throw new ArgumentNullException("x", "The ``NotNull'' contract of parameter ``x'' has been violated. See lib\\list.n:1098:46:1098:47: .");
		}
		object result;
		if ((object)x == list<T>.Nil._N_constant_object)
		{
			if ((object)y != list<TSecond>.Nil._N_constant_object)
			{
				goto IL_0066;
			}
			result = list<TOut>.Nil._N_constant_object;
		}
		else
		{
			if (!(x is list<T>.Cons) || !(y is list<TSecond>.Cons))
			{
				goto IL_0066;
			}
			val = ((list<T>.Cons)x).hd;
			list<T> x2 = ((list<T>.Cons)x).tl;
			val2 = ((list<TSecond>.Cons)y).hd;
			list<TSecond> y2 = ((list<TSecond>.Cons)y).tl;
			result = new list<TOut>.Cons(f.apply(val, val2), Map2(x2, y2, f));
		}
		return (list<TOut>)result;
		IL_0066:
		throw new ArgumentException("NList.Map2");
	}

	public static list<TOut> RevMap2<T, TSecond, TOut>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<T> x, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<TSecond> y, Function<T, TSecond, TOut> f)
	{
		TSecond val = default(TSecond);
		T val2 = default(T);
		if ((object)y == null)
		{
			throw new ArgumentNullException("y", "The ``NotNull'' contract of parameter ``y'' has been violated. See lib\\list.n:1106:73:1106:74: .");
		}
		if ((object)x == null)
		{
			throw new ArgumentNullException("x", "The ``NotNull'' contract of parameter ``x'' has been violated. See lib\\list.n:1106:49:1106:50: .");
		}
		list<TOut> list = list<TOut>.Nil._N_constant_object;
		list<T> list2 = x;
		list<TSecond> list3 = y;
		while (true)
		{
			if ((object)list2 == list<T>.Nil._N_constant_object)
			{
				if ((object)list3 != list<TSecond>.Nil._N_constant_object)
				{
					break;
				}
				return list;
			}
			if (list2 is list<T>.Cons && list3 is list<TSecond>.Cons)
			{
				val2 = ((list<T>.Cons)list2).hd;
				list2 = ((list<T>.Cons)list2).tl;
				val = ((list<TSecond>.Cons)list3).hd;
				list3 = ((list<TSecond>.Cons)list3).tl;
				list<TOut> obj = new list<TOut>.Cons(f.apply(val2, val), list);
				list<T> obj2 = list2;
				list3 = list3;
				list2 = obj2;
				list = obj;
				continue;
			}
			break;
		}
		throw new ArgumentException("NList.RevMap2");
	}

	[Nemerle.Internal.Extension]
	public static TOut FoldLeft2<TFirst, TSecond, TOut>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] this list<TFirst> a, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<TSecond> b, TOut acc, Function<TFirst, TSecond, TOut, TOut> f)
	{
		TFirst val = default(TFirst);
		TSecond val2 = default(TSecond);
		while (true)
		{
			if ((object)b == null)
			{
				throw new ArgumentNullException("b", "The ``NotNull'' contract of parameter ``b'' has been violated. See lib\\list.n:1120:45:1120:46: .");
			}
			if ((object)a == null)
			{
				throw new ArgumentNullException("a", "The ``NotNull'' contract of parameter ``a'' has been violated. See lib\\list.n:1119:61:1119:62: .");
			}
			if ((object)a == list<TFirst>.Nil._N_constant_object)
			{
				if ((object)b != list<TSecond>.Nil._N_constant_object)
				{
					break;
				}
				return acc;
			}
			if (a is list<TFirst>.Cons && b is list<TSecond>.Cons)
			{
				val = ((list<TFirst>.Cons)a).hd;
				list<TFirst> list = ((list<TFirst>.Cons)a).tl;
				val2 = ((list<TSecond>.Cons)b).hd;
				list<TSecond> list2 = ((list<TSecond>.Cons)b).tl;
				list<TFirst> obj = list;
				list<TSecond> obj2 = list2;
				TOut val3 = f.apply(val, val2, acc);
				f = f;
				acc = val3;
				b = obj2;
				a = obj;
				continue;
			}
			break;
		}
		throw new ArgumentException("NList.FoldLeft2");
	}

	[Nemerle.Internal.Extension]
	public static TOut FoldRight2<TFirst, TSecond, TOut>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] this list<TFirst> a, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<TSecond> b, TOut c, Function<TFirst, TSecond, TOut, TOut> f)
	{
		TFirst val = default(TFirst);
		TSecond val2 = default(TSecond);
		if ((object)b == null)
		{
			throw new ArgumentNullException("b", "The ``NotNull'' contract of parameter ``b'' has been violated. See lib\\list.n:1132:47:1132:48: .");
		}
		if ((object)a == null)
		{
			throw new ArgumentNullException("a", "The ``NotNull'' contract of parameter ``a'' has been violated. See lib\\list.n:1131:62:1131:63: .");
		}
		TOut result;
		if ((object)a == list<TFirst>.Nil._N_constant_object)
		{
			if ((object)b != list<TSecond>.Nil._N_constant_object)
			{
				goto IL_0062;
			}
			result = c;
		}
		else
		{
			if (!(a is list<TFirst>.Cons) || !(b is list<TSecond>.Cons))
			{
				goto IL_0062;
			}
			val = ((list<TFirst>.Cons)a).hd;
			list<TFirst> a2 = ((list<TFirst>.Cons)a).tl;
			val2 = ((list<TSecond>.Cons)b).hd;
			list<TSecond> b2 = ((list<TSecond>.Cons)b).tl;
			result = f.apply(val, val2, a2.FoldRight2(b2, c, f));
		}
		return result;
		IL_0062:
		throw new ArgumentException("NList.FoldRight2");
	}

	public static bool ForAll<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<T> lst, Function<T, bool> predicate)
	{
		T val = default(T);
		int result;
		while (true)
		{
			if ((object)lst == null)
			{
				throw new ArgumentNullException("lst", "The ``NotNull'' contract of parameter ``lst'' has been violated. See lib\\list.n:1156:33:1156:36: .");
			}
			if (lst is list<T>.Cons)
			{
				val = ((list<T>.Cons)lst).hd;
				list<T> list = ((list<T>.Cons)lst).tl;
				if (predicate.apply(val))
				{
					list<T> obj = list;
					predicate = predicate;
					lst = obj;
					continue;
				}
				result = 0;
				break;
			}
			if ((object)lst == list<T>.Nil._N_constant_object)
			{
				result = 1;
				break;
			}
			throw new MatchFailureException();
		}
		return (byte)result != 0;
	}

	public static bool Equals<T1, TSecond>(list<T1> lst1, list<TSecond> lst2, Function<T1, TSecond, bool> compare)
	{
		T1 val = default(T1);
		TSecond val2 = default(TSecond);
		int result;
		while (true)
		{
			if (lst1 is list<T1>.Cons)
			{
				if (lst2 is list<TSecond>.Cons)
				{
					val = ((list<T1>.Cons)lst1).hd;
					list<T1> list = ((list<T1>.Cons)lst1).tl;
					val2 = ((list<TSecond>.Cons)lst2).hd;
					list<TSecond> list2 = ((list<TSecond>.Cons)lst2).tl;
					if (compare.apply(val, val2))
					{
						list<T1> obj = list;
						list<TSecond> obj2 = list2;
						compare = compare;
						lst2 = obj2;
						lst1 = obj;
						continue;
					}
					result = 0;
					break;
				}
			}
			else if ((object)lst1 == list<T1>.Nil._N_constant_object && (object)lst2 == list<TSecond>.Nil._N_constant_object)
			{
				result = 1;
				break;
			}
			result = 0;
			break;
		}
		return (byte)result != 0;
	}

	public static bool Exists<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<T> l, Function<T, bool> f)
	{
		T val = default(T);
		int result;
		while (true)
		{
			if ((object)l == null)
			{
				throw new ArgumentNullException("l", "The ``NotNull'' contract of parameter ``l'' has been violated. See lib\\list.n:1184:33:1184:34: .");
			}
			if ((object)l == list<T>.Nil._N_constant_object)
			{
				result = 0;
				break;
			}
			if (l is list<T>.Cons)
			{
				val = ((list<T>.Cons)l).hd;
				list<T> list = ((list<T>.Cons)l).tl;
				if (f.apply(val))
				{
					result = 1;
					break;
				}
				list<T> obj = list;
				f = f;
				l = obj;
				continue;
			}
			throw new MatchFailureException();
		}
		return (byte)result != 0;
	}

	public static bool ForAll2<T, TSecond>(list<T> a, list<TSecond> b, Function<T, TSecond, bool> f)
	{
		T val = default(T);
		TSecond val2 = default(TSecond);
		int result;
		while (true)
		{
			if ((object)a == list<T>.Nil._N_constant_object)
			{
				if ((object)b == list<TSecond>.Nil._N_constant_object)
				{
					result = 1;
					break;
				}
			}
			else if (a is list<T>.Cons && b is list<TSecond>.Cons)
			{
				val = ((list<T>.Cons)a).hd;
				list<T> list = ((list<T>.Cons)a).tl;
				val2 = ((list<TSecond>.Cons)b).hd;
				list<TSecond> list2 = ((list<TSecond>.Cons)b).tl;
				if (f.apply(val, val2))
				{
					list<T> obj = list;
					list<TSecond> obj2 = list2;
					f = f;
					b = obj2;
					a = obj;
					continue;
				}
				result = 0;
				break;
			}
			result = 0;
			break;
		}
		return (byte)result != 0;
	}

	public static bool Exists2<T, TSecond>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<T> a, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<TSecond> b, Function<T, TSecond, bool> f)
	{
		T val = default(T);
		TSecond val2 = default(TSecond);
		int result;
		while (true)
		{
			if ((object)b == null)
			{
				throw new ArgumentNullException("b", "The ``NotNull'' contract of parameter ``b'' has been violated. See lib\\list.n:1201:67:1201:68: .");
			}
			if ((object)a == null)
			{
				throw new ArgumentNullException("a", "The ``NotNull'' contract of parameter ``a'' has been violated. See lib\\list.n:1201:43:1201:44: .");
			}
			if ((object)a == list<T>.Nil._N_constant_object)
			{
				if ((object)b == list<TSecond>.Nil._N_constant_object)
				{
					result = 0;
					break;
				}
			}
			else if (a is list<T>.Cons && b is list<TSecond>.Cons)
			{
				val = ((list<T>.Cons)a).hd;
				list<T> list = ((list<T>.Cons)a).tl;
				val2 = ((list<TSecond>.Cons)b).hd;
				list<TSecond> list2 = ((list<TSecond>.Cons)b).tl;
				if (f.apply(val, val2))
				{
					result = 1;
					break;
				}
				list<T> obj = list;
				list<TSecond> obj2 = list2;
				f = f;
				b = obj2;
				a = obj;
				continue;
			}
			throw new ArgumentException("NList.Exists2");
		}
		return (byte)result != 0;
	}

	public static bool Member<T>(list<T> l, T a)
	{
		T val = default(T);
		EqualityComparer<T> @default = EqualityComparer<T>.Default;
		list<T> list = l;
		int result;
		while (true)
		{
			if (list is list<T>.Cons)
			{
				val = ((list<T>.Cons)list).hd;
				if (@default.Equals(val, a))
				{
					result = 1;
					break;
				}
				list = ((list<T>.Cons)list).tl;
				list = list;
				continue;
			}
			result = 0;
			break;
		}
		return (byte)result != 0;
	}

	public static bool ContainsRef<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<T> Collection, T Obj) where T : class
	{
		T val = null;
		int result;
		while (true)
		{
			if ((object)Collection == null)
			{
				throw new ArgumentNullException("Collection", "The ``NotNull'' contract of parameter ``Collection'' has been violated. See lib\\list.n:1229:39:1229:49: .");
			}
			if (Collection is list<T>.Cons)
			{
				val = ((list<T>.Cons)Collection).hd;
				list<T> list = ((list<T>.Cons)Collection).tl;
				if (val == Obj)
				{
					result = 1;
					break;
				}
				list<T> obj = list;
				Obj = Obj;
				Collection = obj;
				continue;
			}
			if ((object)Collection == list<T>.Nil._N_constant_object)
			{
				result = 0;
				break;
			}
			throw new MatchFailureException();
		}
		return (byte)result != 0;
	}

	public static bool Contains<T>(list<T> l, T a)
	{
		return Member(l, a);
	}

	public static option<T> Find<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<T> l, Function<T, bool> pred)
	{
		T val = default(T);
		object result;
		while (true)
		{
			if ((object)l == null)
			{
				throw new ArgumentNullException("l", "The ``NotNull'' contract of parameter ``l'' has been violated. See lib\\list.n:1255:32:1255:33: .");
			}
			if (l is list<T>.Cons)
			{
				val = ((list<T>.Cons)l).hd;
				list<T> list = ((list<T>.Cons)l).tl;
				if (pred.apply(val))
				{
					result = new option<T>.Some(val);
					break;
				}
				list<T> obj = list;
				pred = pred;
				l = obj;
				continue;
			}
			if ((object)l == list<T>.Nil._N_constant_object)
			{
				result = option<T>.None._N_constant_object;
				break;
			}
			throw new MatchFailureException();
		}
		return (option<T>)result;
	}

	public static int FilteredLength<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<T> l, Function<T, bool> f)
	{
		T val = default(T);
		if ((object)l == null)
		{
			throw new ArgumentNullException("l", "The ``NotNull'' contract of parameter ``l'' has been violated. See lib\\list.n:1269:42:1269:43: .");
		}
		list<T> list = l;
		int num = 0;
		while (true)
		{
			if ((object)list == list<T>.Nil._N_constant_object)
			{
				return num;
			}
			if (!(list is list<T>.Cons))
			{
				break;
			}
			val = ((list<T>.Cons)list).hd;
			list = ((list<T>.Cons)list).tl;
			list<T> obj = list;
			num = ((!f.apply(val)) ? num : checked(num + 1));
			list = obj;
		}
		throw new MatchFailureException();
	}

	public static list<T> Filter<T>(list<T> l, Function<T, bool> f)
	{
		list<T>.Cons cons = null;
		T val = default(T);
		list<T>.Cons cons2 = null;
		cons = null;
		cons2 = null;
		list<T> list = l;
		while (list is list<T>.Cons)
		{
			val = ((list<T>.Cons)list).hd;
			list = ((list<T>.Cons)list).tl;
			val = val;
			if (f.apply(val))
			{
				list<T>.Cons cons3 = new list<T>.Cons(val, list<T>.Nil._N_constant_object);
				if (cons == null)
				{
					cons = cons3;
					cons2 = cons3;
				}
				else
				{
					cons2.tl = cons3;
					cons2 = cons3;
				}
			}
			list = list;
		}
		return (!(cons == null)) ? ((list<T>)cons) : ((list<T>)list<T>.Nil._N_constant_object);
	}

	public static list<T> RevFilter<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<T> l, Function<T, bool> f)
	{
		T val = default(T);
		if ((object)l == null)
		{
			throw new ArgumentNullException("l", "The ``NotNull'' contract of parameter ``l'' has been violated. See lib\\list.n:1297:37:1297:38: .");
		}
		list<T> list = list<T>.Nil._N_constant_object;
		list<T> list2 = l;
		while (list2 is list<T>.Cons)
		{
			val = ((list<T>.Cons)list2).hd;
			list2 = ((list<T>.Cons)list2).tl;
			if (f.apply(val))
			{
				list<T> obj = new list<T>.Cons(val, list);
				list2 = list2;
				list = obj;
			}
			else
			{
				list<T> obj2 = list;
				list2 = list2;
				list = obj2;
			}
		}
		if ((object)list2 == list<T>.Nil._N_constant_object)
		{
			return list;
		}
		throw new MatchFailureException();
	}

	public static list<T> FindAll<T>(list<T> l, Function<T, bool> f)
	{
		return Filter(l, f);
	}

	public static Nemerle.Builtins.Tuple<list<T>, list<T>> Partition<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<T> l, Function<T, bool> pred)
	{
		T val = default(T);
		if ((object)l == null)
		{
			throw new ArgumentNullException("l", "The ``NotNull'' contract of parameter ``l'' has been violated. See lib\\list.n:1325:36:1325:37: .");
		}
		list<T> list = l;
		list<T> list2 = list<T>.Nil._N_constant_object;
		list<T> list3 = list<T>.Nil._N_constant_object;
		while (list is list<T>.Cons)
		{
			val = ((list<T>.Cons)list).hd;
			list = ((list<T>.Cons)list).tl;
			if (pred.apply(val))
			{
				list<T> obj = list;
				list<T> obj2 = new list<T>.Cons(val, list2);
				list3 = list3;
				list2 = obj2;
				list = obj;
			}
			else
			{
				list<T> obj3 = list;
				list<T> obj4 = list2;
				list3 = new list<T>.Cons(val, list3);
				list2 = obj4;
				list = obj3;
			}
		}
		if ((object)list == list<T>.Nil._N_constant_object)
		{
			return new Nemerle.Builtins.Tuple<list<T>, list<T>>(Rev(list2), Rev(list3));
		}
		throw new MatchFailureException();
	}

	public static list<list<T>> Group<T>(list<T> l, Function<T, T, int> cmp)
	{
		_N_closureOf_Group_20490<T> n_closureOf_Group_ = new _N_closureOf_Group_20490<T>();
		n_closureOf_Group_._N_cmp_20495 = cmp;
		object result;
		if (IsEmpty(l))
		{
			result = list<list<T>>.Nil._N_constant_object;
		}
		else
		{
			list<T> l2 = Sort(l, n_closureOf_Group_._N_cmp_20495);
			result = _N_walk_20498(n_closureOf_Group_, Tail(l2), new list<T>.Cons(Head(l2), list<T>.Nil._N_constant_object));
		}
		return (list<list<T>>)result;
	}

	public static option<TSecond> Assoc<T, TSecond>(list<Nemerle.Builtins.Tuple<T, TSecond>> l, T key)
	{
		TSecond val = default(TSecond);
		T val2 = default(T);
		EqualityComparer<T> @default = EqualityComparer<T>.Default;
		list<Nemerle.Builtins.Tuple<T, TSecond>> list = l;
		object result;
		while (true)
		{
			if (list is list<Nemerle.Builtins.Tuple<T, TSecond>>.Cons)
			{
				val2 = ((list<Nemerle.Builtins.Tuple<T, TSecond>>.Cons)list).hd.Field0;
				val = ((list<Nemerle.Builtins.Tuple<T, TSecond>>.Cons)list).hd.Field1;
				if (@default.Equals(key, val2))
				{
					result = new option<TSecond>.Some(val);
					break;
				}
				list = ((list<Nemerle.Builtins.Tuple<T, TSecond>>.Cons)list).tl;
				list = list;
				continue;
			}
			result = option<TSecond>.None._N_constant_object;
			break;
		}
		return (option<TSecond>)result;
	}

	public static bool MemAssoc<T, TSecond>(list<Nemerle.Builtins.Tuple<T, TSecond>> l, T key)
	{
		T val = default(T);
		EqualityComparer<T> @default = EqualityComparer<T>.Default;
		list<Nemerle.Builtins.Tuple<T, TSecond>> list = l;
		int result;
		while (true)
		{
			if (list is list<Nemerle.Builtins.Tuple<T, TSecond>>.Cons)
			{
				val = ((list<Nemerle.Builtins.Tuple<T, TSecond>>.Cons)list).hd.Field0;
				if (@default.Equals(key, val))
				{
					result = 1;
					break;
				}
				list = ((list<Nemerle.Builtins.Tuple<T, TSecond>>.Cons)list).tl;
				list = list;
				continue;
			}
			result = 0;
			break;
		}
		return (byte)result != 0;
	}

	public static list<Nemerle.Builtins.Tuple<T, TSecond>> RemoveAssoc<T, TSecond>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<Nemerle.Builtins.Tuple<T, TSecond>> l, T key)
	{
		T val = default(T);
		TSecond val2 = default(TSecond);
		if ((object)l == null)
		{
			throw new ArgumentNullException("l", "The ``NotNull'' contract of parameter ``l'' has been violated. See lib\\list.n:1396:48:1396:49: .");
		}
		EqualityComparer<T> @default = EqualityComparer<T>.Default;
		list<Nemerle.Builtins.Tuple<T, TSecond>> list = list<Nemerle.Builtins.Tuple<T, TSecond>>.Nil._N_constant_object;
		list<Nemerle.Builtins.Tuple<T, TSecond>> list2 = l;
		while (list2 is list<Nemerle.Builtins.Tuple<T, TSecond>>.Cons)
		{
			val = ((list<Nemerle.Builtins.Tuple<T, TSecond>>.Cons)list2).hd.Field0;
			val2 = ((list<Nemerle.Builtins.Tuple<T, TSecond>>.Cons)list2).hd.Field1;
			list2 = ((list<Nemerle.Builtins.Tuple<T, TSecond>>.Cons)list2).tl;
			if (@default.Equals(key, val))
			{
				list<Nemerle.Builtins.Tuple<T, TSecond>> obj = list;
				list2 = list2;
				list = obj;
			}
			else
			{
				list<Nemerle.Builtins.Tuple<T, TSecond>> obj2 = new list<Nemerle.Builtins.Tuple<T, TSecond>>.Cons(new Nemerle.Builtins.Tuple<T, TSecond>(val, val2), list);
				list2 = list2;
				list = obj2;
			}
		}
		if ((object)list2 == list<Nemerle.Builtins.Tuple<T, TSecond>>.Nil._N_constant_object)
		{
			return Rev(list);
		}
		throw new MatchFailureException();
	}

	[Nemerle.Internal.Extension]
	public static Nemerle.Builtins.Tuple<list<T>, list<TSecond>> Split<T, TSecond>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] this list<Nemerle.Builtins.Tuple<T, TSecond>> l)
	{
		TSecond val = default(TSecond);
		T val2 = default(T);
		if ((object)l == null)
		{
			throw new ArgumentNullException("l", "The ``NotNull'' contract of parameter ``l'' has been violated. See lib\\list.n:1417:46:1417:47: .");
		}
		list<T> list = list<T>.Nil._N_constant_object;
		list<TSecond> list2 = list<TSecond>.Nil._N_constant_object;
		list<Nemerle.Builtins.Tuple<T, TSecond>> list3 = l;
		while (list3 is list<Nemerle.Builtins.Tuple<T, TSecond>>.Cons)
		{
			val2 = ((list<Nemerle.Builtins.Tuple<T, TSecond>>.Cons)list3).hd.Field0;
			val = ((list<Nemerle.Builtins.Tuple<T, TSecond>>.Cons)list3).hd.Field1;
			list3 = ((list<Nemerle.Builtins.Tuple<T, TSecond>>.Cons)list3).tl;
			list<T> obj = new list<T>.Cons(val2, list);
			list<TSecond> obj2 = new list<TSecond>.Cons(val, list2);
			list3 = list3;
			list2 = obj2;
			list = obj;
		}
		if ((object)list3 == list<Nemerle.Builtins.Tuple<T, TSecond>>.Nil._N_constant_object)
		{
			return new Nemerle.Builtins.Tuple<list<T>, list<TSecond>>(Rev(list), Rev(list2));
		}
		throw new MatchFailureException();
	}

	[Nemerle.Internal.Extension]
	public static list<Nemerle.Builtins.Tuple<T, TSecond>> Combine<T, TSecond>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] this list<T> a, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<TSecond> b)
	{
		TSecond val = default(TSecond);
		T val2 = default(T);
		if ((object)b == null)
		{
			throw new ArgumentNullException("b", "The ``NotNull'' contract of parameter ``b'' has been violated. See lib\\list.n:1428:73:1428:74: .");
		}
		if ((object)a == null)
		{
			throw new ArgumentNullException("a", "The ``NotNull'' contract of parameter ``a'' has been violated. See lib\\list.n:1428:49:1428:50: .");
		}
		list<Nemerle.Builtins.Tuple<T, TSecond>> list = list<Nemerle.Builtins.Tuple<T, TSecond>>.Nil._N_constant_object;
		list<T> list2 = a;
		list<TSecond> list3 = b;
		while (true)
		{
			if (list2 is list<T>.Cons)
			{
				if (list3 is list<TSecond>.Cons)
				{
					val2 = ((list<T>.Cons)list2).hd;
					list2 = ((list<T>.Cons)list2).tl;
					val = ((list<TSecond>.Cons)list3).hd;
					list3 = ((list<TSecond>.Cons)list3).tl;
					list<Nemerle.Builtins.Tuple<T, TSecond>> obj = new list<Nemerle.Builtins.Tuple<T, TSecond>>.Cons(new Nemerle.Builtins.Tuple<T, TSecond>(val2, val), list);
					list<T> obj2 = list2;
					list3 = list3;
					list2 = obj2;
					list = obj;
					continue;
				}
			}
			else if ((object)list2 == list<T>.Nil._N_constant_object && (object)list3 == list<TSecond>.Nil._N_constant_object)
			{
				break;
			}
			throw new ArgumentException("NList.Combine");
		}
		return Rev(list);
	}

	private static list<T> MergeSort<T>(Function<T, T, int> cmp, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<T> l)
	{
		T val = default(T);
		T val2 = default(T);
		if ((object)l == null)
		{
			throw new ArgumentNullException("l", "The ``NotNull'' contract of parameter ``l'' has been violated. See lib\\list.n:1442:51:1442:52: .");
		}
		list<T> result;
		if ((object)l == list<T>.Nil._N_constant_object || (l is list<T>.Cons && (object)((list<T>.Cons)l).tl == list<T>.Nil._N_constant_object))
		{
			result = l;
		}
		else
		{
			list<T> list = l;
			list<T> list2 = list<T>.Nil._N_constant_object;
			int num = Length(l) / 2;
			while (num != 0)
			{
				if (list is list<T>.Cons)
				{
					val = ((list<T>.Cons)list).hd;
					list = ((list<T>.Cons)list).tl;
					list<T> obj = list;
					list<T> obj2 = new list<T>.Cons(val, list2);
					num = checked(num - 1);
					list2 = obj2;
					list = obj;
					continue;
				}
				if ((object)list == list<T>.Nil._N_constant_object)
				{
					list<T> obj3 = list;
					list<T> obj4 = list2;
					num = 0;
					list2 = obj4;
					list = obj3;
					continue;
				}
				throw new MatchFailureException();
			}
			Nemerle.Builtins.Tuple<list<T>, list<T>> tuple = new Nemerle.Builtins.Tuple<list<T>, list<T>>(Rev(list2), list);
			list = tuple.Field0;
			list2 = tuple.Field1;
			list = MergeSort(cmp, list);
			list2 = MergeSort(cmp, list2);
			list = list;
			list2 = list2;
			list<T> list3 = list<T>.Nil._N_constant_object;
			while (true)
			{
				if ((object)list == list<T>.Nil._N_constant_object)
				{
					result = RevAppend(list3, list2);
					break;
				}
				if ((object)list2 == list<T>.Nil._N_constant_object)
				{
					result = RevAppend(list3, list);
					break;
				}
				if (list is list<T>.Cons)
				{
					if (list2 is list<T>.Cons)
					{
						val = ((list<T>.Cons)list).hd;
						list<T> list4 = ((list<T>.Cons)list).tl;
						val2 = ((list<T>.Cons)list2).hd;
						list<T> list5 = ((list<T>.Cons)list2).tl;
						if (cmp.apply(val, val2) <= 0)
						{
							list<T> obj5 = list4;
							list<T> obj6 = list2;
							list3 = new list<T>.Cons(val, list3);
							list2 = obj6;
							list = obj5;
						}
						else
						{
							list<T> obj7 = list;
							list<T> obj8 = list5;
							list3 = new list<T>.Cons(val2, list3);
							list2 = obj8;
							list = obj7;
						}
						continue;
					}
					throw new MatchFailureException();
				}
				throw new MatchFailureException();
			}
		}
		return result;
	}

	public static list<T> Sort<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<T> l, Function<T, T, int> cmp)
	{
		if ((object)l == null)
		{
			throw new ArgumentNullException("l", "The ``NotNull'' contract of parameter ``l'' has been violated. See lib\\list.n:1479:31:1479:32: .");
		}
		return MergeSort(cmp, l);
	}

	public static list<T> Copy<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<T> l)
	{
		T val = default(T);
		if ((object)l == null)
		{
			throw new ArgumentNullException("l", "The ``NotNull'' contract of parameter ``l'' has been violated. See lib\\list.n:1485:31:1485:32: .");
		}
		list<T> list = list<T>.Nil._N_constant_object;
		list<T> list2 = l;
		while (list2 is list<T>.Cons)
		{
			val = ((list<T>.Cons)list2).hd;
			list2 = ((list<T>.Cons)list2).tl;
			list<T> obj = new list<T>.Cons(val, list);
			list2 = list2;
			list = obj;
		}
		if ((object)list2 == list<T>.Nil._N_constant_object)
		{
			return Rev(list);
		}
		throw new MatchFailureException();
	}

	private static list<list<T>> Product<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<T> x, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<list<T>> prod)
	{
		if ((object)prod == null)
		{
			throw new ArgumentNullException("prod", "The ``NotNull'' contract of parameter ``prod'' has been violated. See lib\\list.n:1503:20:1503:24: .");
		}
		if ((object)x == null)
		{
			throw new ArgumentNullException("x", "The ``NotNull'' contract of parameter ``x'' has been violated. See lib\\list.n:1502:20:1502:21: .");
		}
		list<T> list = x;
		list<list<T>> list2 = prod;
		list<list<T>> list3 = list<list<T>>.Nil._N_constant_object;
		while (true)
		{
			if ((object)list2 == list<list<T>>.Nil._N_constant_object)
			{
				return list3;
			}
			if (!(list2 is list<list<T>>.Cons))
			{
				break;
			}
			list<T> lst = ((list<list<T>>.Cons)list2).hd;
			list2 = ((list<list<T>>.Cons)list2).tl;
			list<T> obj = list;
			list<list<T>> obj2 = list2;
			list3 = _N_extend_20735(list, lst, list<list<T>>.Nil._N_constant_object) + list3;
			list2 = obj2;
			list = obj;
		}
		throw new MatchFailureException();
	}

	[Nemerle.Internal.Extension]
	public static list<list<T>> Product<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] this list<list<T>> list)
	{
		if ((object)list == null)
		{
			throw new ArgumentNullException("list", "The ``NotNull'' contract of parameter ``list'' has been violated. See lib\\list.n:1544:25:1544:29: .");
		}
		object obj;
		list<list<T>> list3;
		if ((object)list == list<list<T>>.Nil._N_constant_object)
		{
			obj = list<list<T>>.Nil._N_constant_object;
		}
		else
		{
			if (!(list is list<list<T>>.Cons))
			{
				throw new MatchFailureException();
			}
			list<T> list2 = ((list<list<T>>.Cons)list).hd;
			list3 = ((list<list<T>>.Cons)list).tl;
			list3 = list3;
			list<T> lst = list2;
			Function<T, list<T>> instance = _N__N_lambda__20758__20771<T>.Instance;
			list<list<T>> list4 = Map(lst, instance);
			while ((object)list3 != list<list<T>>.Nil._N_constant_object)
			{
				if (list3 is list<list<T>>.Cons)
				{
					list2 = ((list<list<T>>.Cons)list3).hd;
					list3 = ((list<list<T>>.Cons)list3).tl;
					list<list<T>> obj2 = list3;
					list4 = Product(list2, list4);
					list3 = obj2;
					continue;
				}
				throw new MatchFailureException();
			}
			obj = list4;
		}
		list3 = (list<list<T>>)obj;
		return Map(list3, _N_static_proxy_20785<T>.single_instance);
	}

	public static list<list<list<T>>> SubsetsPartitions<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<T> set, int count)
	{
		T val = default(T);
		_N_closureOf_SubsetsPartitions_20831<T> n_SubsetsPartitions_cp_ = new _N_closureOf_SubsetsPartitions_20831<T>();
		if ((object)set == null)
		{
			throw new ArgumentNullException("set", "The ``NotNull'' contract of parameter ``set'' has been violated. See lib\\list.n:1571:20:1571:23: .");
		}
		list<T> list = set;
		list<list<T>> list2 = list<list<T>>.Nil._N_constant_object;
		int num = count;
		while (num != 0)
		{
			list<list<T>> obj = new list<list<T>>.Cons(list<T>.Nil._N_constant_object, list2);
			num = checked(num - 1);
			list2 = obj;
		}
		list<list<T>> hd = list2;
		list<list<list<T>>> list3 = new list<list<list<T>>>.Cons(hd, list<list<list<T>>>.Nil._N_constant_object);
		while (true)
		{
			if ((object)list == list<T>.Nil._N_constant_object)
			{
				return list3;
			}
			if (!(list is list<T>.Cons))
			{
				break;
			}
			val = ((list<T>.Cons)list).hd;
			list = ((list<T>.Cons)list).tl;
			list<T> obj2 = list;
			list3 = _N_extend_20848(n_SubsetsPartitions_cp_, val, list3, list<list<list<T>>>.Nil._N_constant_object);
			list = obj2;
		}
		throw new MatchFailureException();
	}

	public static list<list<T>> Singletons<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<T> list)
	{
		if ((object)list == null)
		{
			throw new ArgumentNullException("list", "The ``NotNull'' contract of parameter ``list'' has been violated. See lib\\list.n:1620:38:1620:42: .");
		}
		Function<T, list<T>> instance = _N__N_lambda__20873__20882<T>.Instance;
		return RevMap(list, instance);
	}

	public static list<list<T>> SizeSubsets<T>(list<T> list, int n)
	{
		T val = default(T);
		object result;
		if (n == 0)
		{
			result = list<list<T>>.Nil._N_constant_object;
		}
		else if ((object)list == list<T>.Nil._N_constant_object)
		{
			result = list<list<T>>.Nil._N_constant_object;
		}
		else if (n == 1)
		{
			result = Singletons(list);
		}
		else
		{
			if (!(list is list<T>.Cons))
			{
				throw new MatchFailureException();
			}
			val = ((list<T>.Cons)list).hd;
			list<T> list2 = ((list<T>.Cons)list).tl;
			val = val;
			list<list<T>> list3 = SizeSubsets(list2, checked(n - 1));
			list<list<T>> list4 = list<list<T>>.Nil._N_constant_object;
			while ((object)list3 != list<list<T>>.Nil._N_constant_object)
			{
				if (list3 is list<list<T>>.Cons)
				{
					list<T> tl = ((list<list<T>>.Cons)list3).hd;
					list3 = ((list<list<T>>.Cons)list3).tl;
					T val2 = val;
					list<list<T>> obj = list3;
					list4 = new list<list<T>>.Cons(new list<T>.Cons(val, tl), list4);
					list3 = obj;
					val = val2;
					continue;
				}
				throw new MatchFailureException();
			}
			list<list<T>> x = list4;
			result = RevAppend(x, SizeSubsets(list2, n));
		}
		return (list<list<T>>)result;
	}

	public static list<T> Repeat<T>(T elem, int count)
	{
		list<T> list = list<T>.Nil._N_constant_object;
		int num = count;
		while (num > 0)
		{
			list<T> obj = new list<T>.Cons(elem, list);
			num = checked(num - 1);
			list = obj;
		}
		return list;
	}

	public static list<int> Range(int end)
	{
		return Range(0, end);
	}

	public static list<int> Range(int beg, int end, int step = 1)
	{
		if (step == 0)
		{
			throw new ArgumentException("Range () step argument must not be zero");
		}
		checked
		{
			object result;
			if ((beg < end && step < 0) || (beg > end && step > 0) || beg == end)
			{
				result = list<int>.Nil._N_constant_object;
			}
			else
			{
				int num = ((end < 0) ? (end + 1) : (end - 1));
				list<int> tl = list<int>.Nil._N_constant_object;
				num -= unchecked(checked(num - beg) % step);
				while (num != beg)
				{
					list<int> obj = new list<int>.Cons(num, tl);
					num -= step;
					tl = obj;
				}
				result = new list<int>.Cons(num, tl);
			}
			return (list<int>)result;
		}
	}

	public static list<char> Range(char end)
	{
		return Range('a', end);
	}

	public static list<char> Range(char b, char e, int step = 1)
	{
		if (step == 0)
		{
			throw new ArgumentException("Range () step argument must not be zero");
		}
		int num = e;
		object result;
		if ((b < num && step < 0) || (b > num && step > 0) || b == num)
		{
			result = list<char>.Nil._N_constant_object;
		}
		else
		{
			list<char> tl;
			checked
			{
				num = ((step <= 0) ? (num + 1) : (num - 1));
				tl = list<char>.Nil._N_constant_object;
				num -= unchecked(checked(num - unchecked((int)b)) % step);
			}
			while (num != b)
			{
				list<char> obj = new list<char>.Cons((char)checked((ushort)num), tl);
				num = checked(num - step);
				tl = obj;
			}
			result = new list<char>.Cons((char)checked((ushort)num), tl);
		}
		return (list<char>)result;
	}

	public static list<Result> Filter2<T1, T2, Result>(list<T1> list1, list<T2> list2, Function<T1, T2, Nemerle.Builtins.Tuple<bool, Result>> convert)
	{
		int capacity = 0;
		T2 val = default(T2);
		T1 val2 = default(T1);
		Result val3 = default(Result);
		list<T1> list3 = list1;
		list<T2> list4 = list2;
		if (list1 != null)
		{
			capacity = list1.Length;
		}
		List<Result> list5 = new List<Result>(capacity);
		Function<T1, T2, Nemerle.Builtins.Tuple<bool, Result>> function = convert;
		object result;
		while (true)
		{
			if (list3 is list<T1>.Cons)
			{
				if (list4 is list<T2>.Cons)
				{
					val2 = ((list<T1>.Cons)list3).hd;
					list3 = ((list<T1>.Cons)list3).tl;
					val = ((list<T2>.Cons)list4).hd;
					list4 = ((list<T2>.Cons)list4).tl;
					Nemerle.Builtins.Tuple<bool, Result> tuple = function.apply(val2, val);
					if (tuple.Field0)
					{
						val3 = tuple.Field1;
						list5.Add(val3);
					}
					list<T1> obj = list3;
					list<T2> obj2 = list4;
					List<Result> obj3 = list5;
					function = convert;
					list5 = obj3;
					list4 = obj2;
					list3 = obj;
					continue;
				}
			}
			else if ((object)list3 == list<T1>.Nil._N_constant_object)
			{
				if ((object)list4 == list<T2>.Nil._N_constant_object)
				{
					result = list5.NToList();
					break;
				}
			}
			else if ((object)list4 == null)
			{
				result = list<Result>.Nil._N_constant_object;
				break;
			}
			throw new ArgumentException("The list1 and list2 has different Length");
		}
		return (list<Result>)result;
	}

	private static list<list<T>> _N_walk_20498<T>(_N_closureOf_Group_20490<T> _N_Group_cp_20497, list<T> l, list<T> acc)
	{
		T val = default(T);
		T val2 = default(T);
		list<list<T>>.Cons result;
		while (true)
		{
			val2 = Head(acc);
			if (l is list<T>.Cons)
			{
				val = ((list<T>.Cons)l).hd;
				list<T> list = ((list<T>.Cons)l).tl;
				if (_N_Group_cp_20497._N_cmp_20495.apply(val, val2) == 0)
				{
					list<T> obj = list;
					acc = new list<T>.Cons(val, acc);
					l = obj;
					continue;
				}
				result = new list<list<T>>.Cons(acc, _N_walk_20498(_N_Group_cp_20497, list, new list<T>.Cons(val, list<T>.Nil._N_constant_object)));
				break;
			}
			if ((object)l == list<T>.Nil._N_constant_object)
			{
				result = new list<list<T>>.Cons(acc, list<list<T>>.Nil._N_constant_object);
				break;
			}
			throw new MatchFailureException();
		}
		return result;
	}

	private static list<list<T>> _N_extend_20735<T>(list<T> a, list<T> lst, list<list<T>> result)
	{
		T val = default(T);
		while (true)
		{
			if ((object)a == list<T>.Nil._N_constant_object)
			{
				return result;
			}
			if (!(a is list<T>.Cons))
			{
				break;
			}
			val = ((list<T>.Cons)a).hd;
			list<T> list = ((list<T>.Cons)a).tl;
			list<T> obj = list;
			list<T> obj2 = lst;
			result = new list<list<T>>.Cons(new list<T>.Cons(val, lst), result);
			lst = obj2;
			a = obj;
		}
		throw new MatchFailureException();
	}

	private static list<list<list<T>>> _N_push_20839<T>(T elem, list<list<T>> list, list<list<T>> left, list<list<list<T>>> result)
	{
		while (true)
		{
			if ((object)list == list<list<T>>.Nil._N_constant_object)
			{
				return result;
			}
			if (!(list is list<list<T>>.Cons))
			{
				break;
			}
			list<T> list2 = ((list<list<T>>.Cons)list).hd;
			list<list<T>> list3 = ((list<list<T>>.Cons)list).tl;
			T val = elem;
			list<list<T>> obj = list3;
			list<list<T>> obj2 = new list<list<T>>.Cons(list2, left);
			result = new list<list<list<T>>>.Cons(left + new list<list<T>>.Cons(new list<T>.Cons(elem, list2), list<list<T>>.Nil._N_constant_object) + list3, result);
			left = obj2;
			list = obj;
			elem = val;
		}
		throw new MatchFailureException();
	}

	private static list<list<list<T>>> _N_extend_20848<T>(_N_closureOf_SubsetsPartitions_20831<T> _N_SubsetsPartitions_cp_20847, T elem, list<list<list<T>>> list, list<list<list<T>>> result)
	{
		while (true)
		{
			if ((object)list == list<list<list<T>>>.Nil._N_constant_object)
			{
				return result;
			}
			if (!(list is list<list<list<T>>>.Cons))
			{
				break;
			}
			list<list<T>> list2 = ((list<list<list<T>>>.Cons)list).hd;
			list<list<list<T>>> list3 = ((list<list<list<T>>>.Cons)list).tl;
			T val = elem;
			list<list<list<T>>> obj = list3;
			result = _N_push_20839(elem, list2, list<list<T>>.Nil._N_constant_object, list<list<list<T>>>.Nil._N_constant_object) + result;
			list = obj;
			elem = val;
		}
		throw new MatchFailureException();
	}
}
