// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.FilterForAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Атрибут навешивается на класс фильтра и определяет тип сущности, для которого он предназначен
  /// </summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
  public class FilterForAttribute : Attribute
  {
    private Type entityType;
    internal static FilterForAttribute m526XOoZrynt1jym9h37;

    /// <summary>Ctor</summary>
    /// <param name="entityType">Тип сущности</param>
    public FilterForAttribute(Type entityType)
    {
      FilterForAttribute.Jw9UcGoZjiT4xLHFR2Do();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.entityType = entityType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    public Type EntityType => this.entityType;

    internal static void Jw9UcGoZjiT4xLHFR2Do() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool vW0hyDoZgwn6GSE4xOA4() => FilterForAttribute.m526XOoZrynt1jym9h37 == null;

    internal static FilterForAttribute TPGXbxoZ5nkAN07St2v6() => FilterForAttribute.m526XOoZrynt1jym9h37;
  }
}
