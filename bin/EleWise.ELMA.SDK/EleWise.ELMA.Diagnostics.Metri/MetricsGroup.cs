using System.Collections.Generic;
using System.Threading;
using EleWise.ELMA.Diagnostics.Metrics.Internal;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Metrics;

public sealed class MetricsGroup<T> : Dictionary<string, T>, IMetricGroup<T>, IMetricGroup where T : IMetric, new()
{
	private readonly ReaderWriterLockSlim rwLock;

	internal static object bKCO9MEZAFQtCqvSC52p;

	public MetricsGroup()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		SingletonReader.JJCZtPuTvSt();
		rwLock = new ReaderWriterLockSlim();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public MetricsGroup(IEqualityComparer<string> comparer = null)
	{
		SingletonReader.JJCZtPuTvSt();
		rwLock = new ReaderWriterLockSlim();
		base._002Ector(comparer);
	}

	public T GetOrAdd(string name)
	{
		T value = default(T);
		if (rwLock.TryEnterUpgradeableReadLock(50))
		{
			try
			{
				if (!TryGetValue(name, out value))
				{
					value = new T();
					rwLock.EnterWriteLock();
					try
					{
						Add(name, value);
						return value;
					}
					finally
					{
						rwLock.ExitWriteLock();
					}
				}
				return value;
			}
			finally
			{
				rwLock.ExitUpgradeableReadLock();
			}
		}
		return value;
	}

	public void Merge(IMetricGroup metricGroup)
	{
		//Discarded unreachable code: IL_007b, IL_00b7, IL_00ca, IL_00d9
		int num = 4;
		int num2 = num;
		MetricsGroup<T> metricsGroup = default(MetricsGroup<T>);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				try
				{
					metricsGroup.ForEach(delegate(KeyValuePair<string, T> g)
					{
						T value = default(T);
						if (TryGetValue(g.Key, out value))
						{
							value.Merge(g.Value);
							return;
						}
						T value2 = new T();
						value2.Merge(g.Value);
						rwLock.EnterWriteLock();
						try
						{
							Add(g.Key, value2);
						}
						finally
						{
							rwLock.ExitWriteLock();
						}
					});
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
					return;
				}
				finally
				{
					rwLock.ExitUpgradeableReadLock();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			case 4:
				metricsGroup = metricGroup as MetricsGroup<T>;
				num2 = 3;
				break;
			case 1:
				return;
			case 3:
				if (metricsGroup != null)
				{
					if (!rwLock.TryEnterUpgradeableReadLock(50))
					{
						return;
					}
					num2 = 2;
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num2 = 0;
					}
				}
				break;
			}
		}
	}

	internal static bool Uw2s0YEZ7i6h35POCU5t()
	{
		return bKCO9MEZAFQtCqvSC52p == null;
	}

	internal static object FvnAHBEZxicGPmcweh17()
	{
		return bKCO9MEZAFQtCqvSC52p;
	}
}
