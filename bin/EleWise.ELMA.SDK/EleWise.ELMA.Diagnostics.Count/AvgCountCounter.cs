using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Counters;

public abstract class AvgCountCounter : BaseCounter
{
	private string _counterName;

	private string _counterDescription;

	private string _counterBaseName;

	private PerformanceCounter _counter;

	private PerformanceCounter _counterBase;

	internal static AvgCountCounter HQZRk3Ek41rw5bdKQYOu;

	public AvgCountCounter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				_counterName = (string)NL4PkVEkACTWTthC3aOO(this);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num = 2;
				}
				break;
			case 1:
				return;
			case 2:
				_counterDescription = (string)qISOMyEk7MlKttVshVQY(this);
				num = 3;
				break;
			case 3:
				_counterBaseName = SR.T((string)FSjQOPEkxyJs7WuSr3kJ(-576149596 ^ -575865950), _counterName);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
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
				_counter.Increment();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void IncrementBy(long value)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				TflRJjEkmeCeypnSyjOl(_counterBase);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				MkXk8yEk0ile0iQmWGnC(_counter, value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
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
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				_counter = CreateCounter(category, _counterName);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				_counterBase = CreateCounter(category, _counterBaseName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object NL4PkVEkACTWTthC3aOO(object P_0)
	{
		return ((BaseCounter)P_0).Name;
	}

	internal static object qISOMyEk7MlKttVshVQY(object P_0)
	{
		return ((BaseCounter)P_0).Description;
	}

	internal static object FSjQOPEkxyJs7WuSr3kJ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool auBtNTEk6yp6vSxw8wSg()
	{
		return HQZRk3Ek41rw5bdKQYOu == null;
	}

	internal static AvgCountCounter ODgfS0EkHH14882CHrYA()
	{
		return HQZRk3Ek41rw5bdKQYOu;
	}

	internal static long MkXk8yEk0ile0iQmWGnC(object P_0, long P_1)
	{
		return ((PerformanceCounter)P_0).IncrementBy(P_1);
	}

	internal static long TflRJjEkmeCeypnSyjOl(object P_0)
	{
		return ((PerformanceCounter)P_0).Increment();
	}
}
