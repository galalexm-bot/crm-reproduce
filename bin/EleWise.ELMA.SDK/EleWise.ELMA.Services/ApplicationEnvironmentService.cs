using System;
using System.Diagnostics;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Services;

[Service]
internal class ApplicationEnvironmentService : IApplicationEnvironmentService
{
	internal static ApplicationEnvironmentService QNnFWeBwPTSqTcARMBmQ;

	public string GetEnvironmentId()
	{
		return string.Format((string)mT9TF4Bw3aer8PA9APwA(-867826612 ^ -867745114), Environment.MachineName, SEFGGVBwaA7TaRRcp7hg(WD1N8gBwp731aB0g5guk()));
	}

	public ApplicationEnvironmentService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		a0cN1sBwDlCl4vVpW5G0();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object mT9TF4Bw3aer8PA9APwA(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object WD1N8gBwp731aB0g5guk()
	{
		return Process.GetCurrentProcess();
	}

	internal static int SEFGGVBwaA7TaRRcp7hg(object P_0)
	{
		return ((Process)P_0).Id;
	}

	internal static bool gIaaKGBw14rK8ArIayti()
	{
		return QNnFWeBwPTSqTcARMBmQ == null;
	}

	internal static ApplicationEnvironmentService NwIHYjBwNN09Jvfas7KF()
	{
		return QNnFWeBwPTSqTcARMBmQ;
	}

	internal static void a0cN1sBwDlCl4vVpW5G0()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
