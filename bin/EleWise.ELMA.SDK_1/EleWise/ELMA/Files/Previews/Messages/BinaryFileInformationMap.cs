// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.Messages.BinaryFileInformationMap
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Files.Previews.Messages
{
  public class BinaryFileInformationMap : BidirectionalMap<BinaryFile, BinaryFileInformation>
  {
    private static BinaryFileInformationMap GwKDMNG3VkE948SZWfrx;

    protected override void InitMap(
      IMappingExpression<BinaryFile, BinaryFileInformation> map)
    {
      base.InitMap(map);
    }

    protected override void InitReverseMap(
      IMappingExpression<BinaryFileInformation, BinaryFile> map)
    {
      base.InitReverseMap(map);
    }

    public BinaryFileInformationMap()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool lpXQPBG3SBZJnyAtVjID() => BinaryFileInformationMap.GwKDMNG3VkE948SZWfrx == null;

    internal static BinaryFileInformationMap BdAwLgG3igF48iGKEKbk() => BinaryFileInformationMap.GwKDMNG3VkE948SZWfrx;
  }
}
