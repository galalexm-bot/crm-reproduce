using System;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Actors;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy;

[Component(Type = ComponentType.Server)]
internal sealed class ModuleAutoDeployActorInitHandler : IActorInitHandler
{
	private static ModuleAutoDeployActorInitHandler L3yLd6E2ORMFoUmD35Zm;

	public Task Init(IActorModelRuntime actorModelRuntime)
	{
		return actorModelRuntime.GetActor<IModuleAutoDeployActor>(Guid.Empty).StartWatching();
	}

	public ModuleAutoDeployActorInitHandler()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		WKUOqjE2PmEjMYN9f5i8();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool Y1VgerE22YB4kfRiWSy3()
	{
		return L3yLd6E2ORMFoUmD35Zm == null;
	}

	internal static ModuleAutoDeployActorInitHandler LwZY0pE2eQr1hlLHqtbp()
	{
		return L3yLd6E2ORMFoUmD35Zm;
	}

	internal static void WKUOqjE2PmEjMYN9f5i8()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
