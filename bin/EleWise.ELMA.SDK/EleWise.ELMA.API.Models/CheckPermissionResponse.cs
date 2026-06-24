using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.API.Models;

[Serializable]
[DataContract]
public class CheckPermissionResponse
{
	private static CheckPermissionResponse dGy82Uf1qD8dTeihTDcF;

	[DataMember]
	public Guid Id
	{
		[CompilerGenerated]
		get
		{
			return _003CId_003Ek__BackingField;
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
					_003CId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember]
	public bool Allow
	{
		[CompilerGenerated]
		get
		{
			return _003CAllow_003Ek__BackingField;
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
				case 1:
					_003CAllow_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public CheckPermissionResponse()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Ashicof1TtYNAS0Rr9If();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool se93TFf1KD2MrKjlefiG()
	{
		return dGy82Uf1qD8dTeihTDcF == null;
	}

	internal static CheckPermissionResponse mgqGtcf1XDpSOiXgkbWv()
	{
		return dGy82Uf1qD8dTeihTDcF;
	}

	internal static void Ashicof1TtYNAS0Rr9If()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
