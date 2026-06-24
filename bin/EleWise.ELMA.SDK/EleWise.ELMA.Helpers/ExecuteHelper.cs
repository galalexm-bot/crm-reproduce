using System;
using System.Threading;

namespace EleWise.ELMA.Helpers;

public static class ExecuteHelper
{
	private static ExecuteHelper aaAcuJhLw7AKDFiIIeJA;

	public static void InvokeSafe(Action action)
	{
		//Discarded unreachable code: IL_005d, IL_00b0, IL_0113, IL_0193, IL_01a2
		int num = 7;
		bool flag = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					try
					{
						iy5mEXhLHicAmFi8nwmT(action);
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								flag = true;
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
								{
									num4 = 0;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					catch (Exception)
					{
						int num5 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							default:
								UZEfNZhLAVkfa3fD8Sn4(2000);
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
								{
									num5 = 0;
								}
								continue;
							case 2:
								num3++;
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
								{
									num5 = 0;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					goto case 2;
				case 5:
					if (flag)
					{
						num2 = 3;
						continue;
					}
					goto case 1;
				case 1:
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					break;
				case 3:
					return;
				case 2:
				case 4:
					if (num3 >= 200)
					{
						return;
					}
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 5;
					}
					continue;
				case 7:
					num3 = 0;
					num2 = 6;
					continue;
				}
				break;
			}
			flag = false;
			num = 2;
		}
	}

	internal static void iy5mEXhLHicAmFi8nwmT(object P_0)
	{
		P_0();
	}

	internal static void UZEfNZhLAVkfa3fD8Sn4(int P_0)
	{
		Thread.Sleep(P_0);
	}

	internal static bool zd1dSGhL47yCGtX5PMp3()
	{
		return aaAcuJhLw7AKDFiIIeJA == null;
	}

	internal static ExecuteHelper VLRlZZhL65qIdO1ZV8TY()
	{
		return aaAcuJhLw7AKDFiIIeJA;
	}
}
