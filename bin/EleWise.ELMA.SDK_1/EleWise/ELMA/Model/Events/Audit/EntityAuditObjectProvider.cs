// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Events.Audit.EntityAuditObjectProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Model.Events.Audit
{
  /// <summary>Провайдер объектов аудита для сущностей</summary>
  [Component]
  public class EntityAuditObjectProvider : IAuditObjectProvider
  {
    private readonly IDictionary<Guid, IAuditObject> objectsByUid;
    private ISet<Guid> toInitialize;
    private static EntityAuditObjectProvider AtoDHjoWPSkehUYQo6yj;

    /// <summary>Получить список объектов</summary>
    /// <returns>Список объектов</returns>
    public IEnumerable<IAuditObject> GetObjects()
    {
      this.Initialize();
      return (IEnumerable<IAuditObject>) this.objectsByUid.Values;
    }

    /// <summary>Получить объект по уникальному идентификатору</summary>
    /// <param name="uid">Уникальный идентификатор объекта</param>
    /// <returns>ОБъект. Если не найден - null</returns>
    public virtual IAuditObject GetObject(Guid uid)
    {
      int num = 1;
      IAuditObject auditObject;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Initialize();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            this.objectsByUid.TryGetValue(uid, out auditObject);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 2;
            continue;
        }
      }
label_3:
      return auditObject;
    }

    private void Initialize()
    {
      int num1 = 3;
      EntityAuditObjectProvider auditObjectProvider;
      bool lockTaken;
      while (true)
      {
        int num2;
        switch (num1)
        {
          case 1:
            lockTaken = false;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
            continue;
          case 2:
            num2 = 0;
            break;
          case 3:
            ISet<Guid> toInitialize = this.toInitialize;
            if (toInitialize == null)
            {
              num1 = 2;
              continue;
            }
            num2 = EntityAuditObjectProvider.EadZB7oW375pLuA3GRd8((object) toInitialize) == 0 ? 1 : 0;
            break;
          case 4:
            goto label_2;
          case 5:
            goto label_49;
          case 6:
            auditObjectProvider = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 1;
            continue;
          default:
            goto label_3;
        }
        if (num2 == 0)
          num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 6 : 4;
        else
          goto label_36;
      }
label_2:
      return;
label_49:
      return;
label_3:
      try
      {
        Monitor.Enter((object) auditObjectProvider, ref lockTaken);
        int num3 = 14;
        while (true)
        {
          IEnumerable<EntityMetadata> source;
          IEnumerator<EntityMetadata> enumerator;
          IMetadataRuntimeService service;
          int num4;
          switch (num3)
          {
            case 1:
              source = source.Where<EntityMetadata>((Func<EntityMetadata, bool>) (m => this.toInitialize.Contains(m.Uid)));
              num3 = 15;
              continue;
            case 2:
            case 15:
              enumerator = source.Where<EntityMetadata>((Func<EntityMetadata, bool>) (m => !m.IsInterfaceType)).GetEnumerator();
              num3 = 9;
              continue;
            case 3:
              goto label_46;
            case 5:
            case 11:
label_21:
              if (this.toInitialize == null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 10 : 2;
                continue;
              }
              goto case 7;
            case 6:
              goto label_40;
            case 7:
              EntityAuditObjectProvider.YF7isvoWtxBWn6ADtjWu((object) this.toInitialize);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 6 : 6;
              continue;
            case 8:
              source = service.GetMetadataList().OfType<EntityMetadata>();
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 2 : 13;
              continue;
            case 9:
              try
              {
label_11:
                if (EntityAuditObjectProvider.qSFh41oWaRYurEw4Qw4w((object) enumerator))
                  goto label_13;
                else
                  goto label_12;
label_9:
                EntityMetadata current;
                int num5;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      goto label_13;
                    case 2:
                      this.objectsByUid[EntityAuditObjectProvider.NE5g51oWpphNIPaa6k1T((object) current)] = (IAuditObject) new EntityAuditObject(current);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
                      continue;
                    case 3:
                      goto label_21;
                    default:
                      goto label_11;
                  }
                }
label_12:
                num5 = 3;
                goto label_9;
label_13:
                current = enumerator.Current;
                num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
                {
                  num5 = 2;
                  goto label_9;
                }
                else
                  goto label_9;
              }
              finally
              {
                int num6;
                if (enumerator == null)
                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
                else
                  goto label_18;
label_17:
                switch (num6)
                {
                  case 1:
                    break;
                  default:
                }
label_18:
                EntityAuditObjectProvider.bTiBNqoWD0vYIWvXTLlG((object) enumerator);
                num6 = 2;
                goto label_17;
              }
            case 10:
              this.toInitialize = PublishCacheContext.CreateCache<Guid>((Action<ISet<Guid>, Type, Guid>) ((c, t, g) => c.Add(g)));
              num3 = 7;
              continue;
            case 12:
              num4 = 0;
              break;
            case 13:
              if (this.toInitialize == null)
              {
                num3 = 2;
                continue;
              }
              goto case 1;
            case 14:
              ISet<Guid> toInitialize = this.toInitialize;
              if (toInitialize == null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 2 : 12;
                continue;
              }
              num4 = EntityAuditObjectProvider.EadZB7oW375pLuA3GRd8((object) toInitialize) == 0 ? 1 : 0;
              break;
            case 16:
              if (service == null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 1 : 11;
                continue;
              }
              goto case 8;
            default:
              service = Locator.GetService<IMetadataRuntimeService>();
              num3 = 16;
              continue;
          }
          if (num4 == 0)
            num3 = 4;
          else
            goto label_41;
        }
