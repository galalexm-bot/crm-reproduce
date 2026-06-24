// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.SortableAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>Указывает доступность сортировки</summary>
  public class SortableAttribute : Attribute
  {
    private bool sortable;
    internal static SortableAttribute yPvuT7oZ8T4pKSSWK3kJ;

    /// <summary>Ctor</summary>
    /// <param name="sortable">Доступность сортировки</param>
    public SortableAttribute(bool sortable)
    {
      SortableAttribute.h9DO5GoZIijpjTAQKsct();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.sortable = sortable;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Доступность сортировки</summary>
    public bool Sortable => this.sortable;

    internal static void h9DO5GoZIijpjTAQKsct() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool zNWMbfoZZb0rG0aLQIcj() => SortableAttribute.yPvuT7oZ8T4pKSSWK3kJ == null;

    internal static SortableAttribute lReapGoZu710tebFVLJl() => SortableAttribute.yPvuT7oZ8T4pKSSWK3kJ;
  }
}
