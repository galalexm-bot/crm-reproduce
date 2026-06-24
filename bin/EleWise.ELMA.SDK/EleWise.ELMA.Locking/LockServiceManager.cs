using System;
using EleWise.ELMA.Configuration;
using EleWise.ELMA.Runtime.Providers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Locking;

public class LockServiceManager : GenericProviderManager<LockService, ILockService>
{
	public const string UID_S = "{43C6D863-0255-440A-91DE-27FB90EB1BD4}";

	public static readonly Guid UID;

	public static readonly string NAME;

	internal static LockServiceManager pkl0wlhrsdyvZDLynpFW;

	public override Guid Uid => UID;

	public override string Name => NAME;

	public override void Configure(ProviderSettingsSection settings, RuntimeConfiguration configuration)
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
				JNd1x8hgFGwifpBdkxka(this, settings, configuration);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				n0VnEuhgBBkFhcBXaemY(DefaultProvider, settings, configuration);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public LockServiceManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		BTddbDhgW30PddS6d786();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static LockServiceManager()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				NAME = (string)xuhJtjhgohYGSlN8GXdm(0x1A33FE36 ^ 0x1A3062B4);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			default:
				UID = new Guid((string)xuhJtjhgohYGSlN8GXdm(-1411196499 ^ -1411299937));
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void JNd1x8hgFGwifpBdkxka(object P_0, object P_1, object P_2)
	{
		((GenericProviderManager<LockService, ILockService>)P_0).Configure((ProviderSettingsSection)P_1, (RuntimeConfiguration)P_2);
	}

	internal static void n0VnEuhgBBkFhcBXaemY(object P_0, object P_1, object P_2)
	{
		((LockService)P_0).Configure((ProviderSettingsSection)P_1, (RuntimeConfiguration)P_2);
	}

	internal static bool QWOVYrhrcCJgSd51lb6F()
	{
		return pkl0wlhrsdyvZDLynpFW == null;
	}

	internal static LockServiceManager sGJTsthrzYZfXMCBV4Bw()
	{
		return pkl0wlhrsdyvZDLynpFW;
	}

	internal static void BTddbDhgW30PddS6d786()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object xuhJtjhgohYGSlN8GXdm(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
