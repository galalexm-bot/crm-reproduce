// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.Entities.EntityMetadataUpdateDataHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Scripts.Manager;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Scripts.Entities
{
  /// <summary>
  /// Получение необходимых данных для обновления метаданных на новый рантайм для сущностей
  /// </summary>
  [Component]
  internal sealed class EntityMetadataUpdateDataHandler : BaseMetadataUpdateDataHandler
  {
    private readonly MetadataItemHeaderManager metadataItemHeaderManager;
    internal static EntityMetadataUpdateDataHandler zUw387beB86lZZZcGXDi;

    /// <summary>Ctor</summary>
    /// <param name="metadataItemHeaderManager">Менеджер заголовков метаданных</param>
    /// <param name="scriptModuleManager">Менеджер модулей сценариев</param>
    public EntityMetadataUpdateDataHandler(
      MetadataItemHeaderManager metadataItemHeaderManager,
      ScriptModuleManager scriptModuleManager)
    {
      EntityMetadataUpdateDataHandler.bm0J1VbebubQkXkfwZd9();
      // ISSUE: explicit constructor call
      base.\u002Ector(scriptModuleManager);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.metadataItemHeaderManager = metadataItemHeaderManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public override bool Check(IMetadata metadata)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!(metadata is EntityMetadata entityMetadata))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      return EntityMetadataUpdateDataHandler.g0vkQobeGBWpIUONPe9x(EntityMetadataUpdateDataHandler.CJr0ttbehmJDeIM3KdQb((object) entityMetadata), EntityMetadata.UID);
label_5:
      return false;
    }

    /// <inheritdoc />
    public override IEnumerable<ScriptModule> GetScriptModules(IMetadataUpdateResult updateResult)
    {
      if (updateResult.Metadata is EntityMetadata metadata)
      {
        IMetadataItemHeader metadataItemHeader = this.metadataItemHeaderManager.LoadOrNull(metadata.Uid);
        if (metadataItemHeader?.Current.ScriptModule != null)
          return (IEnumerable<ScriptModule>) new ScriptModule[1]
          {
            metadataItemHeader.Current.ScriptModule
          };
      }
      return Enumerable.Empty<ScriptModule>();
    }

    /// <inheritdoc />
    public override IEnumerable<Guid> GetFormUids(IMetadataUpdateResult updateResult)
    {
      List<Guid> formUids = new List<Guid>();
      if (!(updateResult.Metadata is EntityMetadata metadata))
        return (IEnumerable<Guid>) formUids;
      if (this.metadataItemHeaderManager.LoadOrNull(metadata.Uid) == null)
        return (IEnumerable<Guid>) formUids;
      foreach (FormViewItem form in metadata.Forms)
        formUids.Add(form.Uid);
      foreach (FormViewItemTransformation formTransformation in metadata.FormTransformations)
        formUids.Add(formTransformation.NewFormUid != Guid.Empty ? formTransformation.NewFormUid : formTransformation.Uid);
      return (IEnumerable<Guid>) formUids;
    }

    internal static void bm0J1VbebubQkXkfwZd9() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool tPRRRKbeW8rWiEEuuD7a() => EntityMetadataUpdateDataHandler.zUw387beB86lZZZcGXDi == null;

    internal static EntityMetadataUpdateDataHandler v9ngCPbeonOZxdfMiolb() => EntityMetadataUpdateDataHandler.zUw387beB86lZZZcGXDi;

    internal static Guid CJr0ttbehmJDeIM3KdQb([In] object obj0) => ((EntityMetadata) obj0).TypeUid;

    internal static bool g0vkQobeGBWpIUONPe9x([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;
  }
}
