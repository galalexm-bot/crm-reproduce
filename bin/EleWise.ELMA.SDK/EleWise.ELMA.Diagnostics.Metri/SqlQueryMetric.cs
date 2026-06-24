using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Diagnostics.Attributes;
using EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Metrics;

[Aggregator(typeof(SqlQueryCallMetricAggregator))]
public class SqlQueryMetric : CountTimeMetric
{
	internal static class __SqlQueryMetricLocalization
	{
		private static __SqlQueryMetricLocalization KHa3mt8Kt5PZ2alYvS8T;

		public static string MaxExecuteTime => (string)YtaIef8K6qY6OuPgYW76(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6DC147B0 ^ 0x6DC4A11C));

		public static string AvgExecuteTime => SR.T((string)UaFOxH8KHvHGSmwiriwH(-16752921 ^ -16401931));

		public static string MaxPrepareTime => (string)YtaIef8K6qY6OuPgYW76(UaFOxH8KHvHGSmwiriwH(0x7459E02 ^ 0x740796C));

		public static string AvgPrepareTime => SR.T((string)UaFOxH8KHvHGSmwiriwH(0x4EA5403C ^ 0x4EA0A7E8));

		public static string TotalAffectedRows => (string)YtaIef8K6qY6OuPgYW76(UaFOxH8KHvHGSmwiriwH(-1146510045 ^ -1146335981));

		internal static object YtaIef8K6qY6OuPgYW76(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool S5RILg8KwYr7L0NcAFrQ()
		{
			return KHa3mt8Kt5PZ2alYvS8T == null;
		}

		internal static __SqlQueryMetricLocalization n1xYax8K4MuFbE74l6ur()
		{
			return KHa3mt8Kt5PZ2alYvS8T;
		}

		internal static object UaFOxH8KHvHGSmwiriwH(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}
	}

	internal static SqlQueryMetric hr6g3cEZlhOSZP6u8VbJ;

	public override Guid Uid => new Guid((string)o6M3tCEZ50IkCSx53JFa(0x1A33FE36 ^ 0x1A37AE10));

	[Order(600)]
	[DisplayName(typeof(__SqlQueryMetricLocalization), "MaxExecuteTime")]
	public long MaxExecuteTime
	{
		[CompilerGenerated]
		get
		{
			return _003CMaxExecuteTime_003Ek__BackingField;
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
					_003CMaxExecuteTime_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DisplayName(typeof(__SqlQueryMetricLocalization), "AvgExecuteTime")]
	[Order(700)]
	public double AvgExecuteTime
	{
		[CompilerGenerated]
		get
		{
			return _003CAvgExecuteTime_003Ek__BackingField;
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
					_003CAvgExecuteTime_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Order(800)]
	[DisplayName(typeof(__SqlQueryMetricLocalization), "MaxPrepareTime")]
	public long MaxPrepareTime
	{
		[CompilerGenerated]
		get
		{
			return _003CMaxPrepareTime_003Ek__BackingField;
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
					_003CMaxPrepareTime_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
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

	[DisplayName(typeof(__SqlQueryMetricLocalization), "AvgPrepareTime")]
	[Order(900)]
	public double AvgPrepareTime
	{
		[CompilerGenerated]
		get
		{
			return _003CAvgPrepareTime_003Ek__BackingField;
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
					_003CAvgPrepareTime_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DisplayName(typeof(__SqlQueryMetricLocalization), "TotalAffectedRows")]
	[Order(1000)]
	public long TotalAffectedRows
	{
		[CompilerGenerated]
		get
		{
			return _003CTotalAffectedRows_003Ek__BackingField;
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
					_003CTotalAffectedRows_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override void Merge(IMetric metric)
	{
		int num = 4;
		int num2 = num;
		SqlQueryMetric sqlQueryMetric = default(SqlQueryMetric);
		while (true)
		{
			switch (num2)
			{
			case 7:
				base.Merge(metric);
				num2 = 8;
				break;
			case 5:
				AvgPrepareTime = (AvgPrepareTime * (double)base.CountCall + eQ8EJUEZUdBsey782Dwj(sqlQueryMetric) * (double)sqlQueryMetric.CountCall) / (double)(base.CountCall + KWRFgTEZYZkdK1LTmpCv(sqlQueryMetric));
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 5;
				}
				break;
			case 3:
				if (sqlQueryMetric != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 2:
				if (MaxPrepareTime < sqlQueryMetric.MaxPrepareTime)
				{
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 10;
					}
					break;
				}
				goto case 5;
			case 6:
				MaxExecuteTime = JZSogIEZjWysl9Pu9ppZ(sqlQueryMetric);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				AvgExecuteTime = (AvgExecuteTime * (double)base.CountCall + sqlQueryMetric.AvgExecuteTime * (double)sqlQueryMetric.CountCall) / (double)(base.CountCall + KWRFgTEZYZkdK1LTmpCv(sqlQueryMetric));
				num2 = 2;
				break;
			case 8:
				return;
			case 4:
				sqlQueryMetric = metric as SqlQueryMetric;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 3;
				}
				break;
			case 10:
				MaxPrepareTime = A1mS38EZLYAaFg1NkTky(sqlQueryMetric);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 5;
				}
				break;
			default:
				if (MaxExecuteTime < JZSogIEZjWysl9Pu9ppZ(sqlQueryMetric))
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 1;
			case 9:
				TotalAffectedRows += buQEpnEZsrNMVkFK7AlY(sqlQueryMetric);
				num2 = 7;
				break;
			}
		}
	}

	public SqlQueryMetric()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		dycaosEZc2fcLdaoem30();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object o6M3tCEZ50IkCSx53JFa(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool cZf1qnEZr78hj7Aj6Pup()
	{
		return hr6g3cEZlhOSZP6u8VbJ == null;
	}

	internal static SqlQueryMetric g1HPY6EZgd26JRtiGnmN()
	{
		return hr6g3cEZlhOSZP6u8VbJ;
	}

	internal static long JZSogIEZjWysl9Pu9ppZ(object P_0)
	{
		return ((SqlQueryMetric)P_0).MaxExecuteTime;
	}

	internal static long KWRFgTEZYZkdK1LTmpCv(object P_0)
	{
		return ((CountMetric)P_0).CountCall;
	}

	internal static long A1mS38EZLYAaFg1NkTky(object P_0)
	{
		return ((SqlQueryMetric)P_0).MaxPrepareTime;
	}

	internal static double eQ8EJUEZUdBsey782Dwj(object P_0)
	{
		return ((SqlQueryMetric)P_0).AvgPrepareTime;
	}

	internal static long buQEpnEZsrNMVkFK7AlY(object P_0)
	{
		return ((SqlQueryMetric)P_0).TotalAffectedRows;
	}

	internal static void dycaosEZc2fcLdaoem30()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
