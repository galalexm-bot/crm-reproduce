using System;
using System.Collections;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Engine;
using NHibernate.Event.Default;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.NH.Listeners;

[Serializable]
public class HHH2763Fix : DefaultFlushEventListener
{
	private static readonly ILogger Log;

	private static HHH2763Fix AC3xCvW7H2RP97Wvtpeu;

	protected override void PostFlush(ISessionImplementor session)
	{
		//Discarded unreachable code: IL_0060, IL_006a, IL_0099, IL_00a8, IL_01a6, IL_0203, IL_0212
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		int num = 1;
		int num2 = num;
		IEnumerator enumerator = default(IEnumerator);
		CollectionEntry val = default(CollectionEntry);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				enumerator = (IEnumerator)mlTNCEW7mPv4rnQoscPE(wRSMEZW70yp7CA1Ykxpm(((IPersistenceContext)EiMME6W7xAB3Rr7LOthL(session)).get_CollectionEntries()));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				while (true)
				{
					IL_0158:
					int num3;
					if (!nndmQ5W7djuBcf7n0IuL(enumerator))
					{
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
						{
							num3 = 0;
						}
						goto IL_006e;
					}
					goto IL_00f8;
					IL_00f8:
					val = (CollectionEntry)S3M6SjW7yJEDX4RiVQW8(enumerator);
					num3 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num3 = 2;
					}
					goto IL_006e;
					IL_006e:
					while (true)
					{
						switch (num3)
						{
						default:
							return;
						case 0:
							return;
						case 4:
							Log.InfoFormat((string)TQ45AGW7MKkecsU4I8sA(--1418440330 ^ 0x5489862E), OemOlJW7JcfFCGmB7kwF(val));
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
							{
								num3 = 1;
							}
							continue;
						case 6:
							break;
						case 1:
							zyYMHjW79QljKVC1nqCM(val, true);
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
							{
								num3 = 0;
							}
							continue;
						case 3:
							if (val.get_IsProcessed())
							{
								num3 = 5;
								continue;
							}
							goto case 4;
						case 2:
						case 5:
							goto IL_0158;
						}
						break;
					}
					goto IL_00f8;
				}
			}
			finally
			{
				IDisposable disposable = enumerator as IDisposable;
				int num4 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num4 = 2;
				}
				while (true)
				{
					switch (num4)
					{
					default:
						QGQMrXW7lpmPhMZ48GIi(disposable);
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
						{
							num4 = 1;
						}
						continue;
					case 2:
						if (disposable != null)
						{
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
							{
								num4 = 0;
							}
							continue;
						}
						break;
					case 1:
						break;
					}
					break;
				}
			}
		}
	}

	public HHH2763Fix()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		JURQfLW7rRmPvEXTYwpi();
		((DefaultFlushEventListener)this)._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static HHH2763Fix()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				Log = (ILogger)tU4SBxW75RuWXvDNqq4k(v2cFHkW7gCXhJOaQlTw7(typeof(HHH2763Fix).TypeHandle));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object EiMME6W7xAB3Rr7LOthL(object P_0)
	{
		return ((ISessionImplementor)P_0).get_PersistenceContext();
	}

	internal static object wRSMEZW70yp7CA1Ykxpm(object P_0)
	{
		return ((IDictionary)P_0).Values;
	}

	internal static object mlTNCEW7mPv4rnQoscPE(object P_0)
	{
		return ((IEnumerable)P_0).GetEnumerator();
	}

	internal static object S3M6SjW7yJEDX4RiVQW8(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}

	internal static object TQ45AGW7MKkecsU4I8sA(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object OemOlJW7JcfFCGmB7kwF(object P_0)
	{
		return ((CollectionEntry)P_0).get_Role();
	}

	internal static void zyYMHjW79QljKVC1nqCM(object P_0, bool P_1)
	{
		((CollectionEntry)P_0).set_IsProcessed(P_1);
	}

	internal static bool nndmQ5W7djuBcf7n0IuL(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void QGQMrXW7lpmPhMZ48GIi(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool PcdpWGW7A0nKqvaaC7y9()
	{
		return AC3xCvW7H2RP97Wvtpeu == null;
	}

	internal static HHH2763Fix D7gC7aW77BRxxIEUXXZU()
	{
		return AC3xCvW7H2RP97Wvtpeu;
	}

	internal static void JURQfLW7rRmPvEXTYwpi()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Type v2cFHkW7gCXhJOaQlTw7(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object tU4SBxW75RuWXvDNqq4k(Type componentType)
	{
		return Logger.GetLogger(componentType);
	}
}
