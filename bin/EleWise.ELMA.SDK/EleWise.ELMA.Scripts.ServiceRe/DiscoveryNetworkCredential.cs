using System.Net;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Scripts.ServiceReference;

public class DiscoveryNetworkCredential : NetworkCredential
{
	public const string DefaultAuthenticationType = "Default";

	private string authenticationType;

	internal static DiscoveryNetworkCredential S5DJS5Bc3cHHWcl1KQu3;

	public string AuthenticationType => authenticationType;

	public bool IsDefaultAuthenticationType => fa1NhgBcHZ61rl04Iqes(authenticationType, dVYYBEBc6UFZKhOOdcmf(0x63ABA4E8 ^ 0x63AB287E), true) == 0;

	public DiscoveryNetworkCredential(string userName, string password, string domain, string authenticationType)
	{
		//Discarded unreachable code: IL_003d, IL_0042
		G3x5beBcDgMjdDLDwKik();
		this.authenticationType = string.Empty;
		base._002Ector(userName, password, domain);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.authenticationType = authenticationType;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
			{
				num = 1;
			}
		}
	}

	public DiscoveryNetworkCredential(NetworkCredential credential, string authenticationType)
	{
		//Discarded unreachable code: IL_003d, IL_0042
		G3x5beBcDgMjdDLDwKik();
		this._002Ector((string)ow8dAPBctMMIArhG6p8a(credential), (string)djOTbsBcwKAJFP5hdcZB(credential), (string)aYM6xTBc4clg9sZGFpDg(credential), authenticationType);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void G3x5beBcDgMjdDLDwKik()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool V1XZO3Bcp0nrGvbfO5Cm()
	{
		return S5DJS5Bc3cHHWcl1KQu3 == null;
	}

	internal static DiscoveryNetworkCredential YIGKKSBcaVbmwZY10MDC()
	{
		return S5DJS5Bc3cHHWcl1KQu3;
	}

	internal static object ow8dAPBctMMIArhG6p8a(object P_0)
	{
		return ((NetworkCredential)P_0).UserName;
	}

	internal static object djOTbsBcwKAJFP5hdcZB(object P_0)
	{
		return ((NetworkCredential)P_0).Password;
	}

	internal static object aYM6xTBc4clg9sZGFpDg(object P_0)
	{
		return ((NetworkCredential)P_0).Domain;
	}

	internal static object dVYYBEBc6UFZKhOOdcmf(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static int fa1NhgBcHZ61rl04Iqes(object P_0, object P_1, bool P_2)
	{
		return string.Compare((string)P_0, (string)P_1, P_2);
	}
}
