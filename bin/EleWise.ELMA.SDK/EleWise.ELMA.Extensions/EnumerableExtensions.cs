using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions;

public static class EnumerableExtensions
{
	public class GenericEnumerable<T> : IEnumerable<T>, IEnumerable
	{
		private readonly IEnumerable source;

		internal static object N39mjQ8EzGIZsTfXYdUN;

		public GenericEnumerable(IEnumerable source)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 1:
					this.source = source;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return source.GetEnumerator();
		}

		[IteratorStateMachine(typeof(GenericEnumerable<>._003CSystem_002DCollections_002DGeneric_002DIEnumerable_003CT_003E_002DGetEnumerator_003Ed__3))]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			//yield-return decompiler failed: Missing enumeratorCtor.Body
			return new _003CSystem_002DCollections_002DGeneric_002DIEnumerable_003CT_003E_002DGetEnumerator_003Ed__3(0)
			{
				_003C_003E4__this = this
			};
		}

		internal static bool zQVTXx8fFKagaoygrfPN()
		{
			return N39mjQ8EzGIZsTfXYdUN == null;
		}

		internal static object w6ByTG8fBJupAsoAAOyL()
		{
			return N39mjQ8EzGIZsTfXYdUN;
		}
	}

	private static class DefaultReadOnlyCollection<T>
	{
		private static ReadOnlyCollection<T> defaultCollection;

		internal static ReadOnlyCollection<T> Empty
		{
			get
			{
				if (defaultCollection == null)
				{
					defaultCollection = new ReadOnlyCollection<T>(new T[0]);
				}
				return defaultCollection;
			}
		}
	}

	private class Linkage<T>
	{
		internal static object yjCwVv8fhKo72EJRXmey;

		public T Element { get; set; }

		public bool Used
		{
			[CompilerGenerated]
			get
			{
				return _003CUsed_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						_003CUsed_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public Linkage()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool MaFuij8fGr2d5FdDmi8X()
		{
			return yjCwVv8fhKo72EJRXmey == null;
		}

		internal static object umrSWU8fERJNRa9jclCl()
		{
			return yjCwVv8fhKo72EJRXmey;
		}
	}

	private static readonly Lazy<PropertyInfo> NameValueCollectionComparerProperty;

	private static readonly ConcurrentDictionary<Type, Type> ElementTypeCache;

	private static EnumerableExtensions DOpVQvGH5ymEQHYndfjn;

	public static IEnumerable<T> If<T>(this IEnumerable<T> instance, bool condition, Func<IEnumerable<T>, IEnumerable<T>> action)
	{
		if (!condition)
		{
			return instance;
		}
		return action(instance);
	}

	public static IEnumerable<T> If<T>(this IEnumerable<T> instance, bool condition, Func<IEnumerable<T>, IEnumerable<T>> thenAction, Func<IEnumerable<T>, IEnumerable<T>> elseAction)
	{
		if (!condition)
		{
			return elseAction(instance);
		}
		return thenAction(instance);
	}

	public static void Each<T>(this IEnumerable<T> instance, Action<T, int> action)
	{
		int num = 0;
		foreach (T item in instance)
		{
			action(item, num++);
		}
	}

	public static void Each<T>(this IEnumerable<T> instance, Action<T> action)
	{
		if (instance == null || action == null)
		{
			return;
		}
		foreach (T item in instance)
		{
			action(item);
		}
	}

	public static IEnumerable<T> EmptyIfNull<T>(this IEnumerable<T> source)
	{
		return source ?? Enumerable.Empty<T>();
	}

	public static IEnumerable<T> CastOrNull<T>(this IEnumerable source)
	{
		return source?.Cast<T>();
	}

	public static ICollection<T> CastToCollectionOrNull<T>(this IEnumerable source)
	{
		return source?.Cast<T>().ToList();
	}

	public static IList<T> CastToListOrNull<T>(this IEnumerable source)
	{
		return source?.Cast<T>().ToList();
	}

	public static T[] CastToArrayOrNull<T>(this IEnumerable source)
	{
		return source?.Cast<T>().ToArray();
	}

	public static IEnumerable<T> AsGenericEnumerable<T>(this IEnumerable source)
	{
		if (source == null)
		{
			return null;
		}
		Type type = typeof(T);
		if (source.GetType().FindGenericType(typeof(IEnumerable<T>)) != null)
		{
			return (IEnumerable<T>)source;
		}
		IEnumerator enumerator = source.GetEnumerator();
		Type type2;
		try
		{
			type2 = typeof(GenericEnumerable<>).MakeGenericType(typeof(T));
		}
		catch
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current != null)
				{
					type = enumerator.Current.GetType();
					try
					{
						enumerator.Reset();
					}
					catch
					{
					}
					break;
				}
			}
			type2 = typeof(GenericEnumerable<>).MakeGenericType(type);
		}
		object[] args = new object[1] { source };
		return (IEnumerable<T>)Activator.CreateInstance(type2, args);
	}

	internal static int IndexOf(this IEnumerable source, object item)
	{
		//Discarded unreachable code: IL_0032, IL_003c, IL_00cf, IL_00e2, IL_0130, IL_017d, IL_018c
		int num = 3;
		int num2 = num;
		IEnumerator enumerator = default(IEnumerator);
		int num4 = default(int);
		int result = default(int);
		while (true)
		{
			switch (num2)
			{
			case 1:
				try
				{
					while (true)
					{
						IL_0084:
						int num3;
						if (!t4UOAXGHcY33euNl8RRX(enumerator))
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
							{
								num3 = 0;
							}
							goto IL_0040;
						}
						goto IL_00ec;
						IL_0040:
						while (true)
						{
							switch (num3)
							{
							case 2:
								goto IL_0066;
							case 1:
								goto IL_0084;
							case 3:
							case 4:
								num4++;
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
								{
									num3 = 0;
								}
								continue;
							case 6:
								goto IL_00ec;
							case 0:
								break;
							case 5:
								return result;
							}
							break;
						}
						break;
						IL_0066:
						result = num4;
						num3 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
						{
							num3 = 3;
						}
						goto IL_0040;
						IL_00ec:
						if (!YWbDJDGHs8WC2ZI1yPxP(qeKJRbGHUd21D12fwVNT(enumerator), item))
						{
							num3 = 3;
							goto IL_0040;
						}
						goto IL_0066;
					}
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					int num5 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num5 = 1;
					}
					while (true)
					{
						switch (num5)
						{
						default:
							disposable.Dispose();
							num5 = 2;
							continue;
						case 1:
							if (disposable != null)
							{
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
								{
									num5 = 0;
								}
								continue;
							}
							break;
						case 2:
							break;
						}
						break;
					}
				}
				break;
			case 3:
				num4 = 0;
				num2 = 2;
				continue;
			case 2:
				enumerator = (IEnumerator)gobH7qGHLkXUvBxdw2AF(source);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			break;
		}
		return -1;
	}

	internal static object ElementAt(this IEnumerable source, int index)
	{
		//Discarded unreachable code: IL_0093, IL_009d, IL_0134, IL_0143, IL_01a4, IL_01f1, IL_023c, IL_024b, IL_027c, IL_028b, IL_029a
		int num = 5;
		IList list = default(IList);
		IEnumerator enumerator = default(IEnumerator);
		object obj = default(object);
		object result = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					return null;
				case 7:
					throw new ArgumentOutOfRangeException((string)EtTTXDGHzimby5nflDyM(0x12441CA4 ^ 0x1245D1D0));
				case 4:
					list = source as IList;
					num2 = 3;
					break;
				case 1:
					if (ckGIGBGAF6HNQrwBn9bQ(list) <= 0)
					{
						goto end_IL_0012;
					}
					goto case 6;
				case 8:
					try
					{
						while (true)
						{
							IL_0109:
							int num3;
							if (!t4UOAXGHcY33euNl8RRX(enumerator))
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
								{
									num3 = 2;
								}
								goto IL_00a1;
							}
							goto IL_00e6;
							IL_00e6:
							obj = qeKJRbGHUd21D12fwVNT(enumerator);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
							{
								num3 = 1;
							}
							goto IL_00a1;
							IL_00a1:
							while (true)
							{
								switch (num3)
								{
								default:
									return result;
								case 0:
									return result;
								case 5:
									index--;
									num3 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
									{
										num3 = 6;
									}
									continue;
								case 3:
									break;
								case 6:
									goto IL_0109;
								case 4:
									result = obj;
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
									{
										num3 = 0;
									}
									continue;
								case 1:
									if (index == 0)
									{
										num3 = 4;
										continue;
									}
									goto case 5;
								case 2:
									goto end_IL_0109;
								}
								break;
							}
							goto IL_00e6;
							continue;
							end_IL_0109:
							break;
						}
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								if (disposable != null)
								{
									num4 = 2;
									continue;
								}
								break;
							case 2:
								disposable.Dispose();
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
								{
									num4 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					goto case 9;
				case 6:
					return nllEOJGAB88MgdOwnaon(list, index);
				default:
					enumerator = (IEnumerator)gobH7qGHLkXUvBxdw2AF(source);
					num2 = 8;
					break;
				case 5:
					if (index >= 0)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
						{
							num2 = 4;
						}
						break;
					}
					goto case 7;
				case 3:
					if (list == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 1;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 2;
		}
	}

	[IteratorStateMachine(typeof(_003CSelectRecursive_003Ed__13<>))]
	public static IEnumerable<TSource> SelectRecursive<TSource>(this IEnumerable<TSource> source, Func<TSource, IEnumerable<TSource>> recursiveSelector)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CSelectRecursive_003Ed__13<TSource>(-2)
		{
			_003C_003E3__source = source,
			_003C_003E3__recursiveSelector = recursiveSelector
		};
	}

	public static IEnumerable<TResult> Consolidate<TFirst, TSecond, TResult>(this IEnumerable<TFirst> first, IEnumerable<TSecond> second, Func<TFirst, TSecond, TResult> resultSelector)
	{
		if (first == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42643203 ^ 0x426036D3));
		}
		if (second == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29254301 ^ -28993091));
		}
		if (resultSelector == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8317432 ^ 0x83570DC));
		}
		return ZipIterator(first, second, resultSelector);
	}

	[IteratorStateMachine(typeof(_003CZipIterator_003Ed__15<, , >))]
	private static IEnumerable<TResult> ZipIterator<TFirst, TSecond, TResult>(IEnumerable<TFirst> first, IEnumerable<TSecond> second, Func<TFirst, TSecond, TResult> resultSelector)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CZipIterator_003Ed__15<TFirst, TSecond, TResult>(-2)
		{
			_003C_003E3__first = first,
			_003C_003E3__second = second,
			_003C_003E3__resultSelector = resultSelector
		};
	}

	public static ReadOnlyCollection<T> ToReadOnlyCollection<T>(this IEnumerable<T> sequence)
	{
		if (sequence == null)
		{
			return DefaultReadOnlyCollection<T>.Empty;
		}
		if (sequence is ReadOnlyCollection<T> result)
		{
			return result;
		}
		return new ReadOnlyCollection<T>(sequence.ToArray());
	}

	public static ConcurrentDictionary<TKey, TSource> ToConcurrentDictionary<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
	{
		return source.ToConcurrentDictionary(keySelector, (TSource x) => x, null);
	}

	public static ConcurrentDictionary<TKey, TSource> ToConcurrentDictionary<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
	{
		return source.ToConcurrentDictionary(keySelector, (TSource x) => x, comparer);
	}

	public static ConcurrentDictionary<TKey, TElement> ToConcurrentDictionary<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
	{
		return source.ToConcurrentDictionary(keySelector, elementSelector, null);
	}

	public static ConcurrentDictionary<TKey, TElement> ToConcurrentDictionary<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
	{
		if (source == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088306818));
		}
		if (keySelector == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675507671));
		}
		if (elementSelector == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x92F12D5 ^ 0x92F1965));
		}
		ConcurrentDictionary<TKey, TElement> concurrentDictionary = new ConcurrentDictionary<TKey, TElement>(comparer ?? EqualityComparer<TKey>.Default);
		foreach (TSource item in source)
		{
			concurrentDictionary.TryAdd(keySelector(item), elementSelector(item));
		}
		return concurrentDictionary;
	}

	public static NameValueCollection ToNameValueCollection<TSource>(this IEnumerable<TSource> source, Func<TSource, string> nameSelector, Func<TSource, string> valueSelector, IEqualityComparer equalityComparer = null)
	{
		if (source == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70005333));
		}
		if (nameSelector == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1853098230));
		}
		if (valueSelector == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4D1C1EE4 ^ 0x4D181BCE));
		}
		NameValueCollection nameValueCollection = new NameValueCollection(equalityComparer);
		foreach (TSource item in source)
		{
			nameValueCollection.Add(nameSelector(item), valueSelector(item));
		}
		return nameValueCollection;
	}

	public static IEqualityComparer EqualityComparer(this NameValueCollection nameValueCollection)
	{
		return (IEqualityComparer)n7swVHGAWwEBP9Oni5Mt(NameValueCollectionComparerProperty.Value, nameValueCollection, null);
	}

	[IteratorStateMachine(typeof(_003CAsEnumerable_003Ed__25<>))]
	public static IEnumerable<T> AsEnumerable<T>(this IDataReader reader, Func<IDataReader, T> func)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CAsEnumerable_003Ed__25<T>(-2)
		{
			_003C_003E3__reader = reader,
			_003C_003E3__func = func
		};
	}

	public static Type GetElementType(Type collectionType)
	{
		return ElementTypeCache.GetOrAdd(collectionType, delegate(Type ct)
		{
			//Discarded unreachable code: IL_0049, IL_0058, IL_00a4, IL_00b3, IL_010d
			int num = 4;
			int num2 = num;
			Type type2 = default(Type);
			while (true)
			{
				Type type;
				switch (num2)
				{
				case 5:
					return null;
				case 6:
					if (_003C_003Ec.oFXcZU8fPwr7LN0Ds3CZ(type2, null))
					{
						return type2.GetGenericArguments()[0];
					}
					num2 = 5;
					continue;
				case 4:
					if (!ct.IsGenericType)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 1;
				case 1:
					if (_003C_003Ec.kmhclw8feqYDvCnmIJwY(ct.GetGenericTypeDefinition(), _003C_003Ec.HrLDxb8f2wdgntvu6yJF(typeof(IEnumerable<>).TypeHandle)))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto default;
				default:
					type = ct.GetInterface(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317943680));
					break;
				case 2:
					type = ct;
					break;
				}
				type2 = type;
				num2 = 6;
			}
		});
	}

	public static IEnumerable<TSource> Concat<TSource>(this TSource first, IEnumerable<TSource> second)
	{
		return Enumerable.Repeat(first, 1).Concat(second);
	}

	public static IEnumerable<TSource> Concat<TSource>(this IEnumerable<TSource> first, TSource second)
	{
		return first.Concat(Enumerable.Repeat(second, 1));
	}

	public static IEnumerable<TSource> ConcatIfNotNull<TSource>(this IEnumerable<TSource> first, TSource second)
	{
		if (second != null)
		{
			return first.Concat(second);
		}
		return first;
	}

	public static TimeSpan Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, TimeSpan> selector)
	{
		_003C_003Ec__DisplayClass31_0<TSource> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass31_0<TSource>();
		CS_0024_003C_003E8__locals0.selector = selector;
		if (source != null)
		{
			return new TimeSpan(source.Sum((TSource s) => CS_0024_003C_003E8__locals0.selector(s).Ticks));
		}
		return TimeSpan.Zero;
	}

	[IteratorStateMachine(typeof(_003CToEnumerable_003Ed__32<>))]
	public static IEnumerable<T> ToEnumerable<T>(this T item)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CToEnumerable_003Ed__32<T>(-2)
		{
			_003C_003E3__item = item
		};
	}

	public static IEnumerable<T> OrderByDependencies<T>(this IEnumerable<T> elements, Func<T, T, bool> hasDependency)
	{
		Linkage<T>[] array = elements.Select((T d) => new Linkage<T>
		{
			Element = d
		}).ToArray();
		List<T> list = new List<T>();
		Linkage<T>[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			Add(array2[i], list, array, hasDependency);
		}
		return list;
	}

	private static void Add<T>(Linkage<T> item, ICollection<T> list, IEnumerable<Linkage<T>> population, Func<T, T, bool> hasDependency)
	{
		_003C_003Ec__DisplayClass34_0<T> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass34_0<T>();
		CS_0024_003C_003E8__locals0.hasDependency = hasDependency;
		CS_0024_003C_003E8__locals0.item = item;
		if (CS_0024_003C_003E8__locals0.item.Used)
		{
			return;
		}
		CS_0024_003C_003E8__locals0.item.Used = true;
		foreach (Linkage<T> item2 in population.Where((Linkage<T> dep) => CS_0024_003C_003E8__locals0.hasDependency(CS_0024_003C_003E8__locals0.item.Element, dep.Element)))
		{
			Add(item2, list, population, CS_0024_003C_003E8__locals0.hasDependency);
		}
		list.Add(CS_0024_003C_003E8__locals0.item.Element);
	}

	public static bool In<T>(this T instance, params T[] expected)
	{
		return expected.Contains(instance);
	}

	static EnumerableExtensions()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				VWJ5dSGAoxG1iDwJqFkB();
				num2 = 2;
				break;
			case 0:
				return;
			case 2:
				NameValueCollectionComparerProperty = new Lazy<PropertyInfo>(() => _003C_003Ec.HrLDxb8f2wdgntvu6yJF(typeof(NameObjectCollectionBase).TypeHandle).GetProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335343519), BindingFlags.Instance | BindingFlags.NonPublic));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				ElementTypeCache = new ConcurrentDictionary<Type, Type>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object gobH7qGHLkXUvBxdw2AF(object P_0)
	{
		return ((IEnumerable)P_0).GetEnumerator();
	}

	internal static object qeKJRbGHUd21D12fwVNT(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}

	internal static bool YWbDJDGHs8WC2ZI1yPxP(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static bool t4UOAXGHcY33euNl8RRX(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static bool CX095MGHjeVJGhEMxmx3()
	{
		return DOpVQvGH5ymEQHYndfjn == null;
	}

	internal static EnumerableExtensions wYTyPNGHYXEMKjHF71uQ()
	{
		return DOpVQvGH5ymEQHYndfjn;
	}

	internal static object EtTTXDGHzimby5nflDyM(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static int ckGIGBGAF6HNQrwBn9bQ(object P_0)
	{
		return ((ICollection)P_0).Count;
	}

	internal static object nllEOJGAB88MgdOwnaon(object P_0, int P_1)
	{
		return ((IList)P_0)[P_1];
	}

	internal static object n7swVHGAWwEBP9Oni5Mt(object P_0, object P_1, object P_2)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}

	internal static void VWJ5dSGAoxG1iDwJqFkB()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
