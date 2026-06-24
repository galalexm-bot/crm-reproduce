using System.IO;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Threading;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics;

[Component(Type = ComponentType.Server)]
internal sealed class CountersCategoryInitHandler : IInitHandler
{
	private readonly IPerformanceCategoryRegistrar registrar;

	internal static CountersCategoryInitHandler TggPjTGzuGVqYywLoJdU;

	public CountersCategoryInitHandler(IPerformanceCategoryRegistrar registrar)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ocwEEUGzSNA3o6Dg87No();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				this.registrar = registrar;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public void Init()
	{
		//Discarded unreachable code: IL_004f, IL_0081, IL_0098, IL_00a7
		switch (1)
		{
		case 1:
			try
			{
				W2fiprGzRtMLG36Lv3Zh(vPZTkmGzifFCN2AEGIhe(registrar));
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
				break;
			}
			catch
			{
				int num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
				break;
			}
		case 0:
			break;
		}
	}

	public void InitComplete()
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
				ThreadStarter.StartNewThread(StartCheck, delegate(Thread t)
				{
					int num3 = 1;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						case 1:
							_003C_003Ec.PpSYU38VnU1ViUK1Evh7(t, true);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
							{
								num4 = 0;
							}
							break;
						default:
							_003C_003Ec.TaY5pD8V2ugsjp4QwuLp(t, _003C_003Ec.jpQwkQ8VOnsxye8A0QM7(-1886646897 ^ -1886793511));
							num4 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
							{
								num4 = 2;
							}
							break;
						case 2:
							return;
						}
					}
				});
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void StartCheck()
	{
		//Discarded unreachable code: IL_004a, IL_007c, IL_0093, IL_00a2
		switch (1)
		{
		case 1:
			try
			{
				registrar.CheckRegisterDefault();
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
				break;
			}
			catch
			{
				int num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
				break;
			}
		case 0:
			break;
		}
	}

	internal static void ocwEEUGzSNA3o6Dg87No()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool Cb3xgYGzItx3T9u0gT4B()
	{
		return TggPjTGzuGVqYywLoJdU == null;
	}

	internal static CountersCategoryInitHandler mJwE1jGzVWiH4nQtDE8w()
	{
		return TggPjTGzuGVqYywLoJdU;
	}

	internal static object vPZTkmGzifFCN2AEGIhe(object P_0)
	{
		return ((IPerformanceCategoryRegistrar)P_0).GetMissingCountersFileName();
	}

	internal static void W2fiprGzRtMLG36Lv3Zh(object P_0)
	{
		File.Delete((string)P_0);
	}
}
