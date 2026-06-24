using System.Collections;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators;

[Component]
internal class ThreadSubPoolCallMetricAggregator : BaseMetricAggregator<ThreadSubPoolCallInfo>
{
	private static ThreadSubPoolCallMetricAggregator jGgK84EIdHYTInWSHopI;

	public ThreadSubPoolCallMetricAggregator(IEnumerable<IMetricProcessor> processors)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(processors);
	}

	public override void Add(ThreadSubPoolCallInfo callInfo, MetricsContainer container)
	{
		//Discarded unreachable code: IL_0092, IL_00a1, IL_00ac, IL_013b, IL_0173, IL_0182
		int num = 3;
		int num2 = num;
		ThreadSubPoolMethodMetric orAdd = default(ThreadSubPoolMethodMetric);
		IEnumerator<IMetricProcessor> enumerator = default(IEnumerator<IMetricProcessor>);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				orAdd = container.GetOrAdd<ThreadSubPoolMethodMetric>().GetOrAdd((string)dH1YBmEIjx4hNDZSgIwx(PoObxbEIgZYYMueNLCne(callInfo), MI53qOEI5KevxLu9FUty(-1921202237 ^ -1921212183), callInfo.OwnerType.FullName, MI53qOEI5KevxLu9FUty(-488881205 ^ -488739287)));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 1:
				try
				{
					while (true)
					{
						int num3;
						if (!U1P4mDEILHHPlZ0JEL9a(enumerator))
						{
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
							{
								num3 = 1;
							}
							goto IL_00b0;
						}
						goto IL_00c6;
						IL_00c6:
						RVVferEIYL3bvmsVNp0Z(enumerator.Current, callInfo, orAdd);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
						{
							num3 = 0;
						}
						goto IL_00b0;
						IL_00b0:
						switch (num3)
						{
						case 2:
							return;
						case 1:
							break;
						default:
							continue;
						}
						goto IL_00c6;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								enumerator.Dispose();
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
								{
									num4 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			case 2:
				enumerator = base.MetricProcessors.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static object PoObxbEIgZYYMueNLCne(object P_0)
	{
		return ((AbstractCallInfo)P_0).Description;
	}

	internal static object MI53qOEI5KevxLu9FUty(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object dH1YBmEIjx4hNDZSgIwx(object P_0, object P_1, object P_2, object P_3)
	{
		return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
	}

	internal static void RVVferEIYL3bvmsVNp0Z(object P_0, object P_1, object P_2)
	{
		((IMetricProcessor)P_0).Process(P_1, (IMetric)P_2);
	}

	internal static bool U1P4mDEILHHPlZ0JEL9a(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static bool CwZKZgEIlLgadPMhdCx6()
	{
		return jGgK84EIdHYTInWSHopI == null;
	}

	internal static ThreadSubPoolCallMetricAggregator VhEIogEIrKwB02SiLbEo()
	{
		return jGgK84EIdHYTInWSHopI;
	}
}
