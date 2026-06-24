// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Components.UIFormLinkedFinder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Components;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Components
{
  /// <summary>Расширение для поиска связных страниц и портлетов</summary>
  [Component]
  internal sealed class UIFormLinkedFinder : LinkedFinderBase
  {
    private readonly FormMetadataItemHeaderManager formMetadataManager;
    private static UIFormLinkedFinder SavG2iEsSjwkDVeCLuAU;

    /// <summary>Ctor</summary>
    /// <param name="formMetadataManager">Менеджер метаданных интерфейсов</param>
    public UIFormLinkedFinder(FormMetadataItemHeaderManager formMetadataManager)
    {
      UIFormLinkedFinder.tW5P8rEsqZUrD28KG7GZ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.formMetadataManager = formMetadataManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
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
        if (metadata != null && metadata is FormMetadata formMetadata)
        {
          EntityMetadata md = (EntityMetadata) null;
          if (formMetadata.GetTypeUid() == PortletMetadata.TypeUid && (formMetadata is PortletMetadata portletMetadata ? portletMetadata.Content : (PortletContentMetadata) null) != null)
            md = (EntityMetadata) portletMetadata.Content.Context;
          if (formMetadata.GetTypeUid() == PageMetadata.TypeUid && (formMetadata is PageMetadata pageMetadata ? pageMetadata.Content : (PageContentMetadata) null) != null)
            md = (EntityMetadata) pageMetadata.Content.Context;
          if (md != null)
            this.FillProperties((ClassMetadata) md, context, resultObj);
        }
      }
      return resultObj;
    }

    /// <inheritdoc />
    protected override IMetadata GetMetadataWithUid(Guid metadataId, LinkedObjectsContext context)
    {
      int num = 5;
      IFormMetadataItemHeader metadataItemHeader;
      while (true)
      {
        object obj;
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            obj = UIFormLinkedFinder.JcKjxhEsK8Ux7HeVnU3C((object) metadataItemHeader);
            break;
          case 3:
            goto label_2;
          case 4:
            if (metadataItemHeader != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 2 : 2;
              continue;
            }
            goto default;
          case 5:
            metadataItemHeader = this.formMetadataManager.LoadOrNull(metadataId);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 2 : 4;
            continue;
          default:
            obj = (object) null;
            break;
        }
        if (obj == null)
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 1 : 0;
        else
          break;
      }
label_2:
      return (IMetadata) (UIFormLinkedFinder.S52jqDEsXlhd0M41MP3U(UIFormLinkedFinder.JcKjxhEsK8Ux7HeVnU3C((object) metadataItemHeader)) as FormMetadata);
label_3:
      return (IMetadata) null;
    }

    internal static void tW5P8rEsqZUrD28KG7GZ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool h2sNoXEsiKFbQJZ9mX45() => UIFormLinkedFinder.SavG2iEsSjwkDVeCLuAU == null;

    internal static UIFormLinkedFinder PMwxc6EsRJLW2l4M9gCD() => UIFormLinkedFinder.SavG2iEsSjwkDVeCLuAU;

    internal static object JcKjxhEsK8Ux7HeVnU3C([In] object obj0) => (object) ((IFormMetadataItemHeader) obj0).Draft;

    internal static object S52jqDEsXlhd0M41MP3U([In] object obj0) => ((IFormMetadataItem) obj0).Metadata;
  }
}
