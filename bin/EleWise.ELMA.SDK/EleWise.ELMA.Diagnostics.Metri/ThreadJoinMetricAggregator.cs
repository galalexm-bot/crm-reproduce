using System;
using System.Collections;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators;

[Component]
internal class ThreadJoinMetricAggregator : BaseMetricAggregator<ThreadJoinCallInfo>
{
	internal static ThreadJoinMetricAggregator oEN3CdEIxOi2KTdlDnya;

	public ThreadJoinMetricAggregator(IEnumerable<IMetricProcessor> processors)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(processors);
	}

	public override void Add(ThreadJoinCallInfo callInfo, MetricsContainer container)
	{
		//Discarded unreachable code: IL_0060, IL_006f, IL_007a, IL_0109, IL_0149, IL_0154, IL_0163
		int num = 1;
		int num2 = num;
		ThreadJoinMetric orAdd = default(ThreadJoinMetric);
		IEnumerator<IMetricProcessor> enumerator = default(IEnumerator<IMetricProcessor>);
		while (true)
		{
			switch (num2)
			{
			case 1:
				orAdd = container.GetOrAdd<ThreadJoinMetric>().GetOrAdd((string)HAlUhVEIy6j5bwkeIrFL(callInfo));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				try
				{
					while (true)
					{
						int num3;
						if (!mcFlThEIJYycBqBc4KhQ(enumerator))
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
							{
								num3 = 2;
							}
							goto IL_007e;
						}
						goto IL_0094;
						IL_0094:
						S0dmjHEIMnCpIVsN38MJ(enumerator.Current, callInfo, orAdd);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
						{
							num3 = 0;
						}
						goto IL_007e;
						IL_007e:
						switch (num3)
						{
						case 1:
							break;
						default:
							continue;
						case 2:
							return;
						}
						goto IL_0094;
					}
				}
				finally
				{
					int num4;
					if (enumerator == null)
					{
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
						{
							num4 = 1;
						}
						goto IL_010d;
					}
					goto IL_0123;
					IL_0123:
					ECdN9LEI9uRkEYu5Okes(enumerator);
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
					{
						num4 = 0;
					}
					goto IL_010d;
					IL_010d:
					switch (num4)
					{
					default:
						goto end_IL_00e8;
					case 2:
						break;
					case 1:
						goto end_IL_00e8;
					case 0:
						goto end_IL_00e8;
					}
					goto IL_0123;
					end_IL_00e8:;
				}
			default:
				enumerator = base.MetricProcessors.GetEnumerator();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			}
		}
	}

	internal static object HAlUhVEIy6j5bwkeIrFL(object P_0)
	{
		return ((AbstractCallInfo)P_0).Description;
	}

	internal static void S0dmjHEIMnCpIVsN38MJ(object P_0, object P_1, object P_2)
	{
		((IMetricProcessor)P_0).Process(P_1, (IMetric)P_2);
	}

	internal static bool mcFlThEIJYycBqBc4KhQ(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void ECdN9LEI9uRkEYu5Okes(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool DXZdL5EI0ZBbExV7XHr7()
	{
		return oEN3CdEIxOi2KTdlDnya == null;
	}

	internal static ThreadJoinMetricAggregator LKywe8EImTBTeLms1FL2()
	{
		return oEN3CdEIxOi2KTdlDnya;
	}
}
