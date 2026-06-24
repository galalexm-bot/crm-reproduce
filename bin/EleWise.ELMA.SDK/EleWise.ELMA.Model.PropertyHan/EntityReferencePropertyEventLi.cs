using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH.Listeners;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Event;
using NHibernate.Persister.Entity;

namespace EleWise.ELMA.Model.PropertyHandlers;

[Component(Order = 1000000)]
internal class EntityReferencePropertyEventListener : EntityEventsListener
{
	private readonly FindReferenceService refService;

	internal static EntityReferencePropertyEventListener Wu8qg1Ws1COkd20xQ8Rf;

	public EntityReferencePropertyEventListener(FindReferenceService refService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		fAGuiIWspEP91dPV5sel();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
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
			this.refService = refService;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
			{
				num = 1;
			}
		}
	}

	public override bool OnPreDelete(PreDeleteEvent @event)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				duJ88IWsDPhJWDxdSqRj(refService, ((AbstractPreDatabaseOperationEvent)@event).get_Entity() as IEntity, bMFPuAWsa88aDwDNQIDy(((AbstractPreDatabaseOperationEvent)@event).get_Persister()), ((AbstractEvent)@event).get_Session());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return false;
			}
		}
	}

	internal static void fAGuiIWspEP91dPV5sel()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool sDQI18WsNNh8B0n4SwMO()
	{
		return Wu8qg1Ws1COkd20xQ8Rf == null;
	}

	internal static EntityReferencePropertyEventListener Y8DV29Ws3Zveeabftl3e()
	{
		return Wu8qg1Ws1COkd20xQ8Rf;
	}

	internal static object bMFPuAWsa88aDwDNQIDy(object P_0)
	{
		return ((IEntityPersister)P_0).get_EntityName();
	}

	internal static void duJ88IWsDPhJWDxdSqRj(object P_0, object P_1, object P_2, object P_3)
	{
		((FindReferenceService)P_0).DeleteEntityReferences((IEntity)P_1, (string)P_2, (ISession)P_3);
	}
}
