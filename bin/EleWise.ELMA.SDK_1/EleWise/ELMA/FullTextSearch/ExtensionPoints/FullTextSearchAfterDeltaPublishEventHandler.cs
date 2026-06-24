// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.ExtensionPoints.FullTextSearchAfterDeltaPublishEventHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.FullTextSearch.Services;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.FullTextSearch.ExtensionPoints
{
  /// <summary>
  /// Обновление списка типов сущностей для полнотекстового поиска.
  /// </summary>
  [Component(Type = ComponentType.Server)]
  internal sealed class FullTextSearchAfterDeltaPublishEventHandler : 
    IAfterDeltaPublishEventHandler,
    IEventHandler
  {
    private readonly IFullTextTypeMappingService mappingService;
    internal static FullTextSearchAfterDeltaPublishEventHandler E8D9LEGqQxhtOegxeL3X;

    /// <summary>Ctor.</summary>
    /// <param name="mappingService">Сервис для управления типами полнотекстового поиска.</param>
    public FullTextSearchAfterDeltaPublishEventHandler(IFullTextTypeMappingService mappingService)
    {
      FullTextSearchAfterDeltaPublishEventHandler.tAoTDGGq8td3ff3y25pK();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.mappingService = mappingService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public void Processing(MetadataPublishedEventArgs e)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.mappingService.CreateMapping();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static void tAoTDGGq8td3ff3y25pK() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool IZUILiGqCxxAy8bRt824() => FullTextSearchAfterDeltaPublishEventHandler.E8D9LEGqQxhtOegxeL3X == null;

    internal static FullTextSearchAfterDeltaPublishEventHandler VDNvfkGqv2YPkl2MEfeB() => FullTextSearchAfterDeltaPublishEventHandler.E8D9LEGqQxhtOegxeL3X;
  }
}
