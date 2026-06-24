using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions;

public static class CollectionExtensions
{
	private class ComparableComparer<T> : IComparer<T> where T : IComparable
	{
		public static readonly ComparableComparer<T> Instance;

		private static object yVVDST8Gl1pFotkivd7F;

		public int Compare(T x, T y)
		{
			return x.CompareTo(y);
		}

		public ComparableComparer()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		static ComparableComparer()
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					Instance = new ComparableComparer<T>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					SingletonReader.JJCZtPuTvSt();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
					{
						num2 = 1;
					}
					break;
				case 0:
					return;
				}
			}
		}

		internal static bool l38BUB8GrviLTEeXU4ls()
		{
			return yVVDST8Gl1pFotkivd7F == null;
		}

		internal static object msOfYt8Gg7xBQP1lt1dk()
		{
			return yVVDST8Gl1pFotkivd7F;
		}
	}

	public class DelegateComparer<T> : IEqualityComparer<T>
	{
		private readonly Func<T, T, bool> _equals;

		private readonly Func<T, int> _hashCode;

		public DelegateComparer(Func<T, T, bool> equals, Func<T, int> hashCode)
		{
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			_equals = equals;
			_hashCode = hashCode;
		}

		public bool Equals(T x, T y)
		{
			return _equals(x, y);
		}

		public int GetHashCode(T obj)
		{
			if (_hashCode != null)
			{
				return _hashCode(obj);
			}
			return obj.GetHashCode();
		}
	}

	internal static CollectionExtensions BMfMIpGHd07uarNrc28o;

	[IteratorStateMachine(typeof(_003CPartialOrderBy_003Ed__0<, >))]
	public static IEnumerable<TSource> PartialOrderBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CPartialOrderBy_003Ed__0<TSource, TKey>(-2)
		{
			_003C_003E3__source = source,
			_003C_003E3__keySelector = keySelector,
			_003C_003E3__comparer = comparer
		};
	}

	public static bool Contains<T>(this IEnumerable source)
	{
		return source.Cast<object>().ToList().Any((object a) => a is T);
	}

	public static IEnumerable<TSource> PartialOrderBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector) where TKey : IComparable
	{
		return source.PartialOrderBy(keySelector, ComparableComparer<TKey>.Instance);
	}

	public static IEnumerable<TSource> OrderByParentDesc<TSource>(this IEnumerable<TSource> source, Func<TSource, TSource> parentSelector)
	{
		return source.OrderByParentDesc(parentSelector, EqualityComparer<TSource>.Default);
	}

	public static IEnumerable<TSource> OrderByParentDesc<TSource>(this IEnumerable<TSource> source, Func<TSource, TSource> parentSelector, IEqualityComparer<TSource> comparer)
	{
		_003C_003Ec__DisplayClass4_0<TSource> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4_0<TSource>();
		CS_0024_003C_003E8__locals0.comparer = comparer;
		CS_0024_003C_003E8__locals0.parentSelector = parentSelector;
		return source.OrderByParentDesc(CS_0024_003C_003E8__locals0.parentSelector, (TSource i) => CS_0024_003C_003E8__locals0.comparer.Equals(CS_0024_003C_003E8__locals0.parentSelector(i), default(TSource)), CS_0024_003C_003E8__locals0.comparer);
	}

	public static IEnumerable<TSource> OrderByParentDesc<TSource>(this IEnumerable<TSource> source, Func<TSource, TSource> parentSelector, Func<TSource, bool> rootSelector)
	{
		return source.OrderByParentDesc(parentSelector, rootSelector, EqualityComparer<TSource>.Default);
	}

	public static IEnumerable<TSource> OrderByParentDesc<TSource>(this IEnumerable<TSource> source, Func<TSource, TSource> parentSelector, Func<TSource, bool> rootSelector, IEqualityComparer<TSource> comparer)
	{
		_003C_003Ec__DisplayClass6_0<TSource> _003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0<TSource>();
		_003C_003Ec__DisplayClass6_.parentSelector = parentSelector;
		_003C_003Ec__DisplayClass6_.comparer = comparer;
		Stack<TSource> stack = new Stack<TSource>();
		List<TSource> list = source.ToList();
		Func<TSource, bool> predicate = rootSelector;
		while (true)
		{
			_003C_003Ec__DisplayClass6_1<TSource> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_1<TSource>();
			CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass6_;
			CS_0024_003C_003E8__locals0.items = list.Where(predicate).ToList();
			if (CS_0024_003C_003E8__locals0.items.Count == 0)
			{
				break;
			}
			foreach (TSource item in CS_0024_003C_003E8__locals0.items)
			{
				stack.Push(item);
				list.Remove(item);
			}
			predicate = (TSource i) => CS_0024_003C_003E8__locals0.items.Contains(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.parentSelector(i), CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.comparer);
		}
		return stack;
	}

	public static List<T> ImmutableAdd<T>(this List<T> source, T value)
	{
		return new List<T>(source) { value };
	}

	public static List<T> ImmutableAdd<T>(this List<T> source, IEnumerable<T> values)
	{
		List<T> list = new List<T>(source);
		list.AddRange(values);
		return list;
	}

	public static List<T> CreateOneElementList<T>(T first)
	{
		return new List<T> { first };
	}

	public static bool SetEqual<T>(this IEnumerable<T> source, IEnumerable<T> sequence)
	{
		return source.ToHashSet().SetEquals(sequence);
	}

	public static bool SetEqual<T>(this IEnumerable<T> source, IEnumerable<T> sequence, IEqualityComparer<T> comparer)
	{
		return source.ToHashSet(comparer).SetEquals(sequence);
	}

	public static void ForEach<T>(this IEnumerable<T> enumeration, Action<T> action)
	{
		if (enumeration == null || action == null)
		{
			return;
		}
		foreach (T item in enumeration)
		{
			action(item);
		}
	}

	public static void ForEach<T>(this IEnumerable<T> enumeration, Action<T, int> action)
	{
		_003C_003Ec__DisplayClass14_0<T> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass14_0<T>();
		CS_0024_003C_003E8__locals0.action = action;
		if (enumeration != null && CS_0024_003C_003E8__locals0.action != null)
		{
			enumeration.Select(delegate(T item, int i)
			{
				CS_0024_003C_003E8__locals0.action(item, i);
				return 0;
			}).FirstOrDefault((int i) => i > 0);
		}
	}

	public static void AddSequense<T>(this ICollection<T> collection, IEnumerable<T> source)
	{
		foreach (T item in source)
		{
			collection.Add(item);
		}
	}

	public static void AssignAll<T>(this ICollection<T> collection, IEnumerable<T> source)
	{
		collection.Clear();
		collection.AddRange(source);
	}

	public static IEnumerable<T> TakeFromTo<T>(this IEnumerable<T> source, int from, int to)
	{
		Contract.CheckArgument(from >= 1, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1318053726));
		Contract.CheckArgument(to >= from, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643523215));
		return source.Skip(from - 1).Take(to - from + 1);
	}

	public static IEnumerable<T> Take<T>(this IEnumerable<T> source, int skip, int length)
	{
		Contract.CheckArgument(skip >= 0, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398924292));
		Contract.CheckArgument(length >= 0, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106256526));
		return source.Skip(skip).Take(length);
	}

	[IteratorStateMachine(typeof(_003CAggregateSequense_003Ed__19<, >))]
	public static IEnumerable<RT> AggregateSequense<RT, ST>(this IEnumerable<ST> source, RT seed, Func<RT, ST, RT> func)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CAggregateSequense_003Ed__19<RT, ST>(-2)
		{
			_003C_003E3__source = source,
			_003C_003E3__seed = seed,
			_003C_003E3__func = func
		};
	}

	public static Dictionary<TK, TV> CreateDictionary<TK, TV>(TK ketSample, TV valueSample)
	{
		return new Dictionary<TK, TV>();
	}

	public static void SyncFrom<T>(this ICollection<T> target, IEnumerable<T> source, Func<T, T, bool> compare, Func<T, bool> skipRemove = null, Action<T> onRemove = null)
	{
		_003C_003Ec__DisplayClass21_0<T> _003C_003Ec__DisplayClass21_ = new _003C_003Ec__DisplayClass21_0<T>();
		_003C_003Ec__DisplayClass21_.compare = compare;
		List<T> list = target.ToList();
		List<T> list2 = source.ToList();
		using (List<T>.Enumerator enumerator = list2.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass21_1<T> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass21_1<T>();
				CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass21_;
				CS_0024_003C_003E8__locals0.v = enumerator.Current;
				if (!target.Any((T t) => CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.compare(t, CS_0024_003C_003E8__locals0.v)))
				{
					target.Add(CS_0024_003C_003E8__locals0.v);
				}
			}
		}
		using List<T>.Enumerator enumerator = list.GetEnumerator();
		while (enumerator.MoveNext())
		{
			_003C_003Ec__DisplayClass21_2<T> CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass21_2<T>();
			CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2 = _003C_003Ec__DisplayClass21_;
			CS_0024_003C_003E8__locals1.v = enumerator.Current;
			if (!list2.Any((T t) => CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.compare(t, CS_0024_003C_003E8__locals1.v)) && (skipRemove == null || !skipRemove(CS_0024_003C_003E8__locals1.v)))
			{
				target.Remove(CS_0024_003C_003E8__locals1.v);
				onRemove?.Invoke(CS_0024_003C_003E8__locals1.v);
			}
		}
	}

	public static void SyncFrom<T>(this ICollection<T> target, IEnumerable<T> source)
	{
		target.SyncFrom(source, (T v1, T v2) => object.Equals(v1, v2));
	}

	public static void AddIfNotContains<T>(this ICollection<T> collection, T item)
	{
		if (!collection.Contains(item))
		{
			collection.Add(item);
		}
	}

	public static void AddIfNotContainsKey<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, KeyValuePair<TKey, TValue> item)
	{
		if (!dictionary.ContainsKey(item.Key))
		{
			dictionary.Add(item);
		}
	}

	public static void AddIfNotContainsKey<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue value)
	{
		if (!dictionary.ContainsKey(key))
		{
			dictionary.Add(key, value);
		}
	}

	public static TValue AddIfNotContainsKey<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, Func<TKey, TValue> value)
	{
		if (!dictionary.TryGetValue(key, out var value2))
		{
			value2 = value(key);
			dictionary.Add(key, value2);
		}
		return value2;
	}

	public static TValue GetValueOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue defaultValue)
	{
		if (!dictionary.TryGetValue(key, out var value))
		{
			return defaultValue;
		}
		return value;
	}

	[IteratorStateMachine(typeof(_003CGenerateSequense_003Ed__28<>))]
	public static IEnumerable<T> GenerateSequense<T>(this T first, Func<T, T> next, Func<T, bool> whileCondirion)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGenerateSequense_003Ed__28<T>(-2)
		{
			_003C_003E3__first = first,
			_003C_003E3__next = next,
			_003C_003E3__whileCondirion = whileCondirion
		};
	}

	public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this IEnumerable<TFirst> first, IEnumerable<TSecond> second, Func<TFirst, TSecond, TResult> resultSelector)
	{
		if (first == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x12401874));
		}
		if (second == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EDCBA32 ^ 0x4ED8BEEC));
		}
		if (resultSelector == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA592A41 ^ 0xA5D2EAF));
		}
		return ZipIterator(first, second, resultSelector);
	}

	[IteratorStateMachine(typeof(_003CZipIterator_003Ed__30<, , >))]
	private static IEnumerable<TResult> ZipIterator<TFirst, TSecond, TResult>(IEnumerable<TFirst> first, IEnumerable<TSecond> second, Func<TFirst, TSecond, TResult> resultSelector)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CZipIterator_003Ed__30<TFirst, TSecond, TResult>(-2)
		{
			_003C_003E3__first = first,
			_003C_003E3__second = second,
			_003C_003E3__resultSelector = resultSelector
		};
	}

	[IteratorStateMachine(typeof(_003CAsDepthFirstEnumerable_003Ed__31<>))]
	public static IEnumerable<T> AsDepthFirstEnumerable<T>(this T head, Func<T, IEnumerable<T>> childrenFunc)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CAsDepthFirstEnumerable_003Ed__31<T>(-2)
		{
			_003C_003E3__head = head,
			_003C_003E3__childrenFunc = childrenFunc
		};
	}

	[IteratorStateMachine(typeof(_003CAsBreadthFirstEnumerable_003Ed__32<>))]
	public static IEnumerable<T> AsBreadthFirstEnumerable<T>(this T head, Func<T, IEnumerable<T>> childrenFunc)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CAsBreadthFirstEnumerable_003Ed__32<T>(-2)
		{
			_003C_003E3__head = head,
			_003C_003E3__childrenFunc = childrenFunc
		};
	}

	public static bool IsSubsetOf<T>(this IEnumerable<T> source, IEnumerable<T> target)
	{
		return !source.Except(target).Any();
	}

	public static bool ByteArrayCompare(byte[] b1, byte[] b2)
	{
		return t2h92DGHgqKBvq02gGJS(b1, b2);
	}

	[IteratorStateMachine(typeof(_003CUnfold_003Ed__35<>))]
	public static IEnumerable<T> Unfold<T>(T first, Func<T, T> next, Func<T, bool> whileCondition)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CUnfold_003Ed__35<T>(-2)
		{
			_003C_003E3__first = first,
			_003C_003E3__next = next,
			_003C_003E3__whileCondition = whileCondition
		};
	}

	public static string AsText<T>(this IEnumerable<T> source) where T : class
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812020052) + string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x20261A4F ^ 0x2026164D), source.Select((T s) => (s != null) ? s.ToString() : z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822606248)).ToArray()) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17ADCCD8 ^ 0x17AD3A30);
	}

	[IteratorStateMachine(typeof(_003CChunk_003Ed__37<>))]
	public static IEnumerable<IEnumerable<T>> Chunk<T>(this IEnumerable<T> source, int chunksize)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CChunk_003Ed__37<T>(-2)
		{
			_003C_003E3__source = source,
			_003C_003E3__chunksize = chunksize
		};
	}

	public static IEnumerable<T> Distinct<T>(this IEnumerable<T> items, Func<T, T, bool> equals, Func<T, int> hashCode)
	{
		return items.Distinct(new DelegateComparer<T>(equals, hashCode));
	}

	public static IEnumerable<T> Distinct<T>(this IEnumerable<T> items, Func<T, T, bool> equals)
	{
		return items.Distinct(new DelegateComparer<T>(equals, null));
	}

	[IteratorStateMachine(typeof(_003CDistinct_003Ed__41<, >))]
	public static IEnumerable<TSource> Distinct<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> selector)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CDistinct_003Ed__41<TSource, TKey>(-2)
		{
			_003C_003E3__source = source,
			_003C_003E3__selector = selector
		};
	}

	public static string ToCommaSeparatedString<T>(this IEnumerable<T> collection)
	{
		return collection.ToSeparatedString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606641172));
	}

	public static string ToSeparatedString<T>(this IEnumerable<T> collection, string separator)
	{
		return string.Join(separator, collection.Select((T el) => el.ToString()).ToArray());
	}

	public static string ToCommaSeparatedQuotedString<T>(this IEnumerable<T> collection)
	{
		return collection.ToSeparatedQuotedString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A5D5EF ^ 0x3A5871F));
	}

	public static string ToSeparatedQuotedString<T>(this IEnumerable<T> collection, string separator, char quoteChar = '"')
	{
		_003C_003Ec__DisplayClass45_0<T> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass45_0<T>();
		CS_0024_003C_003E8__locals0.quoteChar = quoteChar;
		return string.Join(separator, collection.Select((T el) => (el != null) ? el.ToString().Escape(CS_0024_003C_003E8__locals0.quoteChar).Quote(CS_0024_003C_003E8__locals0.quoteChar) : z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951510784)));
	}

	public static void AddRange<T>(this ICollection<T> collection, IEnumerable<T> items)
	{
		foreach (T item in items)
		{
			collection.Add(item);
		}
	}

	public static void AddAll<T>(this ICollection<T> collection, IEnumerable<T> items)
	{
		collection.AddRange(items);
	}

	public static int RemoveAll<T>(this ICollection<T> collection, Func<T, bool> match)
	{
		IList<T> list = collection.Where(match).ToList();
		foreach (T item in list)
		{
			collection.Remove(item);
		}
		return list.Count;
	}

	public static bool HasItems<T>(this ICollection<T> collection)
	{
		if (collection != null)
		{
			return collection.Count > 0;
		}
		return false;
	}

	public static bool HasItems<T>(this ICollection<T> collection, Func<T, bool> predicate)
	{
		return collection?.Any(predicate) ?? false;
	}

	internal static bool t2h92DGHgqKBvq02gGJS(object P_0, object P_1)
	{
		return ByteArrayExtensions.ByteArrayCompare((byte[])P_0, (byte[])P_1);
	}

	internal static bool SXaJLPGHlBKwF7xDi4xX()
	{
		return BMfMIpGHd07uarNrc28o == null;
	}

	internal static CollectionExtensions Kd3JA7GHrwFCS4ESHRdt()
	{
		return BMfMIpGHd07uarNrc28o;
	}
}
