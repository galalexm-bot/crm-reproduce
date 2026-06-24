using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

public class MoneyRangeDescriptor : RangeTypeDescriptor<MoneyRange, Money, MoneySettings>
{
	public const string UID_S = "{C245122D-57EE-4B8E-8F9F-F538D06778F4}";

	public static readonly Guid UID;

	internal static MoneyRangeDescriptor oNH8SloMji0qywMb7hsn;

	public override Guid Uid => UID;

	public override string Name => SR.T((string)VLy29FoMU9prMavmQFCQ(-1886646897 ^ -1886481113));

	public MoneyRangeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ISIiSqoMscFL8a4iEiq2();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static MoneyRangeDescriptor()
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
				UID = new Guid((string)VLy29FoMU9prMavmQFCQ(-1824388195 ^ -1824484525));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				ISIiSqoMscFL8a4iEiq2();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static object VLy29FoMU9prMavmQFCQ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool CrITPOoMYiBXaI7wc0f2()
	{
		return oNH8SloMji0qywMb7hsn == null;
	}

	internal static MoneyRangeDescriptor TstgeLoMLE45f31m2qi9()
	{
		return oNH8SloMji0qywMb7hsn;
	}

	internal static void ISIiSqoMscFL8a4iEiq2()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
