using System;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Metrics.Impl.Processors;

[Component(Order = -5)]
public class CountTimeMetricProcessor : IMetricProcessor
{
	private readonly Type baseMetricAggregatorType;

	internal static CountTimeMetricProcessor W1x4bIEIBL8rbXuN4U6X;

	public Type[] AggregatorTypes => new Type[1] { baseMetricAggregatorType };

	public void Process(object callInfo, IMetric currentMetric)
	{
		//Discarded unreachable code: IL_00ab, IL_00ba
		int num = 1;
		int num2 = num;
		CountTimeMetric countTimeMetric = default(CountTimeMetric);
		IWorkTreeElement workTreeElement = default(IWorkTreeElement);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return;
			case 4:
			{
				CountTimeMetric countTimeMetric2 = countTimeMetric;
				XrbKK0EIG8A2eJAImQFd(countTimeMetric2, XZ4jmsEIbWY9dB1746wn(countTimeMetric2) + AcvPpqEIhqN9u1YNlqva(workTreeElement));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num2 = 7;
				}
				break;
			}
			case 8:
				gWsTg6EIfuOmwMdCgG6F(countTimeMetric, AcvPpqEIhqN9u1YNlqva(workTreeElement).TotalMilliseconds);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 7:
				if (!(s69OZqEIEkNIDV1yxUm2(countTimeMetric) < AcvPpqEIhqN9u1YNlqva(workTreeElement).TotalMilliseconds))
				{
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num2 = 8;
				}
				break;
			default:
				workTreeElement = callInfo as IWorkTreeElement;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num2 = 2;
				}
				break;
			case 6:
				if (countTimeMetric == null)
				{
					return;
				}
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 4;
				}
				break;
			case 3:
				if (workTreeElement == null)
				{
					return;
				}
				num2 = 6;
				break;
			case 1:
				countTimeMetric = currentMetric as CountTimeMetric;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public CountTimeMetricProcessor()
	{
		//Discarded unreachable code: IL_003f, IL_0044
		wB1kWPEIQ75R6vx0ShB1();
		baseMetricAggregatorType = eJZZwEEIC1RQnlCtE94E(typeof(BaseMetricAggregator<>).TypeHandle);
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool K6h9L5EIW6WdrLXDPABq()
	{
		return W1x4bIEIBL8rbXuN4U6X == null;
	}

	internal static CountTimeMetricProcessor xWnZ8DEIoOOVVk6KLblC()
	{
		return W1x4bIEIBL8rbXuN4U6X;
	}

	internal static TimeSpan XZ4jmsEIbWY9dB1746wn(object P_0)
	{
		return ((CountTimeMetric)P_0).TotalTime;
	}

	internal static TimeSpan AcvPpqEIhqN9u1YNlqva(object P_0)
	{
		return ((IWorkTreeElement)P_0).TotalTime;
	}

	internal static void XrbKK0EIG8A2eJAImQFd(object P_0, TimeSpan value)
	{
		((CountTimeMetric)P_0).TotalTime = value;
	}

	internal static double s69OZqEIEkNIDV1yxUm2(object P_0)
	{
		return ((CountTimeMetric)P_0).MaxTime;
	}

	internal static void gWsTg6EIfuOmwMdCgG6F(object P_0, double value)
	{
		((CountTimeMetric)P_0).MaxTime = value;
	}

	internal static void wB1kWPEIQ75R6vx0ShB1()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Type eJZZwEEIC1RQnlCtE94E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
