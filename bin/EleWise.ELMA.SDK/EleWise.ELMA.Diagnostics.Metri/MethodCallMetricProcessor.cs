using System;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Metrics.Impl.Processors;

[Component]
public class MethodCallMetricProcessor : IMetricProcessor
{
	private static MethodCallMetricProcessor MhgSDWEIvh58MYTu9NGY;

	public Type[] AggregatorTypes => new Type[3]
	{
		TypeOf<MethodCallMetricAggregator>.Raw,
		TypeOf<ScriptCallMetricAggregator>.Raw,
		TypeOf<ThreadSubPoolCallMetricAggregator>.Raw
	};

	public void Process(object callInfo, IMetric currentMetric)
	{
		//Discarded unreachable code: IL_00df
		int num = 2;
		int num2 = num;
		MethodMetric methodMetric = default(MethodMetric);
		MethodCallInfo methodCallInfo = default(MethodCallInfo);
		while (true)
		{
			switch (num2)
			{
			default:
				JbM3cBEIRjaitpwJwYJL(methodMetric, O3h0uBEIIZgudG2ko1vk(methodCallInfo).TotalMilliseconds);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num2 = 6;
				}
				break;
			case 6:
				return;
			case 4:
				return;
			case 3:
			{
				MethodMetric methodMetric2 = methodMetric;
				PTRwvMEISpQ5nsOGKduq(methodMetric2, r017LJEIVuUSCaHmWh60(AF6qQ6EIuGhv3hCuShJi(methodMetric2), O3h0uBEIIZgudG2ko1vk(methodCallInfo)));
				num2 = 7;
				break;
			}
			case 5:
				if (methodCallInfo == null)
				{
					return;
				}
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 8;
				}
				break;
			case 8:
				if (methodMetric == null)
				{
					return;
				}
				num2 = 3;
				break;
			case 1:
				methodMetric = currentMetric as MethodMetric;
				num2 = 5;
				break;
			case 7:
				if (!(MdGw0XEIicj2nJA4pNc2(methodMetric) < methodCallInfo.ClearTime.TotalMilliseconds))
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				methodCallInfo = callInfo as MethodCallInfo;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public MethodCallMetricProcessor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		gu62HbEIq2Jjm1SGYdEi();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool g9hQYCEI8K7MsHT48fMC()
	{
		return MhgSDWEIvh58MYTu9NGY == null;
	}

	internal static MethodCallMetricProcessor s8jfHWEIZxBntyDhmThp()
	{
		return MhgSDWEIvh58MYTu9NGY;
	}

	internal static TimeSpan AF6qQ6EIuGhv3hCuShJi(object P_0)
	{
		return ((MethodMetric)P_0).ClearTotalTime;
	}

	internal static TimeSpan O3h0uBEIIZgudG2ko1vk(object P_0)
	{
		return ((AbstractCallInfo)P_0).ClearTime;
	}

	internal static TimeSpan r017LJEIVuUSCaHmWh60(TimeSpan P_0, TimeSpan P_1)
	{
		return P_0 + P_1;
	}

	internal static void PTRwvMEISpQ5nsOGKduq(object P_0, TimeSpan value)
	{
		((MethodMetric)P_0).ClearTotalTime = value;
	}

	internal static double MdGw0XEIicj2nJA4pNc2(object P_0)
	{
		return ((MethodMetric)P_0).ClearMaxTime;
	}

	internal static void JbM3cBEIRjaitpwJwYJL(object P_0, double value)
	{
		((MethodMetric)P_0).ClearMaxTime = value;
	}

	internal static void gu62HbEIq2Jjm1SGYdEi()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
