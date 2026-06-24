using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Attributes;
using EleWise.ELMA.Diagnostics.Metrics.Internal;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Metrics;

public sealed class MetricsContainer : Dictionary<Type, IMetricGroup>
{
	private readonly ReaderWriterLockSlim rwLock;

	private static readonly Type genericMetricGroupType;

	internal static MetricsContainer wCYV4EEZa5yLYJDpbeQ8;

	public DateTime StartTime
	{
		[CompilerGenerated]
		get
		{
			return _003CStartTime_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CStartTime_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public List<DateTimeRange> Periods { get; set; }

	public MetricsContainer()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		U2SdFaEZwoacQGDrAV92();
		rwLock = new ReaderWriterLockSlim();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			Periods = new List<DateTimeRange>();
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
			{
				num = 1;
			}
		}
	}

	public MetricsGroup<T> GetOrAdd<T>(IEqualityComparer<string> comparer = null) where T : IMetric, new()
	{
		MetricsGroup<T> result = null;
		AggregatorAttribute attribute = AttributeHelper<AggregatorAttribute>.GetAttribute(TypeOf<T>.Raw, inherited: false);
		if (attribute == null)
		{
			throw new Exception(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1123633026 ^ -1123878916), TypeOf<T>.Name));
		}
		IMetricGroup value = null;
		if (rwLock.TryEnterUpgradeableReadLock(50))
		{
			try
			{
				if (!TryGetValue(attribute.Type, out value) || !(value is MetricsGroup<T> result2))
				{
					result = new MetricsGroup<T>(comparer);
					rwLock.EnterWriteLock();
					try
					{
						Add(attribute.Type, result);
						return result;
					}
					finally
					{
						rwLock.ExitWriteLock();
					}
				}
				return result2;
			}
			finally
			{
				rwLock.ExitUpgradeableReadLock();
			}
		}
		return result;
	}

	public MetricsGroup<T> Get<T>() where T : IMetric, new()
	{
		AggregatorAttribute attribute = AttributeHelper<AggregatorAttribute>.GetAttribute(TypeOf<T>.Raw, inherited: true);
		if (attribute == null)
		{
			throw new Exception(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7E85ABD), TypeOf<T>.Name));
		}
		IMetricGroup value = null;
		if (rwLock.TryEnterReadLock(50))
		{
			try
			{
				TryGetValue(attribute.Type, out value);
			}
			finally
			{
				rwLock.ExitReadLock();
			}
		}
		return value as MetricsGroup<T>;
	}

	public void Merge(MetricsContainer container)
	{
		//Discarded unreachable code: IL_0082, IL_00be, IL_00d1, IL_00e0
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				if (!iD1ERXEZ4d60JsJ01ZTI(rwLock, 50))
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				container.ForEach(delegate(KeyValuePair<Type, IMetricGroup> a)
				{
					if (TryGetValue(a.Key, out var value))
					{
						IMetricGroup value2 = a.Value;
						if (value != null && value2 != null)
						{
							value.Merge(value2);
						}
					}
					else if (Activator.CreateInstance(genericMetricGroupType.MakeGenericType(a.Value.GetType().GetGenericArguments()[0])) is IMetricGroup metricGroup)
					{
						metricGroup.Merge(a.Value);
						rwLock.EnterWriteLock();
						try
						{
							Add(a.Key, metricGroup);
						}
						finally
						{
							rwLock.ExitWriteLock();
						}
					}
				});
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
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
				WgZZJVEZ6YJJrHNcdkDR(rwLock);
				int num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
				{
					num4 = 0;
				}
				switch (num4)
				{
				case 0:
					break;
				}
			}
		}
	}

	static MetricsContainer()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				genericMetricGroupType = Wa5bfVEZHMiy7D2Zcl2o(typeof(MetricsGroup<>).TypeHandle);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				U2SdFaEZwoacQGDrAV92();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static void U2SdFaEZwoacQGDrAV92()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool QRi2qBEZDK5dkvAc9qss()
	{
		return wCYV4EEZa5yLYJDpbeQ8 == null;
	}

	internal static MetricsContainer m1ASiFEZtswwFxXbcbWB()
	{
		return wCYV4EEZa5yLYJDpbeQ8;
	}

	internal static bool iD1ERXEZ4d60JsJ01ZTI(object P_0, int P_1)
	{
		return ((ReaderWriterLockSlim)P_0).TryEnterUpgradeableReadLock(P_1);
	}

	internal static void WgZZJVEZ6YJJrHNcdkDR(object P_0)
	{
		((ReaderWriterLockSlim)P_0).ExitUpgradeableReadLock();
	}

	internal static Type Wa5bfVEZHMiy7D2Zcl2o(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
