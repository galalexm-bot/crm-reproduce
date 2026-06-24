using System;
using EleWise.ELMA.Runtime.Managers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Providers;

public class BLOBStoreProviderManager : GenericProviderManager<BLOBStoreProvider, IBLOBDataManager>
{
	public const string UID_S = "{569DED27-BA06-4055-A704-EB198EB897AE}";

	public static readonly Guid UID;

	private static BLOBStoreProviderManager qbmQgIWEVGqSmqIlbDDL;

	public override Guid Uid => UID;

	public override string Name => (string)JXnwd5WERFekxixIYTmr(-1979251663 ^ -1979278581);

	public BLOBStoreProviderManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		prCED4WEqiafWOuJdKCS();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static BLOBStoreProviderManager()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				prCED4WEqiafWOuJdKCS();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 1:
				UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68BBB53E ^ 0x68BA2A6E));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object JXnwd5WERFekxixIYTmr(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool t5PaTiWES4H6smI7gVjp()
	{
		return qbmQgIWEVGqSmqIlbDDL == null;
	}

	internal static BLOBStoreProviderManager WNdExrWEi0fa2JsRwqEM()
	{
		return qbmQgIWEVGqSmqIlbDDL;
	}

	internal static void prCED4WEqiafWOuJdKCS()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
