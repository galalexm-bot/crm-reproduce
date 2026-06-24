using System;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Exceptions;

[Serializable]
public class ServiceNotFoundException : Exception
{
	internal static ServiceNotFoundException utOGwVGjds98atBRLIeS;

	protected static string NamedServiceNotFound => SR.T((string)oeDNuLGjYE74xyQKs0vH(0x103FE975 ^ 0x103BF2F9));

	protected static string ServiceNotFound => SR.T((string)oeDNuLGjYE74xyQKs0vH(0x34A6D230 ^ 0x34A2C98E));

	public ServiceNotFoundException()
	{
		//Discarded unreachable code: IL_002f, IL_0034
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(ServiceNotFound);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ServiceNotFoundException(string serviceName)
	{
		//Discarded unreachable code: IL_0036, IL_003b
		VTbj4AGjgdLtTMpypUaa();
		this._002Ector(serviceName, (string)Hs9qG4Gj5JbAhR0wtwTd(NamedServiceNotFound, serviceName));
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ServiceNotFoundException(Type serviceType)
	{
		//Discarded unreachable code: IL_0040, IL_0045
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(serviceType.FullName, (string)Hs9qG4Gj5JbAhR0wtwTd(Yq9QVHGjjbxrseXfF0Be(), serviceType.FullName));
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ServiceNotFoundException(string serviceName, string message)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		VTbj4AGjgdLtTMpypUaa();
		base._002Ector(message);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected ServiceNotFoundException(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		VTbj4AGjgdLtTMpypUaa();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool C6UfXmGjl0THXDg3m8e5()
	{
		return utOGwVGjds98atBRLIeS == null;
	}

	internal static ServiceNotFoundException eVvdwFGjrlKpnbO0qafN()
	{
		return utOGwVGjds98atBRLIeS;
	}

	internal static void VTbj4AGjgdLtTMpypUaa()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object Hs9qG4Gj5JbAhR0wtwTd(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object Yq9QVHGjjbxrseXfF0Be()
	{
		return NamedServiceNotFound;
	}

	internal static object oeDNuLGjYE74xyQKs0vH(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
