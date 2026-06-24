using System;
using EleWise.ELMA.Runtime.Extensions;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Scheduling.Triggers;

public class CustomExecuteTimeTrigger : ITriggerExtension, ITrigger
{
	private TimeSpan overtimeToRun;

	private ITrigger baseTrigger;

	private DateTime executeTime;

	internal static CustomExecuteTimeTrigger ahLDjoBXu4rFAnTFRniq;

	public string Name => (string)dLCgEjBXRMnhGCTxIuXH(baseTrigger);

	public Guid Id => k5QQ9aBXqTrc1u5rVZcH(baseTrigger);

	public ITrigger BaseTrigger => baseTrigger;

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public int? JobResultTimeout => overtimeToRun.Minutes;

	public CustomExecuteTimeTrigger(ITrigger baseTrigger, DateTime executeTime)
	{
		//Discarded unreachable code: IL_0037
		gKVr8iBXSYhQQrYV0VM5();
		overtimeToRun = TimeSpan.FromMinutes(2.0);
		base._002Ector();
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				this.executeTime = Jb61tkBXiHAhHsgGcGkb(executeTime);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				this.baseTrigger = baseTrigger;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public DateTime? GetNextTimeAfter(DateTime? dateTime, DateTime now)
	{
		if (dateTime.HasValue && !(dateTime.Value < executeTime))
		{
			return null;
		}
		return executeTime;
	}

	internal static void gKVr8iBXSYhQQrYV0VM5()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static DateTime Jb61tkBXiHAhHsgGcGkb(DateTime dateTime)
	{
		return dateTime.GetDateTimeWithoutMilliseconds();
	}

	internal static bool gQBIXYBXIMs3mjBS0Nux()
	{
		return ahLDjoBXu4rFAnTFRniq == null;
	}

	internal static CustomExecuteTimeTrigger x2JDfyBXVdeNr7fNLt8Y()
	{
		return ahLDjoBXu4rFAnTFRniq;
	}

	internal static object dLCgEjBXRMnhGCTxIuXH(object P_0)
	{
		return ((ITrigger)P_0).Name;
	}

	internal static Guid k5QQ9aBXqTrc1u5rVZcH(object P_0)
	{
		return ((ITrigger)P_0).Id;
	}
}
