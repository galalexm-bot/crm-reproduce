using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Collections;

public class UntypedISetProxy : IUntypedCollectionProxy, IEnumerable
{
	private readonly object typedISet;

	private readonly MethodInfo addMethod;

	private readonly MethodInfo removeMethod;

	private readonly MethodInfo clearMethod;

	private readonly MethodInfo getEnumeratorMethod;

	private readonly PropertyInfo countProperty;

	private readonly MethodInfo containsMethod;

	private static UntypedISetProxy ixVCvOm53qUXvUJKble;

	public int Count => Convert.ToInt32(cXFiqTyoAOlVa6tMjvd(countProperty, typedISet, null));

	public UntypedISetProxy(object typedISet)
	{
		//Discarded unreachable code: IL_001e, IL_0117, IL_0126, IL_0229, IL_0386, IL_044e, IL_04de, IL_04ed
		IHI3kEmLWgQjJGwe1ib();
		base._002Ector();
		int num = 20;
		Type @interface = default(Type);
		Type interface2 = default(Type);
		Type interface3 = default(Type);
		Type interface4 = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (!Ry8sQgmzOafDQ3hq5Xs(removeMethod, null))
					{
						num2 = 15;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 3;
				case 2:
					if (!Ry8sQgmzOafDQ3hq5Xs(clearMethod, null))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 16;
				case 23:
					getEnumeratorMethod = @interface.GetMethod((string)C3Xx3emcKLuMwEKqHmZ(-105199646 ^ -105225548));
					num2 = 9;
					continue;
				case 18:
					if (!hm84dDyBjcm4gjAE5YP(countProperty, null))
					{
						num2 = 17;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
						{
							num2 = 22;
						}
						continue;
					}
					goto case 13;
				case 16:
					throw new InvalidOperationException((string)CetoHGyFUbWUC9wUy44(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1ECE530A ^ 0x1ECEF60A), interface2.FullName));
				case 4:
					@interface = typedISet.GetType().GetInterface(miMk9mmUE3Ry9Hi8w84(typeof(IEnumerable).TypeHandle).FullName);
					num2 = 23;
					continue;
				case 3:
					throw new InvalidOperationException((string)CetoHGyFUbWUC9wUy44(C3Xx3emcKLuMwEKqHmZ(0x1ECE530A ^ 0x1ECEF7A2), interface2.FullName));
				case 15:
					clearMethod = interface3.GetMethod((string)C3Xx3emcKLuMwEKqHmZ(-1487388570 ^ -1487353316));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 2;
					}
					continue;
				case 14:
					if (UHBiw7ms77VSyXx9Akm(interface2, null))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
						{
							num2 = 24;
						}
					}
					else
					{
						interface4 = typedISet.GetType().GetInterface(miMk9mmUE3Ry9Hi8w84(typeof(ISet<>).TypeHandle).FullName);
						num2 = 7;
					}
					continue;
				case 19:
					if (Ry8sQgmzOafDQ3hq5Xs(containsMethod, null))
					{
						num2 = 10;
						continue;
					}
					return;
				case 6:
					this.typedISet = typedISet;
					num2 = 8;
					continue;
				case 7:
					interface3 = typedISet.GetType().GetInterface(miMk9mmUE3Ry9Hi8w84(typeof(ICollection<>).TypeHandle).FullName);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 2;
					}
					continue;
				case 5:
					break;
				case 13:
					throw new InvalidOperationException(string.Format((string)C3Xx3emcKLuMwEKqHmZ(--1418440330 ^ 0x548B0912), interface2.FullName));
				case 22:
					containsMethod = interface3.GetMethod((string)C3Xx3emcKLuMwEKqHmZ(0x2ACE37D ^ 0x2AC46A7));
					num2 = 19;
					continue;
				case 8:
					interface2 = typedISet.GetType().GetInterface(miMk9mmUE3Ry9Hi8w84(typeof(ISet<>).TypeHandle).FullName);
					num2 = 14;
					continue;
				case 20:
					Contract.ArgumentNotNull(typedISet, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53FAA78E));
					num2 = 6;
					continue;
				case 21:
					if (!Ry8sQgmzOafDQ3hq5Xs(addMethod, null))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 12;
				case 17:
					throw new InvalidOperationException((string)CetoHGyFUbWUC9wUy44(C3Xx3emcKLuMwEKqHmZ(-234299632 ^ -234325404), interface2.FullName));
				case 11:
					countProperty = interface3.GetProperty((string)C3Xx3emcKLuMwEKqHmZ(-488881205 ^ -488880091));
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 18;
					}
					continue;
				case 12:
					throw new InvalidOperationException((string)CetoHGyFUbWUC9wUy44(C3Xx3emcKLuMwEKqHmZ(-105199646 ^ -105225308), interface2.FullName));
				default:
					removeMethod = interface3.GetMethod((string)C3Xx3emcKLuMwEKqHmZ(-740338220 ^ -740298420));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 1;
					}
					continue;
				case 24:
					throw new ArgumentException((string)C3Xx3emcKLuMwEKqHmZ(0x4D1C1EE4 ^ 0x4D1CB9B2), (string)C3Xx3emcKLuMwEKqHmZ(0x63ABA4E8 ^ 0x63AB03A8));
				case 10:
					throw new InvalidOperationException(string.Format((string)C3Xx3emcKLuMwEKqHmZ(-29254301 ^ -29280115), interface2.FullName));
				case 9:
					if (!Ry8sQgmzOafDQ3hq5Xs(getEnumeratorMethod, null))
					{
						num2 = 11;
						continue;
					}
					goto case 17;
				}
				break;
			}
			addMethod = interface4.GetMethod((string)C3Xx3emcKLuMwEKqHmZ(-542721635 ^ -542761567));
			num = 21;
		}
	}

	public bool AddToSet(object o)
	{
		return (bool)addMethod.Invoke(typedISet, new object[1] { o });
	}

	public void Add(object o)
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
				addMethod.Invoke(typedISet, new object[1] { o });
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public bool Remove(object o)
	{
		return (bool)removeMethod.Invoke(typedISet, new object[1] { o });
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
				XYArr3yWkPKwVS7iiyV(clearMethod, typedISet, null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public bool Contains(object o)
	{
		return k6F04VybcQLEkELbXrQ(XYArr3yWkPKwVS7iiyV(containsMethod, typedISet, new object[1] { o }));
	}

	public IEnumerator GetEnumerator()
	{
		return (IEnumerator)XYArr3yWkPKwVS7iiyV(getEnumeratorMethod, typedISet, null);
	}

	internal static void IHI3kEmLWgQjJGwe1ib()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Type miMk9mmUE3Ry9Hi8w84(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool UHBiw7ms77VSyXx9Akm(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object C3Xx3emcKLuMwEKqHmZ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool Ry8sQgmzOafDQ3hq5Xs(object P_0, object P_1)
	{
		return (MethodInfo)P_0 == (MethodInfo)P_1;
	}

	internal static object CetoHGyFUbWUC9wUy44(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static bool hm84dDyBjcm4gjAE5YP(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static bool vmw2WCmjdqCesyQ3ZiH()
	{
		return ixVCvOm53qUXvUJKble == null;
	}

	internal static UntypedISetProxy cVSgO1mYOgvywP23h0N()
	{
		return ixVCvOm53qUXvUJKble;
	}

	internal static object XYArr3yWkPKwVS7iiyV(object P_0, object P_1, object P_2)
	{
		return ((MethodBase)P_0).Invoke(P_1, (object[])P_2);
	}

	internal static object cXFiqTyoAOlVa6tMjvd(object P_0, object P_1, object P_2)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}

	internal static bool k6F04VybcQLEkELbXrQ(object P_0)
	{
		return Convert.ToBoolean(P_0);
	}
}
