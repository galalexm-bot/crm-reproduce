using System;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Scheduling;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Scheduling;

[Component(Type = ComponentType.Server)]
internal sealed class SchedulerActorInitHandler : IActorInitHandler
{
	internal static SchedulerActorInitHandler nlQFkTBqRugDmwlsO2se;

	public Task Init(IActorModelRuntime actorModelRuntime)
	{
		return (Task)VRHdOWBqXyjC8Pfvsf8H(actorModelRuntime.GetActor<ISchedulerActor>(Guid.Empty));
	}

	public SchedulerActorInitHandler()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		mgAnspBqTHrFnCeEhFRR();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object VRHdOWBqXyjC8Pfvsf8H(object P_0)
	{
		return ((ISchedulerActor)P_0).Start();
	}

	internal static bool JgVlBiBqqtS9iv0CLhQT()
	{
		return nlQFkTBqRugDmwlsO2se == null;
	}

	internal static SchedulerActorInitHandler jAs1FaBqKrj7fEemA2bT()
	{
		return nlQFkTBqRugDmwlsO2se;
	}

	internal static void mgAnspBqTHrFnCeEhFRR()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
