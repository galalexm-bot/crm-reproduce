// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.DTO.AutoMaps.FunctionMetadataMap
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Model.Metadata.DTO.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata.DTO.AutoMaps
{
  /// <summary>Преобразование метаданных функции</summary>
  internal class FunctionMetadataMap : EntityDTOMap<FunctionMetadata, FunctionMetadataDTO>
  {
    private static FunctionMetadataMap OblC7ab5MAqhbxMP5RnL;

    /// <inheritdoc />
    protected override void InitMap(
      IMappingExpression<FunctionMetadata, FunctionMetadataDTO> map)
    {
      base.InitMap(map);
    }

    public FunctionMetadataMap()
    {
      FunctionMetadataMap.tLJ5iqb5duDIkkyetVO6();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void tLJ5iqb5duDIkkyetVO6() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool XHLgGbb5J353hYjVLqxF() => FunctionMetadataMap.OblC7ab5MAqhbxMP5RnL == null;

    internal static FunctionMetadataMap IY6rfsb59Cgfsa9i2HSS() => FunctionMetadataMap.OblC7ab5MAqhbxMP5RnL;
  }
}
