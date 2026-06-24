// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.DTO.AutoMaps.ComponentContextMetadataMap
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata.DTO.AutoMaps
{
  /// <summary>Преобразование метаданных контекста компонента</summary>
  internal class ComponentContextMetadataMap : 
    BidirectionalMap<ComponentContextMetadata, ComponentContextMetadata>
  {
    private static ComponentContextMetadataMap waWarbb5NVL4p4EqEhDx;

    /// <inheritdoc />
    protected override void InitMap(
      IMappingExpression<ComponentContextMetadata, ComponentContextMetadata> map)
    {
      base.InitMap(map);
    }

    public ComponentContextMetadataMap()
    {
      ComponentContextMetadataMap.CeTGfFb5avKEwc07ZVoR();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void CeTGfFb5avKEwc07ZVoR() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool FENYaUb53fnP9xh4nYF2() => ComponentContextMetadataMap.waWarbb5NVL4p4EqEhDx == null;

    internal static ComponentContextMetadataMap H7mghib5pu688YpoftXi() => ComponentContextMetadataMap.waWarbb5NVL4p4EqEhDx;
  }
}
