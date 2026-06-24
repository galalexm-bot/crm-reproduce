using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Counters;

public abstract class NumberOfItemsCounter : BaseCounter
{
	private string _counterName;

	private string _counterDescription;

	private PerformanceCounter _counter;

	internal static NumberOfItemsCounter NN9lpXEnil3FmsRMOVdo;

	public NumberOfItemsCounter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		gu6vRnEnKbN9oGuOgJkW();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				_counterDescription = (string)qY7jZVEnTwusFC6QarDO(this);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
				{
					num = 0;
				}
				break;
			case 2:
				_counterName = (string)arGRbfEnXTHppivNH4ia(this);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num = 1;
				}
				break;
			case 0:
				return;
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
				HhQ9M1Enk8QrP8W67s1l(_counter);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void Decrement()
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
				_counter.Decrement();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
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
				wVynclEnnIrtaEHKbDpK(_counter, value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[IteratorStateMachine(typeof(_003CGetCreationData_003Ed__4))]
	protected override IEnumerable<CounterCreationData> GetCreationData()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGetCreationData_003Ed__4(-2)
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
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void gu6vRnEnKbN9oGuOgJkW()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object arGRbfEnXTHppivNH4ia(object P_0)
	{
		return ((BaseCounter)P_0).Name;
	}

	internal static object qY7jZVEnTwusFC6QarDO(object P_0)
	{
		return ((BaseCounter)P_0).Description;
	}

	internal static bool DvW4uVEnRZnen6PDuP79()
	{
		return NN9lpXEnil3FmsRMOVdo == null;
	}

	internal static NumberOfItemsCounter ntCgjUEnqAdRoj5wbMmT()
	{
		return NN9lpXEnil3FmsRMOVdo;
	}

	internal static long HhQ9M1Enk8QrP8W67s1l(object P_0)
	{
		return ((PerformanceCounter)P_0).Increment();
	}

	internal static long wVynclEnnIrtaEHKbDpK(object P_0, long P_1)
	{
		return ((PerformanceCounter)P_0).IncrementBy(P_1);
	}
}
