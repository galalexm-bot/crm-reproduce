using System;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Metrics.Impl.Processors;

[Component]
public class CacheQueryCallMetricProcessor : IMetricProcessor
{
	internal static CacheQueryCallMetricProcessor iWfy1nEu1k3oSD1klOWQ;

	public Type[] AggregatorTypes => new Type[1] { TypeOf<CacheQueryCallMetricAggregator>.Raw };

	public void Process(object callInfo, IMetric currentMetric)
	{
		//Discarded unreachable code: IL_0273, IL_02fa, IL_0309
		int num = 23;
		CacheMetric cacheMetric = default(CacheMetric);
		CacheReadInfo cacheReadInfo = default(CacheReadInfo);
		CacheLockInfo cacheLockInfo = default(CacheLockInfo);
		CacheWriteInfo cacheWriteInfo = default(CacheWriteInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
				{
					CacheMetric cacheMetric7 = cacheMetric;
					long value = yh9L1JEurn9dM9XiDO0T(cacheMetric7) + 1;
					c09wHOEugV4O6rGkxaEU(cacheMetric7, value);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 2;
					}
					continue;
				}
				case 2:
					return;
				case 4:
					return;
				case 12:
					if (EqIRMIEuwN9XH97iUI0d(cacheReadInfo) != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 17;
				case 15:
				{
					CacheMetric cacheMetric3 = cacheMetric;
					h8KNJQEulpOEvU0n7vMB(cacheMetric3, wfZneSEudJiBP8xFkFOw(cacheMetric3) + cacheLockInfo.TotalTime);
					num = 20;
					break;
				}
				case 6:
					if (cacheLockInfo == null)
					{
						num2 = 4;
						continue;
					}
					goto case 18;
				case 8:
					cacheLockInfo = callInfo as CacheLockInfo;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 6;
					}
					continue;
				case 3:
					if (EqIRMIEuwN9XH97iUI0d(cacheWriteInfo) != null)
					{
						num2 = 24;
						continue;
					}
					goto case 8;
				case 20:
					if (EqIRMIEuwN9XH97iUI0d(cacheLockInfo) == null)
					{
						return;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
					{
						num2 = 1;
					}
					continue;
				case 24:
				{
					CacheMetric cacheMetric10 = cacheMetric;
					long value = aAve5WEuy2VrYBCR4OGl(cacheMetric10) + 1;
					iuXEBxEuMKQfKDMWELfW(cacheMetric10, value);
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
					{
						num2 = 8;
					}
					continue;
				}
				case 17:
					if (RSelohEuHKG3ZquwSZHM(cacheReadInfo))
					{
						num2 = 9;
						continue;
					}
					goto case 5;
				case 7:
				{
					CacheMetric cacheMetric9 = cacheMetric;
					cacheMetric9.WriteTotalTime = FxcPeSEutMqDhPSe4i0u(kQDooPEu0ahi22CFYoFX(cacheMetric9), WV7QrUEumKtlXkhObNC4(cacheWriteInfo));
					num2 = 3;
					continue;
				}
				case 22:
					if (cacheMetric == null)
					{
						num2 = 19;
						continue;
					}
					cacheReadInfo = callInfo as CacheReadInfo;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 13;
					}
					continue;
				case 5:
				case 16:
					cacheWriteInfo = callInfo as CacheWriteInfo;
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 0;
					}
					continue;
				case 14:
				{
					CacheMetric cacheMetric8 = cacheMetric;
					long value = Xf9tKPEupslC5OhPieN2(cacheMetric8) + 1;
					RJHAs1Eua80jup2EfRUf(cacheMetric8, value);
					num2 = 21;
					continue;
				}
				case 23:
				{
					CacheQueryInfo obj = callInfo as CacheQueryInfo;
					cacheMetric = currentMetric as CacheMetric;
					if (obj != null)
					{
						num2 = 22;
						continue;
					}
					return;
				}
				case 9:
				{
					CacheMetric cacheMetric6 = cacheMetric;
					long value = SxBeAjEuA5vbx9m0h0ni(cacheMetric6) + 1;
					QojhyvEu7Ak7gYAQ3YQ8(cacheMetric6, value);
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 16;
					}
					continue;
				}
				case 10:
				{
					CacheMetric cacheMetric5 = cacheMetric;
					long value = WOG287Eu4vXGTmr2nLtI(cacheMetric5) + 1;
					RNLx4xEu6lMTvXgWHe9G(cacheMetric5, value);
					num2 = 17;
					continue;
				}
				case 19:
					return;
				case 18:
				{
					CacheMetric cacheMetric11 = cacheMetric;
					long value = xEGdYREuJU2mKu0q0Y1D(cacheMetric11) + 1;
					l7Vk7vEu9cuni3Iq2c7L(cacheMetric11, value);
					num2 = 15;
					continue;
				}
				case 13:
					if (cacheReadInfo == null)
					{
						num = 5;
						break;
					}
					goto case 14;
				case 21:
				{
					CacheMetric cacheMetric4 = cacheMetric;
					cacheMetric4.ReadTotalTime = FxcPeSEutMqDhPSe4i0u(JrOmddEuDwGAD2ZBYcer(cacheMetric4), cacheReadInfo.TotalTime);
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 12;
					}
					continue;
				}
				case 11:
					if (cacheWriteInfo != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 8;
				default:
				{
					CacheMetric cacheMetric2 = cacheMetric;
					long value = cacheMetric2.WriteTotalCount + 1;
					lvlvAKEuxdkLobwZyc3c(cacheMetric2, value);
					num2 = 7;
					continue;
				}
				}
				break;
			}
		}
	}

	public CacheQueryCallMetricProcessor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool k6lh52EuNUNBulQVYVZy()
	{
		return iWfy1nEu1k3oSD1klOWQ == null;
	}

	internal static CacheQueryCallMetricProcessor QYFDkIEu3wphiA6paKQZ()
	{
		return iWfy1nEu1k3oSD1klOWQ;
	}

	internal static long Xf9tKPEupslC5OhPieN2(object P_0)
	{
		return ((CacheMetric)P_0).ReadTotalCount;
	}

	internal static void RJHAs1Eua80jup2EfRUf(object P_0, long value)
	{
		((CacheMetric)P_0).ReadTotalCount = value;
	}

	internal static TimeSpan JrOmddEuDwGAD2ZBYcer(object P_0)
	{
		return ((CacheMetric)P_0).ReadTotalTime;
	}

	internal static TimeSpan FxcPeSEutMqDhPSe4i0u(TimeSpan P_0, TimeSpan P_1)
	{
		return P_0 + P_1;
	}

	internal static object EqIRMIEuwN9XH97iUI0d(object P_0)
	{
		return ((AbstractCallInfo)P_0).Exception;
	}

	internal static long WOG287Eu4vXGTmr2nLtI(object P_0)
	{
		return ((CacheMetric)P_0).ReadErrorTotalCount;
	}

	internal static void RNLx4xEu6lMTvXgWHe9G(object P_0, long value)
	{
		((CacheMetric)P_0).ReadErrorTotalCount = value;
	}

	internal static bool RSelohEuHKG3ZquwSZHM(object P_0)
	{
		return ((CacheReadInfo)P_0).Success;
	}

	internal static long SxBeAjEuA5vbx9m0h0ni(object P_0)
	{
		return ((CacheMetric)P_0).SuccesReadTotalCount;
	}

	internal static void QojhyvEu7Ak7gYAQ3YQ8(object P_0, long value)
	{
		((CacheMetric)P_0).SuccesReadTotalCount = value;
	}

	internal static void lvlvAKEuxdkLobwZyc3c(object P_0, long value)
	{
		((CacheMetric)P_0).WriteTotalCount = value;
	}

	internal static TimeSpan kQDooPEu0ahi22CFYoFX(object P_0)
	{
		return ((CacheMetric)P_0).WriteTotalTime;
	}

	internal static TimeSpan WV7QrUEumKtlXkhObNC4(object P_0)
	{
		return ((AbstractCallInfo)P_0).TotalTime;
	}

	internal static long aAve5WEuy2VrYBCR4OGl(object P_0)
	{
		return ((CacheMetric)P_0).WriteErrorTotalCount;
	}

	internal static void iuXEBxEuMKQfKDMWELfW(object P_0, long value)
	{
		((CacheMetric)P_0).WriteErrorTotalCount = value;
	}

	internal static long xEGdYREuJU2mKu0q0Y1D(object P_0)
	{
		return ((CacheMetric)P_0).LockTotalCount;
	}

	internal static void l7Vk7vEu9cuni3Iq2c7L(object P_0, long value)
	{
		((CacheMetric)P_0).LockTotalCount = value;
	}

	internal static TimeSpan wfZneSEudJiBP8xFkFOw(object P_0)
	{
		return ((CacheMetric)P_0).LockTotalTime;
	}

	internal static void h8KNJQEulpOEvU0n7vMB(object P_0, TimeSpan value)
	{
		((CacheMetric)P_0).LockTotalTime = value;
	}

	internal static long yh9L1JEurn9dM9XiDO0T(object P_0)
	{
		return ((CacheMetric)P_0).LockErrorTotalCount;
	}

	internal static void c09wHOEugV4O6rGkxaEU(object P_0, long value)
	{
		((CacheMetric)P_0).LockErrorTotalCount = value;
	}
}
