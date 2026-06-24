using System;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Metrics.Impl.Processors;

[Component]
public class IndexCallMetricProcessor : IMetricProcessor
{
	private static IndexCallMetricProcessor YbPte4EuT7W7G7vTFT0M;

	public Type[] AggregatorTypes => new Type[1] { TypeOf<IndexCallMetricAggregator>.Raw };

	public void Process(object callInfo, IMetric currentMetric)
	{
		//Discarded unreachable code: IL_00b4, IL_00c3
		int num = 1;
		int num2 = num;
		IndexCallInfo indexCallInfo = default(IndexCallInfo);
		IndexCallMetric indexCallMetric = default(IndexCallMetric);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (indexCallInfo != null)
				{
					num2 = 5;
					break;
				}
				return;
			case 4:
				return;
			case 6:
				return;
			default:
				indexCallInfo = callInfo as IndexCallInfo;
				num2 = 3;
				break;
			case 2:
			{
				IndexCallMetric indexCallMetric2 = indexCallMetric;
				long value = dgMbOXEu23UJ5lxr64mh(indexCallMetric2) + 1;
				HJugubEueZ8kQx44bLtK(indexCallMetric2, value);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 3;
				}
				break;
			}
			case 5:
				if (indexCallMetric == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 7;
					}
					break;
				}
				if (!pCPaEBEuOdBRa3tHr8c1(indexCallInfo))
				{
					num2 = 6;
					break;
				}
				goto case 2;
			case 7:
				return;
			case 1:
				indexCallMetric = currentMetric as IndexCallMetric;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public IndexCallMetricProcessor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		KIFk6TEuPHfPklsMwHvT();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool naEkjlEukVlWapiTthvc()
	{
		return YbPte4EuT7W7G7vTFT0M == null;
	}

	internal static IndexCallMetricProcessor ydprakEunb91GZuxuw2B()
	{
		return YbPte4EuT7W7G7vTFT0M;
	}

	internal static bool pCPaEBEuOdBRa3tHr8c1(object P_0)
	{
		return ((IndexCallInfo)P_0).IsCancel;
	}

	internal static long dgMbOXEu23UJ5lxr64mh(object P_0)
	{
		return ((IndexCallMetric)P_0).CountCancelCall;
	}

	internal static void HJugubEueZ8kQx44bLtK(object P_0, long value)
	{
		((IndexCallMetric)P_0).CountCancelCall = value;
	}

	internal static void KIFk6TEuPHfPklsMwHvT()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
