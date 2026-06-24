// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.PublicApi.PublicApiNodeServicesProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.CodeGeneration.PublicApi
{
  [Component(Order = 4)]
  public class PublicApiNodeServicesProvider : IPublicApiNodeProvider
  {
    private static PublicApiNodeServicesProvider C1DeqNhAV74R5cD0jitj;

    public IEnumerable<IPublicApiNode> CreatePublicApiNodes() => (IEnumerable<IPublicApiNode>) new PublicApiNodeServicesProvider.\u003CCreatePublicApiNodes\u003Ed__0(-2);

    public static IEnumerable<IPublicApiNode> Services(params Type[] serviceList) => (IEnumerable<IPublicApiNode>) new PublicApiNodeServicesProvider.\u003CServices\u003Ed__2(-2)
    {
      \u003C\u003E3__serviceList = serviceList
    };

    public PublicApiNodeServicesProvider()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool l3DyanhASJMo6WkvDBAd() => PublicApiNodeServicesProvider.C1DeqNhAV74R5cD0jitj == null;

    internal static PublicApiNodeServicesProvider zVCxOshAiDJ9O8NCan56() => PublicApiNodeServicesProvider.C1DeqNhAV74R5cD0jitj;

    [Component(Order = 2147483647)]
    internal class PublicApiServicesNodeProvider : IPublicApiNodeProvider
    {
      private static PublicApiNodeServicesProvider.PublicApiServicesNodeProvider DhwnUtvt8VUVDg0WpHGR;

      public IEnumerable<IPublicApiNode> CreatePublicApiNodes() => (IEnumerable<IPublicApiNode>) new PublicApiNodeServicesProvider.PublicApiServicesNodeProvider.\u003CCreatePublicApiNodes\u003Ed__0(-2);

      public PublicApiServicesNodeProvider()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool Ie2rNwvtZubd8vTh81x1() => PublicApiNodeServicesProvider.PublicApiServicesNodeProvider.DhwnUtvt8VUVDg0WpHGR == null;

      internal static PublicApiNodeServicesProvider.PublicApiServicesNodeProvider YJMCWnvtupBPgpC5Sw10() => PublicApiNodeServicesProvider.PublicApiServicesNodeProvider.DhwnUtvt8VUVDg0WpHGR;
    }
  }
}
