using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Reflection;
using System.Web.Mvc;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.ComponentModel;

public static class AttributeHelper<T> where T : Attribute
{
	private class AttributesCache<TKey> where TKey : class
	{
		protected IDictionary<TKey, WeakReference<IList<T>>> cache;

		protected IDictionary<TKey, WeakReference<IList<T>>> cacheInherited;

		internal static object ungsdh8gzNyksYIKGWFb;

		protected AttributesCache(IDictionary<TKey, WeakReference<IList<T>>> cache, IDictionary<TKey, WeakReference<IList<T>>> cacheInherited)
		{
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			this.cache = cache;
			this.cacheInherited = cacheInherited;
		}

		public AttributesCache()
		{
			//Discarded unreachable code: IL_0034, IL_0039
			SingletonReader.JJCZtPuTvSt();
			this._002Ector((IDictionary<TKey, WeakReference<IList<T>>>)new ConcurrentDictionary<TKey, WeakReference<IList<T>>>(), (IDictionary<TKey, WeakReference<IList<T>>>)new ConcurrentDictionary<TKey, WeakReference<IList<T>>>());
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public IList<T> GetList(TKey key, bool inherited, Func<TKey, bool, IList<T>> getResultFunc)
		{
			IDictionary<TKey, WeakReference<IList<T>>> dictionary = (inherited ? cacheInherited : cache);
			if (!dictionary.TryGetValue(key, out var value) || value == null || !value.TryGetTarget(out var target))
			{
				target = getResultFunc(key, inherited);
				dictionary[key] = new WeakReference<IList<T>>(target);
			}
			return target;
		}

		public T Get(TKey key, bool inherited, Func<TKey, bool, IList<T>> getResultFunc)
		{
			IList<T> list = GetList(key, inherited, getResultFunc);
			if (list.Count <= 0)
			{
				return null;
			}
			return list[0];
		}

		internal static bool FCtm0u85F3XkxP6eejhS()
		{
			return ungsdh8gzNyksYIKGWFb == null;
		}

		internal static object bdyFuI85BOCEFM27F4aq()
		{
			return ungsdh8gzNyksYIKGWFb;
		}
	}

	private class AttributesCacheType : AttributesCache<Type>
	{
		internal static object Xv2rLm85WUgdpgjRRxwy;

		public AttributesCacheType()
		{
			//Discarded unreachable code: IL_007d, IL_0082
			SingletonReader.JJCZtPuTvSt();
			base._002Ector(PublishCacheContext.CreateCache(delegate(IDictionary<Type, WeakReference<IList<T>>> c, Type type, Guid _)
			{
				c.Remove(type);
			}), PublishCacheContext.CreateCache(delegate(IDictionary<Type, WeakReference<IList<T>>> c, Type type, Guid _)
			{
				c.Remove(type);
			}));
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool pxyfrM85orX2HCNWxU4D()
		{
			return Xv2rLm85WUgdpgjRRxwy == null;
		}

		internal static object MPDSbm85ba9RqhvIdjEg()
		{
			return Xv2rLm85WUgdpgjRRxwy;
		}
	}

	private class AttributesCacheMemberInfo : AttributesCache<MemberInfo>
	{
		private class Dictionary : IDictionary<MemberInfo, WeakReference<IList<T>>>, ICollection<KeyValuePair<MemberInfo, WeakReference<IList<T>>>>, IEnumerable<KeyValuePair<MemberInfo, WeakReference<IList<T>>>>, IEnumerable
		{
			private IDictionary<Type, ConcurrentDictionary<MemberInfo, WeakReference<IList<T>>>> dictionary;

			internal static object ynwMXXZ3xBpEGhcE1C7G;

			public WeakReference<IList<T>> this[MemberInfo key]
			{
				get
				{
					throw new NotImplementedException();
				}
				set
				{
					_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4_0();
					CS_0024_003C_003E8__locals0.key = key;
					CS_0024_003C_003E8__locals0.value = value;
					dictionary.AddOrUpdate(CS_0024_003C_003E8__locals0.key.DeclaringType ?? TypeOf<Dictionary>.Raw, (Type k) => new ConcurrentDictionary<MemberInfo, WeakReference<IList<T>>>(new KeyValuePair<MemberInfo, WeakReference<IList<T>>>[1]
					{
						new KeyValuePair<MemberInfo, WeakReference<IList<T>>>(CS_0024_003C_003E8__locals0.key, CS_0024_003C_003E8__locals0.value)
					}), delegate(Type k, ConcurrentDictionary<MemberInfo, WeakReference<IList<T>>> d)
					{
						d[CS_0024_003C_003E8__locals0.key] = CS_0024_003C_003E8__locals0.value;
						return d;
					});
				}
			}

