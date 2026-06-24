// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.PublicApiMethodForBuilderAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
  public class PublicApiMethodForBuilderAttribute : Attribute
  {
    private readonly bool showInBuilder;
    internal static PublicApiMethodForBuilderAttribute TmTcwSoQlN4T3oKMTZam;

    public PublicApiMethodForBuilderAttribute(bool showInBuilder)
    {
      PublicApiMethodForBuilderAttribute.keu2SFoQ50GLwA4AwpBh();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.showInBuilder = showInBuilder;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    public bool ShowInBuilder => this.showInBuilder;

    internal static void keu2SFoQ50GLwA4AwpBh() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Ey8VDcoQrr9gjv5c1Gpt() => PublicApiMethodForBuilderAttribute.TmTcwSoQlN4T3oKMTZam == null;

    internal static PublicApiMethodForBuilderAttribute Ny0LW2oQgCp0xNcqytcB() => PublicApiMethodForBuilderAttribute.TmTcwSoQlN4T3oKMTZam;
  }
}
