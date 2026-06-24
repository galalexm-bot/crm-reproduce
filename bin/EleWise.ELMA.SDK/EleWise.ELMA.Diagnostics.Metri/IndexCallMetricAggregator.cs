using System.Collections;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators;

[Component]
public class IndexCallMetricAggregator : BaseMetricAggregator<IndexCallInfo>
{
	private static IndexCallMetricAggregator C351wgEVWLXcWRC2eBbw;

	public IndexCallMetricAggregator(IEnumerable<IMetricProcessor> processors)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(processors);
	}

	public override void Add(IndexCallInfo callInfo, MetricsContainer container)
	{
		//Discarded unreachable code: IL_0088, IL_0097, IL_00a2, IL_0140, IL_014f, IL_0170
		int num = 2;
		int num2 = num;
		IEnumerator<IMetricProcessor> enumerator = default(IEnumerator<IMetricProcessor>);
		IndexCallMetric orAdd = default(IndexCallMetric);
		while (true)
		{
			switch (num2)
			{
			case 1:
				enumerator = base.MetricProcessors.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				return;
			case 2:
				orAdd = container.GetOrAdd<IndexCallMetric>().GetOrAdd(callInfo.Description);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num2 = 1;
				}
				continue;
			}
			try
			{
				while (true)
				{
					int num3;
					if (!aZASEgEVGEXXeQkIKceP(enumerator))
					{
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
						{
							num3 = 0;
						}
						goto IL_00a6;
					}
					goto IL_00bc;
					IL_00bc:
					AsJ9V1EVhWXde5KOOwYM(enumerator.Current, callInfo, orAdd);
					num3 = 2;
					goto IL_00a6;
					IL_00a6:
					switch (num3)
					{
					case 1:
						return;
					case 2:
						continue;
					}
					goto IL_00bc;
				}
			}
			finally
			{
				int num4;
				if (enumerator == null)
				{
					num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num4 = 1;
					}
					goto IL_0125;
				}
				goto IL_015a;
				IL_015a:
				enumerator.Dispose();
				int num5 = 2;
				num4 = num5;
				goto IL_0125;
				IL_0125:
				switch (num4)
				{
				case 1:
					goto end_IL_0100;
				case 2:
					goto end_IL_0100;
				}
				goto IL_015a;
				end_IL_0100:;
			}
		}
	}

	internal static void AsJ9V1EVhWXde5KOOwYM(object P_0, object P_1, object P_2)
	{
		((IMetricProcessor)P_0).Process(P_1, (IMetric)P_2);
	}

	internal static bool aZASEgEVGEXXeQkIKceP(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static bool bVReGaEVoZXxAeChcrHN()
	{
		return C351wgEVWLXcWRC2eBbw == null;
	}

	internal static IndexCallMetricAggregator HZZJHHEVbLCrC2cXLdRG()
	{
		return C351wgEVWLXcWRC2eBbw;
	}
}
