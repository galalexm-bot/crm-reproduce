using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Files;

public class PutContentOptions
{
	public static readonly PutContentOptions Default;

	public static readonly PutContentOptions Async;

	internal static PutContentOptions SMxfT3GXSCPvZ5sxHcap;

	public bool ForAsync
	{
		[CompilerGenerated]
		get
		{
			return _003CForAsync_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CForAsync_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
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

	public string Extension
	{
		[CompilerGenerated]
		get
		{
			return _003CExtension_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CExtension_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public PutContentOptions()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		pEX0KtGXqQuIg2VAhWDG();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
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
				ForAsync = false;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	static PutContentOptions()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				pEX0KtGXqQuIg2VAhWDG();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				Default = new PutContentOptions();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
				{
					num2 = 3;
				}
				break;
			case 3:
			{
				PutContentOptions putContentOptions = new PutContentOptions();
				qjVZPxGXKsUwb1KqUkdB(putContentOptions, true);
				Async = putContentOptions;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 1;
				}
				break;
			}
			}
		}
	}

	internal static void pEX0KtGXqQuIg2VAhWDG()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool GJR8cSGXig3HY8C9ypIL()
	{
		return SMxfT3GXSCPvZ5sxHcap == null;
	}

	internal static PutContentOptions tSR2kgGXRpt4TADnT8nN()
	{
		return SMxfT3GXSCPvZ5sxHcap;
	}

	internal static void qjVZPxGXKsUwb1KqUkdB(object P_0, bool value)
	{
		((PutContentOptions)P_0).ForAsync = value;
	}
}
