// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.SoftDeleteEventListener
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Engine;
using NHibernate.Event;
using NHibernate.Event.Default;
using NHibernate.Persister.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Runtime.NH
{
  /// <summary>
  /// Прослушиватель событий удаления для обеспечения "мягкого" удаления
  /// </summary>
  [Serializable]
  public class SoftDeleteEventListener : DefaultDeleteEventListener
  {
    private static SoftDeleteEventListener cweFJvWHhdMH1pv9eLZn;

    protected override void DeleteEntity(
      IEventSource session,
      object entity,
      EntityEntry entityEntry,
      bool isCascadeDeleteEnabled,
      IEntityPersister persister,
      ISet<object> transientEntities)
    {
      if (entity is ISoftDeletable && !((ISoftDeletable) entity).HardDelete)
      {
        ISoftDeletable softDeletable = (ISoftDeletable) entity;
        this.CascadeBeforeDelete(session, persister, entity, entityEntry, transientEntities);
        softDeletable.IsDeleted = true;
        this.CascadeAfterDelete(session, persister, entity, transientEntities);
        if (!(entity is IEntity<long>))
          return;
        IEnumerable<ILastObjectProvider> extensionPoints = ComponentManager.Current.GetExtensionPoints<ILastObjectProvider>();
        ClassMetadata metadata = MetadataLoader.LoadMetadata(entity.GetType()) as ClassMetadata;
        if (metadata == null)
          return;
        extensionPoints.FirstOrDefault<ILastObjectProvider>((Func<ILastObjectProvider, bool>) (t =>
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (!SoftDeleteEventListener.\u003C\u003Ec__DisplayClass0_0.dJ6qBmQlcTQZMSvXiHmF(SoftDeleteEventListener.\u003C\u003Ec__DisplayClass0_0.cmXiAQQlsegeAGSiKFu6((object) t), metadata.Uid))
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 0;
                  continue;
                }
                goto label_5;
              default:
                goto label_4;
            }
          }
label_4:
          // ISSUE: reference to a compiler-generated method
          return MetadataLoader.IsBaseClass(SoftDeleteEventListener.\u003C\u003Ec__DisplayClass0_0.cmXiAQQlsegeAGSiKFu6((object) t), metadata);
label_5:
          return true;
        }))?.RemoveInfo((IEntity<long>) entity);
      }
      else
      {
        if (MetadataLoader.LoadMetadata(entity.GetType()) is TablePartMetadata && entity.CastAsRealType() is ITablePartItem tablePartItem && tablePartItem.Parent.CastAsRealType<IEntity>() is ISoftDeletable softDeletable && !softDeletable.HardDelete)
          return;
        base.DeleteEntity(session, entity, entityEntry, isCascadeDeleteEnabled, persister, transientEntities);
      }
    }

    public SoftDeleteEventListener()
    {
      SoftDeleteEventListener.mFLB2tWHfBGPhU91DHBY();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void mFLB2tWHfBGPhU91DHBY() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool HUljmJWHGQGu0Ic5D58C() => SoftDeleteEventListener.cweFJvWHhdMH1pv9eLZn == null;

    internal static SoftDeleteEventListener c70wbDWHEoiKMT52EnoQ() => SoftDeleteEventListener.cweFJvWHhdMH1pv9eLZn;
  }
}
