using System;

namespace EleWise.ELMA.Remoting;

public static class RemotingClientParameters
{
	public static Func<bool> TryStopDebuggingHandler;

	public static Func<bool> IsDebuggingHandler;

	internal static RemotingClientParameters eFjY1yXlQpN7eD8g3DZ;

	public static bool IsDebugging
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (IsDebuggingHandler == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
						{
							num2 = 0;
						}
						break;
					}
					return IsDebuggingHandler();
				default:
					return false;
				}
			}
		}
	}

	public static bool TryStopDebugging()
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (TryStopDebuggingHandler == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					return !IsDebugging;
				case 2:
					break;
				}
				break;
			}
			TryStopDebuggingHandler();
			num = 3;
		}
	}

	internal static bool R8Q5GOXrSqGrG738mBw()
	{
		return eFjY1yXlQpN7eD8g3DZ == null;
	}

	internal static RemotingClientParameters IFNamFXgHyalPmqEjU9()
	{
		return eFjY1yXlQpN7eD8g3DZ;
	}
}
