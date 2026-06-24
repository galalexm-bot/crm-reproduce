using System;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Exceptions;

[Serializable]
public class TypeNotFoundException : Exception
{
	private Guid typeUid;

	private static TypeNotFoundException tedjEbGjuA7h8xZET4re;

	public Guid TypeUid => typeUid;

	public TypeNotFoundException()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Y9507yGjSbivmCZYNtJf();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public TypeNotFoundException(Guid typeUid)
	{
		//Discarded unreachable code: IL_004e, IL_0053
		Y9507yGjSbivmCZYNtJf();
		base._002Ector(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EA5403C ^ 0x4EA73F34), typeUid));
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
		{
			num = 1;
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
				this.typeUid = typeUid;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public TypeNotFoundException(string typeName)
	{
		//Discarded unreachable code: IL_004a, IL_004f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(SR.T((string)e6l3LqGjiZEZoDHvv7TJ(0x7459E02 ^ 0x74184C6), typeName));
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected TypeNotFoundException(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		Y9507yGjSbivmCZYNtJf();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void Y9507yGjSbivmCZYNtJf()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool pGDnSlGjIuOcnsN23B6s()
	{
		return tedjEbGjuA7h8xZET4re == null;
	}

	internal static TypeNotFoundException lPhfBAGjVOLkTpEX9fnJ()
	{
		return tedjEbGjuA7h8xZET4re;
	}

	internal static object e6l3LqGjiZEZoDHvv7TJ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
