using System;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Events;

public class MethodCallStartEvent : AbstractCallStartEvent<MethodCallInfo>
{
	internal static MethodCallStartEvent l3Z8PtET7nSpmML0O5F1;

	public MethodCallStartEvent(MethodCallInfo info)
	{
		//Discarded unreachable code: IL_002b, IL_0030, IL_00f9, IL_0108, IL_0118
		iXZNmwETma3ehaG5mFPT();
		base._002Ector(info);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 4:
				base.Message = (string)CQFEKNETdrLPle6MVaRe(base.Message, vHTRqRETJVyTnCkR5Ng3(KRrT7gETMSS9cg6IuqFh(0x1A33FE36 ^ 0x1A37A672), true), e0RuF5ET9WBj8WWvs3sW(KRrT7gETMSS9cg6IuqFh(-1146510045 ^ -1146509023), FIg07ZETy5vKHdpPUXqQ(info)));
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num = 2;
				}
				break;
			case 1:
				if (((Array)FIg07ZETy5vKHdpPUXqQ(info)).Length == 0)
				{
					num = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num = 3;
					}
					break;
				}
				goto case 4;
			case 2:
				return;
			case 3:
				return;
			case 5:
				return;
			default:
				if (info.Arguments == null)
				{
					num = 5;
					break;
				}
				goto case 1;
			}
		}
	}

	public MethodCallStartEvent(CallContextInfo callContextInfo, MethodCallInfo info)
	{
		//Discarded unreachable code: IL_001c, IL_0021
		iXZNmwETma3ehaG5mFPT();
		base._002Ector(callContextInfo, info);
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 3:
				base.Message = base.Message + SR.T((string)KRrT7gETMSS9cg6IuqFh(-1876063057 ^ -1876306709), ignoreTranslationMode: true) + (string)e0RuF5ET9WBj8WWvs3sW(KRrT7gETMSS9cg6IuqFh(-210725949 ^ -210722879), FIg07ZETy5vKHdpPUXqQ(info));
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num = 0;
				}
				break;
			default:
				if (((Array)FIg07ZETy5vKHdpPUXqQ(info)).Length == 0)
				{
					return;
				}
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num = 3;
				}
				break;
			case 2:
				if (FIg07ZETy5vKHdpPUXqQ(info) == null)
				{
					return;
				}
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void iXZNmwETma3ehaG5mFPT()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object FIg07ZETy5vKHdpPUXqQ(object P_0)
	{
		return ((MethodCallInfo)P_0).Arguments;
	}

	internal static object KRrT7gETMSS9cg6IuqFh(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object vHTRqRETJVyTnCkR5Ng3(object P_0, bool ignoreTranslationMode)
	{
		return SR.T((string)P_0, ignoreTranslationMode);
	}

	internal static object e0RuF5ET9WBj8WWvs3sW(object P_0, object P_1)
	{
		return string.Join((string)P_0, (object[])P_1);
	}

	internal static object CQFEKNETdrLPle6MVaRe(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static bool YXflAhETxfRhp0D99U93()
	{
		return l3Z8PtET7nSpmML0O5F1 == null;
	}

	internal static MethodCallStartEvent Q8AyaEET02fBw5GBU5XA()
	{
		return l3Z8PtET7nSpmML0O5F1;
	}
}
