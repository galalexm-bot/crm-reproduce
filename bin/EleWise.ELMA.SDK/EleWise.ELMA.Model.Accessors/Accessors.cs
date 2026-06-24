using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Properties;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Accessors;

[EditorBrowsable(EditorBrowsableState.Never)]
public static class Accessors
{
	private class AccessorsDictionary : IEnumerable<IAccessor>, IEnumerable
	{
		private readonly IDictionary<string, IAccessor> accessors;

		private readonly IDictionary<string, IAccessor> deltaAccessors;

		internal static object j5yi17v4sykQPZ7EQ7L3;

		public AccessorsDictionary(Type type)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			uHAwbfv6FTL3kHcBa8Hi();
			base._002Ector();
			int num = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
			{
				num = 3;
			}
			while (true)
			{
				switch (num)
				{
				case 3:
					if (type.IsInterface)
					{
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
						{
							num = 0;
						}
						break;
					}
					accessors = ((IEnumerable<object>)wBJ1mmv6o5i1cL71aYBn(type.GetMethod((string)dw9eo0v6BGgk1Rast2hv(0x57A5235E ^ 0x57A09D22)), null, null)).Cast<IAccessor>().ToDictionary((IAccessor a) => (string)_003C_003Ec.b0PZZ4ZTZHdenrdoqq5Y(a));
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
					{
						num = 1;
					}
					break;
				case 1:
					deltaAccessors = PublishCacheContext.CreateCache<string, IAccessor>();
					num = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
					{
						num = 1;
					}
					break;
				case 2:
					return;
				default:
					throw new ArgumentException((string)LpJ2Ziv6WnLGCteqMX8b(dw9eo0v6BGgk1Rast2hv(-576149596 ^ -575837864), type), (string)dw9eo0v6BGgk1Rast2hv(-70007027 ^ -70005969));
				}
			}
		}

