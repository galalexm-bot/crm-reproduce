using System.Collections;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators;

[Component]
public class BackgroundTaskMetricAggregator : BaseMetricAggregator<CallContextInfo>
{
	internal static BackgroundTaskMetricAggregator wksYW9EIUmt0d2EFrbSv;

	public BackgroundTaskMetricAggregator(IEnumerable<IMetricProcessor> processors)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(processors);
	}

	public override void Add(CallContextInfo callInfo, MetricsContainer container)
	{
		//Discarded unreachable code: IL_00d9, IL_00e3, IL_0162, IL_01a2, IL_01b1, IL_01bd, IL_01cc, IL_01fb, IL_020a
		int num = 2;
		int num2 = num;
		CallContextType? type = default(CallContextType?);
		CallContextType callContextType = default(CallContextType);
		IEnumerator<IMetricProcessor> enumerator = default(IEnumerator<IMetricProcessor>);
		BackgroundTaskMetric orAdd = default(BackgroundTaskMetric);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return;
			case 4:
				type = callInfo.Type;
				num2 = 8;
				continue;
			case 8:
				callContextType = CallContextType.BackgroundTask;
				num2 = 6;
				continue;
			case 6:
				if (type != callContextType)
				{
					num2 = 9;
					continue;
				}
				goto case 3;
			case 7:
				enumerator = base.MetricProcessors.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				if (!type.HasValue)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 4;
			case 9:
				return;
			case 3:
				orAdd = container.GetOrAdd<BackgroundTaskMetric>().GetOrAdd((string)DDMIwAEIzTI6uSeUvjtQ(callInfo));
				num2 = 7;
				continue;
			case 2:
				type = callInfo.Type;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				while (true)
				{
					int num3;
					if (!yorhunEVBZQBqcmqKebd(enumerator))
					{
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
						{
							num3 = 1;
						}
						goto IL_00e7;
					}
					goto IL_0123;
					IL_0123:
					sBVfNkEVFfyidx6ixrZj(enumerator.Current, callInfo, orAdd);
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
					{
						num3 = 0;
					}
					goto IL_00e7;
					IL_00e7:
					switch (num3)
					{
					case 1:
						return;
					case 2:
						goto IL_0123;
					}
				}
			}
			finally
			{
				int num4;
				if (enumerator == null)
				{
					num4 = 2;
					goto IL_0166;
				}
				goto IL_017c;
				IL_0166:
				switch (num4)
				{
				case 2:
					goto end_IL_0151;
				case 1:
					goto end_IL_0151;
				}
				goto IL_017c;
				IL_017c:
				enumerator.Dispose();
				num4 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num4 = 1;
				}
				goto IL_0166;
				end_IL_0151:;
			}
		}
	}

	internal static object DDMIwAEIzTI6uSeUvjtQ(object P_0)
	{
		return ((CallContextInfo)P_0).Name;
	}

	internal static void sBVfNkEVFfyidx6ixrZj(object P_0, object P_1, object P_2)
	{
		((IMetricProcessor)P_0).Process(P_1, (IMetric)P_2);
	}

	internal static bool yorhunEVBZQBqcmqKebd(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static bool Ouype6EIswlLiRqbt2ol()
	{
		return wksYW9EIUmt0d2EFrbSv == null;
	}

	internal static BackgroundTaskMetricAggregator T8E2RbEIc8T1e1kxa12e()
	{
		return wksYW9EIUmt0d2EFrbSv;
	}
}
