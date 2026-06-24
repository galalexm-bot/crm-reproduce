// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.PublicApi.PublicApiNodeProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.CodeGeneration.PublicApi
{
  [Component(Order = 0)]
  internal class PublicApiNodeProvider : IPublicApiNodeProvider
  {
    private static PublicApiNodeProvider kkl6HQhA86En2tsocEfT;

    public IEnumerable<IPublicApiNode> CreatePublicApiNodes() => (IEnumerable<IPublicApiNode>) new PublicApiNodeProvider.\u003CCreatePublicApiNodes\u003Ed__0(-2);

    public PublicApiNodeProvider()
    {
      PublicApiNodeProvider.o35S3hhAIsnjamafUAg8();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void o35S3hhAIsnjamafUAg8() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Jijpf7hAZNvWjf9YJ5GY() => PublicApiNodeProvider.kkl6HQhA86En2tsocEfT == null;

    internal static PublicApiNodeProvider f26lx4hAug5kjjZExOv7() => PublicApiNodeProvider.kkl6HQhA86En2tsocEfT;
  }
}