			public ICollection<MemberInfo> Keys
			{
				get
				{
					throw new NotImplementedException();
				}
			}

			public ICollection<WeakReference<IList<T>>> Values
			{
				get
				{
					throw new NotImplementedException();
				}
			}

			public int Count
			{
				get
				{
					throw new NotImplementedException();
				}
			}

			public bool IsReadOnly
			{
				get
				{
					throw new NotImplementedException();
				}
			}

			public bool TryGetValue(MemberInfo key, out WeakReference<IList<T>> value)
			{
				//Discarded unreachable code: IL_0031, IL_0040
				int num = 3;
				int num2 = num;
				ConcurrentDictionary<MemberInfo, WeakReference<IList<T>>> value2 = default(ConcurrentDictionary<MemberInfo, WeakReference<IList<T>>>);
				while (true)
				{
					switch (num2)
					{
					default:
						value = null;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
						{
							num2 = 0;
						}
						break;
					case 1:
						return false;
					case 2:
						return value2.TryGetValue(key, out value);
					case 3:
						if (dictionary.TryGetValue(key.DeclaringType ?? TypeOf<Dictionary>.Raw, out value2))
						{
							num2 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
							{
								num2 = 2;
							}
							break;
						}
						goto default;
					}
				}
			}

			public void Add(MemberInfo key, WeakReference<IList<T>> value)
			{
				throw new NotImplementedException();
			}

			public void Add(KeyValuePair<MemberInfo, WeakReference<IList<T>>> item)
			{
				throw new NotImplementedException();
			}

			public void Clear()
			{
				throw new NotImplementedException();
			}

			public bool Contains(KeyValuePair<MemberInfo, WeakReference<IList<T>>> item)
			{
				throw new NotImplementedException();
			}

			public bool ContainsKey(MemberInfo key)
			{
				throw new NotImplementedException();
			}

			public void CopyTo(KeyValuePair<MemberInfo, WeakReference<IList<T>>>[] array, int arrayIndex)
			{
				throw new NotImplementedException();
			}

			public IEnumerator<KeyValuePair<MemberInfo, WeakReference<IList<T>>>> GetEnumerator()
			{
				throw new NotImplementedException();
			}

			public bool Remove(MemberInfo key)
			{
				throw new NotImplementedException();
			}

			public bool Remove(KeyValuePair<MemberInfo, WeakReference<IList<T>>> item)
			{
				throw new NotImplementedException();
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				throw new NotImplementedException();
			}

			public Dictionary()
			{
				//Discarded unreachable code: IL_005c, IL_0061
				SingletonReader.JJCZtPuTvSt();
				dictionary = PublishCacheContext.CreateCache(delegate(IDictionary<Type, ConcurrentDictionary<MemberInfo, WeakReference<IList<T>>>> c, Type type, Guid _)
				{
					c.Remove(type);
				});
				base._002Ector();
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}

			internal static bool YBpTTeZ30S0j4wiYZY0h()
			{
				return ynwMXXZ3xBpEGhcE1C7G == null;
			}

			internal static object DAm5KLZ3mKOqIjUlmvw5()
			{
				return ynwMXXZ3xBpEGhcE1C7G;
			}
		}

		private static object FUZHcL85hEM6Aa2JgRYZ;

		public AttributesCacheMemberInfo()
		{
			//Discarded unreachable code: IL_0034, IL_0039
			SingletonReader.JJCZtPuTvSt();
			base._002Ector((IDictionary<MemberInfo, WeakReference<IList<T>>>)new Dictionary(), (IDictionary<MemberInfo, WeakReference<IList<T>>>)new Dictionary());
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool iGrxIq85GoEbFcVrqAx2()
		{
			return FUZHcL85hEM6Aa2JgRYZ == null;
		}

		internal static object Jav7Xg85EcdijUu8toEV()
		{
			return FUZHcL85hEM6Aa2JgRYZ;
		}
	}

	private static AttributesCache<Type> _attributesCacheType;

	private static AttributesCache<MemberInfo> _attributesCacheMemberInfo;

	private static AttributesCache<Assembly> _attributesCacheAssembly;

	private static AttributesCache<ParameterInfo> _attributesCacheParameterInfo;

	private static AttributesCache<ParameterDescriptor> _attributesCacheParameterDescriptor;

	private static AttributesCache<Type> attributesCacheType => _attributesCacheType ?? (_attributesCacheType = new AttributesCacheType());

	private static AttributesCache<MemberInfo> attributesCacheMemberInfo => _attributesCacheMemberInfo ?? (_attributesCacheMemberInfo = new AttributesCacheMemberInfo());

