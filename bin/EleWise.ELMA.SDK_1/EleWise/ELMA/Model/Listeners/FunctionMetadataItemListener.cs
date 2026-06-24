// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Listeners.FunctionMetadataItemListener
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
  /// Прослушиватель событий для сущности <see cref="T:EleWise.ELMA.Model.Metadata.FunctionMetadataItem" />
  /// </summary>
  [Component]
  internal sealed class FunctionMetadataItemListener : EntityEventsListener
  {
    private readonly IModuleReferenceManager moduleReferenceManager;
    internal static FunctionMetadataItemListener lHRU91oFTQAnXGAUxK1D;

    /// <summary>Ctor</summary>
    /// <param name="moduleReferenceManager">Менеджер ссылки метаданных на модуль</param>
    public FunctionMetadataItemListener(IModuleReferenceManager moduleReferenceManager)
    {
      FunctionMetadataItemListener.ACr82YoFOotf3yOaGQHL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.moduleReferenceManager = moduleReferenceManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
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
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 0 : 0;
            continue;
          case 2:
            base.OnPostInsert(@event);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 1;
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
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.Update((IPostDatabaseOperationEventArgs) @event);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    private void Update(IPostDatabaseOperationEventArgs @event)
    {
      int num = 3;
      ModuleReference moduleReference1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            goto label_3;
          case 3:
            if (FunctionMetadataItemListener.yrqPcOoF29T7lDb0LpDQ((object) @event) is FunctionMetadataItem functionMetadataItem)
            {
              if (!(FunctionMetadataItemListener.d3ghfYoFeevwkWRdsklC((object) functionMetadataItem) is FunctionMetadata functionMetadata))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 1;
                continue;
              }
              ModuleReference moduleReference2 = new ModuleReference();
              FunctionMetadataItemListener.cdk75BoF1FrDVGlIYrE9((object) moduleReference2, FunctionMetadataItemListener.Top0l3oFPymdqkWfrcIm((object) functionMetadata));
              moduleReference2.ModuleUid = FunctionMetadataItemListener.oalW29oFNwHPKnlWg3mE((object) functionMetadata);
              moduleReference1 = moduleReference2;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 2 : 2;
            continue;
          case 4:
            goto label_2;
          default:
            FunctionMetadataItemListener.UeUxLZoF3DBEjlDYSaWe((object) this.moduleReferenceManager, (object) moduleReference1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 4 : 3;
            continue;
        }
      }
label_5:
      return;
label_3:
      return;
label_2:;
    }

    internal static void ACr82YoFOotf3yOaGQHL() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool NIxbGboFkbWO3dO5VmfP() => FunctionMetadataItemListener.lHRU91oFTQAnXGAUxK1D == null;

    internal static FunctionMetadataItemListener Auqev2oFnWepQ3co9moH() => FunctionMetadataItemListener.lHRU91oFTQAnXGAUxK1D;

    internal static object yrqPcOoF29T7lDb0LpDQ([In] object obj0) => ((IPostDatabaseOperationEventArgs) obj0).Entity;

    internal static object d3ghfYoFeevwkWRdsklC([In] object obj0) => ((FunctionMetadataItem) obj0).Metadata;

    internal static Guid Top0l3oFPymdqkWfrcIm([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static void cdk75BoF1FrDVGlIYrE9([In] object obj0, Guid value) => ((ModuleReference) obj0).MetadataUid = value;

    internal static Guid oalW29oFNwHPKnlWg3mE([In] object obj0) => ((AbstractMetadata) obj0).ModuleUid;

    internal static void UeUxLZoF3DBEjlDYSaWe([In] object obj0, [In] object obj1) => ((IModuleReferenceManager) obj0).Save((ModuleReference) obj1);
  }
}
