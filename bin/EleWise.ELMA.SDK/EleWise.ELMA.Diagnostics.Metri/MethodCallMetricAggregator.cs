using System;
using System.Collections;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators;

[Component]
public class MethodCallMetricAggregator : BaseMetricAggregator<MethodCallInfo>
{
	internal static MethodCallMetricAggregator F0SN9IEVpIdjl1agKqTA;

	public MethodCallMetricAggregator(IEnumerable<IMetricProcessor> processors)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(processors);
	}

	public override void Add(MethodCallInfo callInfo, MetricsContainer container)
	{
		//Discarded unreachable code: IL_0033, IL_0042, IL_004d, IL_00dc, IL_011c, IL_012b, IL_0137, IL_0146
		int num = 1;
		int num2 = num;
		IEnumerator<IMetricProcessor> enumerator = default(IEnumerator<IMetricProcessor>);
		MethodMetric orAdd = default(MethodMetric);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 2:
				try
				{
					while (true)
					{
						int num3;
						if (!drVlDkEV682JXxCx9hdA(enumerator))
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
							{
								num3 = 1;
							}
							goto IL_0051;
						}
						goto IL_008d;
						IL_008d:
						rlr59BEV4DYgohau8dvC(enumerator.Current, callInfo, orAdd);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
						{
							num3 = 0;
						}
						goto IL_0051;
						IL_0051:
						switch (num3)
						{
						case 1:
							return;
						case 2:
							goto IL_008d;
						}
					}
				}
				finally
				{
					int num4;
					if (enumerator == null)
					{
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
						{
							num4 = 0;
						}
						goto IL_00e0;
					}
					goto IL_00f6;
					IL_00f6:
					qfAsfOEVHxxGSXgvVYWu(enumerator);
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num4 = 1;
					}
					goto IL_00e0;
					IL_00e0:
					switch (num4)
					{
					default:
						goto end_IL_00bb;
					case 2:
						break;
					case 0:
						goto end_IL_00bb;
					case 1:
						goto end_IL_00bb;
					}
					goto IL_00f6;
					end_IL_00bb:;
				}
			default:
				enumerator = base.MetricProcessors.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				orAdd = container.GetOrAdd<MethodMetric>().GetOrAdd((string)BkHEudEVt0qinXBYXqNg(callInfo) + (string)oqQJb5EVw7qu5VE0iE0v(0x26FFCB59 ^ 0x26FFAC73) + callInfo.OwnerType.FullName + (string)oqQJb5EVw7qu5VE0iE0v(0x5F3078B6 ^ 0x5F325554));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object BkHEudEVt0qinXBYXqNg(object P_0)
	{
		return ((AbstractCallInfo)P_0).Description;
	}

	internal static object oqQJb5EVw7qu5VE0iE0v(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void rlr59BEV4DYgohau8dvC(object P_0, object P_1, object P_2)
	{
		((IMetricProcessor)P_0).Process(P_1, (IMetric)P_2);
	}

	internal static bool drVlDkEV682JXxCx9hdA(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void qfAsfOEVHxxGSXgvVYWu(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool SgKrhPEVaCcyt5IbwocT()
	{
		return F0SN9IEVpIdjl1agKqTA == null;
	}

	internal static MethodCallMetricAggregator LqfvlUEVDFntHsuqiaJI()
	{
		return F0SN9IEVpIdjl1agKqTA;
	}
}
