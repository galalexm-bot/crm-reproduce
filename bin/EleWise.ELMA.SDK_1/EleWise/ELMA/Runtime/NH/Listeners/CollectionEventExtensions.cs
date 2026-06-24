// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.Listeners.CollectionEventExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using NHibernate.Collection;
using NHibernate.Event;
using NHibernate.Persister.Collection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.NH.Listeners
{
  public static class CollectionEventExtensions
  {
    public static ICollectionPersister GetCollectionPersister(
      this AbstractCollectionEvent collectionEvent)
    {
      return CollectionEventExtensions.Helper.GetCollectionPersister((object) collectionEvent);
    }

    private class Helper : AbstractCollectionEvent
    {
      internal static object LTpOftQjPION9k46MR2h;

      public Helper(
        ICollectionPersister collectionPersister,
        IPersistentCollection collection,
        IEventSource source,
        object affectedOwner,
        object affectedOwnerId)
      {
        CollectionEventExtensions.Helper.rSxAMtQj36wFx5iRvrMR();
        // ISSUE: explicit constructor call
        base.\u002Ector(collectionPersister, collection, source, affectedOwner, affectedOwnerId);
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      public static ICollectionPersister GetCollectionPersister(object collectionEvent) => (ICollectionPersister) CollectionEventExtensions.Helper.YHO3qXQjDNrnY6k2u4PV(CollectionEventExtensions.Helper.Ny8DpCQjpcdPFgMgcPOO(collectionEvent), CollectionEventExtensions.Helper.KJkmrQQjaG6l8YsHXfva(collectionEvent));

      internal static void rSxAMtQj36wFx5iRvrMR() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool vJhAFpQj1PEt0F21mgPW() => CollectionEventExtensions.Helper.LTpOftQjPION9k46MR2h == null;

      internal static CollectionEventExtensions.Helper fDnKTwQjNOPBitDD9J7x() => (CollectionEventExtensions.Helper) CollectionEventExtensions.Helper.LTpOftQjPION9k46MR2h;

      internal static object Ny8DpCQjpcdPFgMgcPOO([In] object obj0) => (object) ((AbstractCollectionEvent) obj0).Collection;

      internal static object KJkmrQQjaG6l8YsHXfva([In] object obj0) => (object) ((AbstractEvent) obj0).Session;

      internal static object YHO3qXQjDNrnY6k2u4PV([In] object obj0, [In] object obj1) => (object) AbstractCollectionEvent.GetLoadedCollectionPersister((IPersistentCollection) obj0, (IEventSource) obj1);
    }
  }
}
