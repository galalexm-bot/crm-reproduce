using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Counters;

public abstract class AvgTimeCounter : BaseCounter
{
	private string _counterName;

	private string _counterDescription;

	private string _counterBaseName;

	private PerformanceCounter _counter;

	private PerformanceCounter _counterBase;

	private static AvgTimeCounter Ta88nJEkylTC6r6dFOSY;

	public AvgTimeCounter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		QNwaxwEk9V0qjyyhRIXN();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				_counterName = Name;
				num = 3;
				break;
			case 3:
				_counterDescription = (string)NpfBg3Ekd0MS7r51rpGE(this);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num = 1;
				}
				break;
			case 0:
				return;
			case 1:
				_counterBaseName = SR.T((string)LW5v5iEklMcsqTO78f1f(-1822890472 ^ -1822639586), _counterName);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public void Increment()
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
				RKAYVpEkrh5bPyEfgs16(_counter);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void IncrementBy(long ticks)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				Rwh4owEkgrli0BAPGyAt(_counter, ticks);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				RKAYVpEkrh5bPyEfgs16(_counterBase);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[IteratorStateMachine(typeof(_003CGetCreationData_003Ed__3))]
	protected override IEnumerable<CounterCreationData> GetCreationData()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGetCreationData_003Ed__3(-2)
		{
			_003C_003E4__this = this
		};
	}

	protected override void Init(string category)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				_counterBase = CreateCounter(category, _counterBaseName);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				_counter = CreateCounter(category, _counterName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void QNwaxwEk9V0qjyyhRIXN()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object NpfBg3Ekd0MS7r51rpGE(object P_0)
	{
		return ((BaseCounter)P_0).Description;
	}

	internal static object LW5v5iEklMcsqTO78f1f(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool z4ZrAXEkM8G4SF5EG58d()
	{
		return Ta88nJEkylTC6r6dFOSY == null;
	}

	internal static AvgTimeCounter ajSaTVEkJbRBpaMCONml()
	{
		return Ta88nJEkylTC6r6dFOSY;
	}

	internal static long RKAYVpEkrh5bPyEfgs16(object P_0)
	{
		return ((PerformanceCounter)P_0).Increment();
	}

	internal static long Rwh4owEkgrli0BAPGyAt(object P_0, long P_1)
	{
		return ((PerformanceCounter)P_0).IncrementBy(P_1);
	}
}
