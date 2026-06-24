using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Collections;

public class UntypedIDictionaryProxy : IUntypedCollectionProxy, IEnumerable
{
	private readonly object typedIDictionary;

	private readonly MethodInfo addKeyValueMethod;

	private readonly MethodInfo keyGetMethod;

	private readonly MethodInfo valueGetMethod;

	private readonly MethodInfo addMethod;

	private readonly MethodInfo removeMethod;

	private readonly MethodInfo clearMethod;

	private readonly MethodInfo getEnumeratorMethod;

	private readonly MethodInfo containsMethod;

	private static UntypedIDictionaryProxy n8FyHkm7hh2NUyUe8tO;

	public UntypedIDictionaryProxy(object typedIDictionary)
	{
		//Discarded unreachable code: IL_0082, IL_0166, IL_0175, IL_0185, IL_01ee, IL_0403
		JnV42OmmPyOMiQXDf3e();
		keyGetMethod = (MethodInfo)a8BupbmJBOYUHob1cgq(HlIbaMmyjuyZaOKfK5C(typeof(KeyValuePair<, >).TypeHandle).GetProperty((string)bTlqMxmMP53v10sBlOT(0x463A0F3C ^ 0x463AA976)));
		valueGetMethod = (MethodInfo)a8BupbmJBOYUHob1cgq(HlIbaMmyjuyZaOKfK5C(typeof(KeyValuePair<, >).TypeHandle).GetProperty((string)bTlqMxmMP53v10sBlOT(0x7E6E5A0B ^ 0x7E6EFC5F)));
		base._002Ector();
		int num = 16;
		Type @interface = default(Type);
		Type interface3 = default(Type);
		Type interface2 = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 21:
					throw new InvalidOperationException((string)aYuBxtmlkFG8fFbBmP5(bTlqMxmMP53v10sBlOT(-1217523399 ^ -1217481513), @interface.FullName));
				case 13:
					@interface = typedIDictionary.GetType().GetInterface(typeof(IDictionary<, >).FullName);
					num2 = 8;
					continue;
				case 8:
					if (!(@interface == null))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 15;
				case 11:
					throw new InvalidOperationException((string)aYuBxtmlkFG8fFbBmP5(bTlqMxmMP53v10sBlOT(-541731959 ^ -541755651), @interface.FullName));
				case 2:
					addKeyValueMethod = @interface.GetMethod((string)bTlqMxmMP53v10sBlOT(-105199646 ^ -105225250));
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num2 = 4;
					}
					continue;
				case 15:
					throw new ArgumentException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x363055E7), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -69998526));
				case 3:
					interface3 = typedIDictionary.GetType().GetInterface(typeof(ICollection<>).FullName);
					num2 = 2;
					continue;
				case 4:
					if (!bT3rmhmdTTmkYpdlylb(getEnumeratorMethod, null))
					{
						containsMethod = interface3.GetMethod((string)bTlqMxmMP53v10sBlOT(0x53CACA3 ^ 0x53C0979));
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
						{
							num2 = 7;
						}
					}
					else
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
						{
							num2 = 5;
						}
					}
					continue;
				case 10:
					throw new InvalidOperationException((string)aYuBxtmlkFG8fFbBmP5(bTlqMxmMP53v10sBlOT(0x66F566B6 ^ 0x66F5C060), @interface.FullName));
				case 12:
					addMethod = interface3.GetMethod((string)bTlqMxmMP53v10sBlOT(-281842504 ^ -281819004));
					num2 = 6;
					continue;
				case 18:
					throw new InvalidOperationException((string)aYuBxtmlkFG8fFbBmP5(bTlqMxmMP53v10sBlOT(0x7459E02 ^ 0x7453B02), @interface.FullName));
				case 9:
					interface2 = typedIDictionary.GetType().GetInterface(HlIbaMmyjuyZaOKfK5C(typeof(IEnumerable).TypeHandle).FullName);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 1;
					}
					continue;
				case 19:
					if (removeMethod == null)
					{
						num2 = 22;
						continue;
					}
					clearMethod = interface3.GetMethod((string)bTlqMxmMP53v10sBlOT(-1867198571 ^ -1867233809));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 0;
					}
					continue;
				case 22:
					throw new InvalidOperationException((string)aYuBxtmlkFG8fFbBmP5(bTlqMxmMP53v10sBlOT(-1824388195 ^ -1824346315), @interface.FullName));
				case 6:
					if (!bT3rmhmdTTmkYpdlylb(addMethod, null))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 20;
				case 14:
					this.typedIDictionary = typedIDictionary;
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num2 = 13;
					}
					continue;
				case 16:
					WW89lUm9iYhZmZeGRdJ(typedIDictionary, bTlqMxmMP53v10sBlOT(0x3A6135BE ^ 0x3A6193DC));
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 14;
					}
					continue;
				case 20:
					throw new InvalidOperationException(string.Format((string)bTlqMxmMP53v10sBlOT(-477139494 ^ -477116004), @interface.FullName));
				case 5:
					break;
				case 7:
					if (!bT3rmhmdTTmkYpdlylb(containsMethod, null))
					{
						return;
					}
					num2 = 21;
					continue;
				case 17:
					if (!bT3rmhmdTTmkYpdlylb(addKeyValueMethod, null))
					{
						num2 = 12;
						continue;
					}
					goto case 10;
				case 1:
					getEnumeratorMethod = interface2.GetMethod(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767760723));
					num2 = 4;
					continue;
				default:
					if (!(clearMethod == null))
					{
						num2 = 9;
						continue;
					}
					goto case 18;
				}
				break;
			}
			removeMethod = interface3.GetMethod((string)bTlqMxmMP53v10sBlOT(-541731959 ^ -541755631));
			num = 19;
		}
	}

	public void Add(KeyValuePair<object, object> o)
	{
		addKeyValueMethod.Invoke(typedIDictionary, new object[2] { o.Key, o.Value });
	}

	public void Add(object o)
	{
		//Discarded unreachable code: IL_00af, IL_00be
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (HlIbaMmyjuyZaOKfK5C(typeof(KeyValuePair<, >).TypeHandle).IsInstanceOfType(o))
				{
					num2 = 4;
					break;
				}
				goto default;
			case 3:
				return;
			default:
				dHxajLmr5H1qpdbBAh0(addMethod, typedIDictionary, new object[1] { o });
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				if (o == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 5:
				return;
			case 4:
				Add(new KeyValuePair<object, object>(dHxajLmr5H1qpdbBAh0(keyGetMethod, o, null), dHxajLmr5H1qpdbBAh0(valueGetMethod, o, null)));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	public bool Remove(object o)
	{
		return (bool)dHxajLmr5H1qpdbBAh0(removeMethod, typedIDictionary, new object[1] { o });
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
				dHxajLmr5H1qpdbBAh0(clearMethod, typedIDictionary, null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
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
		return sQhHmsmg0vbfroR5ylj(dHxajLmr5H1qpdbBAh0(containsMethod, typedIDictionary, new object[1] { o }));
	}

	public IEnumerator GetEnumerator()
	{
		return (IEnumerator)getEnumeratorMethod.Invoke(typedIDictionary, null);
	}

	internal static void JnV42OmmPyOMiQXDf3e()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Type HlIbaMmyjuyZaOKfK5C(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object bTlqMxmMP53v10sBlOT(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object a8BupbmJBOYUHob1cgq(object P_0)
	{
		return ((PropertyInfo)P_0).GetGetMethod();
	}

	internal static void WW89lUm9iYhZmZeGRdJ(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static bool bT3rmhmdTTmkYpdlylb(object P_0, object P_1)
	{
		return (MethodInfo)P_0 == (MethodInfo)P_1;
	}

	internal static object aYuBxtmlkFG8fFbBmP5(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static bool wIBmZymx84aVEH9gWLO()
	{
		return n8FyHkm7hh2NUyUe8tO == null;
	}

	internal static UntypedIDictionaryProxy cxd4Bgm0FsjI7Poo8U5()
	{
		return n8FyHkm7hh2NUyUe8tO;
	}

	internal static object dHxajLmr5H1qpdbBAh0(object P_0, object P_1, object P_2)
	{
		return ((MethodBase)P_0).Invoke(P_1, (object[])P_2);
	}

	internal static bool sQhHmsmg0vbfroR5ylj(object P_0)
	{
		return Convert.ToBoolean(P_0);
	}
}
