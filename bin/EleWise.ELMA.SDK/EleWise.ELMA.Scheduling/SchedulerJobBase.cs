using System;
using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Scheduling;

public abstract class SchedulerJobBase : ISchedulerJob, IHiddenSchedulerJob
{
	internal static SchedulerJobBase oXXw3ABK9GSdrbYI83fx;

	public virtual Guid? OwnerUid => null;

	public abstract ITrigger Trigger { get; }

	public abstract ICollection<IJob> Jobs { get; }

	public virtual bool Hidden => false;

	protected SchedulerJobBase()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		B39bJkBKrvM5vWW11NXa();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void B39bJkBKrvM5vWW11NXa()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool hhePJgBKd2kPlFc2TJBM()
	{
		return oXXw3ABK9GSdrbYI83fx == null;
	}

	internal static SchedulerJobBase uEx0lxBKlihPGHmtmrP3()
	{
		return oXXw3ABK9GSdrbYI83fx;
	}
}