		public bool TryGetValue(string propertyName, out IAccessor accessor)
		{
			//Discarded unreachable code: IL_0069, IL_0078
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (accessors.TryGetValue(propertyName, out accessor))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto default;
				default:
					return deltaAccessors.TryGetValue(propertyName, out accessor);
				case 1:
					return true;
				}
			}
		}

		public void AddAccessors(IEnumerable<IAccessor> newAccessors)
		{
			newAccessors.ForEach(delegate(IAccessor a)
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
						deltaAccessors[a.PropertyName] = a;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					case 2:
						accessors.Remove((string)zsBrv6v6bK7yv1ilw6wJ(a));
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
						{
							num2 = 1;
						}
						break;
					}
				}
			});
		}

		public IEnumerator<IAccessor> GetEnumerator()
		{
			return accessors.Values.Concat(deltaAccessors.Values).GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		internal static void uHAwbfv6FTL3kHcBa8Hi()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static object dw9eo0v6BGgk1Rast2hv(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object LpJ2Ziv6WnLGCteqMX8b(object P_0, object P_1)
		{
			return string.Format((string)P_0, P_1);
		}

		internal static object wBJ1mmv6o5i1cL71aYBn(object P_0, object P_1, object P_2)
		{
			return ((MethodBase)P_0).Invoke(P_1, (object[])P_2);
		}

		internal static bool GdlwjVv4c1pxWKget6km()
		{
			return j5yi17v4sykQPZ7EQ7L3 == null;
		}

		internal static AccessorsDictionary cCYemSv4zijPcbWSaDaS()
		{
			return (AccessorsDictionary)j5yi17v4sykQPZ7EQ7L3;
		}

		internal static object zsBrv6v6bK7yv1ilw6wJ(object P_0)
		{
			return ((IAccessor)P_0).PropertyName;
		}
	}

	internal const string GetAccessors_034F = "GetAccessors\u034f";

	private static readonly IDictionary<Type, IDictionary<string, IDictionary<Type, IAccessor>>> accessorsRecursive;

	private static readonly IDictionary<Type, AccessorsDictionary> accessors;

	private static Accessors SubpNjhmVXuZSD6v87if;

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static IGetter GetGetter(this Type type, string propertyName, bool declaredOnly)
	{
		object obj = gNvHNdhmRBrBFXImqJMM(type, propertyName, declaredOnly);
		return (IGetter)((obj is IGetter) ? obj : null);
	}

	internal static ISetter GetSetter(this Type type, string propertyName, bool declaredOnly)
	{
		IAccessor accessor = type.GetAccessor(propertyName, declaredOnly);
		return (ISetter)((accessor is ISetter) ? accessor : null);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static IAccessor GetAccessor(this Type type, string propertyName, bool declaredOnly)
	{
		//Discarded unreachable code: IL_008b, IL_011e
		int num = 1;
		int num2 = num;
		KeyValuePair<Type, IAccessor> keyValuePair = default(KeyValuePair<Type, IAccessor>);
		IAccessor accessor = default(IAccessor);
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 7:
			{
				if (!GetAccessorsRecursive(type).TryGetValue(propertyName, out var value))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 1;
					}
					break;
				}
				keyValuePair = value.Single();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
				{
					num2 = 4;
				}
				break;
			}
			case 3:
				return null;
			case 5:
				return accessor;
			case 1:
				if (iec1t5hmqFqycKE0p8AG(type.Assembly))
				{
					type = d4yUFqhmKSqBIySOikGt(type);
					num2 = 8;
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				if (declaredOnly)
				{
					num2 = 6;
					break;
				}
				goto case 7;
			case 4:
				return keyValuePair.Value;
			case 6:
				if (((AccessorsDictionary)lkLDjYhmXBCnefWPZr9J(type)).TryGetValue(propertyName, out accessor))
				{
					num2 = 5;
					break;
				}
				goto case 3;
			case 2:
				return null;
			}
		}
	}

	internal static void AddAccessors(this Type type, IEnumerable accessors)
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
				((AccessorsDictionary)lkLDjYhmXBCnefWPZr9J(type)).AddAccessors(accessors.Cast<IAccessor>());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private static AccessorsDictionary GetAccessorsInternal(Type type)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = default(_003C_003Ec__DisplayClass7_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass7_.type = type;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return accessors.GetOrAdd(_003C_003Ec__DisplayClass7_.type, _003C_003Ec__DisplayClass7_._003CGetAccessorsInternal_003Eb__0);
			}
		}
	}

	private static IDictionary<string, IDictionary<Type, IAccessor>> GetAccessorsRecursive(Type type)
	{
		return accessorsRecursive.GetOrAdd(type, delegate(Type t)
		{
			Dictionary<string, IDictionary<Type, IAccessor>> dictionary = GetAccessorsInternal(t)?.ToDictionary((Func<IAccessor, string>)((IAccessor a) => a.PropertyName), (Func<IAccessor, IDictionary<Type, IAccessor>>)((IAccessor p) => new Dictionary<Type, IAccessor> { [p.PropertyType] = p }));
			if (dictionary != null)
			{
				while (t.BaseType != null)
				{
					t = t.BaseType;
					AccessorsDictionary accessorsInternal = GetAccessorsInternal(t);
					if (accessorsInternal == null)
					{
						break;
					}
					foreach (IAccessor item in accessorsInternal)
					{
						if (!dictionary.TryGetValue(item.PropertyName, out var value))
						{
							dictionary[item.PropertyName] = new Dictionary<Type, IAccessor> { [item.PropertyType] = item };
						}
						else if (!value.ContainsKey(item.PropertyType))
						{
							value[item.PropertyType] = item;
						}
					}
				}
			}
			return dictionary;
		});
	}

	internal static object GetData(IValueContainerObjectInternal value, int dataIndex)
	{
		return value.GetData().ElementAt(dataIndex);
	}

	static Accessors()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 2:
				accessorsRecursive = PublishCacheContext.CreateCache(delegate(IDictionary<Type, IDictionary<string, IDictionary<Type, IAccessor>>> c, Type _, Guid __)
				{
					c.Clear();
				});
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				DQG4LjhmTQfGOEHBl7hT();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num2 = 2;
				}
				break;
			default:
				accessors = PublishCacheContext.CreateCache<Type, AccessorsDictionary>();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static object gNvHNdhmRBrBFXImqJMM(Type type, object P_1, bool declaredOnly)
	{
		return type.GetAccessor((string)P_1, declaredOnly);
	}

	internal static bool cOut4MhmSqvqYWXos9Pf()
	{
		return SubpNjhmVXuZSD6v87if == null;
	}

	internal static Accessors bvu1Qfhmiy0RPyRVU98Z()
	{
		return SubpNjhmVXuZSD6v87if;
	}

	internal static bool iec1t5hmqFqycKE0p8AG(object P_0)
	{
		return ((Assembly)P_0).IsDynamicAssembly();
	}

	internal static Type d4yUFqhmKSqBIySOikGt(Type t)
	{
		return InterfaceActivator.TypeOf(t);
	}

	internal static object lkLDjYhmXBCnefWPZr9J(Type type)
	{
		return GetAccessorsInternal(type);
	}

	internal static void DQG4LjhmTQfGOEHBl7hT()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
