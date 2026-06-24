using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Exceptions;

[Serializable]
public class ServerRestartCancellationException : Exception
{
	internal static ServerRestartCancellationException fM1xhtGg4Hr67NYhaRDQ;

	public Guid RestartId
	{
		[CompilerGenerated]
		get
		{
			return _003CRestartId_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CRestartId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ServerRestartCancellationException()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Q8jr7vGgAUSmy2iM6bvk();
		base._002Ector();
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

	public ServerRestartCancellationException(Guid restartId, string message)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(message);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
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
			RestartId = restartId;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
			{
				num = 0;
			}
		}
	}

	public ServerRestartCancellationException(Guid restartId, string message, Exception innerException)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		Q8jr7vGgAUSmy2iM6bvk();
		base._002Ector(message, innerException);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
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
			RestartId = restartId;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
			{
				num = 1;
			}
		}
	}

	public ServerRestartCancellationException(string message)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		Q8jr7vGgAUSmy2iM6bvk();
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

	public ServerRestartCancellationException(string message, Exception innerException)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		Q8jr7vGgAUSmy2iM6bvk();
		base._002Ector(message, innerException);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected ServerRestartCancellationException(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
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
			RestartId = (Guid)hnLZXSGgx7IDp9F5g6TR(info, YvG4xmGg7tCaqaAPHguI(-1317790512 ^ -1318057728), typeof(Guid));
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
			{
				num = 0;
			}
		}
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				qtVCXDGgyqqnVitV9h3S(info, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1870892489 ^ -1871157273), RestartId, hwDMOyGgmOtkMnEyuqWv(typeof(Guid).TypeHandle));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				DXLc2dGg05tMpJs3tNTK(this, info, context);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool y03v0TGg61PCPBC1EHKh()
	{
		return fM1xhtGg4Hr67NYhaRDQ == null;
	}

	internal static ServerRestartCancellationException RPWsXOGgHuuOlfBkfL5i()
	{
		return fM1xhtGg4Hr67NYhaRDQ;
	}

	internal static void Q8jr7vGgAUSmy2iM6bvk()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object YvG4xmGg7tCaqaAPHguI(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object hnLZXSGgx7IDp9F5g6TR(object P_0, object P_1, Type P_2)
	{
		return ((SerializationInfo)P_0).GetValue((string)P_1, P_2);
	}

	internal static void DXLc2dGg05tMpJs3tNTK(object P_0, object P_1, StreamingContext P_2)
	{
		((Exception)P_0).GetObjectData((SerializationInfo)P_1, P_2);
	}

	internal static Type hwDMOyGgmOtkMnEyuqWv(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static void qtVCXDGgyqqnVitV9h3S(object P_0, object P_1, object P_2, Type P_3)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2, P_3);
	}
}
