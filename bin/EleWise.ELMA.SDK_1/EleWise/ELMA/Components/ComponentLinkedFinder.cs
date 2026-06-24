// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Components.ComponentLinkedFinder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Components
{
  /// <summary>Расширение для поиска связных компонентов</summary>
  [Component]
  internal sealed class ComponentLinkedFinder : LinkedFinderBase
  {
    private readonly IEntityManager<ComponentMetadataItemHeader, long> componentMetadataItemManager;
    internal static ComponentLinkedFinder zvIKwEfGTlWpPYrxQlWP;

    /// <summary>Ctor</summary>
    /// <param name="componentMetadataItemManager">Менеджер метаданных компонентов</param>
    public ComponentLinkedFinder(
      IEntityManager<ComponentMetadataItemHeader, long> componentMetadataItemManager)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.componentMetadataItemManager = componentMetadataItemManager;
    }

    /// <inheritdoc />
    public override FindLinkedObjectsResult FindLinkedObjects(
      ICollection<ILinkedObject> objectsToSearch,
      LinkedObjectsContext context)
    {
      FindLinkedObjectsResult resultObj = new FindLinkedObjectsResult();
      foreach (ILinkedObject linkedObject in (IEnumerable<ILinkedObject>) objectsToSearch)
      {
        IMetadata metadata = this.GetMetadata(linkedObject.Uid, context, resultObj);
        if (metadata != null && metadata is ComponentMetadata)
          this.FillDependencies(linkedObject.Uid, context, resultObj);
      }
      return resultObj;
    }

    /// <inheritdoc />
    protected override IMetadata GetMetadataWithUid(Guid metadataId, LinkedObjectsContext context)
    {
      int num1 = 1;
      ComponentMetadataItemHeader metadataItemHeader;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              metadataItemHeader = this.componentMetadataItemManager.LoadOrNull(metadataId);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_9;
            case 3:
              goto label_5;
            case 4:
              goto label_6;
            default:
              if (metadataItemHeader != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 2 : 2;
                continue;
              }
              goto label_5;
          }
        }
label_5:
        object obj = (object) null;
        goto label_10;
label_9:
        obj = ComponentLinkedFinder.peiCEdfGOq5TKBhfoqN2((object) metadataItemHeader);
label_10:
        if (obj != null)
          num1 = 4;
        else
          goto label_7;
      }
label_6:
      return (IMetadata) (((ComponentMetadataItem) ComponentLinkedFinder.peiCEdfGOq5TKBhfoqN2((object) metadataItemHeader)).Metadata as ComponentMetadata);
label_7:
      return (IMetadata) null;
    }

    internal static object peiCEdfGOq5TKBhfoqN2([In] object obj0) => (object) ((ComponentMetadataItemHeader) obj0).Draft;

    internal static bool G8t7rifGkuwsBR31baw6() => ComponentLinkedFinder.zvIKwEfGTlWpPYrxQlWP == null;

    internal static ComponentLinkedFinder Bk1sDYfGnuu4UTxKc8vt() => ComponentLinkedFinder.zvIKwEfGTlWpPYrxQlWP;
  }
}
