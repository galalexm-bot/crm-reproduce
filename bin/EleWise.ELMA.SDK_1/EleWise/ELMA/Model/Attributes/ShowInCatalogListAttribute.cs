// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.ShowInCatalogListAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Атрибут, указывающий, нужно ли показывать сущность в дереве справочников
  /// </summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
  public class ShowInCatalogListAttribute : Attribute
  {
    private bool needShow;
    private static ShowInCatalogListAttribute xVa9fbouAf6Kg6y1iSvA;

    /// <summary>Ctor</summary>
    public ShowInCatalogListAttribute()
    {
      ShowInCatalogListAttribute.gfmIQ5ou0Xl9X4YtsP0O();
      this.needShow = true;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="needShow">Нужно ли показывать</param>
    public ShowInCatalogListAttribute(bool needShow)
    {
      ShowInCatalogListAttribute.gfmIQ5ou0Xl9X4YtsP0O();
      this.needShow = true;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.needShow = needShow;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Нужно ли показывать</summary>
    public bool NeedShow => this.needShow;

    internal static void gfmIQ5ou0Xl9X4YtsP0O() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool bQgBlnou7u74Slw1hdkd() => ShowInCatalogListAttribute.xVa9fbouAf6Kg6y1iSvA == null;

    internal static ShowInCatalogListAttribute HQNMh5ouxjWduUWvZhYd() => ShowInCatalogListAttribute.xVa9fbouAf6Kg6y1iSvA;
  }
}
