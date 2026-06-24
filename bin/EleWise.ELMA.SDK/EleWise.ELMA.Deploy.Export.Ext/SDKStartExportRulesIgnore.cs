using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Export.ExtensionPoints;

[Component]
public class SDKStartExportRulesIgnore : IStartExportRulesIgnore
{
	internal static SDKStartExportRulesIgnore ukS18cEUaCUgaXKxIUWS;

	public bool IgnoreThisEntity(EntityMetadata entityMetadata)
	{
		//Discarded unreachable code: IL_007a, IL_0089
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				if (!(entityMetadata is TablePartMetadata))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				goto case 2;
			case 1:
				if (entityMetadata != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 2:
				return true;
			case 3:
				break;
			}
			break;
		}
		return false;
	}

	public SDKStartExportRulesIgnore()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Ml7FZ5EUwr7IYs7hsDco();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool aN8R7SEUDkSLtHj9ybh0()
	{
		return ukS18cEUaCUgaXKxIUWS == null;
	}

	internal static SDKStartExportRulesIgnore slOgImEUt4Efa2S7iGDV()
	{
		return ukS18cEUaCUgaXKxIUWS;
	}

	internal static void Ml7FZ5EUwr7IYs7hsDco()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
