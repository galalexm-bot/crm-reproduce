using System;
using System.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Runtime.Extensions;

public static class StartInformationExtension
{
	internal static StartInformationExtension l4b5U6Wvx7Wljpww8WtL;

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static int NumberOfDBConversionStages { get; }

	public static void SetInfo(this IStartInformation startInformation, string message)
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
				ciISBhWvMHqVN71sYyby(startInformation, ((IStartInformation)HiE73iWvyMgPKPTscRAu()).Percent, message);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static int GetCurrentDBConversionStage()
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		DBStartInformation dBStartInformation = default(DBStartInformation);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if ((dBStartInformation = HiE73iWvyMgPKPTscRAu() as DBStartInformation) != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return 0;
			case 1:
				return (int)etvheBWvJDRUiC9NiWkI(dBStartInformation);
			}
		}
	}

	static StartInformationExtension()
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
			case 2:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				NumberOfDBConversionStages = ((Array)YqiYNDWvdgNTBCk5pNbB(KcVnPOWv90M4KaqfGfEQ(typeof(DatabaseConversionStage).TypeHandle))).Length;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object HiE73iWvyMgPKPTscRAu()
	{
		return StartInformation.Current;
	}

	internal static void ciISBhWvMHqVN71sYyby(object P_0, double percent, object P_2)
	{
		((IStartInformation)P_0).SetInfo(percent, (string)P_2);
	}

	internal static bool dqBGSIWv0QYGwpF2hiyL()
	{
		return l4b5U6Wvx7Wljpww8WtL == null;
	}

	internal static StartInformationExtension iB1ib4WvmWjywLuvFc15()
	{
		return l4b5U6Wvx7Wljpww8WtL;
	}

	internal static DatabaseConversionStage etvheBWvJDRUiC9NiWkI(object P_0)
	{
		return ((DBStartInformation)P_0).CurrentDatabaseConversionStage;
	}

	internal static Type KcVnPOWv90M4KaqfGfEQ(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object YqiYNDWvdgNTBCk5pNbB(Type P_0)
	{
		return Enum.GetNames(P_0);
	}
}
