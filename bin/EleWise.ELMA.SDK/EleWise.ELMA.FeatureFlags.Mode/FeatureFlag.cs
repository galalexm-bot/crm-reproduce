using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.FeatureFlags.Models;

internal struct FeatureFlag : IFeatureFlag
{
	private readonly bool enabled;

	internal static object qf1pDMGWNHgfEU6mAFnB;

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return _003CName_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	internal FeatureFlag(string name, bool enabled)
	{
		//Discarded unreachable code: IL_0005
		rUFEJpGWaLbDT1tVQskE();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				this.enabled = enabled;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 2:
				Name = name;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public bool Enabled()
	{
		return enabled;
	}

	internal static void rUFEJpGWaLbDT1tVQskE()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool kbbTuBGW3yy4VSSWPSB3()
	{
		return qf1pDMGWNHgfEU6mAFnB == null;
	}

	internal static object Dbh0wAGWppe7vFKgviNl()
	{
		return qf1pDMGWNHgfEU6mAFnB;
	}
}
