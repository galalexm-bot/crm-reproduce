using System;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Import.Modules;

internal sealed class ModuleDeployException : Exception
{
	private static ModuleDeployException ObW2ZxEMuhKgEf3rNbPM;

	private ModuleDeployException(string message)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		zu57nGEMSRmqcLdoAsdq();
		base._002Ector(message);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public static ModuleDeployException ImportError()
	{
		return new ModuleDeployException((string)KfFUV8EMiEd8hPbhayWl(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4DC2B14D ^ 0x4DC60D93)));
	}

	public static ModuleDeployException TestError(string id, string title, string message)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (wsPep4EMRcYjJbsaFFqt(message))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return new ModuleDeployException(SR.T((string)AOQ7LQEMqKbpitLFdEov(0xE1229CF ^ 0xE16944F), title, id, message));
			case 1:
				message = (string)KfFUV8EMiEd8hPbhayWl(AOQ7LQEMqKbpitLFdEov(-1710575414 ^ -1710355060));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static ModuleDeployException TestError()
	{
		return new ModuleDeployException((string)KfFUV8EMiEd8hPbhayWl(AOQ7LQEMqKbpitLFdEov(0x4785BC0D ^ 0x478101D9)));
	}

	internal static void zu57nGEMSRmqcLdoAsdq()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool nlVpCuEMIWegTQmBUNXG()
	{
		return ObW2ZxEMuhKgEf3rNbPM == null;
	}

	internal static ModuleDeployException zaiTW1EMVLD0U0k6gVE2()
	{
		return ObW2ZxEMuhKgEf3rNbPM;
	}

	internal static object KfFUV8EMiEd8hPbhayWl(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool wsPep4EMRcYjJbsaFFqt(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object AOQ7LQEMqKbpitLFdEov(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
