using System;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Metrics.Impl.Processors;

[Component]
public class CallContextMetricProcessor : IMetricProcessor
{
	private static CallContextMetricProcessor Mfrl2sEuCgN9F6pxaOyu;

	public Type[] AggregatorTypes => new Type[3]
	{
		TypeOf<WebRequestMetricAggregator>.Raw,
		TypeOf<BackgroundTaskMetricAggregator>.Raw,
		TypeOf<CustomDiagnostcisSessionMetricAggregator>.Raw
	};

	public void Process(object callInfo, IMetric currentMetric)
	{
		//Discarded unreachable code: IL_00ce, IL_0100, IL_010f
		int num = 6;
		int num2 = num;
		CallContextInfo callContextInfo = default(CallContextInfo);
		CallContextMetric callContextMetric = default(CallContextMetric);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (callContextInfo == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 3;
					}
					continue;
				}
				break;
			case 9:
				return;
			case 3:
				return;
			case 7:
				return;
			default:
			{
				CallContextMetric callContextMetric2 = callContextMetric;
				NMIFcmEuVUFGanyXAnbU(callContextMetric2, Wua9RIEuIMSjWVweqg6t(SbvIvKEuZxAUBxDxbnFG(callContextMetric2), McfymwEuuunhbYGxHrFu(callContextInfo)));
				num2 = 4;
				continue;
			}
			case 6:
				callContextInfo = callInfo as CallContextInfo;
				num2 = 5;
				continue;
			case 2:
				((MetricsContainer)c2dDlLEuqkDa0AJgflXh(callContextMetric)).Merge((MetricsContainer)cQtSuuEuKUtS7kd63QbE(callContextInfo));
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num2 = 9;
				}
				continue;
			case 4:
			{
				CallContextMetric callContextMetric3 = callContextMetric;
				qblmJOEuRTXVbH40Fvq9(callContextMetric3, Wua9RIEuIMSjWVweqg6t(xrZaQNEuSW0dP4K6oyix(callContextMetric3), W5HuohEuip2692KnaY1c(callContextInfo)));
				num2 = 2;
				continue;
			}
			case 5:
				callContextMetric = currentMetric as CallContextMetric;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num2 = 1;
				}
				continue;
			case 8:
				break;
			}
			if (callContextMetric == null)
			{
				break;
			}
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
			{
				num2 = 0;
			}
		}
	}

	public CallContextMetricProcessor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		pAcWS1EuXFMIM3sDkiRf();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool M1S5MbEuvVyaJ7ZcrK95()
	{
		return Mfrl2sEuCgN9F6pxaOyu == null;
	}

	internal static CallContextMetricProcessor HtRoWiEu8bC9lM35xjqP()
	{
		return Mfrl2sEuCgN9F6pxaOyu;
	}

	internal static TimeSpan SbvIvKEuZxAUBxDxbnFG(object P_0)
	{
		return ((CallContextMetric)P_0).TotalProcessorTime;
	}

	internal static TimeSpan McfymwEuuunhbYGxHrFu(object P_0)
	{
		return ((CallContextInfo)P_0).TotalProcessorTime;
	}

	internal static TimeSpan Wua9RIEuIMSjWVweqg6t(TimeSpan P_0, TimeSpan P_1)
	{
		return P_0 + P_1;
	}

	internal static void NMIFcmEuVUFGanyXAnbU(object P_0, TimeSpan value)
	{
		((CallContextMetric)P_0).TotalProcessorTime = value;
	}

	internal static TimeSpan xrZaQNEuSW0dP4K6oyix(object P_0)
	{
		return ((CallContextMetric)P_0).UserProcessorTime;
	}

	internal static TimeSpan W5HuohEuip2692KnaY1c(object P_0)
	{
		return ((CallContextInfo)P_0).UserProcessorTime;
	}

	internal static void qblmJOEuRTXVbH40Fvq9(object P_0, TimeSpan value)
	{
		((CallContextMetric)P_0).UserProcessorTime = value;
	}

	internal static object c2dDlLEuqkDa0AJgflXh(object P_0)
	{
		return ((CallContextMetric)P_0).Metrics;
	}

	internal static object cQtSuuEuKUtS7kd63QbE(object P_0)
	{
		return ((CallContextInfo)P_0).Metrics;
	}

	internal static void pAcWS1EuXFMIM3sDkiRf()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
