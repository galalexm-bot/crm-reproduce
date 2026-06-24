using System;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Services;

[Service]
public class WorkWithFormDependenciesService : IWorkWithFormDependeciesService
{
	private static WorkWithFormDependenciesService VC4v1HBHZoHOMH0iegDg;

	public bool IsActive()
	{
		return xtxFTCBHSxymYxrQVfBT(htcJvdBHVcMoTFSYQXvd(-1317790512 ^ -1317713148));
	}

	public void Run(Action action)
	{
		//Discarded unreachable code: IL_003a, IL_005d, IL_00dd, IL_0129, IL_0138
		int num = 1;
		int num2 = num;
		bool flag = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 1:
				flag = IsActive();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			try
			{
				int num3;
				if (flag)
				{
					num3 = 2;
					goto IL_003e;
				}
				goto IL_0087;
				IL_003e:
				while (true)
				{
					switch (num3)
					{
					default:
						return;
					case 1:
					case 2:
						Md6R1YBHihApo4pHUVdC(action);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
						{
							num3 = 0;
						}
						continue;
					case 3:
						break;
					case 0:
						return;
					}
					break;
				}
				goto IL_0087;
				IL_0087:
				ContextVars.Set((string)htcJvdBHVcMoTFSYQXvd(-951514650 ^ -951558606), value: true);
				num3 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
				{
					num3 = 1;
				}
				goto IL_003e;
			}
			finally
			{
				if (!flag)
				{
					int num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							ahbRNRBHRk7rH8fsY3bm(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x66F566B6 ^ 0x66F43162));
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
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
			}
		}
	}

	public WorkWithFormDependenciesService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object htcJvdBHVcMoTFSYQXvd(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool xtxFTCBHSxymYxrQVfBT(object P_0)
	{
		return ContextVars.Contains((string)P_0);
	}

	internal static bool GWGS0DBHuyN9sUrR07lJ()
	{
		return VC4v1HBHZoHOMH0iegDg == null;
	}

	internal static WorkWithFormDependenciesService LoUtHMBHIGdySu8cxXOm()
	{
		return VC4v1HBHZoHOMH0iegDg;
	}

	internal static void Md6R1YBHihApo4pHUVdC(object P_0)
	{
		P_0();
	}

	internal static void ahbRNRBHRk7rH8fsY3bm(object P_0)
	{
		ContextVars.Remove((string)P_0);
	}
}
