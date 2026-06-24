using System;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Actors;

internal sealed class CustomActivityPublicationServerInstanceActor : Actor, ICustomActivityPublicationServerInstanceActor, IServerPlacementActor, IActorWithGuidKey, IActor
{
	private readonly ICustomActivityPublicationEventHandler customActivityPublicationEventHandler;

	internal static CustomActivityPublicationServerInstanceActor dGl1ivmwsSYCvq87WqI;

	public CustomActivityPublicationServerInstanceActor(ICustomActivityPublicationEventHandler customActivityPublicationEventHandler)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e496a9998cf542ff98d1a5e001d6c664 == 0)
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
			this.customActivityPublicationEventHandler = customActivityPublicationEventHandler;
			num = 0;
			if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_931b467c9a154e15b6f12c7011275615 == 0)
			{
				num = 1;
			}
		}
	}

	public Task PublicationSuccess(long customActivityId)
	{
		return (Task)fyaRwMm2XJTRjrq4QlP(customActivityPublicationEventHandler, customActivityId);
	}

	public Task PublicationError(long customActivityId, Exception exception)
	{
		return (Task)zDbYf1mqMxPuJy5TvNd(customActivityPublicationEventHandler, customActivityId, exception);
	}

	internal static bool s1LeL6mt2KMbugnGQrg()
	{
		return dGl1ivmwsSYCvq87WqI == null;
	}

	internal static CustomActivityPublicationServerInstanceActor tSK5TTmsrnpUkVZMxcW()
	{
		return dGl1ivmwsSYCvq87WqI;
	}

	internal static object fyaRwMm2XJTRjrq4QlP(object P_0, long customActivityId)
	{
		return ((ICustomActivityPublicationEventHandler)P_0).Complete(customActivityId);
	}

	internal static object zDbYf1mqMxPuJy5TvNd(object P_0, long customActivityId, object P_2)
	{
		return ((ICustomActivityPublicationEventHandler)P_0).Error(customActivityId, (Exception)P_2);
	}
}
