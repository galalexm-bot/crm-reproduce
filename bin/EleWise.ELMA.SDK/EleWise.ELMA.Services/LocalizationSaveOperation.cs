using System.Runtime.CompilerServices;
using EleWise.ELMA.Globalization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Services;

internal class LocalizationSaveOperation : LocalizationOperation
{
	private static LocalizationSaveOperation nAWSjXB7uVs70Ci28uhn;

	public LocalizationFile File
	{
		[CompilerGenerated]
		get
		{
			return _003CFile_003Ek__BackingField;
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
					_003CFile_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
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

	public LocalizationSaveOperation()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		N2MZSeB7SBwRO6rbJsXw();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				base.Name = (string)bgtMgRB7iVP8eAskMkIY(-787452571 ^ -787468365);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override void Execute()
	{
		//Discarded unreachable code: IL_0039, IL_0048
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				return;
			case 4:
				return;
			case 2:
				if (File == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 5:
				if (base.TranslateService == null)
				{
					num2 = 4;
					continue;
				}
				goto case 2;
			case 3:
				break;
			case 0:
				return;
			}
			PeZuBtB7RDplmbZm189p(base.TranslateService, File);
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
			{
				num2 = 0;
			}
		}
	}

	internal static void N2MZSeB7SBwRO6rbJsXw()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object bgtMgRB7iVP8eAskMkIY(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool stKB5cB7IOhy0qOX0bIK()
	{
		return nAWSjXB7uVs70Ci28uhn == null;
	}

	internal static LocalizationSaveOperation GSL9l0B7V6WI8k18w5Xd()
	{
		return nAWSjXB7uVs70Ci28uhn;
	}

	internal static void PeZuBtB7RDplmbZm189p(object P_0, object P_1)
	{
		((TranslateService)P_0).SaveChanges((LocalizationFile)P_1);
	}
}
