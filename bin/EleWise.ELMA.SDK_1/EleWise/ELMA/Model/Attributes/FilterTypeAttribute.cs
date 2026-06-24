// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.FilterTypeAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Атрибут навешивается на сущность или интерфейс и определяет тип фильтра
  /// </summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
  public class FilterTypeAttribute : Attribute
  {
    private Type filterType;
    private static FilterTypeAttribute kA5DeSo88bsor5XU9nrT;

    /// <summary>Ctor</summary>
    /// <param name="filterType">Тип фильтра</param>
    public FilterTypeAttribute(Type filterType)
    {
      FilterTypeAttribute.Qcg9LZo8IRctewcHBtJo();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.filterType = filterType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Тип фильтра</summary>
    public Type FilterType => this.filterType;

    internal static void Qcg9LZo8IRctewcHBtJo() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool dT2nHto8Z8caWLDIpaEG() => FilterTypeAttribute.kA5DeSo88bsor5XU9nrT == null;

    internal static FilterTypeAttribute gQrG2jo8u0USwuukstYo() => FilterTypeAttribute.kA5DeSo88bsor5XU9nrT;
  }
}
