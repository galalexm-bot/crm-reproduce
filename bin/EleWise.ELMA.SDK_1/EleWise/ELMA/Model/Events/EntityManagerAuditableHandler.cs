// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Events.EntityManagerAuditableHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Model.Events
{
  /// <summary>
  /// Перехватчик методов менеджеров сущностей, помеченных атрибутом Auditable.
  /// Осуществляет вызов методов из менеджеров расширения сущностей.
  /// </summary>
  [Component]
  public class EntityManagerAuditableHandler : 
    IAuditableEventHandlerAsync,
    IAuditableEventHandler,
    IEventHandler
  {
    private ConcurrentDictionary<Type, IEnumerable<IEntityExtensionManager>> _extManagersByInvokerType;
    internal static EntityManagerAuditableHandler qVfMsjoFcedYwMKGksJO;

    /// <summary>Сервис управления метаданными</summary>
    public IMetadataRuntimeService MetadataRuntimeService
    {
      get => this.\u003CMetadataRuntimeService\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CMetadataRuntimeService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    public void Preprocess(AuditableCancelEventArgs e)
    {
      int num1 = 3;
      IEnumerable<IEntityExtensionManager> extensionManagers;
      IEnumerator<IEntityExtensionManager> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_5;
          case 1:
            if (extensionManagers == null)
            {
              num1 = 4;
              continue;
            }
            goto case 5;
          case 2:
            goto label_27;
          case 3:
            if (EntityManagerAuditableHandler.TpwnIboBBsIVfFQiBKEu((object) e))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 2 : 2;
              continue;
            }
            extensionManagers = this.GetExtensionManagers(EntityManagerAuditableHandler.QeIfacoBW4cw4NfX5uG0((object) e));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 0;
            continue;
          case 4:
            goto label_22;
          case 5:
            enumerator = extensionManagers.GetEnumerator();
            num1 = 6;
            continue;
          case 6:
            goto label_11;
          default:
            goto label_21;
        }
      }
label_5:
      return;
label_27:
      return;
label_22:
      return;
label_21:
      return;
label_11:
      try
      {
label_16:
        if (enumerator.MoveNext())
          goto label_18;
        else
          goto label_17;
label_12:
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_20;
            case 1:
              goto label_18;
            case 2:
              if (!EntityManagerAuditableHandler.TpwnIboBBsIVfFQiBKEu((object) e))
              {
                num2 = 5;
                continue;
              }
              goto label_13;
            case 3:
              goto label_10;
            case 4:
            case 5:
              goto label_16;
            default:
              goto label_2;
          }
        }
label_20:
        return;
label_10:
        return;
label_2:
        return;
label_13:
        return;
label_17:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
        goto label_12;
label_18:
        EntityManagerAuditableHandler.dAyy4moBo9XknkqjpOpm((object) enumerator.Current, (object) e);
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
        {
          num2 = 2;
          goto label_12;
        }
        else
          goto label_12;
      }
      finally
      {
        if (enumerator != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_29;
              default:
                EntityManagerAuditableHandler.f3YJBfoBbNKg5GPVEbo5((object) enumerator);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 1 : 1;
                continue;
            }
          }
        }
label_29:;
      }
    }

    public void Postprocess(AuditableEventArgs e)
    {
      int num1 = 1;
      IEnumerable<IEntityExtensionManager> extensionManagers;
      IEnumerator<IEntityExtensionManager> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            extensionManagers = this.GetExtensionManagers(EntityManagerAuditableHandler.QeIfacoBW4cw4NfX5uG0((object) e));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
            continue;
          case 2:
            enumerator = extensionManagers.GetEnumerator();
            num1 = 3;
            continue;
          case 3:
            goto label_5;
          case 4:
            goto label_18;
          default:
            if (extensionManagers != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 2 : 2;
              continue;
            }
            goto label_15;
        }
      }
label_18:
      return;
label_15:
      return;
label_5:
      try
      {
label_9:
        if (EntityManagerAuditableHandler.d6fyoeoBGdwfjO2uBnVZ((object) enumerator))
          goto label_7;
        else
          goto label_10;
label_6:
        int num2;
        switch (num2)
        {
          case 1:
            return;
          case 2:
            break;
          default:
            goto label_9;
        }
label_7:
        EntityManagerAuditableHandler.jtt6pGoBhLIvlOuPYdsJ((object) enumerator.Current, (object) e);
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
        {
          num2 = 0;
          goto label_6;
        }
        else
          goto label_6;
label_10:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 1 : 1;
        goto label_6;
      }
      finally
      {
        int num3;
        if (enumerator == null)
          num3 = 2;
        else
          goto label_16;
label_14:
        switch (num3)
        {
          case 1:
            break;
          default:
        }
label_16:
        EntityManagerAuditableHandler.f3YJBfoBbNKg5GPVEbo5((object) enumerator);
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
        {
          num3 = 0;
          goto label_14;
        }
        else
          goto label_14;
      }
    }

    /// <inheritdoc />
    public Task PreprocessAsync(AuditableCancelEventArgs e, CancellationToken cancellationToken = default (CancellationToken))
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            cancellationToken.ThrowIfCancellationRequested();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            this.Preprocess(e);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 1 : 2;
            continue;
        }
      }
