using System;
using System.Runtime.Serialization;
using EleWise.ELMA.Security;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Licensing;

[Serializable]
public class SimultaneousSessionExceededException : LicenseException
{
	private IUser _user;

	internal static SimultaneousSessionExceededException Nfu4yQ7XNM7NHjXbobT;

	public IUser User => _user;

	public SimultaneousSessionExceededException(IUser user)
	{
		//Discarded unreachable code: IL_003f, IL_0044
		SRCaAa7nLkAC3NH0x6P();
		base._002Ector(SR.T((string)cKk2Am7OBe5J6nuYVt8(-138018305 ^ -137979067)));
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
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
			_user = user;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
			{
				num = 1;
			}
		}
	}

	protected SimultaneousSessionExceededException(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		SRCaAa7nLkAC3NH0x6P();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void SRCaAa7nLkAC3NH0x6P()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object cKk2Am7OBe5J6nuYVt8(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool VUfFPS7TnDkLQHhrcfQ()
	{
		return Nfu4yQ7XNM7NHjXbobT == null;
	}

	internal static SimultaneousSessionExceededException wSqfCS7k8HJYRlYLgGr()
	{
		return Nfu4yQ7XNM7NHjXbobT;
	}
}
