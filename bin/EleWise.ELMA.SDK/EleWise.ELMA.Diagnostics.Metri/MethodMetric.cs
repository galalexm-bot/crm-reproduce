using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Diagnostics.Attributes;
using EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Metrics;

[Aggregator(typeof(MethodCallMetricAggregator))]
public class MethodMetric : CountTimeMetric
{
	internal static class __MethodMetricLocalization
	{
		private static __MethodMetricLocalization PdOpQN8KNSHHCelK69gX;

		public static string ClearTotalTime => (string)iZjrbY8Ka87NrgfLLYOg(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CB464B ^ 0x53CEA38F));

		public static string ClearMaxTime => SR.T((string)NFNQkk8KDYYnOOFVdqis(-195614443 ^ -195900177));

		public static string ClearAvgTime => (string)iZjrbY8Ka87NrgfLLYOg(NFNQkk8KDYYnOOFVdqis(-2106517564 ^ -2106265188));

		internal static object iZjrbY8Ka87NrgfLLYOg(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool UwK43d8K3jqMlGOqLRRy()
		{
			return PdOpQN8KNSHHCelK69gX == null;
		}

		internal static __MethodMetricLocalization pSrbSD8KpBju0LBksTh2()
		{
			return PdOpQN8KNSHHCelK69gX;
		}

		internal static object NFNQkk8KDYYnOOFVdqis(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}
	}

	internal static MethodMetric rjNneGEZ25FCJIOb5mGV;

	public override Guid Uid => new Guid((string)d36PHrEZ10LHDKm3MH8R(-1852837372 ^ -1853113034));

	[DisplayName(typeof(__MethodMetricLocalization), "ClearTotalTime")]
	[Order(600)]
	public TimeSpan ClearTotalTime
	{
		[CompilerGenerated]
		get
		{
			return _003CClearTotalTime_003Ek__BackingField;
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
					_003CClearTotalTime_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
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

	[Order(700)]
	[DisplayName(typeof(__MethodMetricLocalization), "ClearMaxTime")]
	public double ClearMaxTime
	{
		[CompilerGenerated]
		get
		{
			return _003CClearMaxTime_003Ek__BackingField;
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
					_003CClearMaxTime_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DisplayName(typeof(__MethodMetricLocalization), "ClearAvgTime")]
	[Order(800)]
	public double ClearAvgTime
	{
		get
		{
			int num = 1;
			int num2 = num;
			TimeSpan clearTotalTime = default(TimeSpan);
			while (true)
			{
				switch (num2)
				{
				case 1:
					clearTotalTime = ClearTotalTime;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 0;
					}
					break;
				default:
					return clearTotalTime.TotalMilliseconds / (double)base.CountCall;
				}
			}
		}
	}

	public override void Merge(IMetric metric)
	{
		int num = 1;
		int num2 = num;
		MethodMetric methodMetric = default(MethodMetric);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (ClearMaxTime < h34G43EZ3GSfH1obBfuu(methodMetric))
				{
					num2 = 4;
					break;
				}
				return;
			case 2:
				return;
			case 6:
				base.Merge(metric);
				num2 = 5;
				break;
			default:
				if (methodMetric == null)
				{
					return;
				}
				num2 = 6;
				break;
			case 4:
				ClearMaxTime = h34G43EZ3GSfH1obBfuu(methodMetric);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				methodMetric = metric as MethodMetric;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				ClearTotalTime = jTpAfuEZNlic3tfcIVBS(ClearTotalTime, methodMetric.ClearTotalTime);
				num2 = 3;
				break;
			}
		}
	}

	public MethodMetric()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		mgtsayEZpa5RrtQ1Q0xa();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object d36PHrEZ10LHDKm3MH8R(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool XdXGh3EZeN0d34d50hVX()
	{
		return rjNneGEZ25FCJIOb5mGV == null;
	}

	internal static MethodMetric IeOlp5EZPtnBPJI3Mqvc()
	{
		return rjNneGEZ25FCJIOb5mGV;
	}

	internal static TimeSpan jTpAfuEZNlic3tfcIVBS(TimeSpan P_0, TimeSpan P_1)
	{
		return P_0 + P_1;
	}

	internal static double h34G43EZ3GSfH1obBfuu(object P_0)
	{
		return ((MethodMetric)P_0).ClearMaxTime;
	}

	internal static void mgtsayEZpa5RrtQ1Q0xa()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
