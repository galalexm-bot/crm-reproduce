using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Collections;

public class UntypedICollectionProxy : IUntypedCollectionProxy, IEnumerable
{
	private readonly object typedICollection;

	private readonly MethodInfo addMethod;

	private readonly MethodInfo removeMethod;

	private readonly MethodInfo clearMethod;

	private readonly MethodInfo getEnumeratorMethod;

	private readonly MethodInfo containsMethod;

	internal static UntypedICollectionProxy NHXv5Amp9HBqHSrPZ8h;

	public UntypedICollectionProxy(object typedICollection)
	{
		//Discarded unreachable code: IL_001a, IL_0126, IL_0135, IL_0144
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 2;
		Type interface2 = default(Type);
		Type @interface = default(Type);
		while (true)
		{
			int num2;
			switch (num)
			{
			case 12:
				getEnumeratorMethod = interface2.GetMethod((string)ngE3EkmtUaY7aK5GdlB(-1837662597 ^ -1837638867));
				num = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num = 9;
				}
				break;
			case 13:
				throw new InvalidOperationException(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487346414), @interface.FullName));
			case 15:
				if (!iUkRa2m6sxCXfl2Qmoc(removeMethod, null))
				{
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num = 1;
					}
					break;
				}
				goto default;
			case 4:
				if (r1muOsmw6kpl4kRFxwD(@interface, null))
				{
					num2 = 6;
					goto IL_001f;
				}
				addMethod = @interface.GetMethod(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17ADCCD8 ^ 0x17AD68E4));
				num = 5;
				break;
			default:
				throw new InvalidOperationException((string)srLUEHm4DRWf1hSKi9b(ngE3EkmtUaY7aK5GdlB(0x31326106 ^ 0x3132C5AE), @interface.FullName));
			case 1:
				clearMethod = @interface.GetMethod((string)ngE3EkmtUaY7aK5GdlB(-138018305 ^ -137983099));
				num2 = 10;
				goto IL_001f;
			case 10:
				if (clearMethod == null)
				{
					num = 8;
					break;
				}
				interface2 = typedICollection.GetType().GetInterface(ClcKJCmHn5kn3KyRw4E(typeof(IEnumerable).TypeHandle).FullName);
				num = 12;
				break;
			case 9:
				if (!iUkRa2m6sxCXfl2Qmoc(getEnumeratorMethod, null))
				{
					containsMethod = @interface.GetMethod((string)ngE3EkmtUaY7aK5GdlB(0x7459E02 ^ 0x7453BD8));
					num = 7;
				}
				else
				{
					num = 13;
				}
				break;
			case 14:
				@interface = typedICollection.GetType().GetInterface(typeof(ICollection<>).FullName);
				num = 4;
				break;
			case 11:
				throw new InvalidOperationException((string)srLUEHm4DRWf1hSKi9b(ngE3EkmtUaY7aK5GdlB(--1867379187 ^ 0x6F4D541D), @interface.FullName));
			case 6:
				throw new ArgumentException((string)ngE3EkmtUaY7aK5GdlB(-1217523399 ^ -1217482097), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606629234));
			case 16:
				throw new InvalidOperationException((string)srLUEHm4DRWf1hSKi9b(ngE3EkmtUaY7aK5GdlB(0x7C1EE318 ^ 0x7C1E475E), @interface.FullName));
			case 17:
				removeMethod = @interface.GetMethod(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767760541));
				num2 = 15;
				goto IL_001f;
			case 5:
				if (!(addMethod == null))
				{
					num = 17;
					break;
				}
				goto case 16;
			case 3:
				this.typedICollection = typedICollection;
				num = 14;
				break;
			case 8:
				throw new InvalidOperationException((string)srLUEHm4DRWf1hSKi9b(ngE3EkmtUaY7aK5GdlB(-1710575414 ^ -1710615094), @interface.FullName));
			case 7:
				if (!iUkRa2m6sxCXfl2Qmoc(containsMethod, null))
				{
					return;
				}
				num = 11;
				break;
			case 2:
				{
					Contract.ArgumentNotNull(typedICollection, (string)ngE3EkmtUaY7aK5GdlB(-882126494 ^ -882150672));
					num = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num = 0;
					}
					break;
				}
				IL_001f:
				num = num2;
				break;
			}
		}
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
			case 0:
				return;
			case 1:
				nOKbC1mApHrmLhCRWVn(addMethod, typedICollection, new object[1] { o });
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public bool Remove(object o)
	{
		return (bool)nOKbC1mApHrmLhCRWVn(removeMethod, typedICollection, new object[1] { o });
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
				clearMethod.Invoke(typedICollection, null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public bool Contains(object o)
	{
		return Convert.ToBoolean(nOKbC1mApHrmLhCRWVn(containsMethod, typedICollection, new object[1] { o }));
	}

	public IEnumerator GetEnumerator()
	{
		return (IEnumerator)nOKbC1mApHrmLhCRWVn(getEnumeratorMethod, typedICollection, null);
	}

	internal static object ngE3EkmtUaY7aK5GdlB(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool r1muOsmw6kpl4kRFxwD(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object srLUEHm4DRWf1hSKi9b(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static bool iUkRa2m6sxCXfl2Qmoc(object P_0, object P_1)
	{
		return (MethodInfo)P_0 == (MethodInfo)P_1;
	}

	internal static Type ClcKJCmHn5kn3KyRw4E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool Les6dumaxYW442cQJv5()
	{
		return NHXv5Amp9HBqHSrPZ8h == null;
	}

	internal static UntypedICollectionProxy YCdnrOmD9JfsTsN9HfM()
	{
		return NHXv5Amp9HBqHSrPZ8h;
	}

	internal static object nOKbC1mApHrmLhCRWVn(object P_0, object P_1, object P_2)
	{
		return ((MethodBase)P_0).Invoke(P_1, (object[])P_2);
	}
}
