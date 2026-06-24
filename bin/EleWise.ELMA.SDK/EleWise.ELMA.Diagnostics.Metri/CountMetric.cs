using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Metrics;

public class CountMetric : BaseExpandableMetric
{
	internal static class __CountMetricLocalization
	{
		internal static __CountMetricLocalization xVG8EV8KV4Ajmb8ag7UX;

		public static string CountCall => (string)KCvQ8y8KqsVOOsQnpawv(MNDRxu8KRURmubeF3ZWb(-16752921 ^ -16401813));

		public static string CountErrorCall => (string)KCvQ8y8KqsVOOsQnpawv(MNDRxu8KRURmubeF3ZWb(0x2ACE37D ^ 0x2A907C9));

		internal static object MNDRxu8KRURmubeF3ZWb(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object KCvQ8y8KqsVOOsQnpawv(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool mWRscp8KSOEhm2KIlSRU()
		{
			return xVG8EV8KV4Ajmb8ag7UX == null;
		}

		internal static __CountMetricLocalization sNqksR8KixnbOaUh46wU()
		{
			return xVG8EV8KV4Ajmb8ag7UX;
		}
	}

	internal static CountMetric mhIXWlE8rqA3vBS9EcQ0;

	public override Guid Uid => new Guid((string)YwLo0xE8j1x0rfVqAoSY(0x7C1EE318 ^ 0x7C1AAEEA));

	[Order(100)]
	[DisplayName(typeof(__CountMetricLocalization), "CountCall")]
	public long CountCall
	{
		[CompilerGenerated]
		get
		{
			return _003CCountCall_003Ek__BackingField;
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
					_003CCountCall_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DisplayName(typeof(__CountMetricLocalization), "CountErrorCall")]
	[Order(200)]
	public long CountErrorCall
	{
		[CompilerGenerated]
		get
		{
			return _003CCountErrorCall_003Ek__BackingField;
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
					_003CCountErrorCall_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override void Merge(IMetric metric)
	{
		//Discarded unreachable code: IL_00b0, IL_00bf
		int num = 1;
		CountMetric countMetric = default(CountMetric);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (countMetric == null)
					{
						num2 = 5;
						continue;
					}
					goto case 2;
				case 3:
					break;
				case 4:
					CountCall += countMetric.CountCall;
					num2 = 3;
					continue;
				case 2:
					base.Merge(metric);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 2;
					}
					continue;
				case 5:
					return;
				case 6:
					return;
				case 1:
					countMetric = metric as CountMetric;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			CountErrorCall += pYAb2rE8YuHwgrCbFYDJ(countMetric);
			num = 6;
		}
	}

	public CountMetric()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		jYCZeEE8LNXD1iLBbbNL();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object YwLo0xE8j1x0rfVqAoSY(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool stl7qrE8g0f6rWwZfaEE()
	{
		return mhIXWlE8rqA3vBS9EcQ0 == null;
	}

	internal static CountMetric vpN2lcE85nv0n6XFAShy()
	{
		return mhIXWlE8rqA3vBS9EcQ0;
	}

	internal static long pYAb2rE8YuHwgrCbFYDJ(object P_0)
	{
		return ((CountMetric)P_0).CountErrorCall;
	}

	internal static void jYCZeEE8LNXD1iLBbbNL()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
