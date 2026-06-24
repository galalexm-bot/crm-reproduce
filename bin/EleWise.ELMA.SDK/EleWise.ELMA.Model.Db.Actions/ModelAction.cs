using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Actions;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Db.Actions;

public abstract class ModelAction : DbAction
{
	private IDbModelUpdater updater;

	private IMetadataRuntimeService metadataService;

	private static ModelAction mxxOdloEvFJ1bIVL8bm2;

	protected IDbModelUpdater Updater => updater;

	protected IMetadataRuntimeService MetadataService => metadataService;

	public ModelAction(IDbModelUpdater updater)
	{
		//Discarded unreachable code: IL_0020
		SingletonReader.JJCZtPuTvSt();
		base._002Ector((ITransformationProvider)vrtVSpoEuSbtifg3SrXS(updater));
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 4:
				return;
			default:
				metadataService = Locator.GetServiceNotNull<IMetadataRuntimeService>();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
				{
					num = 4;
				}
				break;
			case 2:
				this.updater = updater;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num = 0;
				}
				break;
			case 3:
				JxF02ooEVktAnaHSTRLI(updater, Ej3ix0oEIjNXGZl00xkY(0x7247028A ^ 0x7245554A));
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num = 1;
				}
				break;
			case 1:
			{
				JxF02ooEVktAnaHSTRLI(vrtVSpoEuSbtifg3SrXS(updater), Ej3ix0oEIjNXGZl00xkY(0x1C9495B4 ^ 0x1C96C266));
				int num2 = 2;
				num = num2;
				break;
			}
			}
		}
	}

	internal static object vrtVSpoEuSbtifg3SrXS(object P_0)
	{
		return ((IDbModelUpdater)P_0).Transform;
	}

	internal static object Ej3ix0oEIjNXGZl00xkY(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void JxF02ooEVktAnaHSTRLI(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static bool z8M9kxoE8Xt8AEAvP5bZ()
	{
		return mxxOdloEvFJ1bIVL8bm2 == null;
	}

	internal static ModelAction z9uKpHoEZdRTXwwwHy4B()
	{
		return mxxOdloEvFJ1bIVL8bm2;
	}
}
