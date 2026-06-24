using System;
using EleWise.ELMA.Configuration;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Managers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Providers;

public class FileStoreProviderManager : GenericProviderManager<FileStoreProvider, IFileManager>, IUpdatableProviderManager
{
	public const string UID_S = "{5CEE6AEC-28C5-48C0-8D89-6A94AD14FBB2}";

	public static readonly Guid UID;

	internal static FileStoreProviderManager rIQYCEWGUaXJovT4sfh5;

	public override Guid Uid => UID;

	public override string Name => (string)yaj18sWGzULyLkIiU2OL(-812025778 ^ -812063308);

	public void UpdateConfiguration(RuntimeConfiguration configuration)
	{
		//Discarded unreachable code: IL_004b, IL_007e, IL_00d5, IL_00e4
		switch (1)
		{
		case 1:
			try
			{
				QYtXSpWEFZMGkv0CfqSY(DefaultProvider, configuration);
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
				break;
			}
			catch (Exception ex)
			{
				int num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 1;
				}
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						vSsHOsWEW96uI4bOoGdi(Logger.GetLogger((string)yaj18sWGzULyLkIiU2OL(-812025778 ^ -812115066)), wBhfHfWEBoLTAQ9iWAhs(ex));
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		case 0:
			break;
		}
	}

	public FileStoreProviderManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static FileStoreProviderManager()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				UID = new Guid((string)yaj18sWGzULyLkIiU2OL(0xD3DEF7E ^ 0xD3C716E));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static object yaj18sWGzULyLkIiU2OL(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool CaSTLGWGsaJFKR79VtVs()
	{
		return rIQYCEWGUaXJovT4sfh5 == null;
	}

	internal static FileStoreProviderManager i0PZlPWGcK7Ughwpe0kL()
	{
		return rIQYCEWGUaXJovT4sfh5;
	}

	internal static void QYtXSpWEFZMGkv0CfqSY(object P_0, object P_1)
	{
		((FileStoreProvider)P_0).ReConfigure((RuntimeConfiguration)P_1);
	}

	internal static object wBhfHfWEBoLTAQ9iWAhs(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static void vSsHOsWEW96uI4bOoGdi(object P_0, object P_1)
	{
		((ILogger)P_0).Info(P_1);
	}
}
