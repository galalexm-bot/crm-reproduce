using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Services;

internal class LocalizationMergeOperation : LocalizationOperation
{
	internal static LocalizationMergeOperation BKei7uB7qLQ7vpEyildk;

	public string LocalId
	{
		[CompilerGenerated]
		get
		{
			return _003CLocalId_003Ek__BackingField;
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
					_003CLocalId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public LocalizationMergeOperation()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
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
				base.Name = (string)jcMSp1B7TIGh1CwTfCm5(--1360331293 ^ 0x51145CC3);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override void Execute()
	{
		//Discarded unreachable code: IL_004f, IL_005e
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				if (!yxvvBHB7kibKvXvCXxgL(LocalId))
				{
					num2 = 3;
					break;
				}
				return;
			case 0:
				return;
			case 3:
				cJNgHxB7nTWSo1NqBy0A(base.TranslateService, LocalId);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				return;
			case 1:
				if (base.TranslateService == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	internal static object jcMSp1B7TIGh1CwTfCm5(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool rKh7ytB7KPnXtS3E6Log()
	{
		return BKei7uB7qLQ7vpEyildk == null;
	}

	internal static LocalizationMergeOperation xcGOQUB7XwWCvQDKGIHy()
	{
		return BKei7uB7qLQ7vpEyildk;
	}

	internal static bool yxvvBHB7kibKvXvCXxgL(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void cJNgHxB7nTWSo1NqBy0A(object P_0, object P_1)
	{
		((TranslateService)P_0).MergeFiles((string)P_1);
	}
}
