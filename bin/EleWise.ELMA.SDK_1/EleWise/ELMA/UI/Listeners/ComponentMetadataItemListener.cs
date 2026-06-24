// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Listeners.ComponentMetadataItemListener
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Listeners
{
  /// <summary>
  /// Прослушиватель событий для сущности <see cref="T:EleWise.ELMA.UI.Models.ComponentMetadataItem" />
  /// </summary>
  [Component]
  internal sealed class ComponentMetadataItemListener : EntityEventsListener
  {
    private readonly IModuleReferenceManager moduleReferenceManager;
    internal static ComponentMetadataItemListener IPUwsUdWRl5odt1dMCS;

    /// <summary>Ctor</summary>
    /// <param name="moduleReferenceManager">Менеджер ссылки метаданных на модуль</param>
    public ComponentMetadataItemListener(IModuleReferenceManager moduleReferenceManager)
    {
      ComponentMetadataItemListener.IAkBqsdhhfwKiIVAVeb();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.moduleReferenceManager = moduleReferenceManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public override void OnPostInsert(PostInsertEvent @event)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Update((IPostDatabaseOperationEventArgs) @event);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
            continue;
          case 2:
            base.OnPostInsert(@event);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <inheritdoc />
    public override void OnPostUpdate(PostUpdateEvent @event)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            base.OnPostUpdate(@event);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.Update((IPostDatabaseOperationEventArgs) @event);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    private void Update(IPostDatabaseOperationEventArgs @event)
    {
      int num1 = 3;
      List<DataClassMetadata>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_8;
          case 2:
            goto label_2;
          case 3:
            if (ComponentMetadataItemListener.MAjRgvdGICr4eFDSdFJ((object) @event) is ComponentMetadataItem componentMetadataItem)
            {
              if (ComponentMetadataItemListener.S0AubBdE71tJS3KVnOq((object) componentMetadataItem) is ComponentMetadata componentMetadata)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
                continue;
              }
              goto label_19;
            }
            else
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 2 : 1;
              continue;
            }
          case 4:
            goto label_4;
          case 5:
            goto label_23;
          case 6:
            enumerator = componentMetadata.DataClasses.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 1 : 0;
            continue;
          default:
            IModuleReferenceManager referenceManager1 = this.moduleReferenceManager;
            ModuleReference moduleReference1 = new ModuleReference();
            ComponentMetadataItemListener.boswe2dQ6wEu2Np487T((object) moduleReference1, ComponentMetadataItemListener.iiwrsBdfuc6gUNlhfmH((object) componentMetadata));
            moduleReference1.ModuleUid = ComponentMetadataItemListener.xn48XedCv9KIVDtVXeS((object) componentMetadata);
            ComponentMetadataItemListener.pov7oZdvcB5CP1K90eT((object) referenceManager1, (object) moduleReference1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 3 : 6;
            continue;
        }
      }
label_2:
      return;
label_4:
      return;
label_23:
      return;
label_19:
      return;
label_8:
      try
      {
label_12:
        if (enumerator.MoveNext())
          goto label_14;
        else
          goto label_13;
label_9:
        DataClassMetadata current;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_15;
            case 1:
              goto label_12;
            case 2:
              IModuleReferenceManager referenceManager2 = this.moduleReferenceManager;
              ModuleReference moduleReference2 = new ModuleReference();
              ComponentMetadataItemListener.boswe2dQ6wEu2Np487T((object) moduleReference2, ComponentMetadataItemListener.iiwrsBdfuc6gUNlhfmH((object) current));
              moduleReference2.ModuleUid = ComponentMetadataItemListener.xn48XedCv9KIVDtVXeS((object) componentMetadata);
              ComponentMetadataItemListener.pov7oZdvcB5CP1K90eT((object) referenceManager2, (object) moduleReference2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_14;
            default:
              goto label_10;
          }
        }
label_15:
        return;
label_10:
        return;
label_13:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
        goto label_9;
label_14:
        current = enumerator.Current;
        num2 = 2;
        goto label_9;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    internal static void IAkBqsdhhfwKiIVAVeb() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Nd3Jkudo9Sof8FSGxSS() => ComponentMetadataItemListener.IPUwsUdWRl5odt1dMCS == null;

    internal static ComponentMetadataItemListener akbECrdbQwn3Ui9LhcI() => ComponentMetadataItemListener.IPUwsUdWRl5odt1dMCS;

    internal static object MAjRgvdGICr4eFDSdFJ([In] object obj0) => ((IPostDatabaseOperationEventArgs) obj0).Entity;

    internal static object S0AubBdE71tJS3KVnOq([In] object obj0) => ((ComponentMetadataItem) obj0).Metadata;

    internal static Guid iiwrsBdfuc6gUNlhfmH([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static void boswe2dQ6wEu2Np487T([In] object obj0, Guid value) => ((ModuleReference) obj0).MetadataUid = value;

    internal static Guid xn48XedCv9KIVDtVXeS([In] object obj0) => ((AbstractMetadata) obj0).ModuleUid;

    internal static void pov7oZdvcB5CP1K90eT([In] object obj0, [In] object obj1) => ((IModuleReferenceManager) obj0).Save((ModuleReference) obj1);
  }
}
