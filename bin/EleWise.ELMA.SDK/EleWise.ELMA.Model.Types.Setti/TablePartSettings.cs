using System;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Settings;

[Serializable]
public class TablePartSettings : TypeSettings
{
	private ITablePartMetadata metadata;

	private static TablePartSettings wRx2BXozcPfMCNUXwuf0;

	[JsonSerializationIgnore]
	public ITablePartMetadata Metadata => metadata;

	public TablePartSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		K1orfXbFBgYaXsQiMZo8();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public TablePartSettings(ITablePartMetadata metadata)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		K1orfXbFBgYaXsQiMZo8();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				this.metadata = metadata;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void K1orfXbFBgYaXsQiMZo8()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool om5w1oozzX5mJ96Aj954()
	{
		return wRx2BXozcPfMCNUXwuf0 == null;
	}

	internal static TablePartSettings M4xV9ZbFFUeudYViRuuM()
	{
		return wRx2BXozcPfMCNUXwuf0;
	}
}
