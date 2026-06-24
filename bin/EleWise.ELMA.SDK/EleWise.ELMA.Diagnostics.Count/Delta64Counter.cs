using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Counters;

public abstract class Delta64Counter : BaseCounter
{
	private string _counterName;

	private string _counterDescription;

	private PerformanceCounter _counter;

	internal static Delta64Counter HMT5reEn8FvtXEwF6P0J;

	public Delta64Counter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		JH5V3VEnIm07OHll28tM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
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
				_counterDescription = (string)AUajJEEnVuC0VTuQX5Gr(this);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
				{
					num = 0;
				}
				break;
			case 2:
				_counterName = Name;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
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
			case 1:
				xMotDjEnSlyIiF309Vug(_counter);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
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
			case 1:
				_counter.IncrementBy(value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
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
			case 0:
				return;
			case 1:
				_counter = CreateCounter(category, _counterName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void JH5V3VEnIm07OHll28tM()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object AUajJEEnVuC0VTuQX5Gr(object P_0)
	{
		return ((BaseCounter)P_0).Description;
	}

	internal static bool k5OqfSEnZpfT5HIAepHU()
	{
		return HMT5reEn8FvtXEwF6P0J == null;
	}

	internal static Delta64Counter eMZmxcEnuOVyMRwsdLVN()
	{
		return HMT5reEn8FvtXEwF6P0J;
	}

	internal static long xMotDjEnSlyIiF309Vug(object P_0)
	{
		return ((PerformanceCounter)P_0).Increment();
	}
}
