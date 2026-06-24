using System;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Starting;
using EleWise.ELMA.Runtime.Db;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Services;

internal sealed class ClasterInformationService : IClasterInformationService
{
	private readonly IActorModelRuntime actorModelRuntime;

	internal static ClasterInformationService sOx8p3BD22Qufng1sGUO;

	public ClasterInformationService(IActorModelRuntime actorModelRuntime)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.actorModelRuntime = actorModelRuntime;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
			{
				num = 1;
			}
		}
	}

	public Task<DbConnectionStatus> GetStatus(Guid serverConnectionUid)
	{
		return actorModelRuntime.GetActor<IServerInstanceActor>(serverConnectionUid).GetStatus();
	}

	internal static bool cuxU40BDeq3iwGPafd3n()
	{
		return sOx8p3BD22Qufng1sGUO == null;
	}

	internal static ClasterInformationService auSCqCBDPsdFt5YohRMu()
	{
		return sOx8p3BD22Qufng1sGUO;
	}
}
