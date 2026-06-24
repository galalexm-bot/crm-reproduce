using System;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Exceptions;

[Serializable]
public class ObtainObjectLockException : Exception
{
	private static ObtainObjectLockException o1eA4NG5KuvDT7jpyx3s;

	public ObtainObjectLockException()
	{
		//Discarded unreachable code: IL_0045, IL_004a
		NhPUdGG5kyNruBhXi5nF();
		base._002Ector((string)CNTGecG5Oc0kNqBNSZFi(woiduyG5nd96UpMXhNLk(-70037984 ^ -69773794)));
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ObtainObjectLockException(string typeName, object id)
	{
		//Discarded unreachable code: IL_004d, IL_0052
		NhPUdGG5kyNruBhXi5nF();
		base._002Ector(SR.T((string)woiduyG5nd96UpMXhNLk(0xE1229CF ^ 0xE163141), typeName, id));
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ObtainObjectLockException(string typeName, object id, Exception innerException)
	{
		//Discarded unreachable code: IL_004e, IL_0053
		NhPUdGG5kyNruBhXi5nF();
		base._002Ector(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1ECE530A ^ 0x1ECA4B84), typeName, id), innerException);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected ObtainObjectLockException(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		NhPUdGG5kyNruBhXi5nF();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void NhPUdGG5kyNruBhXi5nF()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object woiduyG5nd96UpMXhNLk(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object CNTGecG5Oc0kNqBNSZFi(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool qaBgFrG5XAbeNxtbOt8p()
	{
		return o1eA4NG5KuvDT7jpyx3s == null;
	}

	internal static ObtainObjectLockException sw1mtaG5TjWlfwQpCl4E()
	{
		return o1eA4NG5KuvDT7jpyx3s;
	}
}
