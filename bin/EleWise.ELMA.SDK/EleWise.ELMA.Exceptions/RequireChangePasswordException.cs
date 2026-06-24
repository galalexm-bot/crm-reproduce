using System;
using System.Runtime.Serialization;
using EleWise.ELMA.Security;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Exceptions;

[Serializable]
public class RequireChangePasswordException : Exception
{
	private IUser _user;

	internal static RequireChangePasswordException rZL3udGgl1G16rqjNQAG;

	public IUser User => _user;

	public RequireChangePasswordException(IUser user)
	{
		//Discarded unreachable code: IL_0045, IL_004a
		KHwPBNGg5eNXd5OZur7u();
		base._002Ector((string)btNlWwGgjwAE4uKnxPfB(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x92F12D5 ^ 0x92F3D4F)));
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
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
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
			{
				num = 1;
			}
		}
	}

	public RequireChangePasswordException()
	{
		//Discarded unreachable code: IL_003f, IL_0044
		KHwPBNGg5eNXd5OZur7u();
		base._002Ector((string)btNlWwGgjwAE4uKnxPfB(b8bx5jGgY4T36ammhL4d(0x2ACE37D ^ 0x2ACCCE7)));
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
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
			_user = null;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
			{
				num = 1;
			}
		}
	}

	protected RequireChangePasswordException(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		KHwPBNGg5eNXd5OZur7u();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void KHwPBNGg5eNXd5OZur7u()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object btNlWwGgjwAE4uKnxPfB(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool mwUgtOGgrAZjAfStWd1Q()
	{
		return rZL3udGgl1G16rqjNQAG == null;
	}

	internal static RequireChangePasswordException g5oSPnGggPJxvkpu9NXa()
	{
		return rZL3udGgl1G16rqjNQAG;
	}

	internal static object b8bx5jGgY4T36ammhL4d(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
