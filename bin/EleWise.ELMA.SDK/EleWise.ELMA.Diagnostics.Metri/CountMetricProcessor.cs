using System;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Metrics.Impl.Processors;

[Component(Order = -10)]
public class CountMetricProcessor : IMetricProcessor
{
	private readonly Type baseMetricAggregatorType;

	private static CountMetricProcessor fJDfniEu5fxxsmn2CZs8;

	public Type[] AggregatorTypes => new Type[1] { baseMetricAggregatorType };

	public void Process(object callInfo, IMetric currentMetric)
	{
		//Discarded unreachable code: IL_00ba
		int num = 2;
		int num2 = num;
		IWorkTreeElement workTreeElement = default(IWorkTreeElement);
		CountMetric countMetric = default(CountMetric);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 5:
				if (workTreeElement == null)
				{
					num2 = 8;
					break;
				}
				goto case 7;
			case 6:
				return;
			case 8:
				return;
			case 0:
				return;
			case 1:
				workTreeElement = callInfo as IWorkTreeElement;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				countMetric = currentMetric as CountMetric;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				if (MdtxvtEus9s4wL7LQBvA(workTreeElement) == null)
				{
					return;
				}
				num2 = 3;
				break;
			case 7:
				if (countMetric != null)
				{
					CountMetric countMetric3 = countMetric;
					long value = JuMU3EEuLGd88FCLwYak(countMetric3) + 1;
					d27UdmEuU8eZPt1shPs9(countMetric3, value);
					num2 = 4;
				}
				else
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 3;
					}
				}
				break;
			case 3:
			{
				CountMetric countMetric2 = countMetric;
				long value = iBsCKkEucpjlRCVMNxHj(countMetric2) + 1;
				WOQyaVEuz77Tcs7fhGdW(countMetric2, value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	public CountMetricProcessor()
	{
		//Discarded unreachable code: IL_003f, IL_0044
		i4uVxFEIFv84n2TEpvdr();
		baseMetricAggregatorType = typeof(BaseMetricAggregator<>);
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool FBXTSYEuj1RGTPgA8jxg()
	{
		return fJDfniEu5fxxsmn2CZs8 == null;
	}

	internal static CountMetricProcessor H9cgNSEuYlXs70BtAU6G()
	{
		return fJDfniEu5fxxsmn2CZs8;
	}

	internal static long JuMU3EEuLGd88FCLwYak(object P_0)
	{
		return ((CountMetric)P_0).CountCall;
	}

	internal static void d27UdmEuU8eZPt1shPs9(object P_0, long value)
	{
		((CountMetric)P_0).CountCall = value;
	}

	internal static object MdtxvtEus9s4wL7LQBvA(object P_0)
	{
		return ((IWorkTreeElement)P_0).Exception;
	}

	internal static long iBsCKkEucpjlRCVMNxHj(object P_0)
	{
		return ((CountMetric)P_0).CountErrorCall;
	}

	internal static void WOQyaVEuz77Tcs7fhGdW(object P_0, long value)
	{
		((CountMetric)P_0).CountErrorCall = value;
	}

	internal static void i4uVxFEIFv84n2TEpvdr()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
