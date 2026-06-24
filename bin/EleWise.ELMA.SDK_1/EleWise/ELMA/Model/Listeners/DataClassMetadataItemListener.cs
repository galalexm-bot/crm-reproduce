// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Listeners.DataClassMetadataItemListener
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Runtime.NH.Listeners;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Listeners
{
  /// <summary>
  /// Прослушиватель событий для сущности <see cref="T:EleWise.ELMA.Model.Metadata.DataClassMetadataItem" />
  /// </summary>
  [Component]
  internal sealed class DataClassMetadataItemListener : EntityEventsListener
  {
    private readonly IModuleReferenceManager moduleReferenceManager;
    internal static DataClassMetadataItemListener ebo5HToFuxDrbSYxnkJW;

    /// <summary>Ctor</summary>
    /// <param name="moduleReferenceManager">Менеджер ссылки метаданных на модуль</param>
    public DataClassMetadataItemListener(IModuleReferenceManager moduleReferenceManager)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.moduleReferenceManager = moduleReferenceManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <inheritdoc />
    public override bool OnPreInsert(PreInsertEvent @event)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Update((IPreDatabaseOperationEventArgs) @event);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return base.OnPreInsert(@event);
    }

    /// <inheritdoc />
    public override bool OnPreUpdate(PreUpdateEvent @event)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Update((IPreDatabaseOperationEventArgs) @event);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return base.OnPreUpdate(@event);
    }

    private void Update(IPreDatabaseOperationEventArgs @event)
    {
      int num = 4;
      ModuleReference moduleReference1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_9;
          case 2:
            DataClassMetadataItemListener.YmBD1xoFXStKnX9beqen((object) this.moduleReferenceManager, (object) moduleReference1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 1;
            continue;
          case 3:
            goto label_11;
          case 4:
            if (!(DataClassMetadataItemListener.Nqq2BBoFSk0la7GVkGyH((object) @event) is DataClassMetadataItem classMetadataItem))
            {
              num = 3;
              continue;
            }
            if (classMetadataItem.Metadata is DataClassMetadata metadata)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 5:
            goto label_6;
          default:
            ModuleReference moduleReference2 = new ModuleReference();
            DataClassMetadataItemListener.EXmE3ZoFRtOJU9mVITUD((object) moduleReference2, DataClassMetadataItemListener.OHJR9NoFijQcl1UGPCVL((object) metadata));
            DataClassMetadataItemListener.t7u9kioFKbAd4X2n6thH((object) moduleReference2, DataClassMetadataItemListener.vCXL6joFqSu0qxoLbZaD((object) metadata));
            moduleReference1 = moduleReference2;
            num = 2;
            continue;
        }
      }
label_9:
      return;
label_11:
      return;
label_6:
      return;
label_2:;
    }

    internal static bool CTY4qNoFI9ObTH5ZU7WA() => DataClassMetadataItemListener.ebo5HToFuxDrbSYxnkJW == null;

    internal static DataClassMetadataItemListener Ou3wPnoFVH8jJp4hebwx() => DataClassMetadataItemListener.ebo5HToFuxDrbSYxnkJW;

    internal static object Nqq2BBoFSk0la7GVkGyH([In] object obj0) => ((IPreDatabaseOperationEventArgs) obj0).Entity;

    internal static Guid OHJR9NoFijQcl1UGPCVL([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static void EXmE3ZoFRtOJU9mVITUD([In] object obj0, Guid value) => ((ModuleReference) obj0).MetadataUid = value;

    internal static Guid vCXL6joFqSu0qxoLbZaD([In] object obj0) => ((AbstractMetadata) obj0).ModuleUid;

    internal static void t7u9kioFKbAd4X2n6thH([In] object obj0, Guid value) => ((ModuleReference) obj0).ModuleUid = value;

    internal static void YmBD1xoFXStKnX9beqen([In] object obj0, [In] object obj1) => ((IModuleReferenceManager) obj0).Save((ModuleReference) obj1);
  }
}
