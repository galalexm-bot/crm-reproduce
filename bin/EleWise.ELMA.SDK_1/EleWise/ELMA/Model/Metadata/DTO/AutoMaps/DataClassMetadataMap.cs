// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.DTO.AutoMaps.DataClassMetadataMap
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata.DTO.AutoMaps
{
  /// <summary>Преобразование метаданных датакласса</summary>
  internal class DataClassMetadataMap : BidirectionalMap<DataClassMetadata, DataClassMetadata>
  {
    private static DataClassMetadataMap KpvceTb5lcX6pi0odvgy;

    /// <inheritdoc />
    protected override void InitMap(
      IMappingExpression<DataClassMetadata, DataClassMetadata> map)
    {
      base.InitMap(map);
    }

    public DataClassMetadataMap()
    {
      DataClassMetadataMap.sUjCLwb55ih2mXKvPGHb();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void sUjCLwb55ih2mXKvPGHb() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool JfcQHib5rF24USeTW6Sw() => DataClassMetadataMap.KpvceTb5lcX6pi0odvgy == null;

    internal static DataClassMetadataMap MeKKbUb5gtevDREgrKvJ() => DataClassMetadataMap.KpvceTb5lcX6pi0odvgy;
  }
}
