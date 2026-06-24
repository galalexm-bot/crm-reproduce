using System;
using System.Linq;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Scheduling.Managers;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Scheduling;

public static class TriggerExtensions
{
	internal static TriggerExtensions m4LWELBKhYljBYKhiFg2;

	public static DateTime? GetNextTimeAfterUnfolded(this ITrigger trigger, DateTime? latestDateOfRun, DateTime now)
	{
		_003C_003Ec__DisplayClass0_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass0_0();
		CS_0024_003C_003E8__locals0.trigger = trigger;
		CS_0024_003C_003E8__locals0.now = now;
		DateTime? first = null;
		try
		{
			first = CS_0024_003C_003E8__locals0.trigger.GetNextTimeAfter(latestDateOfRun, CS_0024_003C_003E8__locals0.now);
		}
		catch (Exception exception)
		{
			if (Logger.Log.IsErrorEnabled())
			{
				Logger.Log.Error(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34A6D230 ^ 0x34A7CCCC)), exception);
			}
		}
		if (!first.HasValue)
		{
			if (Logger.Log.IsDebugEnabled())
			{
				Logger.Log.Debug(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812095702), CS_0024_003C_003E8__locals0.trigger));
			}
			return null;
		}
		try
		{
			return CollectionExtensions.Unfold(first, delegate(DateTime? d)
			{
				DateTime? nextTimeAfter = CS_0024_003C_003E8__locals0.trigger.GetNextTimeAfter(d, CS_0024_003C_003E8__locals0.now);
				if (d >= nextTimeAfter)
				{
					throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103A9A21), nextTimeAfter, d));
				}
				return nextTimeAfter;
			}, (DateTime? d) => d.HasValue && d.Value <= CS_0024_003C_003E8__locals0.now).ToList().LastOrDefault((DateTime? d) => d.HasValue && d.Value <= CS_0024_003C_003E8__locals0.now && CS_0024_003C_003E8__locals0.now - d.Value <= CS_0024_003C_003E8__locals0.trigger.OvertimeToRun);
		}
		catch (Exception exception2)
		{
			Logger.Log.Error(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107911172), CS_0024_003C_003E8__locals0.trigger.Name, CS_0024_003C_003E8__locals0.trigger.Id), exception2);
			return null;
		}
	}

	internal static TimeSpan GetTriggerTimeout(this ITrigger trigger)
	{
		//Discarded unreachable code: IL_0098
		int num = 5;
		int num2 = num;
		ITriggerExtension triggerExtension = default(ITriggerExtension);
		int num3;
		int? jobResultTimeout = default(int?);
		while (true)
		{
			switch (num2)
			{
			case 5:
				triggerExtension = trigger as ITriggerExtension;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num2 = 3;
				}
				continue;
			case 4:
				if (triggerExtension != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 2;
			case 7:
				num3 = 1;
				break;
			case 6:
				if (!jobResultTimeout.HasValue)
				{
					num2 = 2;
					continue;
				}
				jobResultTimeout = triggerExtension.JobResultTimeout;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return SchedulerJobRunInfoManager.GetJobRunInfoTtl();
			case 1:
				jobResultTimeout = triggerExtension.JobResultTimeout;
				num2 = 6;
				continue;
			default:
				if (jobResultTimeout.Value > 0)
				{
					jobResultTimeout = triggerExtension.JobResultTimeout;
					num2 = 3;
				}
				else
				{
					num2 = 7;
				}
				continue;
			case 3:
				num3 = jobResultTimeout.Value;
				break;
			}
			break;
		}
		return LwoQxJBKfq0wTMRFWJ8F(num3);
	}

	internal static TimeSpan LwoQxJBKfq0wTMRFWJ8F(double P_0)
	{
		return TimeSpan.FromMinutes(P_0);
	}

	internal static bool ov7OC8BKG6IVNcS2WqIN()
	{
		return m4LWELBKhYljBYKhiFg2 == null;
	}

	internal static TriggerExtensions cP0jO7BKEkdD5pAbuFyd()
	{
		return m4LWELBKhYljBYKhiFg2;
	}
}
