using System.Collections;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators;

[Component]
public class CustomDiagnostcisSessionMetricAggregator : BaseMetricAggregator<CallContextInfo>
{
	internal static CustomDiagnostcisSessionMetricAggregator S9dQQFEIwU7ZTM9Icyjo;

	public CustomDiagnostcisSessionMetricAggregator(IEnumerable<IMetricProcessor> processors)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(processors);
	}

	public override void Add(CallContextInfo callInfo, MetricsContainer container)
	{
		//Discarded unreachable code: IL_0070, IL_007f, IL_008a, IL_0109, IL_0128, IL_0154, IL_0163, IL_01cf, IL_0211
		int num = 3;
		int num2 = num;
		CallContextType? type = default(CallContextType?);
		IEnumerator<IMetricProcessor> enumerator = default(IEnumerator<IMetricProcessor>);
		CustomDiagnosticsSessionMetrics orAdd = default(CustomDiagnosticsSessionMetrics);
		CallContextType callContextType = default(CallContextType);
		while (true)
		{
			switch (num2)
			{
			case 7:
				type = callInfo.Type;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 3;
				}
				break;
			case 6:
				try
				{
					while (true)
					{
						int num3;
						if (!Vo7CllEI7OuJ1Ub6b3u0(enumerator))
						{
							num3 = 2;
							goto IL_008e;
						}
						goto IL_00a4;
						IL_008e:
						switch (num3)
						{
						case 1:
							continue;
						case 2:
							return;
						}
						goto IL_00a4;
						IL_00a4:
						jg77T3EIAO3HThtygmrb(enumerator.Current, callInfo, orAdd);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
						{
							num3 = 1;
						}
						goto IL_008e;
					}
				}
				finally
				{
					int num4;
					if (enumerator == null)
					{
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
						{
							num4 = 0;
						}
						goto IL_010d;
					}
					goto IL_0132;
					IL_0132:
					enumerator.Dispose();
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num4 = 1;
					}
					goto IL_010d;
					IL_010d:
					switch (num4)
					{
					default:
						goto end_IL_00e8;
					case 0:
						goto end_IL_00e8;
					case 2:
						break;
					case 1:
						goto end_IL_00e8;
					}
					goto IL_0132;
					end_IL_00e8:;
				}
			default:
				enumerator = base.MetricProcessors.GetEnumerator();
				num2 = 6;
				break;
			case 5:
				callContextType = CallContextType.SubContext;
				num2 = 9;
				break;
			case 2:
				if (!type.HasValue)
				{
					num2 = 4;
					break;
				}
				goto case 7;
			case 9:
				if (type == callContextType)
				{
					num2 = 10;
					break;
				}
				return;
			case 8:
				return;
			case 4:
			case 10:
				orAdd = container.GetOrAdd<CustomDiagnosticsSessionMetrics>().GetOrAdd((string)mkiAOkEIHaUpLomkY0Ph(callInfo));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return;
			case 3:
				type = callInfo.Type;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static object mkiAOkEIHaUpLomkY0Ph(object P_0)
	{
		return ((CallContextInfo)P_0).Name;
	}

	internal static void jg77T3EIAO3HThtygmrb(object P_0, object P_1, object P_2)
	{
		((IMetricProcessor)P_0).Process(P_1, (IMetric)P_2);
	}

	internal static bool Vo7CllEI7OuJ1Ub6b3u0(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static bool MNsEJeEI4RlSm5s5OoOp()
	{
		return S9dQQFEIwU7ZTM9Icyjo == null;
	}

	internal static CustomDiagnostcisSessionMetricAggregator jXX4rNEI6OwMod874cdQ()
	{
		return S9dQQFEIwU7ZTM9Icyjo;
	}
}
