using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Actors;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy;

[Component(Type = ComponentType.Server)]
internal sealed class ContinuedImportActorInitHandler : IActorInitHandler
{
	internal static ContinuedImportActorInitHandler KA8togEO93rUFcLnGsw1;

	public Task Init(IActorModelRuntime actorModelRuntime)
	{
		return actorModelRuntime.GetActor<IImportStartActor>(ImportStartActor.ActorId).ContinueImport();
	}

	public ContinuedImportActorInitHandler()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool sYJtoZEOd8eLv126UYE2()
	{
		return KA8togEO93rUFcLnGsw1 == null;
	}

	internal static ContinuedImportActorInitHandler mXV3FbEOlf1F0mwJrTDZ()
	{
		return KA8togEO93rUFcLnGsw1;
	}
}
