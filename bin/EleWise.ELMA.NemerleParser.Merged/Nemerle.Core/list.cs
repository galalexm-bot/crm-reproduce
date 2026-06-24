using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Internal;

namespace Nemerle.Core;

[Serializable]
[ComVisible(false)]
[Nemerle.Internal.Extension]
[DebuggerDisplay("Length = {Length}: {ToString()}")]
[Variant("Nemerle.Core.list.Cons,Nemerle.Core.list.Nil")]
[Nemerle.Internal.Extension]
[DebuggerNonUserCode]
public abstract class list<T> : IEnumerable, IEnumerable<T>, ICovariantList<T>, IEquatable<list<T>>
{
	[Serializable]
	[VariantOption]
	[DebuggerNonUserCode]
	public class Cons : list<T>
	{
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public readonly T hd;

		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		[Immutable]
		public list<T> tl;

		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public T[] AsArray2
		{
			get
			{
				T[] nToArray = NToArray;
				return ToArray();
			}
		}

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 0;
		}

		[RecordCtor]
		public Cons([MappedMember("hd")] T hd, [MappedMember("tl")] list<T> tl)
		{
			this.hd = hd;
			this.tl = tl;
		}
	}

	[Serializable]
	[DebuggerNonUserCode]
	[ConstantVariantOption]
	public class Nil : list<T>, IObjectReference
	{
		public static readonly Nil _N_constant_object;

		[SpecialName]
		public static Nil _N_constant_object_generator()
		{
			return _N_constant_object;
		}

		[SpecialName]
		[SecurityCritical]
		public object GetRealObject(StreamingContext _N_wildcard_3398)
		{
			return _N_constant_object;
		}

		static Nil()
		{
			_N_constant_object = new Nil();
		}

		public override string ToString()
		{
			return "[]";
		}

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 1;
		}

		[RecordCtor]
		private Nil()
		{
		}
	}

	private sealed class _N__N_lambda__18821__18828 : Function<T, string>
	{
		[SpecialName]
		public static readonly _N__N_lambda__18821__18828 Instance = new _N__N_lambda__18821__18828();

		[SpecialName]
		public sealed override string apply(T x)
		{
			return Convert.ToString(x);
		}
	}

	private sealed class _N__N_lambda__19222__19229<TSecond> : Function<TSecond, TSecond, bool> where TSecond : IComparable<TSecond>
	{
		[SpecialName]
		public static readonly _N__N_lambda__19222__19229<TSecond> Instance = new _N__N_lambda__19222__19229<TSecond>();

		[SpecialName]
		public sealed override bool apply(TSecond x, TSecond y)
		{
			return x.CompareTo(y) > 0;
		}
	}

	public ICovariantList<T> CovariantTail => Tail;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public int Length => NList.Length(this);

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public bool IsEmpty => NList.IsEmpty(this);

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public T Head
	{
		get
		{
			T val = default(T);
			if (this is Cons)
			{
				return ((Cons)this).hd;
			}
			if ((object)this == Nil._N_constant_object)
			{
				throw new ArgumentException("NList.Head called with empty list");
			}
			throw new MatchFailureException();
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public list<T> Tail
	{
		get
		{
			if (this is Cons)
			{
				return ((Cons)this).tl;
			}
			if ((object)this == Nil._N_constant_object)
			{
				throw new ArgumentException("NList.Tail called for empty list");
			}
			throw new MatchFailureException();
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public T Last => NList.Last(this);

	[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
	protected T[] NToArray => ToArray();

	public override string ToString()
	{
		return string.Concat("[" + ToString(", "), "]");
	}

	public string ToString(string separator)
	{
		string[] array = new string[1];
		IEnumerable<T> source = this;
		Function<T, string> instance = _N__N_lambda__18821__18828.Instance;
		array[0] = string.Join(separator, source.MapToArray(instance));
		return string.Concat(array);
	}

	public static bool operator ==(list<T> x, list<T> y)
	{
		return (!object.ReferenceEquals(null, x)) ? x.Equals(y) : object.ReferenceEquals(x, y);
	}

	public static bool operator !=(list<T> x, list<T> y)
	{
		return (!object.ReferenceEquals(null, x)) ? (!x.Equals(y)) : (!object.ReferenceEquals(x, y));
	}

	public bool Equals(list<T> other)
	{
		T val = default(T);
		T val2 = default(T);
		EqualityComparer<T> @default = EqualityComparer<T>.Default;
		list<T> list2 = this;
		list<T> list3 = other;
		int result;
		while (true)
		{
			if (object.ReferenceEquals(list2, list3))
			{
				result = 1;
			}
			else if (list2 is Cons)
			{
				val = ((Cons)list2).hd;
				list2 = ((Cons)list2).tl;
				if (list3 is Cons)
				{
					val2 = ((Cons)list3).hd;
					list3 = ((Cons)list3).tl;
					if (@default.Equals(val, val2))
					{
						list<T> obj = list2;
						list3 = list3;
						list2 = obj;
						continue;
					}
				}
				result = 0;
			}
			else
			{
				result = (((object)list2 != Nil._N_constant_object) ? (object.ReferenceEquals(null, list3) ? 1 : 0) : (((object)list3 == Nil._N_constant_object) ? 1 : 0));
			}
			break;
		}
		return (byte)result != 0;
	}

	public bool Equals<TSecond>(list<TSecond> lst2, Function<T, TSecond, bool> compare)
	{
		return NList.Equals(this, lst2, compare);
	}

	public override int GetHashCode()
	{
		T val = default(T);
		EqualityComparer<T> @default = EqualityComparer<T>.Default;
		list<T> list2 = this;
		int num = 842801;
		while (list2 is Cons)
		{
			val = ((Cons)list2).hd;
			list2 = ((Cons)list2).tl;
			list<T> obj = list2;
			num = 757927 * num + @default.GetHashCode(val);
			list2 = obj;
		}
		return num;
	}

	public Type GetElementType()
	{
		return typeof(T);
	}

	public ListEnumerator<T> GetEnumerator()
	{
		return new ListEnumerator<T>(this);
	}

	public static list<T>operator +(list<T> x, list<T> y)
	{
		return NList.Append(x, y);
	}

	public list<T> FirstN(int n)
	{
		T val = default(T);
		int num = n;
		list<T> list2 = Nil._N_constant_object;
		list<T> list3 = this;
		while (true)
		{
			if (num == 0)
			{
				return NList.Rev(list2);
			}
			if (!(list3 is Cons))
			{
				break;
			}
			val = ((Cons)list3).hd;
			list3 = ((Cons)list3).tl;
			int num2 = checked(num - 1);
			list<T> obj = new Cons(val, list2);
			list3 = list3;
			list2 = obj;
			num = num2;
		}
		if ((object)list3 == Nil._N_constant_object)
		{
			throw new ArgumentException("NList.FirstN called for too short list");
		}
		throw new MatchFailureException();
	}

	public list<T> ChopFirstN(int n)
	{
		int num = n;
		list<T> list2 = this;
		while (true)
		{
			if (num == 0)
			{
				return list2;
			}
			if (!(list2 is Cons))
			{
				break;
			}
			list2 = ((Cons)list2).tl;
			int num2 = checked(num - 1);
			list2 = list2;
			num = num2;
		}
		if ((object)list2 == Nil._N_constant_object)
		{
			throw new ArgumentException("NList.ChopFirstN called for too short list");
		}
		throw new MatchFailureException();
	}

	public list<T> LastN(int n)
	{
		int length = Length;
		if (n > length)
		{
			throw new ArgumentException("NList.LastN called for too short list");
		}
		return ChopFirstN(checked(length - n));
	}

	public T Nth(int n)
	{
		return NList.Nth(this, n);
	}

	public list<T> Reverse()
	{
		return NList.Rev(this);
	}

	public list<T> Append(list<T> y)
	{
		return NList.RevAppend(Reverse(), y);
	}

	public list<T> RevAppend(list<T> y)
	{
		return NList.RevAppend(this, y);
	}

	public list<T> Remove(T x)
	{
		return NList.Remove(this, x);
	}

	public Nemerle.Builtins.Tuple<list<T>, T> DivideLast()
	{
		return NList.DivideLast(this);
	}

	public void Iter(FunctionVoid<T> f)
	{
		NList.Iter(this, f);
	}

	public void IterI(int acc, FunctionVoid<int, T> f)
	{
		T val = default(T);
		list<T> list2 = this;
		while (list2 is Cons)
		{
			val = ((Cons)list2).hd;
			list2 = ((Cons)list2).tl;
			f.apply_void(new Nemerle.Builtins.Tuple<int, T>(acc, val));
			acc = checked(acc + 1);
			list2 = list2;
		}
	}

	public list<TOut> Map<TOut>(Function<T, TOut> convert)
	{
		return NList.Map(this, convert);
	}

	public list<TOut> MapIRev<TOut>(Function<int, T, TOut> convert)
	{
		T val = default(T);
		list<T> list2 = this;
		list<TOut> list3 = list<TOut>.Nil._N_constant_object;
		int num = 0;
		while (true)
		{
			if ((object)list2 == Nil._N_constant_object)
			{
				return list3;
			}
			if (!(list2 is Cons))
			{
				break;
			}
			val = ((Cons)list2).hd;
			list2 = ((Cons)list2).tl;
			list<T> obj = list2;
			list<TOut> obj2 = new list<TOut>.Cons(convert.apply(num, val), list3);
			num = checked(num + 1);
			list3 = obj2;
			list2 = obj;
		}
		throw new MatchFailureException();
	}

	public list<TOut> MapI<TOut>(Function<int, T, TOut> convert)
	{
		return MapIRev(convert).Reverse();
	}

	public list<Nemerle.Builtins.Tuple<T, TSecond>> Zip<TSecond>(list<TSecond> second)
	{
		list<T> list2 = null;
		T val = default(T);
		TSecond val2 = default(TSecond);
		list2 = this;
		object result;
		if (list2 is Cons)
		{
			if (!(second is list<TSecond>.Cons))
			{
				if ((object)second == null)
				{
					goto IL_0091;
				}
				goto IL_009c;
			}
			val = ((Cons)list2).hd;
			list2 = ((Cons)list2).tl;
			val2 = ((list<TSecond>.Cons)second).hd;
			list<TSecond> second2 = ((list<TSecond>.Cons)second).tl;
			result = new list<Nemerle.Builtins.Tuple<T, TSecond>>.Cons(new Nemerle.Builtins.Tuple<T, TSecond>(val, val2), list2.Zip(second2));
		}
		else
		{
			if ((object)list2 != Nil._N_constant_object)
			{
				throw new ArgumentNullException("this");
			}
			if ((object)second != list<TSecond>.Nil._N_constant_object)
			{
				if ((object)second == null)
				{
					goto IL_0091;
				}
				goto IL_009c;
			}
			result = list<Nemerle.Builtins.Tuple<T, TSecond>>.Nil._N_constant_object;
		}
		return (list<Nemerle.Builtins.Tuple<T, TSecond>>)result;
		IL_0091:
		throw new ArgumentNullException("second");
		IL_009c:
		throw new ArgumentException("list[T].Zip(): Collections mast have same", "second");
	}

	public list<TOut> MapFiltered<TOut>(Function<T, bool> predicate, Function<T, TOut> convert)
	{
		return NList.MapFiltered(this, predicate, convert);
	}

	public list<TOut> RevMap<TOut>(Function<T, TOut> f)
	{
		return NList.RevMap(this, f);
	}

	public TOut FoldLeft<TOut>(TOut acc, Function<T, TOut, TOut> f)
	{
		return NList.FoldLeft(this, acc, f);
	}

	public TOut FoldRight<TOut>(TOut acc, Function<T, TOut, TOut> f)
	{
		return NList.FoldRight(this, acc, f);
	}

	public list<list<T>> Group(Function<T, T, int> cmp)
	{
		return NList.Group(this, cmp);
	}

	public bool ForAll(Function<T, bool> f)
	{
		return NList.ForAll(this, f);
	}

	public bool ForAll2<TSecond>(list<TSecond> lst2, Function<T, TSecond, bool> predicate)
	{
		return NList.ForAll2(this, lst2, predicate);
	}

	public bool Exists(Function<T, bool> f)
	{
		return NList.Exists(this, f);
	}

	public bool Contains(T a)
	{
		return NList.Member(this, a);
	}

	public option<T> Find(Function<T, bool> pred)
	{
		return NList.Find(this, pred);
	}

	public T FindWithDefault(T @default, Function<T, bool> pred)
	{
		T val = default(T);
		list<T> list2 = this;
		T result;
		while (true)
		{
			if (list2 is Cons)
			{
				val = ((Cons)list2).hd;
				list2 = ((Cons)list2).tl;
				if (pred.apply(val))
				{
					result = val;
					break;
				}
				list2 = list2;
				continue;
			}
			if ((object)list2 == Nil._N_constant_object)
			{
				result = @default;
				break;
			}
			throw new MatchFailureException();
		}
		return result;
	}

	public int FilteredLength(Function<T, bool> f)
	{
		return NList.FilteredLength(this, f);
	}

	public list<T> Filter(Function<T, bool> f)
	{
		return NList.Filter(this, f);
	}

	public list<T> RevFilter(Function<T, bool> f)
	{
		return NList.RevFilter(this, f);
	}

	public list<T> RevFilterWhenNeeded(Function<T, bool> f)
	{
		return (!NList.ForAll(this, f)) ? NList.RevFilter(this, f) : this;
	}

	public list<T> FindAll(Function<T, bool> f)
	{
		return Filter(f);
	}

	public Nemerle.Builtins.Tuple<list<T>, list<T>> Partition(Function<T, bool> pred)
	{
		return NList.Partition(this, pred);
	}

	public list<list<T>> Singletons()
	{
		return NList.Singletons(this);
	}

	public list<list<T>> SizeSubsets(int n)
	{
		return NList.SizeSubsets(this, n);
	}

	public static list<T> Repeat(T elem, int count)
	{
		list<T> list2 = Nil._N_constant_object;
		int num = count;
		while (num > 0)
		{
			list<T> obj = new Cons(elem, list2);
			num = checked(num - 1);
			list2 = obj;
		}
		return list2;
	}

	public static list<int> Range(int end)
	{
		return NList.Range(0, end);
	}

	public static list<int> Range(int beg, int end, int step = 1)
	{
		return NList.Range(beg, end, step);
	}

	public static list<char> Range(char end)
	{
		return NList.Range(end);
	}

	public static list<char> Range(char b, char e, int step = 1)
	{
		return NList.Range(b, e, step);
	}

	public list<T> Rev()
	{
		return NList.Rev(this);
	}

	public list<T> Sort(Function<T, T, int> cmp)
	{
		return NList.Sort(this, cmp);
	}

	[Nemerle.Internal.Extension]
	public static bool IsOrdered<TSecond>(this list<TSecond> lst, Function<TSecond, TSecond, bool> great)
	{
		TSecond val = default(TSecond);
		TSecond val2 = default(TSecond);
		int result;
		while (true)
		{
			if (lst is list<TSecond>.Cons)
			{
				if (((list<TSecond>.Cons)lst).tl is list<TSecond>.Cons)
				{
					val = ((list<TSecond>.Cons)lst).hd;
					list<TSecond>.Cons cons = (list<TSecond>.Cons)((list<TSecond>.Cons)lst).tl;
					val2 = ((list<TSecond>.Cons)((list<TSecond>.Cons)lst).tl).hd;
					if (great.apply(val, val2))
					{
						result = 0;
						break;
					}
					list<TSecond> obj = cons;
					great = great;
					lst = obj;
					continue;
				}
				if ((object)((list<TSecond>.Cons)lst).tl != list<TSecond>.Nil._N_constant_object)
				{
					throw new MatchFailureException();
				}
			}
			else if ((object)lst != list<TSecond>.Nil._N_constant_object)
			{
			}
			result = 1;
			break;
		}
		return (byte)result != 0;
	}

	[Nemerle.Internal.Extension]
	public static bool IsOrdered<TSecond>(this list<TSecond> lst) where TSecond : IComparable<TSecond>
	{
		Function<TSecond, TSecond, bool> instance = _N__N_lambda__19222__19229<TSecond>.Instance;
		return IsOrdered(lst, instance);
	}

	public list<T> RemoveDuplicates()
	{
		return NList.RemoveDuplicates(this);
	}

	public T[] ToArray()
	{
		T[] array = new T[Length];
		CopyTo(array);
		return array;
	}

	public void CopyTo(T[] dest, int len)
	{
		int num = 0;
		T val = default(T);
		num = 0;
		list<T> list2 = this;
		while (list2 is Cons)
		{
			val = ((Cons)list2).hd;
			list2 = ((Cons)list2).tl;
			val = val;
			if (num >= len)
			{
				break;
			}
			dest[num] = val;
			num = checked(num + 1);
			list2 = list2;
		}
		if (num < len)
		{
			throw new ArgumentException("insufficient amount of elements in current list: expected " + Convert.ToString(len) + ", has " + Convert.ToString(num));
		}
	}

	public void CopyTo(T[] dest)
	{
		int num = 0;
		T val = default(T);
		num = 0;
		list<T> list2 = this;
		while (list2 is Cons)
		{
			val = ((Cons)list2).hd;
			list2 = ((Cons)list2).tl;
			dest[num] = val;
			num = checked(num + 1);
			list2 = list2;
		}
	}

	public TOut[] MapToArray<TOut>(Function<T, TOut> f)
	{
		int num = 0;
		T val = default(T);
		TOut[] array = new TOut[Length];
		num = 0;
		list<T> list2 = this;
		while (list2 is Cons)
		{
			val = ((Cons)list2).hd;
			list2 = ((Cons)list2).tl;
			array[num] = f.apply(val);
			num = checked(num + 1);
			list2 = list2;
		}
		return array;
	}

	public list<TOut> Flatten<TOut>(FunctionVoid<T, List<TOut>> selector)
	{
		T val = default(T);
		List<TOut> list2 = new List<TOut>();
		list<T> list3 = this;
		while (list3 is Cons)
		{
			val = ((Cons)list3).hd;
			list3 = ((Cons)list3).tl;
			selector.apply_void(new Nemerle.Builtins.Tuple<T, List<TOut>>(val, list2));
			list3 = list3;
		}
		return list2.NToList();
	}

	public list<TOut> Flatten<TOut>(Function<T, IEnumerable<TOut>> selector)
	{
		T val = default(T);
		List<TOut> list2 = new List<TOut>();
		list<T> list3 = this;
		while (list3 is Cons)
		{
			val = ((Cons)list3).hd;
			list3 = ((Cons)list3).tl;
			list2.AddRange(selector.apply(val));
			list3 = list3;
		}
		return list2.NToList();
	}

	public list<Result> Filter2<T2, Result>(list<T2> list2, Function<T, T2, Nemerle.Builtins.Tuple<bool, Result>> convert)
	{
		return NList.Filter2(this, list2, convert);
	}

	public list<TResult> OfTypeRevert<TResult>()
	{
		list<TResult> list2 = null;
		T val = default(T);
		list2 = list<TResult>.Nil._N_constant_object;
		list<T> list3 = this;
		while (list3 is Cons)
		{
			val = ((Cons)list3).hd;
			list3 = ((Cons)list3).tl;
			if (val is TResult)
			{
				list2 = new list<TResult>.Cons((TResult)(object)val, list2);
			}
			list3 = list3;
		}
		return list2;
	}

	public list<TResult> OfType<TResult>()
	{
		T val = default(T);
		List<TResult> list2 = new List<TResult>(Length);
		list<T> list3 = this;
		while (list3 is Cons)
		{
			val = ((Cons)list3).hd;
			list3 = ((Cons)list3).tl;
			if (val is TResult)
			{
				list2.Add((TResult)(object)val);
			}
			list3 = list3;
		}
		return list2.NToList();
	}

	public override bool Equals(object other)
	{
		return other == this || (other is list<T> && Equals((list<T>)other));
	}

	[SpecialName]
	public abstract override int _N_GetVariantCode();

	[SpecialName]
	public static int _N_GetVariantCodeSafe(list<T> x)
	{
		return ((object)x != null) ? x._N_GetVariantCode() : (-1);
	}

	[SpecialName]
	public static int _N_GetVariantCodeObject(object x)
	{
		return (!(x is list<T>)) ? (-1) : ((list<T>)x)._N_GetVariantCode();
	}

	[SpecialName]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return GetEnumerator();
	}

	[SpecialName]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