label_46:
        return;
label_40:
        return;
label_41:
        return;
      }
      finally
      {
        int num7;
        if (!lockTaken)
          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 0;
        else
          goto label_42;
label_39:
        switch (num7)
        {
          case 1:
          case 2:
        }
label_42:
        EntityAuditObjectProvider.MT1jtcoWweWvWhKH3sej((object) auditObjectProvider);
        num7 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
        {
          num7 = 2;
          goto label_39;
        }
        else
          goto label_39;
      }
label_36:;
    }

    public EntityAuditObjectProvider()
    {
      EntityAuditObjectProvider.S645MRoW4COn972SnGkp();
      // ISSUE: reference to a compiler-generated field
      Action<IDictionary<Guid, IAuditObject>, Type, Guid> action = EntityAuditObjectProvider.\u003C\u003Ec.\u003C\u003E9__6_0;
      Action<IDictionary<Guid, IAuditObject>, Type, Guid> remove;
      if (action == null)
      {
        // ISSUE: reference to a compiler-generated field
        EntityAuditObjectProvider.\u003C\u003Ec.\u003C\u003E9__6_0 = remove = (Action<IDictionary<Guid, IAuditObject>, Type, Guid>) ((c, t, u) => c.Remove(u));
      }
      else
        goto label_7;
label_3:
      this.objectsByUid = PublishCacheContext.CreateCache<Guid, IAuditObject>(remove);
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
        num = 0;
      switch (num)
      {
        case 0:
          return;
        default:
          return;
      }
label_7:
      remove = action;
      goto label_3;
    }

    internal static bool lLhHBUoW1UWVMduJbFgk() => EntityAuditObjectProvider.AtoDHjoWPSkehUYQo6yj == null;

    internal static EntityAuditObjectProvider OUuKpdoWNSlaIjD1XAvi() => EntityAuditObjectProvider.AtoDHjoWPSkehUYQo6yj;

    internal static int EadZB7oW375pLuA3GRd8([In] object obj0) => ((ICollection<Guid>) obj0).Count;

    internal static Guid NE5g51oWpphNIPaa6k1T([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static bool qSFh41oWaRYurEw4Qw4w([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void bTiBNqoWD0vYIWvXTLlG([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void YF7isvoWtxBWn6ADtjWu([In] object obj0) => ((ICollection<Guid>) obj0).Clear();

    internal static void MT1jtcoWweWvWhKH3sej([In] object obj0) => Monitor.Exit(obj0);

    internal static void S645MRoW4COn972SnGkp() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    [Component(Order = -200)]
    private class MetadataPublishFinishedEventHandler : 
      IMetadataPublishFinishedEventHandler,
      IEventHandler
    {
      private readonly object entityAuditObjectProvider;
      internal static object YsAyYXCoOEh9ESr81D6g;

      public MetadataPublishFinishedEventHandler(
        EntityAuditObjectProvider entityAuditObjectProvider)
      {
        EntityAuditObjectProvider.MetadataPublishFinishedEventHandler.YTXKcDCoPRnSOfNZT3pO();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            default:
              this.entityAuditObjectProvider = (object) entityAuditObjectProvider;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 1 : 1;
              continue;
          }
        }
label_3:;
      }

      public void PublishExecuted(MetadataPublishedEventArgs e)
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_5;
            case 1:
              goto label_3;
            case 2:
              ISet<Guid> toInitialize = ((EntityAuditObjectProvider) this.entityAuditObjectProvider).toInitialize;
              if (toInitialize == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 1 : 1;
                continue;
              }
              // ISSUE: reference to a compiler-generated method
              toInitialize.AddAll<Guid>(e.DeltaPublishedMetadata.OfType<EntityMetadata>().Select<EntityMetadata, Guid>((Func<EntityMetadata, Guid>) (m => EntityAuditObjectProvider.MetadataPublishFinishedEventHandler.\u003C\u003Ec.Rq3ct1ZuUotS1dGWypjH((object) m))));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_5:
        return;
label_3:
        return;
label_2:;
      }

      internal static void YTXKcDCoPRnSOfNZT3pO() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool MNCfslCo23DZuPDBEQKL() => EntityAuditObjectProvider.MetadataPublishFinishedEventHandler.YsAyYXCoOEh9ESr81D6g == null;

      internal static EntityAuditObjectProvider.MetadataPublishFinishedEventHandler fH0XRMCoema8HAhDyjBd() => (EntityAuditObjectProvider.MetadataPublishFinishedEventHandler) EntityAuditObjectProvider.MetadataPublishFinishedEventHandler.YsAyYXCoOEh9ESr81D6g;
    }
  }
}
