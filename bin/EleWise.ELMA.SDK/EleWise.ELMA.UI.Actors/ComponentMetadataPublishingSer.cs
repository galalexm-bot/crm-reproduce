using System;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Model;
using EleWise.ELMA.UI.Events;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.Actors;

internal sealed class ComponentMetadataPublishingServerInstanceActor : Actor, IComponentMetadataPublishingServerInstanceActor, IServerPlacementActor, IActorWithGuidKey, IActor
{
	private readonly IComponentMetadataPublishingEventHandler componentMetadataPublishingEventHandler;

	internal static ComponentMetadataPublishingServerInstanceActor GPWqgPBV9AYqDVamM3te;

	public ComponentMetadataPublishingServerInstanceActor(IComponentMetadataPublishingEventHandler componentMetadataPublishingEventHandler)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		USGxQTBVrOV6o1LSsRKB();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
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
			this.componentMetadataPublishingEventHandler = componentMetadataPublishingEventHandler;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
			{
				num = 1;
			}
		}
	}

	public Task PublicationSuccess(Guid componentMetadataUid, UIMetadataPublishResult result)
	{
		return (Task)OrkbkeBVg7D7JRMXQMOc(componentMetadataPublishingEventHandler, componentMetadataUid, result);
	}

	public Task PublicationError(Guid componentMetadataUid, Exception exception)
	{
		return componentMetadataPublishingEventHandler.PublicationError(componentMetadataUid, exception);
	}

	internal static void USGxQTBVrOV6o1LSsRKB()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool EhW4OFBVdOB0MwjW8wgX()
	{
		return GPWqgPBV9AYqDVamM3te == null;
	}

	internal static ComponentMetadataPublishingServerInstanceActor TB3pFgBVlO9QN2yQCYEL()
	{
		return GPWqgPBV9AYqDVamM3te;
	}

	internal static object OrkbkeBVg7D7JRMXQMOc(object P_0, Guid componentMetadataUid, object P_2)
	{
		return ((IComponentMetadataPublishingEventHandler)P_0).PublicationSuccess(componentMetadataUid, (UIMetadataPublishResult)P_2);
	}
}
