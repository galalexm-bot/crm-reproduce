using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Runtime.InteropServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Scheduling;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Services;

[Service(Type = ComponentType.Server, Scope = ServiceScope.Application)]
public class TimestampService : ITimestampService, ISweepHandler
{
	private readonly DateTime ORIGIN_DATE;

	private ILogger logger;

	private ITransformationProvider transformationProvider;

	private double syncInterval;

	private long nextSyncTimestamp;

	private long timestampDiff;

	private static TimestampService hxla1bB6cddcx1MJWo5c;

	protected virtual ITransformationProvider TransformationProvider
	{
		get
		{
			int num = 1;
			int num2 = num;
			ITransformationProvider transformationProvider = default(ITransformationProvider);
			ITransformationProvider obj;
			while (true)
			{
				switch (num2)
				{
				default:
					transformationProvider = (this.transformationProvider = Locator.GetService<ITransformationProvider>());
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					obj = this.transformationProvider;
					if (obj != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					obj = transformationProvider;
					break;
				}
				break;
			}
			return obj;
		}
	}

	protected virtual ILogger TimestampLogger
	{
		get
		{
			int num = 1;
			int num2 = num;
			ILogger logger = default(ILogger);
			ILogger obj;
			while (true)
			{
				switch (num2)
				{
				default:
					logger = (this.logger = (ILogger)hCbbOABHhSrlvVy9Wa8E(yGyU7ABHbhlO3LbwSmex(0x12A5FAC7 ^ 0x12A4AC83)));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					obj = this.logger;
					if (obj != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					obj = logger;
					break;
				}
				break;
			}
			return obj;
		}
	}

	protected bool IsInitialized => timestampDiff != long.MinValue;

	public TimestampService()
	{
		//Discarded unreachable code: IL_0055, IL_005a
		WCLGaZBHBjm0VVsa6sow();
		ORIGIN_DATE = new DateTime(2000, 1, 1);
		timestampDiff = long.MinValue;
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				LoadSettings();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public long GetTimestamp()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				TryInitialize();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return b3rJWbBHWpnVDnDYD45k(this) - timestampDiff;
			}
		}
	}

	public long GetTimeStampRelativeToNow(TimeSpan timeOffset)
	{
		return GetTimestamp() + GetTimestampOffset(timeOffset);
	}

	void ISweepHandler.Execute()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 3:
				if (GetTimestamp() < nextSyncTimestamp)
				{
					return;
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				SyncTime();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				nextSyncTimestamp = GetTimeStampRelativeToNow(bV4aXEBHoQG04080rr9s(syncInterval));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected void SyncTime()
	{
		//Discarded unreachable code: IL_0117, IL_0126, IL_0135, IL_017c
		int num = 3;
		int num2 = num;
		long num4 = default(long);
		long num3 = default(long);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!IsInitialized)
				{
					num2 = 5;
					continue;
				}
				break;
			case 11:
				ai9VEOBHfbh8PQDPE8l4(TQVowdBHGWuRM4sG7tAY(this), yGyU7ABHbhlO3LbwSmex(0x53FA00CE ^ 0x53FB5600));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 1;
				}
				continue;
			case 7:
				ALe6NwBHEDInEBHWp0sK(TQVowdBHGWuRM4sG7tAY(this), yGyU7ABHbhlO3LbwSmex(-672123589 ^ -672046247));
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num2 = 9;
				}
				continue;
			case 3:
				num4 = GetServerTimestamp() - GetMasterTimestamp();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num2 = 2;
				}
				continue;
			default:
				timestampDiff = num4;
				num2 = 4;
				continue;
			case 10:
				if (num3 <= 1)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 11;
			case 6:
				if (num3 > 30)
				{
					num2 = 7;
					continue;
				}
				goto case 10;
			case 4:
				return;
			case 8:
				break;
			}
			num3 = Math.Abs(num4 - timestampDiff) / 100;
			num2 = 6;
		}
	}

	protected long GetMasterTimestamp()
	{
		return GetTimestampOffset(TransformationProvider.GetUtcDateTimeNow() - ORIGIN_DATE);
	}

	protected virtual long GetServerTimestamp()
	{
		return (long)(GetTickCount64() / 10uL);
	}

	protected long GetTimestampOffset(TimeSpan timeSpan)
	{
		return timeSpan.Ticks / 10000 / 10;
	}

	protected void LoadSettings()
	{
		//Discarded unreachable code: IL_0054
		int num = 2;
		long result = default(long);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					result = 0L;
					num2 = 6;
					continue;
				case 8:
					return;
				case 4:
				case 5:
					if (result <= 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 7;
				case 6:
					if (string.IsNullOrEmpty(text))
					{
						num = 4;
						break;
					}
					goto case 3;
				case 2:
					text = (string)DI3is9BHCxtOFDEEVrV7(rQ6jW0BHQdsUw2b9XTY5(), yGyU7ABHbhlO3LbwSmex(0x3A6135BE ^ 0x3A606284));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					result = 30L;
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 1;
					}
					continue;
				case 7:
					syncInterval = result;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 8;
					}
					continue;
				case 3:
					long.TryParse(text, out result);
					num = 5;
					break;
				}
				break;
			}
		}
	}

	private void TryInitialize()
	{
		//Discarded unreachable code: IL_0035
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return;
				case 1:
					if (UoTitwBHv0RShD1OvMwf(this) != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					throw new InvalidOperationException((string)a56j3BBH8dkbyShrvInU(yGyU7ABHbhlO3LbwSmex(-1088304168 ^ -1088381792)));
				case 4:
					return;
				case 2:
					if (IsInitialized)
					{
						return;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			SyncTime();
			num = 4;
		}
	}

	[DllImport("kernel32.dll")]
	private static extern ulong GetTickCount64();

	internal static void WCLGaZBHBjm0VVsa6sow()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool JF0SXKB6zvHqSXC5daC1()
	{
		return hxla1bB6cddcx1MJWo5c == null;
	}

	internal static TimestampService B0KQXCBHFB8MxTZJ5pMM()
	{
		return hxla1bB6cddcx1MJWo5c;
	}

	internal static long b3rJWbBHWpnVDnDYD45k(object P_0)
	{
		return ((TimestampService)P_0).GetServerTimestamp();
	}

	internal static TimeSpan bV4aXEBHoQG04080rr9s(double P_0)
	{
		return TimeSpan.FromSeconds(P_0);
	}

	internal static object yGyU7ABHbhlO3LbwSmex(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object hCbbOABHhSrlvVy9Wa8E(object P_0)
	{
		return Logger.GetLogger((string)P_0);
	}

	internal static object TQVowdBHGWuRM4sG7tAY(object P_0)
	{
		return ((TimestampService)P_0).TimestampLogger;
	}

	internal static void ALe6NwBHEDInEBHWp0sK(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}

	internal static void ai9VEOBHfbh8PQDPE8l4(object P_0, object P_1)
	{
		((ILogger)P_0).Warn(P_1);
	}

	internal static object rQ6jW0BHQdsUw2b9XTY5()
	{
		return ConfigurationManager.AppSettings;
	}

	internal static object DI3is9BHCxtOFDEEVrV7(object P_0, object P_1)
	{
		return ((NameValueCollection)P_0)[(string)P_1];
	}

	internal static object UoTitwBHv0RShD1OvMwf(object P_0)
	{
		return ((TimestampService)P_0).TransformationProvider;
	}

	internal static object a56j3BBH8dkbyShrvInU(object P_0)
	{
		return SR.T((string)P_0);
	}
}
