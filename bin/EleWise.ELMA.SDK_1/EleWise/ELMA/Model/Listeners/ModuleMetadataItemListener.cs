// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Listeners.ModuleMetadataItemListener
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
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Listeners
{
  /// <summary>
  /// Прослушиватель событий для сущности <see cref="T:EleWise.ELMA.Model.Metadata.ModuleMetadataItem" />
  /// </summary>
  [Component]
  internal sealed class ModuleMetadataItemListener : EntityEventsListener
  {
    private readonly IModuleReferenceManager moduleReferenceManager;
    internal static ModuleMetadataItemListener VUbSqmoFp4UCyjyyVBU5;

    /// <summary>Ctor</summary>
    /// <param name="moduleReferenceManager">Менеджер ссылки метаданных на модуль</param>
    public ModuleMetadataItemListener(IModuleReferenceManager moduleReferenceManager)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.moduleReferenceManager = moduleReferenceManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 1;
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
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
            continue;
          case 2:
            base.OnPostInsert(@event);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 1 : 1;
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
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.Update((IPostDatabaseOperationEventArgs) @event);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    private void Update(IPostDatabaseOperationEventArgs @event)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_8;
          case 1:
            goto label_6;
          case 2:
            if (!(ModuleMetadataItemListener.CDv4GAoFthEDiJEg4ycD((object) @event) is ModuleMetadataItem moduleMetadataItem))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 1 : 1;
              continue;
            }
            if (!(ModuleMetadataItemListener.YaCbd2oFwyyQrxbJdj6I((object) moduleMetadataItem) is ModuleInfoMetadata moduleInfoMetadata))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
              continue;
            }
            ProcessMetadata((IEnumerable<IMetadata>) moduleInfoMetadata.Components);
            num = 5;
            continue;
          case 3:
            ProcessMetadata((IEnumerable<IMetadata>) moduleInfoMetadata.Functions);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 4 : 1;
            continue;
          case 4:
            goto label_2;
          case 5:
            ProcessMetadata((IEnumerable<IMetadata>) moduleInfoMetadata.DataClasses);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 3 : 3;
            continue;
          default:
            goto label_12;
        }
      }
label_8:
      return;
label_6:
      return;
label_2:
      return;
label_12:

      void ProcessMetadata(IEnumerable<IMetadata> metadataList)
      {
        foreach (IMetadata metadata in metadataList)
          this.moduleReferenceManager.Save(new ModuleReference()
          {
            MetadataUid = metadata.Uid,
            ModuleUid = metadata.ModuleUid
          });
      }
    }

    internal static bool MHQUBhoFaI9bMeCEkeWW() => ModuleMetadataItemListener.VUbSqmoFp4UCyjyyVBU5 == null;

    internal static ModuleMetadataItemListener nL3wUEoFDZDoEVKIkXnh() => ModuleMetadataItemListener.VUbSqmoFp4UCyjyyVBU5;

    internal static object CDv4GAoFthEDiJEg4ycD([In] object obj0) => ((IPostDatabaseOperationEventArgs) obj0).Entity;

    internal static object YaCbd2oFwyyQrxbJdj6I([In] object obj0) => ((ModuleMetadataItem) obj0).Metadata;
  }
}
