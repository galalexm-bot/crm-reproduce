using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Diagnostics.Attributes;
using EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Metrics;

[Aggregator(typeof(IndexCallMetricAggregator))]
public class IndexCallMetric : CountTimeMetric
{
	internal static class __IndexCallMetricLocalization
	{
		private static __IndexCallMetricLocalization RohhmR8KOpiJsKYJ8bst;

		public static string CountCancelCall => (string)AV3Y7C8K1o9PyDjBpewD(X1JW058KPNU39FBrW60G(0x3A6135BE ^ 0x3A64D03C));

		internal static object X1JW058KPNU39FBrW60G(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object AV3Y7C8K1o9PyDjBpewD(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool hOQRtP8K24ieVLPqYwYi()
		{
			return RohhmR8KOpiJsKYJ8bst == null;
		}

		internal static __IndexCallMetricLocalization S8QNfe8KeuE79fW1jBip()
		{
			return RohhmR8KOpiJsKYJ8bst;
		}
	}

	internal static IndexCallMetric tGBQktEZvGwjTA6gDtBx;

	public override Guid Uid => new Guid((string)gJMFi6EZu4VsOMRXUBfP(-1710575414 ^ -1710293416));

	[DisplayName(typeof(__IndexCallMetricLocalization), "CountCancelCall")]
	[Order(600)]
	public long CountCancelCall
	{
		[CompilerGenerated]
		get
		{
			return _003CCountCancelCall_003Ek__BackingField;
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
					_003CCountCancelCall_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
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

	public override void Merge(IMetric metric)
	{
		int num = 3;
		int num2 = num;
		IndexCallMetric indexCallMetric = default(IndexCallMetric);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				base.Merge(metric);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num2 = 4;
				}
				break;
			case 0:
				return;
			case 3:
				indexCallMetric = metric as IndexCallMetric;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				if (indexCallMetric == null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				CountCancelCall += wwxfH1EZI1muPACLvxmY(indexCallMetric);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public IndexCallMetric()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		iMb96wEZV8Hc30UFsFId();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object gJMFi6EZu4VsOMRXUBfP(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool xdbcSBEZ8T5VUCO14cN8()
	{
		return tGBQktEZvGwjTA6gDtBx == null;
	}

	internal static IndexCallMetric vRP49NEZZlT9cdfDyqmi()
	{
		return tGBQktEZvGwjTA6gDtBx;
	}

	internal static long wwxfH1EZI1muPACLvxmY(object P_0)
	{
		return ((IndexCallMetric)P_0).CountCancelCall;
	}

	internal static void iMb96wEZV8Hc30UFsFId()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
