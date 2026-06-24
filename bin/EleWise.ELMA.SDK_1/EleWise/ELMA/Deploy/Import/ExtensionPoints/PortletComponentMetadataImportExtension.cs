// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ExtensionPoints.PortletComponentMetadataImportExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints
{
  /// <summary>
  /// Точка расширения для обработки компонентов-портлетов при импорте конфигурации
  /// </summary>
  [Component(Order = 10)]
  internal class PortletComponentMetadataImportExtension : 
    ComponentMetadataImportExtension<PortletComponentMetadata>
  {
    private static PortletComponentMetadataImportExtension KS4Y3HElHUHvmCh0lCnG;

    /// <summary>Ctor</summary>
    /// <param name="componentMetadataItemManager">Интерфейс менеджера метаданных компонента</param>
    /// <param name="componentMetadataItemHeaderManager">Интерфейс менеджера заголовков метаданных компонента</param>
    /// <param name="metadataItemGroupUIManager">Менеджер метаданных групп КИ</param>
    /// <param name="dataClassMetadataImportExtension">Точка расширения для обработки датаклассов при импорте конфигурации</param>
    /// <param name="actorContextService">Сервис контекста исполнения в акторе</param>
    /// <param name="featureFlagService">Сервис флагов функций</param>
    public PortletComponentMetadataImportExtension(
      IComponentMetadataItemManager componentMetadataItemManager,
      IComponentMetadataItemHeaderManager componentMetadataItemHeaderManager,
      IMetadataItemGroupUIManager metadataItemGroupUIManager,
      DataClassMetadataImportExtension dataClassMetadataImportExtension,
      IActorContextService actorContextService,
      IFeatureFlagService featureFlagService)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(componentMetadataItemManager, componentMetadataItemHeaderManager, metadataItemGroupUIManager, dataClassMetadataImportExtension, actorContextService, featureFlagService);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <inheritdoc />
    protected override void MergeMetadata(
      PortletComponentMetadata mdImported,
      PortletComponentMetadata mdDraft,
      bool isTestRead,
      ReadMetadataParameters parameters)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            base.MergeMetadata(mdImported, mdDraft, isTestRead, parameters);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
            continue;
          case 2:
            mdDraft.PersonalizationContext = (PortletPersonalizationMetadata) PortletComponentMetadataImportExtension.Pby09tElxyhewElH48fR((object) mdImported);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 3 : 0;
            continue;
          case 3:
            goto label_5;
          case 4:
            goto label_2;
          default:
            if (isTestRead)
            {
              num = 4;
              continue;
            }
            goto case 2;
        }
      }
label_5:
      return;
label_2:;
    }

    internal static bool aD3KqYElAKNT1hhHRQxX() => PortletComponentMetadataImportExtension.KS4Y3HElHUHvmCh0lCnG == null;

    internal static PortletComponentMetadataImportExtension rlc3hUEl7noYOccP6m1u() => PortletComponentMetadataImportExtension.KS4Y3HElHUHvmCh0lCnG;

    internal static object Pby09tElxyhewElH48fR([In] object obj0) => (object) ((PortletComponentMetadata) obj0).PersonalizationContext;
  }
}
