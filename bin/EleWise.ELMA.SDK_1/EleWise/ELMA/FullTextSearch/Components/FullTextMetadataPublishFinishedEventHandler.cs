// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Components.FullTextMetadataPublishFinishedEventHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.FullTextSearch.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.FullTextSearch.Components
{
  /// <summary>
  /// Обновление маппинга при публикации объектов поддерживающих полнотекст
  /// </summary>
  [Component]
  internal sealed class FullTextMetadataPublishFinishedEventHandler : 
    IMetadataPublishFinishedEventHandler,
    IEventHandler
  {
    private FullTextSearchSettingsModule fullTextSearchSettingsModule;
    private IEnumerable<IModuleFullTextSearchExtension> moduleFullTextSearchExtensions;
    private IEnumerable<IFullTextSearchMappingProvider> fullTextSearchMappingProvider;
    internal static FullTextMetadataPublishFinishedEventHandler MslGLSGVQHI3Op0udtJa;

    /// <summary>Ctor</summary>
    /// <param name="fullTextSearchSettingsModule">Модуль настроек индексации</param>
    /// <param name="moduleFullTextSearchExtensions">Точка расширения для реализации настроек и обработки полнотекстового поиска по модулям</param>
    /// <param name="fullTextSearchMappingProvider">Провадйер с поддержкой маппинга</param>
    public FullTextMetadataPublishFinishedEventHandler(
      FullTextSearchSettingsModule fullTextSearchSettingsModule,
      IEnumerable<IModuleFullTextSearchExtension> moduleFullTextSearchExtensions,
      IEnumerable<IFullTextSearchMappingProvider> fullTextSearchMappingProvider)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.fullTextSearchSettingsModule = fullTextSearchSettingsModule;
      this.moduleFullTextSearchExtensions = moduleFullTextSearchExtensions;
      this.fullTextSearchMappingProvider = fullTextSearchMappingProvider;
    }

    private IFullTextSearchMappingProvider Provider
    {
      get
      {
        int num = 3;
        Guid providerUid;
        while (true)
        {
          switch (num)
          {
            case 1:
              providerUid = this.fullTextSearchSettingsModule.Settings.ProviderUid;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 0 : 0;
              continue;
            case 2:
              providerUid = new Guid();
              num = 5;
              continue;
            case 3:
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 2 : 0;
              continue;
            case 5:
              if (this.fullTextSearchSettingsModule.Settings == null)
              {
                num = 4;
                continue;
              }
              goto case 1;
            default:
              goto label_2;
          }
        }
label_2:
        return this.fullTextSearchMappingProvider.FirstOrDefault<IFullTextSearchMappingProvider>((Func<IFullTextSearchMappingProvider, bool>) (p => FullTextMetadataPublishFinishedEventHandler.\u003C\u003Ec__DisplayClass5_0.f3MMkGvYP6er6Q9CFudO(FullTextMetadataPublishFinishedEventHandler.\u003C\u003Ec__DisplayClass5_0.B3WOQQvYelIUJ8rhnOff((object) p), providerUid)));
      }
    }

    /// <inheritdoc />
    public void PublishExecuted(MetadataPublishedEventArgs e)
    {
      int num1 = 1;
      List<Type> typeList;
      IEnumerator<ClassMetadata> enumerator1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            typeList = new List<Type>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_36;
          case 3:
            goto label_3;
          default:
            enumerator1 = e.DeltaPublishedMetadata.OfType<ClassMetadata>().GetEnumerator();
            num1 = 3;
            continue;
        }
      }
label_36:
      return;
label_3:
      try
      {
label_5:
        if (enumerator1.MoveNext())
          goto label_28;
        else
          goto label_6;
label_4:
        IEnumerator<IModuleFullTextSearchExtension> enumerator2;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_31;
            case 1:
              goto label_28;
            case 2:
              goto label_5;
            case 3:
              goto label_7;
            case 4:
              enumerator2 = this.moduleFullTextSearchExtensions.GetEnumerator();
              num2 = 3;
              continue;
            default:
              goto label_26;
          }
        }
