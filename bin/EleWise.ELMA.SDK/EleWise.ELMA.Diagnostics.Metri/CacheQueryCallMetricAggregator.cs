using System;
using System.Collections;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators;

[Component]
public class CacheQueryCallMetricAggregator : BaseMetricAggregator<CacheQueryInfo>, IMetricAggregator
{
	private static CacheQueryCallMetricAggregator VbLIBYEVKiq9gFJ5Oi28;

	public CacheQueryCallMetricAggregator(IEnumerable<IMetricProcessor> processors)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(processors);
	}

	void IMetricAggregator.Add(object callInfo, MetricsContainer container)
	{
		int num = 1;
		int num2 = num;
		CacheQueryInfo cacheQueryInfo = default(CacheQueryInfo);
		while (true)
		{
			switch (num2)
			{
			case 1:
				cacheQueryInfo = callInfo as CacheQueryInfo;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			case 3:
				return;
			}
			if (cacheQueryInfo == null)
			{
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
				{
					num2 = 2;
				}
			}
			else
			{
				Add(cacheQueryInfo, container);
				num2 = 3;
			}
		}
	}

	public override void Add(CacheQueryInfo callInfo, MetricsContainer container)
	{
		//Discarded unreachable code: IL_0032, IL_0041, IL_004c, IL_00db, IL_011b, IL_0126, IL_0135
		int num = 3;
		int num2 = num;
		IEnumerator<IMetricProcessor> enumerator = default(IEnumerator<IMetricProcessor>);
		CacheMetric orAdd = default(CacheMetric);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				try
				{
					while (true)
					{
						int num3;
						if (!DfB9MXEVO0FpvQtZaCWU(enumerator))
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
							{
								num3 = 0;
							}
							goto IL_0050;
						}
						goto IL_008c;
						IL_008c:
						JASNGREVnu6OSkU7PO4J(enumerator.Current, callInfo, orAdd);
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
						{
							num3 = 0;
						}
						goto IL_0050;
						IL_0050:
						switch (num3)
						{
						default:
							return;
						case 1:
							break;
						case 2:
							goto IL_008c;
						case 0:
							return;
						}
					}
				}
				finally
				{
					int num4;
					if (enumerator == null)
					{
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
						{
							num4 = 1;
						}
						goto IL_00df;
					}
					goto IL_00f5;
					IL_00f5:
					vliG35EV2IJOfuh2lM9i(enumerator);
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num4 = 0;
					}
					goto IL_00df;
					IL_00df:
					switch (num4)
					{
					default:
						goto end_IL_00ba;
					case 2:
						break;
					case 1:
						goto end_IL_00ba;
					case 0:
						goto end_IL_00ba;
					}
					goto IL_00f5;
					end_IL_00ba:;
				}
			case 0:
				return;
			case 3:
				orAdd = container.GetOrAdd<CacheMetric>().GetOrAdd((string)S0Jln7EVkcWfkNrp7Ztx(-1710575414 ^ -1710319544));
				num2 = 2;
				break;
			case 2:
				enumerator = base.MetricProcessors.GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static bool zaN934EVXmBBLq9qnhFA()
	{
		return VbLIBYEVKiq9gFJ5Oi28 == null;
	}

	internal static CacheQueryCallMetricAggregator LfncU2EVTxHoHP5u47uw()
	{
		return VbLIBYEVKiq9gFJ5Oi28;
	}

	internal static object S0Jln7EVkcWfkNrp7Ztx(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void JASNGREVnu6OSkU7PO4J(object P_0, object P_1, object P_2)
	{
		((IMetricProcessor)P_0).Process(P_1, (IMetric)P_2);
	}

	internal static bool DfB9MXEVO0FpvQtZaCWU(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void vliG35EV2IJOfuh2lM9i(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}
}