label_3:
      return (Task) EntityManagerAuditableHandler.DHRStGoBEUvbh0bmgTAm();
    }

    /// <inheritdoc />
    public Task PostprocessAsync(AuditableEventArgs e, CancellationToken cancellationToken = default (CancellationToken))
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            cancellationToken.ThrowIfCancellationRequested();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.Postprocess(e);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 2 : 2;
            continue;
        }
      }
label_2:
      return (Task) EntityManagerAuditableHandler.DHRStGoBEUvbh0bmgTAm();
    }

    private IEnumerable<IEntityExtensionManager> GetExtensionManagers(Type invokerType)
    {
      IEnumerable<IEntityExtensionManager> extensionManagers;
      if (this._extManagersByInvokerType.TryGetValue(invokerType, out extensionManagers))
        return extensionManagers;
      if (this.MetadataRuntimeService == null)
      {
        this._extManagersByInvokerType[invokerType] = (IEnumerable<IEntityExtensionManager>) null;
        return (IEnumerable<IEntityExtensionManager>) null;
      }
      Type type = invokerType.GetInterface(typeof (IEntityManager<>).FullName);
      if (type == (Type) null)
      {
        this._extManagersByInvokerType[invokerType] = (IEnumerable<IEntityExtensionManager>) null;
        return (IEnumerable<IEntityExtensionManager>) null;
      }
      EntityMetadata entityMetadata = MetadataLoader.LoadMetadata(type.GetGenericArguments()[0]) as EntityMetadata;
      List<IEntityExtensionManager> managers = new List<IEntityExtensionManager>();
      this.GetExtensionManagers(entityMetadata, managers);
      this._extManagersByInvokerType[invokerType] = (IEnumerable<IEntityExtensionManager>) managers;
      return (IEnumerable<IEntityExtensionManager>) managers;
    }

    private void GetExtensionManagers(
      EntityMetadata entityMetadata,
      List<IEntityExtensionManager> managers)
    {
      if (entityMetadata == null || entityMetadata.Type != EntityMetadataType.InterfaceImplementation)
        return;
      if (entityMetadata.ImplementedExtensionUids != null && entityMetadata.ImplementedExtensionUids.Any<Guid>())
      {
        Type typeByUid1 = this.MetadataRuntimeService.GetTypeByUid(entityMetadata.ImplementationUid, false);
        Type entityIdType = ModelHelper.GetEntityIdType(typeByUid1);
        if (typeByUid1 != (Type) null && entityIdType != (Type) null)
        {
          foreach (Guid implementedExtensionUid in entityMetadata.ImplementedExtensionUids)
          {
            Type typeByUid2 = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(implementedExtensionUid, false);
            if (typeByUid2 != (Type) null)
            {
              if (Locator.GetService(typeof (IEntityExtensionManager<,,>).MakeGenericType(typeByUid1, typeByUid2, entityIdType)) is IEntityExtensionManager service)
                managers.Add(service);
            }
          }
        }
      }
      EntityMetadata metadata = entityMetadata.BaseClassUid != Guid.Empty ? this.MetadataRuntimeService.GetMetadata(entityMetadata.BaseClassUid) as EntityMetadata : (EntityMetadata) null;
      if (metadata == null)
        return;
      this.GetExtensionManagers(metadata, managers);
    }

    public EntityManagerAuditableHandler()
    {
      EntityManagerAuditableHandler.QhPQN6oBfvbVE3Eefec3();
      this._extManagersByInvokerType = new ConcurrentDictionary<Type, IEnumerable<IEntityExtensionManager>>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool xJ9XeHoFzpphGGQOZR3l() => EntityManagerAuditableHandler.qVfMsjoFcedYwMKGksJO == null;

    internal static EntityManagerAuditableHandler bee8FyoBFeYuFY9QOGD7() => EntityManagerAuditableHandler.qVfMsjoFcedYwMKGksJO;

    internal static bool TpwnIboBBsIVfFQiBKEu([In] object obj0) => ((AuditableCancelEventArgs) obj0).Cancel;

    internal static Type QeIfacoBW4cw4NfX5uG0([In] object obj0) => ((AuditableEventArgs) obj0).InvokerType;

    internal static void dAyy4moBo9XknkqjpOpm([In] object obj0, [In] object obj1) => ((IEntityExtensionManager) obj0).Preprocess((AuditableCancelEventArgs) obj1);

    internal static void f3YJBfoBbNKg5GPVEbo5([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void jtt6pGoBhLIvlOuPYdsJ([In] object obj0, [In] object obj1) => ((IEntityExtensionManager) obj0).Postprocess((AuditableEventArgs) obj1);

    internal static bool d6fyoeoBGdwfjO2uBnVZ([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static object DHRStGoBEUvbh0bmgTAm() => (object) Task.CompletedTask;

    internal static void QhPQN6oBfvbVE3Eefec3() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