	private static AttributesCache<Assembly> attributesCacheAssembly => _attributesCacheAssembly ?? (_attributesCacheAssembly = new AttributesCache<Assembly>());

	private static AttributesCache<ParameterInfo> attributesCacheParameterInfo => _attributesCacheParameterInfo ?? (_attributesCacheParameterInfo = new AttributesCache<ParameterInfo>());

	private static AttributesCache<ParameterDescriptor> attributesCacheParameterDescriptor => _attributesCacheParameterDescriptor ?? (_attributesCacheParameterDescriptor = new AttributesCache<ParameterDescriptor>());

	public static T ResetAttribute([NotNull] Type type, bool inherited)
	{
		Contract.ArgumentNotNull(type, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE1225ED));
		return attributesCacheType.Get(type, inherited, GetTypeAttributes);
	}

	public static T GetAttribute([NotNull] Type type, bool inherited)
	{
		Contract.ArgumentNotNull(type, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x10E41EDB ^ 0x10E412F9));
		return attributesCacheType.Get(type, inherited, GetTypeAttributes);
	}

	public static IList<T> GetAttributes([NotNull] Type type, bool inherited)
	{
		Contract.ArgumentNotNull(type, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C9495B4 ^ 0x1C949996));
		return attributesCacheType.GetList(type, inherited, GetTypeAttributes);
	}

	public static T GetAttribute([NotNull] Assembly assembly)
	{
		if (assembly == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34A6D230 ^ 0x34A6A75E));
		}
		return attributesCacheAssembly.Get(assembly, inherited: false, GetAssemblyAttributes);
	}

	public static IList<T> GetAttributes([NotNull] Assembly assembly)
	{
		if (assembly == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53FA75A0));
		}
		return attributesCacheAssembly.GetList(assembly, inherited: false, GetAssemblyAttributes);
	}

	public static T GetAttribute([NotNull] MemberInfo memberInfo, bool inherited)
	{
		if (memberInfo == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583926744));
		}
		return attributesCacheMemberInfo.Get(memberInfo, inherited, GetMemberInfoAttributes);
	}

	public static IList<T> GetAttributes([NotNull] MemberInfo memberInfo, bool inherited)
	{
		if (memberInfo == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195947063));
		}
		return attributesCacheMemberInfo.GetList(memberInfo, inherited, GetMemberInfoAttributes);
	}

	public static T GetAttribute([NotNull] ParameterInfo parameterInfo, bool inherited)
	{
		if (parameterInfo == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1410865831));
		}
		return attributesCacheParameterInfo.Get(parameterInfo, inherited, GetParameterInfoAttributes);
	}

	public static T GetAttributeForParameterDescriptor([NotNull] ParameterDescriptor parameterInfo, bool inherited)
	{
		if (parameterInfo == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DD55050 ^ 0x5DD06CA4));
		}
		return attributesCacheParameterDescriptor.Get(parameterInfo, inherited, GetParameterInfoAttributes);
	}

	public static IList<T> GetAttributes([NotNull] ParameterInfo parameterInfo, bool inherited)
	{
		if (parameterInfo == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34A6D230 ^ 0x34A3EEC4));
		}
		return attributesCacheParameterInfo.GetList(parameterInfo, inherited, GetParameterInfoAttributes);
	}

	private static IList<T> GetAssemblyAttributes(Assembly assembly, bool inherited)
	{
		return ToArray(assembly.GetCustomAttributes(TypeOf<T>.Raw, inherited));
	}

	private static IList<T> GetTypeAttributes(Type type, bool inherited)
	{
		return ToArray(type.GetReflectionCustomAttributes(TypeOf<T>.Raw, inherited));
	}

	private static IList<T> GetMemberInfoAttributes(MemberInfo memberInfo, bool inherited)
	{
		return ToArray(memberInfo.GetCustomAttributes(TypeOf<T>.Raw, inherited));
	}

	private static IList<T> GetParameterInfoAttributes(ParameterInfo parameterInfo, bool inherited)
	{
		return ToArray(parameterInfo.GetCustomAttributes(TypeOf<T>.Raw, inherited));
	}

	private static IList<T> GetParameterInfoAttributes(ParameterDescriptor parameterInfo, bool inherited)
	{
		return ToArray(parameterInfo.GetCustomAttributes(TypeOf<T>.Raw, inherited));
	}

	private static IList<T> ToArray(object[] attributes)
	{
		T[] array = new T[attributes.Length];
		for (int i = 0; i < attributes.Length; i++)
		{
			array[i] = (T)attributes[i];
		}
		return array;
	}
}
