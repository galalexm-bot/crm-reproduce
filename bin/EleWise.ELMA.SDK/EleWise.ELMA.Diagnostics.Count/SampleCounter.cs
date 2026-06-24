using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Counters;

public abstract class SampleCounter : BaseCounter
{
	private string _counterName;

	private string _counterDescription;

	private PerformanceCounter _counter;

	private static SampleCounter tuxSs8EnO9TQN8VJDaqE;

	public SampleCounter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		aQa0MWEnPaWM8PlQtwrc();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			default:
				_counterName = Name;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
				{
					num = 1;
				}
				break;
			case 2:
				_counterDescription = (string)syTECrEn1dwo9btbD5iv(this);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num = 1;
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
			case 1:
				_counter.Increment();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
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
				return;
			case 0:
				return;
			case 1:
				_counter.IncrementBy(value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
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
			default:
				return;
			case 1:
				_counter = CreateCounter(category, _counterName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void aQa0MWEnPaWM8PlQtwrc()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object syTECrEn1dwo9btbD5iv(object P_0)
	{
		return ((BaseCounter)P_0).Description;
	}

	internal static bool I1uvlyEn2mAf2PxRHRHf()
	{
		return tuxSs8EnO9TQN8VJDaqE == null;
	}

	internal static SampleCounter SRrQ1vEneCCYmFmwDJ4Z()
	{
		return tuxSs8EnO9TQN8VJDaqE;
	}
}
