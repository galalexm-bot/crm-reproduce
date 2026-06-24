using System.Collections.Generic;
using System.Diagnostics;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Counters;

[Component]
public abstract class BaseCounter : IPerformanceCounter
{
	private static BaseCounter r5BHE0EksvG87S82kLLf;

	public abstract string Name { get; }

	public abstract string Description { get; }

	IEnumerable<CounterCreationData> IPerformanceCounter.GetCreationData()
	{
		return GetCreationData();
	}

	void IPerformanceCounter.Init(string category)
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
				Init(category);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected abstract IEnumerable<CounterCreationData> GetCreationData();

	protected abstract void Init(string category);

	protected CounterCreationData CreateCounterData(string name, string description, PerformanceCounterType type)
	{
		CounterCreationData counterCreationData = new CounterCreationData();
		oZeftiEnFncGw9fxrelE(counterCreationData, name);
		GAMqY0EnBaiWIb7l6XfI(counterCreationData, description);
		pRPeO9EnWRNsB6eQexhw(counterCreationData, type);
		return counterCreationData;
	}

	protected PerformanceCounter CreateCounter(string category, string name)
	{
		PerformanceCounter obj = new PerformanceCounter
		{
			CategoryName = category
		};
		zndA8VEno1GHnGlUgTUB(obj, name);
		obj.MachineName = (string)K2XrkJEnblrPiwvD57EO(-1998538950 ^ -1998541314);
		o2nnE3Enhia8fcEYjNEJ(obj, false);
		AvAjW1EnGZ8dritFRfbH(obj, 0L);
		return obj;
	}

	protected BaseCounter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool IGCBVKEkcxha6tIvsWS0()
	{
		return r5BHE0EksvG87S82kLLf == null;
	}

	internal static BaseCounter mfdwaEEkzVUctYDeKxCI()
	{
		return r5BHE0EksvG87S82kLLf;
	}

	internal static void oZeftiEnFncGw9fxrelE(object P_0, object P_1)
	{
		((CounterCreationData)P_0).CounterName = (string)P_1;
	}

	internal static void GAMqY0EnBaiWIb7l6XfI(object P_0, object P_1)
	{
		((CounterCreationData)P_0).CounterHelp = (string)P_1;
	}

	internal static void pRPeO9EnWRNsB6eQexhw(object P_0, PerformanceCounterType P_1)
	{
		((CounterCreationData)P_0).CounterType = P_1;
	}

	internal static void zndA8VEno1GHnGlUgTUB(object P_0, object P_1)
	{
		((PerformanceCounter)P_0).CounterName = (string)P_1;
	}

	internal static object K2XrkJEnblrPiwvD57EO(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void o2nnE3Enhia8fcEYjNEJ(object P_0, bool P_1)
	{
		((PerformanceCounter)P_0).ReadOnly = P_1;
	}

	internal static void AvAjW1EnGZ8dritFRfbH(object P_0, long P_1)
	{
		((PerformanceCounter)P_0).RawValue = P_1;
	}
}
