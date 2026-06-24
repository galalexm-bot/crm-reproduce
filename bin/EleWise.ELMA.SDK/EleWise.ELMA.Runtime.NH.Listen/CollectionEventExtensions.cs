using j3AmrhgkCleVTGdEwA;
using NHibernate.Collection;
using NHibernate.Event;
using NHibernate.Persister.Collection;

namespace EleWise.ELMA.Runtime.NH.Listeners;

public static class CollectionEventExtensions
{
	private class Helper : AbstractCollectionEvent
	{
		internal static object LTpOftQjPION9k46MR2h;

		public Helper(ICollectionPersister collectionPersister, IPersistentCollection collection, IEventSource source, object affectedOwner, object affectedOwnerId)
		{
			//Discarded unreachable code: IL_0031, IL_0036
			rSxAMtQj36wFx5iRvrMR();
			((AbstractCollectionEvent)this)._002Ector(collectionPersister, collection, source, affectedOwner, affectedOwnerId);
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public static ICollectionPersister GetCollectionPersister(object collectionEvent)
		{
			return (ICollectionPersister)YHO3qXQjDNrnY6k2u4PV(Ny8DpCQjpcdPFgMgcPOO(collectionEvent), KJkmrQQjaG6l8YsHXfva(collectionEvent));
		}

		internal static void rSxAMtQj36wFx5iRvrMR()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool vJhAFpQj1PEt0F21mgPW()
		{
			return LTpOftQjPION9k46MR2h == null;
		}

		internal static Helper fDnKTwQjNOPBitDD9J7x()
		{
			return (Helper)LTpOftQjPION9k46MR2h;
		}

		internal static object Ny8DpCQjpcdPFgMgcPOO(object P_0)
		{
			return ((AbstractCollectionEvent)P_0).get_Collection();
		}

		internal static object KJkmrQQjaG6l8YsHXfva(object P_0)
		{
			return ((AbstractEvent)P_0).get_Session();
		}

		internal static object YHO3qXQjDNrnY6k2u4PV(object P_0, object P_1)
		{
			return AbstractCollectionEvent.GetLoadedCollectionPersister((IPersistentCollection)P_0, (IEventSource)P_1);
		}
	}

	public static ICollectionPersister GetCollectionPersister(this AbstractCollectionEvent collectionEvent)
	{
		return Helper.GetCollectionPersister(collectionEvent);
	}
}