label_31:
        return;
label_26:
        return;
label_7:
        ClassMetadata current;
        try
        {
label_13:
          if (FullTextMetadataPublishFinishedEventHandler.ncbBB2GVVQgynkQQCFqZ((object) enumerator2))
            goto label_15;
          else
            goto label_14;
label_8:
          Type cardType;
          int num3;
          while (true)
          {
            switch (num3)
            {
              case 2:
                goto label_5;
              case 3:
                FullTextMetadataPublishFinishedEventHandler.x1RTm4GVI8jnueqEqTL6((object) this.Provider, cardType);
                num3 = 6;
                continue;
              case 4:
                goto label_15;
              case 5:
                typeList.Add(cardType);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 9 : 2;
                continue;
              case 7:
                if (typeList.Contains(cardType))
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
                  continue;
                }
                goto case 5;
              case 8:
                if (!FullTextMetadataPublishFinishedEventHandler.MTtY8FGVug3uZhNX7Hhb(cardType, (Type) null))
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 1;
                  continue;
                }
                goto case 7;
              case 9:
                if (this.Provider != null)
                {
                  num3 = 3;
                  continue;
                }
                goto label_13;
              default:
                goto label_13;
            }
          }
label_14:
          num3 = 2;
          goto label_8;
label_15:
          cardType = FullTextMetadataPublishFinishedEventHandler.JD5AMHGVZ5NPOLNFXjfW((object) enumerator2.Current, FullTextMetadataPublishFinishedEventHandler.DRdkIeGV8FRrnSCD2Itj((object) current));
          num3 = 5;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
          {
            num3 = 8;
            goto label_8;
          }
          else
            goto label_8;
        }
        finally
        {
          int num4;
          if (enumerator2 == null)
            num4 = 2;
          else
            goto label_24;
label_23:
          switch (num4)
          {
            case 1:
              break;
            default:
          }
label_24:
          enumerator2.Dispose();
          num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
          {
            num4 = 0;
            goto label_23;
          }
          else
            goto label_23;
        }
label_6:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
        goto label_4;
label_28:
        current = enumerator1.Current;
        num2 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
        {
          num2 = 4;
          goto label_4;
        }
        else
          goto label_4;
      }
      finally
      {
        if (enumerator1 != null)
        {
          int num5 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0)
            num5 = 0;
          while (true)
          {
            switch (num5)
            {
              case 1:
                FullTextMetadataPublishFinishedEventHandler.uVjMMsGVSKPP6dQeGBp7((object) enumerator1);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
                continue;
              default:
                goto label_38;
            }
          }
        }
label_38:;
      }
    }

    internal static bool PJwfCKGVCKOxIjDXaqdJ() => FullTextMetadataPublishFinishedEventHandler.MslGLSGVQHI3Op0udtJa == null;

    internal static FullTextMetadataPublishFinishedEventHandler l8D3F3GVvsBunj32VkhU() => FullTextMetadataPublishFinishedEventHandler.MslGLSGVQHI3Op0udtJa;

    internal static Guid DRdkIeGV8FRrnSCD2Itj([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static Type JD5AMHGVZ5NPOLNFXjfW([In] object obj0, Guid objectTypeUid) => ((IModuleFullTextSearchExtension) obj0).GetSupportedCardTypeByTypeUid(objectTypeUid);

    internal static bool MTtY8FGVug3uZhNX7Hhb([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static void x1RTm4GVI8jnueqEqTL6([In] object obj0, Type cardType) => ((IFullTextSearchMappingProvider) obj0).UpdateMapping(cardType);

    internal static bool ncbBB2GVVQgynkQQCFqZ([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void uVjMMsGVSKPP6dQeGBp7([In] object obj0) => ((IDisposable) obj0).Dispose();
  }
}
