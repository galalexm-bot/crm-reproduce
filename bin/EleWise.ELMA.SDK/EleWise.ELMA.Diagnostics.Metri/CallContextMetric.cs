using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Metrics;

public class CallContextMetric : CountTimeMetric
{
	internal static class __CallContextMetricLocalization
	{
		private static __CallContextMetricLocalization mVVuqs8KvmOqnajKjSLH;

		public static string TotalProcessorTime => (string)CTIh428KIQ6L8Yj5JBOi(fUCrrb8KuoFMKIRZeplv(0x3CE17B75 ^ 0x3CE498B7));

		public static string UserProcessorTime => (string)CTIh428KIQ6L8Yj5JBOi(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1ECE530A ^ 0x1ECBB71A));

		internal static object fUCrrb8KuoFMKIRZeplv(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object CTIh428KIQ6L8Yj5JBOi(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool MpWXmW8K8P5Ybkxdocfc()
		{
			return mVVuqs8KvmOqnajKjSLH == null;
		}

		internal static __CallContextMetricLocalization ROiIAn8KZLwahBTiRlfG()
		{
			return mVVuqs8KvmOqnajKjSLH;
		}
	}

	private static CallContextMetric zWEAaPE8mxPX4RbqKZvV;

	public override Guid Uid => new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x57A5235E ^ 0x57A16EFC));

	[Order(310)]
	[DisplayName(typeof(__CallContextMetricLocalization), "TotalProcessorTime")]
	public TimeSpan TotalProcessorTime
	{
		[CompilerGenerated]
		get
		{
			return _003CTotalProcessorTime_003Ek__BackingField;
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
					_003CTotalProcessorTime_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DisplayName(typeof(__CallContextMetricLocalization), "UserProcessorTime")]
	[Order(320)]
	public TimeSpan UserProcessorTime
	{
		[CompilerGenerated]
		get
		{
			return _003CUserProcessorTime_003Ek__BackingField;
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
					_003CUserProcessorTime_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
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

	public MetricsContainer Metrics
	{
		[CompilerGenerated]
		get
		{
			return _003CMetrics_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CMetrics_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public CallContextMetric()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Tjiw09E8JSJv1cA0m2dw();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
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
			Metrics = new MetricsContainer();
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
			{
				num = 1;
			}
		}
	}

	public override void Merge(IMetric metric)
	{
		//Discarded unreachable code: IL_00e4
		int num = 7;
		int num2 = num;
		CallContextMetric callContextMetric = default(CallContextMetric);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				UserProcessorTime = U77PE9E8dtsTVdMv2T8d(UserProcessorTime, callContextMetric.UserProcessorTime);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				if (callContextMetric == null)
				{
					num2 = 2;
					break;
				}
				goto case 5;
			case 5:
				base.Merge(metric);
				num2 = 4;
				break;
			case 1:
				Metrics.Merge((MetricsContainer)ECkq38E8lbLBflDIb6B0(callContextMetric));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				TotalProcessorTime = U77PE9E8dtsTVdMv2T8d(TotalProcessorTime, GtaK77E895pCRy84iPik(callContextMetric));
				num2 = 3;
				break;
			case 0:
				return;
			case 2:
				return;
			case 7:
				callContextMetric = metric as CallContextMetric;
				num2 = 6;
				break;
			}
		}
	}

	internal static void Tjiw09E8JSJv1cA0m2dw()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool oZ7AucE8ycBovdOQsUF9()
	{
		return zWEAaPE8mxPX4RbqKZvV == null;
	}

	internal static CallContextMetric qGeutME8M7SniqJj9ADy()
	{
		return zWEAaPE8mxPX4RbqKZvV;
	}

	internal static TimeSpan GtaK77E895pCRy84iPik(object P_0)
	{
		return ((CallContextMetric)P_0).TotalProcessorTime;
	}

	internal static TimeSpan U77PE9E8dtsTVdMv2T8d(TimeSpan P_0, TimeSpan P_1)
	{
		return P_0 + P_1;
	}

	internal static object ECkq38E8lbLBflDIb6B0(object P_0)
	{
		return ((CallContextMetric)P_0).Metrics;
	}
}
