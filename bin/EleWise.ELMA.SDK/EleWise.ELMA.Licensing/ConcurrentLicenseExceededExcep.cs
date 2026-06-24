using System;
using System.Runtime.Serialization;
using EleWise.ELMA.Security;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Licensing;

[Serializable]
public class ConcurrentLicenseExceededException : LicenseException
{
	private IUser _user;

	private static ConcurrentLicenseExceededException AlGQQhAflqs2FJXdr5U;

	public IUser User => _user;

	public ConcurrentLicenseExceededException(IUser user)
	{
		//Discarded unreachable code: IL_0040, IL_0045
		FCZIuJAvFQG368mbKuf();
		base._002Ector((string)xeKSq4AZHpSjSv4EMiV(r662OcA8Uu9W9yu8Vc7(-1998538950 ^ -1998577178)));
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
		{
			num = 0;
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
				_user = user;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	protected ConcurrentLicenseExceededException(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		FCZIuJAvFQG368mbKuf();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void FCZIuJAvFQG368mbKuf()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object r662OcA8Uu9W9yu8Vc7(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object xeKSq4AZHpSjSv4EMiV(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool xfdVcKAQOjCc93751t0()
	{
		return AlGQQhAflqs2FJXdr5U == null;
	}

	internal static ConcurrentLicenseExceededException HNHicAACI9eEj2jNQkC()
	{
		return AlGQQhAflqs2FJXdr5U;
	}
}
