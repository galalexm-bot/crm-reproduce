using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using EleWise.ELMA.Collections;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Context;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata;

[EditorBrowsable(EditorBrowsableState.Never)]
public static class PublishCacheContext
{
	internal class Local<T> : ICache where T : class
	{
		private class ValueContainer
		{
			public T value;

			private static object ILNLUgZSQnGWXGURlgZj;

			public ValueContainer()
			{
				//Discarded unreachable code: IL_002a, IL_002f
				SingletonReader.JJCZtPuTvSt();
				base._002Ector();
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}

			internal static bool bxMYhcZSCWfWPdbLLx35()
			{
				return ILNLUgZSQnGWXGURlgZj == null;
			}

			internal static object Htc4aqZSv6CCofunnGoH()
			{
				return ILNLUgZSQnGWXGURlgZj;
			}
		}

		private readonly Func<T, T> clone;

		private readonly Action<T> onCancel;

		private readonly Action<T> onComplete;

		private readonly Action<T> onClear;

		private (ValueContainer ValueContainer, ConcurrentDictionary<ICache, object> Context) currentGlobal;

		internal static object iHXrDyCac6wOvwacpyW5;

		public T Value
		{
			get
			{
				return GetValueContainer().value;
			}
			set
			{
				GetValueContainer().value = value;
			}
		}

		public Local(Func<T, T> clone = null, Action<T> onCancel = null, Action<T> onComplete = null, Action<T> onClear = null)
		{
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			this.clone = clone;
			this.onCancel = onCancel;
			this.onComplete = onComplete;
			this.onClear = onClear;
			ConcurrentDictionary<ICache, object> currentGlobalContext = PublishCacheContext.currentGlobalContext;
			currentGlobal = ((ValueContainer)currentGlobalContext.GetOrAdd(this, (ICache c) => c.Clone(null)), currentGlobalContext);
		}

		private ValueContainer GetValueContainer()
		{
			ConcurrentDictionary<ICache, object> caches = GetCaches();
			(ValueContainer, ConcurrentDictionary<ICache, object>) tuple = currentGlobal;
			if (caches != tuple.Item2)
			{
				return (ValueContainer)caches.GetOrAdd(this, (ICache c) => c.Clone(null));
			}
			return tuple.Item1;
		}

		object ICache.Clone(object cache)
		{
			//Discarded unreachable code: IL_0086, IL_0095
			int num = 3;
			int num2 = num;
			T val3 = default(T);
			T val = default(T);
			while (true)
			{
				T val2;
				switch (num2)
				{
				case 1:
				case 5:
					return new ValueContainer
					{
						value = val3
					};
				default:
					val3 = clone(val3);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					val = null;
					num2 = 4;
					continue;
				case 6:
					if (clone == null)
					{
						num2 = 5;
						continue;
					}
					goto default;
				case 3:
				{
					ValueContainer obj = (ValueContainer)cache;
					if (obj == null)
					{
						num2 = 2;
						continue;
					}
					val2 = obj.value;
					break;
				}
				case 4:
					val2 = val;
					break;
				}
				val3 = val2;
				num2 = 6;
			}
		}

