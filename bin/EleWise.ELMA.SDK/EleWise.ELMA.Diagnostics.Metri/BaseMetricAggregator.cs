using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Metrics;

public abstract class BaseMetricAggregator<TCallInfo> : IMetricAggregator where TCallInfo : class
{
	private readonly Type baseMetricAggregatorType;

	private static object VZtlNFEZqvVPP1667BbC;

	public virtual Type[] IgnoredProcessors => new Type[0];

	public IEnumerable<IMetricProcessor> MetricProcessors { get; private set; }

	protected BaseMetricAggregator(IEnumerable<IMetricProcessor> processors)
	{
		SingletonReader.JJCZtPuTvSt();
		baseMetricAggregatorType = typeof(BaseMetricAggregator<>);
		base._002Ector();
		MetricProcessors = processors.Where(delegate(IMetricProcessor mp)
		{
			//Discarded unreachable code: IL_002d, IL_003c
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return !IgnoredProcessors.Contains(mp.GetType());
				case 1:
					return false;
				case 2:
					if (!mp.AggregatorTypes.Any(delegate(Type at)
					{
						//Discarded unreachable code: IL_0062, IL_0071
						int num3 = 2;
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							default:
								return at == baseMetricAggregatorType;
							case 1:
								return true;
							case 2:
								if (at.IsInstanceOfType(this))
								{
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
									{
										num4 = 1;
									}
									break;
								}
								goto default;
							}
						}
					}))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				}
			}
		});
	}

	void IMetricAggregator.Add(object callInfo, MetricsContainer container)
	{
		//Discarded unreachable code: IL_0079, IL_0088
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 2:
				return;
			default:
				Add((TCallInfo)callInfo, container);
				num2 = 3;
				break;
			case 1:
				if (callInfo.GetType() != TypeOf<TCallInfo>.Raw)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public abstract void Add(TCallInfo callInfo, MetricsContainer container);

	internal static bool cGBrPrEZKMNgnO0ONYkt()
	{
		return VZtlNFEZqvVPP1667BbC == null;
	}

	internal static object aXfejTEZX7Pp5OEoRbrQ()
	{
		return VZtlNFEZqvVPP1667BbC;
	}
}
