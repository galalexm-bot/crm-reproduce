// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Scripts.PortletMetadataUpdateDataHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Scripts
{
  /// <summary>
  /// Получение необходимых данных для обновления метаданных на новый рантайм для портлетов
  /// </summary>
  internal sealed class PortletMetadataUpdateDataHandler : FormMetadataUpdateDataHandler
  {
    private readonly IComponentMetadataItemManager componentMetadataItemManager;
    internal static PortletMetadataUpdateDataHandler RPdcWsgkcBSZmJ4IGdx;

    /// <inheritdoc />
    public PortletMetadataUpdateDataHandler(
      FormMetadataItemHeaderManager formMetadataItemHeaderManager,
      IComponentMetadataItemManager componentMetadataItemManager)
    {
      PortletMetadataUpdateDataHandler.YtJ39Xg2DWiyjOaDaCS();
      // ISSUE: explicit constructor call
      base.\u002Ector(formMetadataItemHeaderManager);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.componentMetadataItemManager = componentMetadataItemManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public override bool Check(IMetadata metadata) => metadata is PortletMetadata;

    /// <inheritdoc />
    public override IEnumerable<Guid> GetFormUids(IMetadataUpdateResult updateResult) => (IEnumerable<Guid>) new Guid[1]
    {
      ((PortletMetadata) updateResult.Metadata).Content.View.Uid
    };

    /// <inheritdoc />
    protected override void CreateComponent(IMetadataUpdateResult updateResult)
    {
      int num = 1;
      PortletMetadata metadata;
      ComponentMetadataItem componentMetadataItem;
      while (true)
      {
        switch (num)
        {
          case 1:
            metadata = (PortletMetadata) updateResult.Metadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
            continue;
          case 2:
            updateResult.Entities.Add((IEntity) componentMetadataItem);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 3 : 0;
            continue;
          case 3:
            goto label_2;
          default:
            componentMetadataItem = this.componentMetadataItemManager.Create(PortletComponentMetadata.TypeUid, Guid.Empty, Guid.Empty, (string) PortletMetadataUpdateDataHandler.VCP2bcge2XXyD45KbxV((object) metadata));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static void YtJ39Xg2DWiyjOaDaCS() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool dJcy6ngnZYHtbn1f8xL() => PortletMetadataUpdateDataHandler.RPdcWsgkcBSZmJ4IGdx == null;

    internal static PortletMetadataUpdateDataHandler tyCV1dgOJgY2p5cuW1V() => PortletMetadataUpdateDataHandler.RPdcWsgkcBSZmJ4IGdx;

    internal static object VCP2bcge2XXyD45KbxV([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;
  }
}
