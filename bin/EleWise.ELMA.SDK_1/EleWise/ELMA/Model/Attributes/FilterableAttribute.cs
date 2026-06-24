// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.FilterableAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Атрибут указывает, что для сущности задан фильтр, либо что по свойству сущности можно фильтровать
  /// </summary>
  public class FilterableAttribute : Attribute
  {
    private bool filterable;
    private static FilterableAttribute X73Qt1oZJCdCG4fxYOB2;

    /// <summary>Указать что фильтр доступен</summary>
    public FilterableAttribute()
    {
      FilterableAttribute.KDkvb8oZlOGbEFmCSi6j();
      this.filterable = true;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="filterable">Доступен ли фильтр</param>
    public FilterableAttribute(bool filterable)
    {
      FilterableAttribute.KDkvb8oZlOGbEFmCSi6j();
      this.filterable = true;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.filterable = filterable;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Доступен ли фильтр</summary>
    public bool Filterable => this.filterable;

    internal static void KDkvb8oZlOGbEFmCSi6j() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool hyLNxQoZ9lMZQVGE82GZ() => FilterableAttribute.X73Qt1oZJCdCG4fxYOB2 == null;

    internal static FilterableAttribute pfwJSioZdTpGB3tDb2qn() => FilterableAttribute.X73Qt1oZJCdCG4fxYOB2;
  }
}
