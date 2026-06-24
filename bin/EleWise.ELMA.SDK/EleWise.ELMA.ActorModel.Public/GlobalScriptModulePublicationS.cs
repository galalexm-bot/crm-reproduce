using System;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ActorModel.Publication;

internal sealed class GlobalScriptModulePublicationServerInstanceActor : Actor, IGlobalScriptModulePublicationServerInstanceActor, IServerPlacementActor, IActorWithGuidKey, IActor
{
	private readonly IGlobalScriptModulePublicationEventHandler globalScriptModulePublicationEventHandler;

	private static GlobalScriptModulePublicationServerInstanceActor F5pGu8fpStVb8ofKGXdC;

	public GlobalScriptModulePublicationServerInstanceActor(IGlobalScriptModulePublicationEventHandler globalScriptModulePublicationEventHandler)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		BsKGWpfpqQoRLOx9GFYH();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				this.globalScriptModulePublicationEventHandler = globalScriptModulePublicationEventHandler;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public Task PublicationError(long globalScriptModuleId, Exception exception)
	{
		return (Task)PmYfvEfpKl8iPgyjKs3Q(globalScriptModulePublicationEventHandler, globalScriptModuleId, exception);
	}

	public Task PublicationSuccess(long globalScriptModuleId)
	{
		return (Task)Pa8Q6JfpXyjMAKqxZak1(globalScriptModulePublicationEventHandler, globalScriptModuleId);
	}

	internal static void BsKGWpfpqQoRLOx9GFYH()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool NdofeNfpitXxv4Y5E6w9()
	{
		return F5pGu8fpStVb8ofKGXdC == null;
	}

	internal static GlobalScriptModulePublicationServerInstanceActor zOPjGwfpR8vRKVAP9WwE()
	{
		return F5pGu8fpStVb8ofKGXdC;
	}

	internal static object PmYfvEfpKl8iPgyjKs3Q(object P_0, long globalScriptModuleId, object P_2)
	{
		return ((IGlobalScriptModulePublicationEventHandler)P_0).Error(globalScriptModuleId, (Exception)P_2);
	}

	internal static object Pa8Q6JfpXyjMAKqxZak1(object P_0, long globalScriptModuleId)
	{
		return ((IGlobalScriptModulePublicationEventHandler)P_0).Complete(globalScriptModuleId);
	}
}
