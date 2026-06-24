using System;
using System.Collections;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators;

[Component]
public class ScriptCallMetricAggregator : BaseMetricAggregator<ScriptCallInfo>
{
	internal static ScriptCallMetricAggregator DPRd4pEVAZeEmc46YTRQ;

	public ScriptCallMetricAggregator(IEnumerable<IMetricProcessor> processors)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(processors);
	}

	public override void Add(ScriptCallInfo callInfo, MetricsContainer container)
	{
		//Discarded unreachable code: IL_005a, IL_0069, IL_0074, IL_0103, IL_0133, IL_0142, IL_014e, IL_015d
		int num = 3;
		int num2 = num;
		IEnumerator<IMetricProcessor> enumerator = default(IEnumerator<IMetricProcessor>);
		ScriptMetric orAdd = default(ScriptMetric);
		while (true)
		{
			switch (num2)
			{
			case 2:
				enumerator = base.MetricProcessors.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				return;
			case 3:
				orAdd = container.GetOrAdd<ScriptMetric>().GetOrAdd((string)ieHJBMEV0juFaelgG49E(callInfo));
				num2 = 2;
				continue;
			}
			try
			{
				while (true)
				{
					int num3;
					if (!eTFo9qEVyTXelG7fHQkB(enumerator))
					{
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
						{
							num3 = 1;
						}
						goto IL_0078;
					}
					goto IL_00b4;
					IL_00b4:
					jMosHvEVmkG3cenjTZM0(enumerator.Current, callInfo, orAdd);
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num3 = 0;
					}
					goto IL_0078;
					IL_0078:
					switch (num3)
					{
					case 1:
						return;
					case 2:
						goto IL_00b4;
					}
				}
			}
			finally
			{
				int num4;
				if (enumerator == null)
				{
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num4 = 1;
					}
					goto IL_0107;
				}
				goto IL_011d;
				IL_011d:
				alWvN8EVMm1rCc7Y9V7t(enumerator);
				num4 = 2;
				goto IL_0107;
				IL_0107:
				switch (num4)
				{
				case 1:
					goto end_IL_00e2;
				case 2:
					goto end_IL_00e2;
				}
				goto IL_011d;
				end_IL_00e2:;
			}
		}
	}

	internal static object ieHJBMEV0juFaelgG49E(object P_0)
	{
		return ((AbstractCallInfo)P_0).Description;
	}

	internal static void jMosHvEVmkG3cenjTZM0(object P_0, object P_1, object P_2)
	{
		((IMetricProcessor)P_0).Process(P_1, (IMetric)P_2);
	}

	internal static bool eTFo9qEVyTXelG7fHQkB(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void alWvN8EVMm1rCc7Y9V7t(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool XF75SvEV7tWOcR03FlIN()
	{
		return DPRd4pEVAZeEmc46YTRQ == null;
	}

	internal static ScriptCallMetricAggregator KSqDqSEVxCXSQ1DU7vQr()
	{
		return DPRd4pEVAZeEmc46YTRQ;
	}
}
