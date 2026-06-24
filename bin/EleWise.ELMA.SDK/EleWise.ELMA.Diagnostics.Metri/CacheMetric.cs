using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Diagnostics.Attributes;
using EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Metrics;

[Aggregator(typeof(CacheQueryCallMetricAggregator))]
public class CacheMetric : CountTimeMetric
{
	internal static class __CacheMetricLocalization
	{
		internal static __CacheMetricLocalization YZyQ198KG6WwKvciQHVV;

		public static string ReadTotalCount => SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x20261A4F ^ 0x2023FA5D));

		public static string ReadTotalTime => (string)fD2XPc8KQ4UpELd37hLx(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-210725949 ^ -210406517));

		public static string AvgReadTime => (string)fD2XPc8KQ4UpELd37hLx(O2ZyrB8KCMqNNWKjg0DG(0x1ECE530A ^ 0x1ECBB382));

		public static string ReadErrorTotalCount => (string)fD2XPc8KQ4UpELd37hLx(O2ZyrB8KCMqNNWKjg0DG(0x571EA399 ^ 0x571B4357));

		public static string SuccesReadTotalCount => SR.T((string)O2ZyrB8KCMqNNWKjg0DG(0x3CE17B75 ^ 0x3CE49A6F));

		public static string WriteTotalCount => (string)fD2XPc8KQ4UpELd37hLx(O2ZyrB8KCMqNNWKjg0DG(0x17ADCCD8 ^ 0x17A82DB6));

		public static string WriteTotalTime => (string)fD2XPc8KQ4UpELd37hLx(O2ZyrB8KCMqNNWKjg0DG(0x4A1640F ^ 0x4A485AD));

		public static string AvgWriteTime => SR.T((string)O2ZyrB8KCMqNNWKjg0DG(0x7E6E5A0B ^ 0x7E6BBBD5));

		public static string WriteErrorTotalCount => (string)fD2XPc8KQ4UpELd37hLx(O2ZyrB8KCMqNNWKjg0DG(-345420348 ^ -345198620));

		public static string LockTotalCount => (string)fD2XPc8KQ4UpELd37hLx(O2ZyrB8KCMqNNWKjg0DG(-957824448 ^ -957538264));

		public static string LockTotalTime => (string)fD2XPc8KQ4UpELd37hLx(O2ZyrB8KCMqNNWKjg0DG(-1822890472 ^ -1822620488));

		public static string AvgLockTime => SR.T((string)O2ZyrB8KCMqNNWKjg0DG(-1876063057 ^ -1876398515));

		public static string LockErrorTotalCount => (string)fD2XPc8KQ4UpELd37hLx(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138332846));

		public static string LockSuccesTotalCount => (string)fD2XPc8KQ4UpELd37hLx(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1853222532));

		internal static bool bqvg7o8KENwKWel3nN8u()
		{
			return YZyQ198KG6WwKvciQHVV == null;
		}

		internal static __CacheMetricLocalization J4esdQ8KfjxtmWKMm9JJ()
		{
			return YZyQ198KG6WwKvciQHVV;
		}

		internal static object fD2XPc8KQ4UpELd37hLx(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static object O2ZyrB8KCMqNNWKjg0DG(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}
	}

	private static CacheMetric UoblQSE8NX7b6DZk5oal;

	public override Guid Uid => new Guid((string)n8KfxNE8aEyny2V54PbY(0x18A6761F ^ 0x18A23B4D));

	[Order(60)]
	[DisplayName(typeof(__CacheMetricLocalization), "ReadTotalCount")]
	public long ReadTotalCount
	{
		[CompilerGenerated]
		get
		{
			return _003CReadTotalCount_003Ek__BackingField;
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
					_003CReadTotalCount_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
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

	[Order(70)]
	[DisplayName(typeof(__CacheMetricLocalization), "ReadTotalTime")]
	public TimeSpan ReadTotalTime
	{
		[CompilerGenerated]
		get
		{
			return _003CReadTotalTime_003Ek__BackingField;
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
					_003CReadTotalTime_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
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

	[DisplayName(typeof(__CacheMetricLocalization), "AvgReadTime")]
	[Order(80)]
	public double AvgReadTime
	{
		get
		{
			int num = 1;
			int num2 = num;
			TimeSpan readTotalTime = default(TimeSpan);
			while (true)
			{
				switch (num2)
				{
				case 1:
					readTotalTime = ReadTotalTime;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 0;
					}
					break;
				default:
					return readTotalTime.TotalMilliseconds / (double)ReadTotalCount;
				}
			}
		}
	}

	[Order(90)]
	[DisplayName(typeof(__CacheMetricLocalization), "ReadErrorTotalCount")]
	public long ReadErrorTotalCount
	{
		[CompilerGenerated]
		get
		{
			return _003CReadErrorTotalCount_003Ek__BackingField;
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
					_003CReadErrorTotalCount_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
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

	[DisplayName(typeof(__CacheMetricLocalization), "SuccesReadTotalCount")]
	[Order(100)]
	public long SuccesReadTotalCount
	{
		[CompilerGenerated]
		get
		{
			return _003CSuccesReadTotalCount_003Ek__BackingField;
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
					_003CSuccesReadTotalCount_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
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

	[DisplayName(typeof(__CacheMetricLocalization), "WriteTotalCount")]
	[Order(110)]
	public long WriteTotalCount
	{
		[CompilerGenerated]
		get
		{
			return _003CWriteTotalCount_003Ek__BackingField;
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
				case 0:
					return;
				case 1:
					_003CWriteTotalCount_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Order(120)]
	[DisplayName(typeof(__CacheMetricLocalization), "WriteTotalTime")]
	public TimeSpan WriteTotalTime
	{
		[CompilerGenerated]
		get
		{
			return _003CWriteTotalTime_003Ek__BackingField;
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
					_003CWriteTotalTime_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
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

	[DisplayName(typeof(__CacheMetricLocalization), "AvgWriteTime")]
	[Order(130)]
	public double AvgWriteTime
	{
		get
		{
			int num = 1;
			int num2 = num;
			TimeSpan writeTotalTime = default(TimeSpan);
			while (true)
			{
				switch (num2)
				{
				default:
					return writeTotalTime.TotalMilliseconds / (double)WriteTotalCount;
				case 1:
					writeTotalTime = WriteTotalTime;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Order(140)]
	[DisplayName(typeof(__CacheMetricLocalization), "WriteErrorTotalCount")]
	public long WriteErrorTotalCount
	{
		[CompilerGenerated]
		get
		{
			return _003CWriteErrorTotalCount_003Ek__BackingField;
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
				case 0:
					return;
				case 1:
					_003CWriteErrorTotalCount_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Order(150)]
	[DisplayName(typeof(__CacheMetricLocalization), "LockTotalCount")]
	public long LockTotalCount
	{
		[CompilerGenerated]
		get
		{
			return _003CLockTotalCount_003Ek__BackingField;
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
				case 0:
					return;
				case 1:
					_003CLockTotalCount_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DisplayName(typeof(__CacheMetricLocalization), "LockTotalTime")]
	[Order(160)]
	public TimeSpan LockTotalTime
	{
		[CompilerGenerated]
		get
		{
			return _003CLockTotalTime_003Ek__BackingField;
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
					_003CLockTotalTime_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
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

	[Order(170)]
	[DisplayName(typeof(__CacheMetricLocalization), "AvgLockTime")]
	public double AvgLockTime
	{
		get
		{
			int num = 1;
			int num2 = num;
			TimeSpan lockTotalTime = default(TimeSpan);
			while (true)
			{
				switch (num2)
				{
				case 1:
					lockTotalTime = LockTotalTime;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 0;
					}
					break;
				default:
					return lockTotalTime.TotalMilliseconds / (double)LockTotalCount;
				}
			}
		}
	}

	[Order(180)]
	[DisplayName(typeof(__CacheMetricLocalization), "LockErrorTotalCount")]
	public long LockErrorTotalCount
	{
		[CompilerGenerated]
		get
		{
			return _003CLockErrorTotalCount_003Ek__BackingField;
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
				case 0:
					return;
				case 1:
					_003CLockErrorTotalCount_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DisplayName(typeof(__CacheMetricLocalization), "LockSuccesTotalCount")]
	[Order(190)]
	public long LockSuccesTotalCount => LockTotalCount - LockErrorTotalCount;

	public override void Merge(IMetric metric)
	{
		//Discarded unreachable code: IL_00ed, IL_00fc
		int num = 7;
		int num2 = num;
		CacheMetric cacheMetric = default(CacheMetric);
		while (true)
		{
			switch (num2)
			{
			case 13:
				SuccesReadTotalCount += bZ5PUhE8477n6hDxMq52(cacheMetric);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 5;
				}
				break;
			default:
				LockTotalCount += tvJSRfE87o7PTYBBc79h(cacheMetric);
				num2 = 12;
				break;
			case 12:
				LockTotalTime = qk5pWKE8thYeuMbaDNkv(LockTotalTime, xx3o7ME8xQfVvUpvJ5e6(cacheMetric));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num2 = 8;
				}
				break;
			case 1:
				return;
			case 14:
				return;
			case 6:
				if (cacheMetric == null)
				{
					num2 = 14;
					break;
				}
				goto case 3;
			case 11:
				ReadErrorTotalCount += crIjT5E8wyObyqNqqA29(cacheMetric);
				num2 = 13;
				break;
			case 8:
				LockErrorTotalCount += Iwfm0CE800fOJarO3Z7w(cacheMetric);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
				{
					num2 = 1;
				}
				break;
			case 7:
				cacheMetric = metric as CacheMetric;
				num2 = 6;
				break;
			case 5:
				WriteTotalCount += F5IHGuE86igJxS4ECu9Y(cacheMetric);
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 6;
				}
				break;
			case 2:
				ReadTotalCount += Ripl2fE8Dfv8TB2kPdon(cacheMetric);
				num2 = 4;
				break;
			case 4:
				ReadTotalTime = qk5pWKE8thYeuMbaDNkv(ReadTotalTime, cacheMetric.ReadTotalTime);
				num2 = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				base.Merge(metric);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num2 = 0;
				}
				break;
			case 10:
				WriteErrorTotalCount += raAK6jE8AMh8krDRXd2U(cacheMetric);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
				{
					num2 = 0;
				}
				break;
			case 9:
				WriteTotalTime += ojTF08E8HdrfURjF4RTZ(cacheMetric);
				num2 = 10;
				break;
			}
		}
	}

	public CacheMetric()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object n8KfxNE8aEyny2V54PbY(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool oLhIj1E83DfBHVTIglQ8()
	{
		return UoblQSE8NX7b6DZk5oal == null;
	}

	internal static CacheMetric dhlTkAE8piDn50Ib9YAY()
	{
		return UoblQSE8NX7b6DZk5oal;
	}

	internal static long Ripl2fE8Dfv8TB2kPdon(object P_0)
	{
		return ((CacheMetric)P_0).ReadTotalCount;
	}

	internal static TimeSpan qk5pWKE8thYeuMbaDNkv(TimeSpan P_0, TimeSpan P_1)
	{
		return P_0 + P_1;
	}

	internal static long crIjT5E8wyObyqNqqA29(object P_0)
	{
		return ((CacheMetric)P_0).ReadErrorTotalCount;
	}

	internal static long bZ5PUhE8477n6hDxMq52(object P_0)
	{
		return ((CacheMetric)P_0).SuccesReadTotalCount;
	}

	internal static long F5IHGuE86igJxS4ECu9Y(object P_0)
	{
		return ((CacheMetric)P_0).WriteTotalCount;
	}

	internal static TimeSpan ojTF08E8HdrfURjF4RTZ(object P_0)
	{
		return ((CacheMetric)P_0).WriteTotalTime;
	}

	internal static long raAK6jE8AMh8krDRXd2U(object P_0)
	{
		return ((CacheMetric)P_0).WriteErrorTotalCount;
	}

	internal static long tvJSRfE87o7PTYBBc79h(object P_0)
	{
		return ((CacheMetric)P_0).LockTotalCount;
	}

	internal static TimeSpan xx3o7ME8xQfVvUpvJ5e6(object P_0)
	{
		return ((CacheMetric)P_0).LockTotalTime;
	}

	internal static long Iwfm0CE800fOJarO3Z7w(object P_0)
	{
		return ((CacheMetric)P_0).LockErrorTotalCount;
	}
}
