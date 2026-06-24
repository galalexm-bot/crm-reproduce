using System;
using EleWise.ELMA.Events.Audit;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Events.Audit;

[Serializable]
public class EntityAuditObjectType : IAuditObjectType
{
	public const string UID_S = "{CA0411EC-8D96-4D56-93CD-08FFADB1CE01}";

	public static readonly Guid UID;

	private static readonly EntityAuditObjectType instance;

	private static EntityAuditObjectType OM5x0woWvv3Uk9ISkvHM;

	public static IAuditObjectType Instance => instance;

	public Guid Uid => UID;

	static EntityAuditObjectType()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				instance = new EntityAuditObjectType();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				return;
			case 2:
				UID = new Guid((string)VuvQkXoWukcpDUX5S4EF(0x61EC0CB8 ^ 0x61EE4B22));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				SingletonReader.JJCZtPuTvSt();
				num2 = 2;
				break;
			}
		}
	}

	public EntityAuditObjectType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		XXnK1uoWIianGfIWh30C();
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

	internal static object VuvQkXoWukcpDUX5S4EF(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool AuSX4AoW8dBG3KlD73Uu()
	{
		return OM5x0woWvv3Uk9ISkvHM == null;
	}

	internal static EntityAuditObjectType VfAgDqoWZ0kZA9PIbqdL()
	{
		return OM5x0woWvv3Uk9ISkvHM;
	}

	internal static void XXnK1uoWIianGfIWh30C()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
