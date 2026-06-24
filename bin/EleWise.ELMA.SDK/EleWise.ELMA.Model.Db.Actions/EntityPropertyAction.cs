using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Db.Actions;

public abstract class EntityPropertyAction : EntityAction
{
	private EntityPropertyMetadata propertyMetadata;

	internal static EntityPropertyAction RpBZKboG4uQlvLyTBhSi;

	protected EntityPropertyMetadata PropertyMetadata => propertyMetadata;

	public EntityPropertyAction(IDbModelUpdater updater, EntityMetadata metadata, EntityPropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		T7iijooGAMSUVBhhYCVG();
		base._002Ector(updater, metadata);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				lYsw8goG7XXoU9g5l0iE(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 0x51154B4F));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num = 0;
				}
				break;
			default:
				this.propertyMetadata = propertyMetadata;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			}
		}
	}

	internal static void T7iijooGAMSUVBhhYCVG()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void lYsw8goG7XXoU9g5l0iE(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static bool jM6WeAoG6T5vSKkd6DFC()
	{
		return RpBZKboG4uQlvLyTBhSi == null;
	}

	internal static EntityPropertyAction DLs6qmoGH8V1qTgBsJAt()
	{
		return RpBZKboG4uQlvLyTBhSi;
	}
}
