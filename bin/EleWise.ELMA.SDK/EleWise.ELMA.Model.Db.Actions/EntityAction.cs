using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Db.Actions;

public abstract class EntityAction : ModelAction
{
	private EntityMetadata metadata;

	private static EntityAction Xb28aToEGJJCBQxYAQgI;

	protected EntityMetadata Metadata => metadata;

	public EntityAction(IDbModelUpdater updater, EntityMetadata metadata)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		XlChdIoEQ4wL64N2JOQv();
		base._002Ector(updater);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				zI5fNnoECJ56EwNDZsBq(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088322842));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
				{
					num = 0;
				}
				break;
			default:
				this.metadata = metadata;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
				{
					num = 1;
				}
				break;
			case 1:
				return;
			}
		}
	}

	internal static void XlChdIoEQ4wL64N2JOQv()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void zI5fNnoECJ56EwNDZsBq(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static bool gvjQB1oEEGka3SgHc8gh()
	{
		return Xb28aToEGJJCBQxYAQgI == null;
	}

	internal static EntityAction UQdQKLoEfVAJu4YQSVST()
	{
		return Xb28aToEGJJCBQxYAQgI;
	}
}
