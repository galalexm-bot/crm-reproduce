using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Db.Actions;

public class ChangePropertyAction : EntityPropertyAction
{
	private EntityPropertyMetadata oldPropertyMetadata;

	internal static ChangePropertyAction TvwV3aoGCEP4jvAgt8UJ;

	public ChangePropertyAction(IDbModelUpdater updater, EntityMetadata metadata, EntityPropertyMetadata propertyMetadata, EntityPropertyMetadata oldPropertyMetadata)
	{
		//Discarded unreachable code: IL_002d, IL_0032
		zBDITXoGZ9bJOpkgP80S();
		base._002Ector(updater, metadata, propertyMetadata);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				XlM0SXoGuBKTaYVBHr0a(base.Updater, base.Metadata, propertyMetadata, oldPropertyMetadata);
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num = 2;
				}
				break;
			case 1:
				this.oldPropertyMetadata = oldPropertyMetadata;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static void zBDITXoGZ9bJOpkgP80S()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool XlM0SXoGuBKTaYVBHr0a(object P_0, object P_1, object P_2, object P_3)
	{
		return DbModelHelper.ApplyPropertyDbChanges((IDbModelUpdater)P_0, (EntityMetadata)P_1, (EntityPropertyMetadata)P_2, (EntityPropertyMetadata)P_3);
	}

	internal static bool h2M7bAoGvgGtebAm8O4N()
	{
		return TvwV3aoGCEP4jvAgt8UJ == null;
	}

	internal static ChangePropertyAction pvxcKPoG8sddIpn1WyOZ()
	{
		return TvwV3aoGCEP4jvAgt8UJ;
	}
}
