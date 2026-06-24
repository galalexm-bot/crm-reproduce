using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Metrics;

public class CountTimeMetric : CountMetric
{
	internal static class __CountTimeMetricLocalization
	{
		private static __CountTimeMetricLocalization WaySXv8KKuTBZ0wSoNr6;

		public static string TotalTime => SR.T((string)DATF6f8KkG0jYW7S1BSG(0x5A4C7B29 ^ 0x5A499FED));

		public static string MaxTime => (string)gFkxM28KnZG0HnFqR6P7(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195899911));

		public static string AvgTime => (string)gFkxM28KnZG0HnFqR6P7(DATF6f8KkG0jYW7S1BSG(-309639236 ^ -309419392));

		internal static object DATF6f8KkG0jYW7S1BSG(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static bool C1wFSr8KXxoJcs38Vkro()
		{
			return WaySXv8KKuTBZ0wSoNr6 == null;
		}

		internal static __CountTimeMetricLocalization NEEk1Y8KTLFMdWGfos6c()
		{
			return WaySXv8KKuTBZ0wSoNr6;
		}

		internal static object gFkxM28KnZG0HnFqR6P7(object P_0)
		{
			return SR.T((string)P_0);
		}
	}

	private static CountTimeMetric qnSHXUE8UmYIEc04qaeZ;

	public override Guid Uid => new Guid((string)PKUr6NE8zfO9btf1T710(-1822890472 ^ -1822644134));

	[Order(300)]
	[DisplayName(typeof(__CountTimeMetricLocalization), "TotalTime")]
	public TimeSpan TotalTime
	{
		[CompilerGenerated]
		get
		{
			return _003CTotalTime_003Ek__BackingField;
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
					_003CTotalTime_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Order(400)]
	[DisplayName(typeof(__CountTimeMetricLocalization), "MaxTime")]
	public double MaxTime
	{
		[CompilerGenerated]
		get
		{
			return _003CMaxTime_003Ek__BackingField;
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
					_003CMaxTime_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Order(500)]
	[DisplayName(typeof(__CountTimeMetricLocalization), "AvgTime")]
	public double AvgTime
	{
		get
		{
			int num = 1;
			int num2 = num;
			TimeSpan totalTime = default(TimeSpan);
			while (true)
			{
				switch (num2)
				{
				case 1:
					totalTime = TotalTime;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					return totalTime.TotalMilliseconds / (double)base.CountCall;
				}
			}
		}
	}

	public override void Merge(IMetric metric)
	{
		int num = 1;
		int num2 = num;
		CountTimeMetric countTimeMetric = default(CountTimeMetric);
		while (true)
		{
			switch (num2)
			{
			case 5:
				base.Merge(metric);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num2 = 2;
				}
				continue;
			case 1:
				countTimeMetric = metric as CountTimeMetric;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				if (MaxTime < wKYxRTEZFYd0f0L2Uwxn(countTimeMetric))
				{
					num2 = 6;
					continue;
				}
				return;
			case 3:
				return;
			case 6:
				MaxTime = wKYxRTEZFYd0f0L2Uwxn(countTimeMetric);
				num2 = 3;
				continue;
			case 2:
				TotalTime += countTimeMetric.TotalTime;
				num2 = 4;
				continue;
			}
			if (countTimeMetric == null)
			{
				return;
			}
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
			{
				num2 = 5;
			}
		}
	}

	public CountTimeMetric()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		KgngorEZBawqN5syCwXD();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object PKUr6NE8zfO9btf1T710(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool BC8XwLE8skPS62s2cjRI()
	{
		return qnSHXUE8UmYIEc04qaeZ == null;
	}

	internal static CountTimeMetric A7gSaoE8cNaCcdR5nFID()
	{
		return qnSHXUE8UmYIEc04qaeZ;
	}

	internal static double wKYxRTEZFYd0f0L2Uwxn(object P_0)
	{
		return ((CountTimeMetric)P_0).MaxTime;
	}

	internal static void KgngorEZBawqN5syCwXD()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
