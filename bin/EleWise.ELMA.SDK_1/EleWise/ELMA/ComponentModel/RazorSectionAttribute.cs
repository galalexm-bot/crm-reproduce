// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.RazorSectionAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.ComponentModel
{
  /// <summary>
  /// Razor attribute. Indicates that a parameter or a method is a Razor section.
  /// Use this attribute for custom wrappers similar to
  /// <c>System.Web.WebPages.WebPageBase.RenderSection(String)</c>.
  /// </summary>
  [AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter)]
  public sealed class RazorSectionAttribute : Attribute
  {
    private static RazorSectionAttribute r8nLDHfCT5ptCidOEVLC;

    public RazorSectionAttribute()
    {
      RazorSectionAttribute.sx6lbAfCOqalXKopqZhd();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void sx6lbAfCOqalXKopqZhd() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool sV3iDXfCkkA1y8Br2P0n() => RazorSectionAttribute.r8nLDHfCT5ptCidOEVLC == null;

    internal static RazorSectionAttribute UiF6UMfCnddvktJ3iHtP() => RazorSectionAttribute.r8nLDHfCT5ptCidOEVLC;
  }
}
