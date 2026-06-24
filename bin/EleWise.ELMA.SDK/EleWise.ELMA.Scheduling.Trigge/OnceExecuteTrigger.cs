using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Scheduling.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Scheduling.Triggers;

public class OnceExecuteTrigger : ITriggerExtension, ITrigger
{
	private TimeSpan overtimeToRun;

	private readonly DateTime executeTime;

	private Func<ISchedulerTask> _taskAccessor;

	internal static OnceExecuteTrigger jlmy2HBXeMHcdmXbqs2u;

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return _003CName_003Ek__BackingField;
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
					_003CName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Guid Id
	{
		[CompilerGenerated]
		get
		{
			return _003CId_003Ek__BackingField;
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
					_003CId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public TimeSpan OvertimeToRun
	{
		get
		{
			return overtimeToRun;
		}
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
					overtimeToRun = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	internal ISchedulerTask Task
	{
		get
		{
			//Discarded unreachable code: IL_0052, IL_0061
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (_taskAccessor != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 2:
					return null;
				default:
					return _taskAccessor();
				}
			}
		}
	}

	public int? JobResultTimeout => null;

	public OnceExecuteTrigger([NotNull] ISchedulerTask task)
	{
		//Discarded unreachable code: IL_0050, IL_0055
		H0DeQ5BXN0jlgcGIW6wd();
		_003C_003Ec__DisplayClass0_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass0_0();
		CS_0024_003C_003E8__locals0.task = task;
		this._002Ector(() => CS_0024_003C_003E8__locals0.task);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public OnceExecuteTrigger([NotNull] Func<ISchedulerTask> taskAccessor)
	{
		SingletonReader.JJCZtPuTvSt();
		overtimeToRun = TimeSpan.MaxValue;
		base._002Ector();
		if (taskAccessor == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE130C77));
		}
		_taskAccessor = taskAccessor;
		ISchedulerTask schedulerTask = taskAccessor();
		if (schedulerTask == null)
		{
			throw new ArgumentException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-538519530 ^ -538444350));
		}
		if (!schedulerTask.OnceExecuteTime.HasValue)
		{
			throw new ArgumentException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A60104E));
		}
		executeTime = schedulerTask.OnceExecuteTime.Value;
	}

	public DateTime? GetNextTimeAfter(DateTime? dateTime, DateTime now)
	{
		if (dateTime.HasValue)
		{
			return null;
		}
		return executeTime;
	}

	internal static void H0DeQ5BXN0jlgcGIW6wd()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool cspBiABXPLvkxrIogIP5()
	{
		return jlmy2HBXeMHcdmXbqs2u == null;
	}

	internal static OnceExecuteTrigger vhntu6BX1CEoMMapFdqa()
	{
		return jlmy2HBXeMHcdmXbqs2u;
	}
}