		void ICache.OnCancel(object cache)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					return;
				case 1:
				{
					Action<T> action = onCancel;
					if (action == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
						{
							num2 = 0;
						}
						break;
					}
					ValueContainer obj = (ValueContainer)cache;
					action((obj != null) ? obj.value : null);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 1;
					}
					break;
				}
				case 0:
					return;
				}
			}
		}

		void ICache.OnComplete(object cache)
		{
			int num = 4;
			int num2 = num;
			ValueContainer valueContainer = default(ValueContainer);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 3:
				{
					Action<T> action = onComplete;
					if (action == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
						{
							num2 = 1;
						}
					}
					else
					{
						action((valueContainer != null) ? valueContainer.value : null);
						num2 = 2;
					}
					break;
				}
				case 4:
					valueContainer = (ValueContainer)cache;
					num2 = 3;
					break;
				case 1:
				case 2:
					currentGlobal = (valueContainer, GetCaches());
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		void ICache.Remove(object cache, Type type, Guid uid)
		{
		}

		void ICache.Clear(object cache)
		{
			int num = 2;
			int num2 = num;
			T value = default(T);
			while (true)
			{
				switch (num2)
				{
				case 3:
					return;
				case 1:
					((ValueContainer)cache).value = null;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					value = ((ValueContainer)cache).value;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					return;
				}
				Action<T> action = onClear;
				if (action == null)
				{
					num2 = 4;
					continue;
				}
				action(value);
				num2 = 3;
			}
		}

		internal static bool fdLnPiCazZmaOwfh5Rpl()
		{
			return iHXrDyCac6wOvwacpyW5 == null;
		}

		internal static object yAmLJqCDF9bib2nc0Tam()
		{
			return iHXrDyCac6wOvwacpyW5;
		}
	}

	private class PreviousGlobalContextCount
	{
		public int Count;

		private static object jFVxSUCDB4rFP57JiJiw;

		public PreviousGlobalContextCount()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			KDnghTCDbLv8HvlNA3L1();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void KDnghTCDbLv8HvlNA3L1()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool w1u95tCDWQslatWdhWsO()
		{
			return jFVxSUCDB4rFP57JiJiw == null;
		}

		internal static PreviousGlobalContextCount WIWv1wCDoJsYHp9qPfrr()
		{
			return (PreviousGlobalContextCount)jFVxSUCDB4rFP57JiJiw;
		}
	}

	private class CreateCacheDisposable : IDisposable
	{
		private readonly ConcurrentDictionary<ICache, object> oldContext;

		internal static object o3KDluCDhcV8QDIP3wxk;

		public CreateCacheDisposable()
		{
			//Discarded unreachable code: IL_001a, IL_001f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 1:
					return;
				case 2:
					oldContext = LocalCaches;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
					{
						num = 0;
					}
					continue;
				}
				LocalCaches = new ConcurrentDictionary<ICache, object>(from p in GetCaches()
					select new KeyValuePair<ICache, object>(p.Key, p.Key.Clone(p.Value)));
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num = 0;
				}
			}
		}

		public void Dispose()
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 2:
					if (LocalCaches == currentGlobalContext)
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					LocalCaches = oldContext;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					Cancel(LocalCaches);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 3;
					}
					break;
				}
			}
		}

		internal static bool JSVGNFCDGs2jAfB0N1M2()
		{
			return o3KDluCDhcV8QDIP3wxk == null;
		}

		internal static CreateCacheDisposable EfYEtXCDE4VyMf9QE7Ka()
		{
			return (CreateCacheDisposable)o3KDluCDhcV8QDIP3wxk;
		}
	}

	private interface ICache
	{
		object Clone(object cache);

		void Remove(object cache, Type type, Guid uid);

		void OnComplete(object cache);

		void OnCancel(object cache);

		void Clear(object cache);
	}

	internal interface IConcurrentDictionary<TKey, TValue>
	{
		TValue AddOrUpdate<TArg>(TKey key, Func<TKey, TArg, TValue> addValueFactory, Func<TKey, TValue, TArg, TValue> updateValueFactory, TArg factoryArgument);

		TValue AddOrUpdate(TKey key, Func<TKey, TValue> addValueFactory, Func<TKey, TValue, TValue> updateValueFactory);

		TValue AddOrUpdate(TKey key, TValue addValue, Func<TKey, TValue, TValue> updateValueFactory);

		TValue GetOrAdd(TKey key, Func<TKey, TValue> valueFactory);

		TValue GetOrAdd(TKey key, TValue value);

		TValue GetOrAdd<TArg>(TKey key, Func<TKey, TArg, TValue> valueFactory, TArg factoryArgument);

		bool TryUpdate(TKey key, TValue newValue, TValue comparisonValue);
	}

	private class CacheDictinary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IConcurrentDictionary<TKey, TValue>, ICache
	{
		private readonly Func<IDictionary<TKey, TValue>, IDictionary<TKey, TValue>> clone;

		private readonly Action<IDictionary<TKey, TValue>, Type, Guid> remove;

		private readonly Action<IDictionary<TKey, TValue>> onComplete;

		private readonly Action<IDictionary<TKey, TValue>> onCancel;

		private static object vH5BxdCDufkZ9Fxm6Hca;

		private IDictionary<TKey, TValue> Cache => GetCache<IDictionary<TKey, TValue>>(this);

		public TValue this[TKey key]
		{
			get
			{
				return Cache[key];
			}
			set
			{
				Cache[key] = value;
			}
		}

		public ICollection<TKey> Keys => Cache.Keys;

		public ICollection<TValue> Values => Cache.Values;

		public int Count => Cache.Count;

		public bool IsReadOnly => Cache.IsReadOnly;

		public CacheDictinary(Func<IDictionary<TKey, TValue>, IDictionary<TKey, TValue>> clone, Action<IDictionary<TKey, TValue>, Type, Guid> remove, Action<IDictionary<TKey, TValue>> onComplete, Action<IDictionary<TKey, TValue>> onCancel)
		{
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			this.clone = clone;
			this.remove = remove;
			this.onComplete = onComplete;
			this.onCancel = onCancel;
			GetCache<IDictionary<TKey, TValue>>(this);
		}

		object ICache.Clone(object cache)
		{
			return clone(((IDictionary<TKey, TValue>)cache) ?? new Dictionary<TKey, TValue>());
		}

		void ICache.Remove(object cache, Type type, Guid uid)
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 2:
				{
					Action<IDictionary<TKey, TValue>, Type, Guid> action = remove;
					if (action == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
						{
							num2 = 1;
						}
						break;
					}
					action((IDictionary<TKey, TValue>)cache, type, uid);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
					{
						num2 = 0;
					}
					break;
				}
				case 1:
					return;
				}
			}
		}

		void ICache.OnComplete(object cache)
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 2:
				{
					Action<IDictionary<TKey, TValue>> action = onComplete;
					if (action == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
						{
							num2 = 0;
						}
						break;
					}
					action((IDictionary<TKey, TValue>)cache);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 0;
					}
					break;
				}
				case 1:
					return;
				}
			}
		}

		void ICache.OnCancel(object cache)
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 2:
				{
					Action<IDictionary<TKey, TValue>> action = onCancel;
					if (action == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
						{
							num2 = 1;
						}
						break;
					}
					action((IDictionary<TKey, TValue>)cache);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 0;
					}
					break;
				}
				case 1:
					return;
				}
			}
		}

		void ICache.Clear(object cache)
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
					((IDictionary<TKey, TValue>)cache).Clear();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		public void Add(TKey key, TValue value)
		{
			Cache.Add(key, value);
		}

		public void Add(KeyValuePair<TKey, TValue> item)
		{
			Cache.Add(item);
		}

		public void Clear()
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
					Cache.Clear();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		public bool Contains(KeyValuePair<TKey, TValue> item)
		{
			return Cache.Contains(item);
		}

		public bool ContainsKey(TKey key)
		{
			return Cache.ContainsKey(key);
		}

		public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					Cache.CopyTo(array, arrayIndex);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return Cache.GetEnumerator();
		}

		public bool Remove(TKey key)
		{
			return Cache.Remove(key);
		}

		public bool Remove(KeyValuePair<TKey, TValue> item)
		{
			return Cache.Remove(item);
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			return Cache.TryGetValue(key, out value);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable)Cache).GetEnumerator();
		}

		TValue IConcurrentDictionary<TKey, TValue>.AddOrUpdate<TArg>(TKey key, Func<TKey, TArg, TValue> addValueFactory, Func<TKey, TValue, TArg, TValue> updateValueFactory, TArg factoryArgument)
		{
			return Cache.AddOrUpdate(key, addValueFactory, updateValueFactory, factoryArgument);
		}

		TValue IConcurrentDictionary<TKey, TValue>.AddOrUpdate(TKey key, Func<TKey, TValue> addValueFactory, Func<TKey, TValue, TValue> updateValueFactory)
		{
			return Cache.AddOrUpdate(key, addValueFactory, updateValueFactory);
		}

		TValue IConcurrentDictionary<TKey, TValue>.AddOrUpdate(TKey key, TValue addValue, Func<TKey, TValue, TValue> updateValueFactory)
		{
			return Cache.AddOrUpdate(key, addValue, updateValueFactory);
		}

		TValue IConcurrentDictionary<TKey, TValue>.GetOrAdd(TKey key, Func<TKey, TValue> valueFactory)
		{
			return Cache.GetOrAdd(key, valueFactory);
		}

		TValue IConcurrentDictionary<TKey, TValue>.GetOrAdd(TKey key, TValue value)
		{
			return Cache.GetOrAdd(key, value);
		}

		TValue IConcurrentDictionary<TKey, TValue>.GetOrAdd<TArg>(TKey key, Func<TKey, TArg, TValue> valueFactory, TArg factoryArgument)
		{
			return Cache.GetOrAdd(key, valueFactory, factoryArgument);
		}

		bool IConcurrentDictionary<TKey, TValue>.TryUpdate(TKey key, TValue newValue, TValue comparisonValue)
		{
			return Cache.TryUpdate(key, newValue, comparisonValue);
		}

		internal static bool mwwjJgCDI5HV072JxqDe()
		{
			return vH5BxdCDufkZ9Fxm6Hca == null;
		}

		internal static object ooVtl4CDVPeOGEp1oLbs()
		{
			return vH5BxdCDufkZ9Fxm6Hca;
		}
	}

	private class CacheSet<T> : ISet<T>, ICollection<T>, IEnumerable<T>, IEnumerable, ICache
	{
		private readonly Func<ISet<T>, ISet<T>> clone;

		private readonly Action<ISet<T>, Type, Guid> remove;

		private readonly Action<ISet<T>> onComplete;

		private readonly Action<ISet<T>> onCancel;

		internal static object IL58c4CDS5pkHDTgxTju;

		private ISet<T> Cache => GetCache<ISet<T>>(this);

		public int Count => Cache.Count;

		public bool IsReadOnly => Cache.IsReadOnly;

		public CacheSet(Func<ISet<T>, ISet<T>> clone, Action<ISet<T>, Type, Guid> remove, Action<ISet<T>> onComplete, Action<ISet<T>> onCancel)
		{
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			this.clone = clone;
			this.remove = remove;
			this.onComplete = onComplete;
			this.onCancel = onCancel;
			GetCache<ISet<T>>(this);
		}

		object ICache.Clone(object cache)
		{
			return clone(((ISet<T>)cache) ?? new HashSet<T>());
		}

		void ICache.Remove(object cache, Type type, Guid uid)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					return;
				case 1:
				{
					Action<ISet<T>, Type, Guid> action = remove;
					if (action == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
						{
							num2 = 0;
						}
						break;
					}
					action((ISet<T>)cache, type, uid);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 2;
					}
					break;
				}
				case 0:
					return;
				}
			}
		}

		void ICache.OnComplete(object cache)
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 2:
				{
					Action<ISet<T>> action = onComplete;
					if (action == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
						{
							num2 = 0;
						}
						break;
					}
					action((ISet<T>)cache);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 0;
					}
					break;
				}
				case 1:
					return;
				}
			}
		}

		void ICache.OnCancel(object cache)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					return;
				case 1:
				{
					Action<ISet<T>> action = onCancel;
					if (action == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
						{
							num2 = 0;
						}
						break;
					}
					action((ISet<T>)cache);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
					{
						num2 = 2;
					}
					break;
				}
				case 0:
					return;
				}
			}
		}

		void ICache.Clear(object cache)
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
					((ISet<T>)cache).Clear();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		public bool Add(T item)
		{
			return Cache.Add(item);
		}

		public void Clear()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					Cache.Clear();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public bool Contains(T item)
		{
			return Cache.Contains(item);
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					Cache.CopyTo(array, arrayIndex);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public void ExceptWith(IEnumerable<T> other)
		{
			Cache.ExceptWith(other);
		}

		public IEnumerator<T> GetEnumerator()
		{
			return Cache.GetEnumerator();
		}

		public void IntersectWith(IEnumerable<T> other)
		{
			Cache.IntersectWith(other);
		}

		public bool IsProperSubsetOf(IEnumerable<T> other)
		{
			return Cache.IsProperSubsetOf(other);
		}

		public bool IsProperSupersetOf(IEnumerable<T> other)
		{
			return Cache.IsProperSupersetOf(other);
		}

		public bool IsSubsetOf(IEnumerable<T> other)
		{
			return Cache.IsSubsetOf(other);
		}

		public bool IsSupersetOf(IEnumerable<T> other)
		{
			return Cache.IsSupersetOf(other);
		}

		public bool Overlaps(IEnumerable<T> other)
		{
			return Cache.Overlaps(other);
		}

		public bool Remove(T item)
		{
			return Cache.Remove(item);
		}

		public bool SetEquals(IEnumerable<T> other)
		{
			return Cache.SetEquals(other);
		}

		public void SymmetricExceptWith(IEnumerable<T> other)
		{
			Cache.SymmetricExceptWith(other);
		}

		public void UnionWith(IEnumerable<T> other)
		{
			Cache.UnionWith(other);
		}

		void ICollection<T>.Add(T item)
		{
			Cache.Add(item);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable)Cache).GetEnumerator();
		}

		internal static bool NW5EdXCDiqRAWfFI4kyU()
		{
			return IL58c4CDS5pkHDTgxTju == null;
		}

		internal static object hv2baaCDRP7CBjKRIeDO()
		{
			return IL58c4CDS5pkHDTgxTju;
		}
	}

	private static ConcurrentDictionary<ICache, object> currentGlobalContext;

	internal static ILogger logger;

	private static int currentGlobalContextCount;

	private static SpinLock currentGlobalContextCountLock;

	private static readonly ConditionalWeakTable<ConcurrentDictionary<ICache, object>, PreviousGlobalContextCount> PreviousGlobalContextCounts;

	private static PublishCacheContext XGgpbsb3xHyq8s9wEUIS;

	private static ConcurrentDictionary<ICache, object> LocalCaches
	{
		get
		{
			return (ConcurrentDictionary<ICache, object>)ELMAContext.PublishCaches;
		}
		set
		{
			ELMAContext.PublishCaches = value;
		}
	}

	public static IDictionary<TKey, TValue> CreateCache<TKey, TValue>(Action<IDictionary<TKey, TValue>, Type, Guid> remove = null)
	{
		return CreateCache((IDictionary<TKey, TValue> c) => new ConcurrentDictionary<TKey, TValue>(c), remove);
	}

	public static ISet<T> CreateCache<T>(Action<ISet<T>, Type, Guid> remove = null)
	{
		return CreateCache((ISet<T> c) => new ConcurrentHashSet<T>(c), remove);
	}

	internal static IDictionary<TKey, TValue> CreateCache<TKey, TValue>(Func<IDictionary<TKey, TValue>, IDictionary<TKey, TValue>> clone, Action<IDictionary<TKey, TValue>, Type, Guid> remove = null, Action<IDictionary<TKey, TValue>> onComplete = null, Action<IDictionary<TKey, TValue>> onCancel = null)
	{
		return new CacheDictinary<TKey, TValue>(clone, remove, onComplete, onCancel);
	}

	internal static ISet<T> CreateCache<T>(Func<ISet<T>, ISet<T>> clone, Action<ISet<T>, Type, Guid> remove = null, Action<ISet<T>> onComplete = null, Action<ISet<T>> onCancel = null)
	{
		return new CacheSet<T>(clone, remove, onComplete, onCancel);
	}

	static PublishCacheContext()
	{
		int num = 6;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					PreviousGlobalContextCounts = new ConditionalWeakTable<ConcurrentDictionary<ICache, object>, PreviousGlobalContextCount>();
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					currentGlobalContextCountLock = default(SpinLock);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					EmqkLlb39GwH4EFcrm25(new EventHandler(ELMAContext_OnClear));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 4;
					}
					continue;
				case 1:
					logger = (ILogger)vSWIX3b3J2G3QshfgxJq(loqmh4b3MwallxputmBm(typeof(PublishCacheContext).TypeHandle));
					num2 = 2;
					continue;
				case 5:
					currentGlobalContext = new ConcurrentDictionary<ICache, object>();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					return;
				case 6:
					break;
				}
				break;
			}
			Jj7O3Lb3ybOVXSQP92FQ();
			num = 5;
		}
	}

	internal static IDisposable Create()
	{
		return new CreateCacheDisposable();
	}

	internal static void Complete()
	{
		//Discarded unreachable code: IL_0069, IL_00da, IL_0162, IL_019d, IL_01ac, IL_01cd, IL_01dc, IL_0262
		int num = 11;
		int num2 = num;
		bool lockTaken = default(bool);
		ConcurrentDictionary<ICache, object> concurrentDictionary = default(ConcurrentDictionary<ICache, object>);
		int num3 = default(int);
		ConcurrentDictionary<ICache, object> caches = default(ConcurrentDictionary<ICache, object>);
		while (true)
		{
			switch (num2)
			{
			case 7:
				return;
			case 1:
				lockTaken = false;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
				{
					num2 = 12;
				}
				continue;
			case 4:
				h6coPRb3g47LnBJMMYvn(concurrentDictionary);
				num2 = 6;
				continue;
			case 17:
				if (num3 > 0)
				{
					num2 = 2;
					continue;
				}
				goto default;
			case 12:
				try
				{
					currentGlobalContextCountLock.Enter(ref lockTaken);
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							currentGlobalContext = caches;
							num4 = 3;
							continue;
						case 3:
							currentGlobalContextCount = 1;
							num4 = 2;
							continue;
						case 1:
							num3 = currentGlobalContextCount - 1;
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
							{
								num4 = 0;
							}
							continue;
						case 2:
							break;
						}
						break;
					}
				}
				finally
				{
					if (lockTaken)
					{
						int num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
						{
							num5 = 1;
						}
						while (true)
						{
							switch (num5)
							{
							case 1:
								currentGlobalContextCountLock.Exit();
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
								{
									num5 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
				goto case 17;
			case 14:
			case 16:
				if (num3 != 0)
				{
					num2 = 7;
					continue;
				}
				break;
			default:
				if (!OqYEQSb3dBX1nWTdZFK5(logger))
				{
					num2 = 13;
					continue;
				}
				goto case 9;
			case 5:
			case 13:
				mVKs7Bb3rTtPF4MU364s(logger, GAnfVQb3l1L1XEBTOv0e(0x1DE3DD89 ^ 0x1DE13A4D));
				num2 = 14;
				continue;
			case 8:
				return;
			case 11:
				caches = GetCaches();
				num2 = 10;
				continue;
			case 3:
				concurrentDictionary = currentGlobalContext;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 1;
				}
				continue;
			case 2:
				PreviousGlobalContextCounts.Add(concurrentDictionary, new PreviousGlobalContextCount
				{
					Count = num3
				});
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
				{
					num2 = 0;
				}
				continue;
			case 6:
				logger.Info(GAnfVQb3l1L1XEBTOv0e(-1317790512 ^ -1317602520));
				num2 = 8;
				continue;
			case 9:
				logger.InfoFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87444697), num3);
				num2 = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 16;
				}
				continue;
			case 10:
				caches.ForEach(delegate(KeyValuePair<ICache, object> p)
				{
					p.Key.OnComplete(p.Value);
				});
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
				{
					num2 = 3;
				}
				continue;
			case 15:
				break;
			}
			concurrentDictionary.ForEach(delegate(KeyValuePair<ICache, object> p)
			{
				p.Key.Clear(p.Value);
			});
			num2 = 4;
		}
	}

	private static void Cancel(ConcurrentDictionary<ICache, object> caches)
	{
		caches.ForEach(delegate(KeyValuePair<ICache, object> p)
		{
			p.Key.OnCancel(p.Value);
		});
	}

	internal static void RemoveFromCache(Type type, Guid uid)
	{
		//Discarded unreachable code: IL_0042, IL_0051
		int num = 5;
		_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = default(_003C_003Ec__DisplayClass11_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return;
				case 5:
					_003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
					num2 = 4;
					continue;
				default:
					GetCaches().ForEach(_003C_003Ec__DisplayClass11_._003CRemoveFromCache_003Eb__0);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					if (!logger.IsTraceEnabled())
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 4:
					_003C_003Ec__DisplayClass11_.type = type;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 6;
					}
					continue;
				case 3:
					break;
				case 6:
					_003C_003Ec__DisplayClass11_.uid = uid;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			}
			JA5QJUb35MoMjSfS9Vgc(logger, string.Format((string)GAnfVQb3l1L1XEBTOv0e(-1870892489 ^ -1870751217), _003C_003Ec__DisplayClass11_.type.FullName, _003C_003Ec__DisplayClass11_.uid));
			num = 7;
		}
	}

	private static T GetCache<T>(object cache)
	{
		return (T)GetCaches().GetOrAdd((ICache)cache, (ICache c) => c.Clone(null));
	}

	private static ConcurrentDictionary<ICache, object> GetCaches()
	{
		if (!ELMAContext.Initialized)
		{
			return currentGlobalContext;
		}
		ConcurrentDictionary<ICache, object> localCaches = LocalCaches;
		if (localCaches == null)
		{
			bool lockTaken = false;
			try
			{
				currentGlobalContextCountLock.Enter(ref lockTaken);
				localCaches = LocalCaches;
				localCaches = (ConcurrentDictionary<ICache, object>)ELMAContext.PublishCaches;
				if (localCaches != null)
				{
					return localCaches;
				}
				localCaches = (LocalCaches = currentGlobalContext);
				currentGlobalContextCount++;
				logger.DebugFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x463A0F3C ^ 0x4638E74A), currentGlobalContextCount);
				return localCaches;
			}
			finally
			{
				if (lockTaken)
				{
					currentGlobalContextCountLock.Exit();
				}
			}
		}
		return localCaches;
	}

	private static void ELMAContext_OnClear(object sender, object e)
	{
		//Discarded unreachable code: IL_00ee, IL_0148, IL_01b9, IL_01d8, IL_01e7, IL_0217, IL_02d6
		int num = 5;
		int num3 = default(int);
		ConcurrentDictionary<ICache, object> localCaches = default(ConcurrentDictionary<ICache, object>);
		bool lockTaken = default(bool);
		bool flag = default(bool);
		PreviousGlobalContextCount value = default(PreviousGlobalContextCount);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 13:
					logger.DebugFormat((string)GAnfVQb3l1L1XEBTOv0e(-1886646897 ^ -1886460773), num3);
					num2 = 9;
					continue;
				case 5:
					localCaches = LocalCaches;
					num2 = 4;
					continue;
				case 15:
					localCaches.Clear();
					num2 = 6;
					continue;
				case 1:
					return;
				case 3:
					return;
				case 6:
					mVKs7Bb3rTtPF4MU364s(logger, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1334871049));
					num2 = 16;
					continue;
				case 12:
					return;
				default:
					lockTaken = false;
					num2 = 10;
					continue;
				case 2:
					if (flag)
					{
						num2 = 8;
					}
					else if (!PreviousGlobalContextCounts.TryGetValue(localCaches, out value))
					{
						logger.WarnFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1633514411 ^ -1633655491));
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
						{
							num2 = 1;
						}
					}
					else
					{
						num2 = 14;
					}
					continue;
				case 14:
					num3 = Interlocked.Decrement(ref value.Count);
					num2 = 13;
					continue;
				case 10:
					try
					{
						currentGlobalContextCountLock.Enter(ref lockTaken);
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								if (flag = localCaches == currentGlobalContext)
								{
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
									{
										num4 = 0;
									}
									continue;
								}
								break;
							default:
								currentGlobalContextCount--;
								num4 = 2;
								continue;
							case 2:
								break;
							}
							break;
						}
					}
					finally
					{
						int num5;
						if (!lockTaken)
						{
							num5 = 2;
							goto IL_01bd;
						}
						goto IL_01f2;
						IL_01bd:
						switch (num5)
						{
						case 2:
							goto end_IL_01a8;
						case 1:
							goto end_IL_01a8;
						}
						goto IL_01f2;
						IL_01f2:
						currentGlobalContextCountLock.Exit();
						num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
						{
							num5 = 1;
						}
						goto IL_01bd;
						end_IL_01a8:;
					}
					goto case 2;
				case 16:
					return;
				case 9:
					if (num3 != 0)
					{
						num2 = 3;
						continue;
					}
					break;
				case 8:
					goto end_IL_0012;
				case 11:
					return;
				case 4:
					if (localCaches == null)
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					break;
				}
				localCaches.ForEach(delegate(KeyValuePair<ICache, object> p)
				{
					p.Key.Clear(p.Value);
				});
				num2 = 15;
				continue;
				end_IL_0012:
				break;
			}
			logger.DebugFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x10E41EDB ^ 0x10E6F61F), currentGlobalContextCount);
			num = 11;
		}
	}

	internal static void Jj7O3Lb3ybOVXSQP92FQ()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Type loqmh4b3MwallxputmBm(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object vSWIX3b3J2G3QshfgxJq(Type componentType)
	{
		return Logger.GetLogger(componentType);
	}

	internal static void EmqkLlb39GwH4EFcrm25(object P_0)
	{
		ELMAContext.OnClear += (EventHandler)P_0;
	}

	internal static bool DLrjBdb30HpW28X7FpwW()
	{
		return XGgpbsb3xHyq8s9wEUIS == null;
	}

	internal static PublishCacheContext LhSV6Fb3mh5e1KDvsmic()
	{
		return XGgpbsb3xHyq8s9wEUIS;
	}

	internal static bool OqYEQSb3dBX1nWTdZFK5(object P_0)
	{
		return ((ILogger)P_0).IsDebugEnabled();
	}

	internal static object GAnfVQb3l1L1XEBTOv0e(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void mVKs7Bb3rTtPF4MU364s(object P_0, object P_1)
	{
		((ILogger)P_0).Info(P_1);
	}

	internal static void h6coPRb3g47LnBJMMYvn(object P_0)
	{
		((ConcurrentDictionary<ICache, object>)P_0).Clear();
	}

	internal static void JA5QJUb35MoMjSfS9Vgc(object P_0, object P_1)
	{
		((ILogger)P_0).Trace(P_1);
	}
}
