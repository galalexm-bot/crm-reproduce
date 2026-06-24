// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Scripts.PageMetadataUpdateDataHandler
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
  /// Получение необходимых данных для обновления метаданных на новый рантайм для страниц
  /// </summary>
  internal sealed class PageMetadataUpdateDataHandler : FormMetadataUpdateDataHandler
  {
    private readonly IComponentMetadataItemManager componentMetadataItemManager;
    internal static PageMetadataUpdateDataHandler GtyRfwgCv9VmGDntkf6;

    /// <inheritdoc />
    public PageMetadataUpdateDataHandler(
      FormMetadataItemHeaderManager formMetadataItemHeaderManager,
      IComponentMetadataItemManager componentMetadataItemManager)
    {
      PageMetadataUpdateDataHandler.Jtf11FgZwqXaBU35Pjh();
      // ISSUE: explicit constructor call
      base.\u002Ector(formMetadataItemHeaderManager);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.componentMetadataItemManager = componentMetadataItemManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public override bool Check(IMetadata metadata) => metadata is PageMetadata;

    /// <inheritdoc />
    public override IEnumerable<Guid> GetFormUids(IMetadataUpdateResult updateResult) => (IEnumerable<Guid>) new Guid[1]
    {
      ((PageMetadata) updateResult.Metadata).Content.View.Uid
    };

    /// <inheritdoc />
    protected override void CreateComponent(IMetadataUpdateResult updateResult)
    {
      int num = 1;
      PageMetadata metadata;
      ComponentMetadataItem componentMetadataItem;
      while (true)
      {
        switch (num)
        {
          case 1:
            metadata = (PageMetadata) updateResult.Metadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
            continue;
          case 2:
            updateResult.Entities.Add((IEntity) componentMetadataItem);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 3 : 3;
            continue;
          case 3:
            goto label_2;
          default:
            componentMetadataItem = (ComponentMetadataItem) PageMetadataUpdateDataHandler.saHMJwgIpZFyWIsMTnF((object) this.componentMetadataItemManager, PageComponentMetadata.TypeUid, Guid.Empty, Guid.Empty, PageMetadataUpdateDataHandler.HRwN7oguoY3k0J9k9Bs((object) metadata));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    internal static void Jtf11FgZwqXaBU35Pjh() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool mvVxDvgv2bdd822hXUv() => PageMetadataUpdateDataHandler.GtyRfwgCv9VmGDntkf6 == null;

    internal static PageMetadataUpdateDataHandler xtrV6mg8sSbQJCoyQOJ() => PageMetadataUpdateDataHandler.GtyRfwgCv9VmGDntkf6;

    internal static object HRwN7oguoY3k0J9k9Bs([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static object saHMJwgIpZFyWIsMTnF(
      [In] object obj0,
      Guid typeUid,
      Guid moduleUid,
      Guid groupUid,
      [In] object obj4)
    {
      return (object) ((IComponentMetadataItemManager) obj0).Create(typeUid, moduleUid, groupUid, (string) obj4);
    }
  }
}
