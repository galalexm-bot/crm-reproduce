using System;
using System.Collections;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Engine;
using NHibernate.Event.Default;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.NH.Listeners;

[Serializable]
public class HHH2763FixAutoFlush : DefaultAutoFlushEventListener
{
	private static readonly ILogger Log;

	private static HHH2763FixAutoFlush Kl16TKW7jHFaJ5IsF1D0;

	protected override void PostFlush(ISessionImplementor session)
	{
		//Discarded unreachable code: IL_002f, IL_00b3, IL_0149, IL_0196, IL_01a5
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		int num = 2;
		int num2 = num;
		IEnumerator enumerator = default(IEnumerator);
		CollectionEntry val = default(CollectionEntry);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				try
				{
					while (true)
					{
						int num3;
						if (!VEO0ajWxWvLPwa5K2OqT(enumerator))
						{
							num3 = 5;
							goto IL_003d;
						}
						goto IL_00d3;
						IL_003d:
						while (true)
						{
							switch (num3)
							{
							case 5:
								return;
							case 6:
							{
								val.set_IsProcessed(true);
								int num4 = 4;
								num3 = num4;
								continue;
							}
							case 2:
								Log.InfoFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7459E02 ^ 0x747B6A6), val.get_Role());
								num3 = 6;
								continue;
							case 3:
								goto IL_00d3;
							case 1:
								if (JS2LjxWxB8gWWuKBJeh9(val))
								{
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
									{
										num3 = 0;
									}
									continue;
								}
								goto case 2;
							}
							break;
						}
						continue;
						IL_00d3:
						val = (CollectionEntry)PjkL5YWxFgPKboRAdUXR(enumerator);
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
						{
							num3 = 0;
						}
						goto IL_003d;
					}
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					int num5 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
					{
						num5 = 1;
					}
					while (true)
					{
						switch (num5)
						{
						case 1:
							if (disposable != null)
							{
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
								{
									num5 = 0;
								}
								continue;
							}
							break;
						default:
							qNVFc6WxoeqZyZQ6VU4b(disposable);
							num5 = 2;
							continue;
						case 2:
							break;
						}
						break;
					}
				}
			case 2:
				enumerator = (IEnumerator)youprAW7zBv7C2Px53LS(Thm7txW7ce43DyDn75WS(fxp0vDW7seughoxyDjSX(hx6OZFW7UjVq2MAMNaD3(session))));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public HHH2763FixAutoFlush()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		DrnhOhWxbEZfVYX5U0PL();
		((DefaultAutoFlushEventListener)this)._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static HHH2763FixAutoFlush()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				Log = (ILogger)nISqgIWxGKCGqfKe93sJ(wFyIdXWxhcNQGmFEGwk9(typeof(HHH2763FixAutoFlush).TypeHandle));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				DrnhOhWxbEZfVYX5U0PL();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object hx6OZFW7UjVq2MAMNaD3(object P_0)
	{
		return ((ISessionImplementor)P_0).get_PersistenceContext();
	}

	internal static object fxp0vDW7seughoxyDjSX(object P_0)
	{
		return ((IPersistenceContext)P_0).get_CollectionEntries();
	}

	internal static object Thm7txW7ce43DyDn75WS(object P_0)
	{
		return ((IDictionary)P_0).Values;
	}

	internal static object youprAW7zBv7C2Px53LS(object P_0)
	{
		return ((IEnumerable)P_0).GetEnumerator();
	}

	internal static object PjkL5YWxFgPKboRAdUXR(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}

	internal static bool JS2LjxWxB8gWWuKBJeh9(object P_0)
	{
		return ((CollectionEntry)P_0).get_IsProcessed();
	}

	internal static bool VEO0ajWxWvLPwa5K2OqT(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void qNVFc6WxoeqZyZQ6VU4b(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool GOSO2OW7Yh3wMOKpyeJ6()
	{
		return Kl16TKW7jHFaJ5IsF1D0 == null;
	}

	internal static HHH2763FixAutoFlush yLcGYHW7L5aE9xUAEsd5()
	{
		return Kl16TKW7jHFaJ5IsF1D0;
	}

	internal static void DrnhOhWxbEZfVYX5U0PL()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Type wFyIdXWxhcNQGmFEGwk9(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object nISqgIWxGKCGqfKe93sJ(Type componentType)
	{
		return Logger.GetLogger(componentType);
	}
}
