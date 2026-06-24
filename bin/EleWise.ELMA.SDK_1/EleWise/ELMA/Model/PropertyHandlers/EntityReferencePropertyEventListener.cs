// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.PropertyHandlers.EntityReferencePropertyEventListener
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH.Listeners;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Event;
using NHibernate.Persister.Entity;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.PropertyHandlers
{
  [Component(Order = 1000000)]
  internal class EntityReferencePropertyEventListener : EntityEventsListener
  {
    private readonly FindReferenceService refService;
    internal static EntityReferencePropertyEventListener Wu8qg1Ws1COkd20xQ8Rf;

    public EntityReferencePropertyEventListener(FindReferenceService refService)
    {
      EntityReferencePropertyEventListener.fAGuiIWspEP91dPV5sel();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.refService = refService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    public override bool OnPreDelete(PreDeleteEvent @event)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            EntityReferencePropertyEventListener.duJ88IWsDPhJWDxdSqRj((object) this.refService, (object) (@event.Entity as IEntity), EntityReferencePropertyEventListener.bMFPuAWsa88aDwDNQIDy((object) @event.Persister), (object) @event.Session);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return false;
    }

    internal static void fAGuiIWspEP91dPV5sel() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool sDQI18WsNNh8B0n4SwMO() => EntityReferencePropertyEventListener.Wu8qg1Ws1COkd20xQ8Rf == null;

    internal static EntityReferencePropertyEventListener Y8DV29Ws3Zveeabftl3e() => EntityReferencePropertyEventListener.Wu8qg1Ws1COkd20xQ8Rf;

    internal static object bMFPuAWsa88aDwDNQIDy([In] object obj0) => (object) ((IEntityPersister) obj0).EntityName;

    internal static void duJ88IWsDPhJWDxdSqRj([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((FindReferenceService) obj0).DeleteEntityReferences((IEntity) obj1, (string) obj2, (ISession) obj3);
  }
}
