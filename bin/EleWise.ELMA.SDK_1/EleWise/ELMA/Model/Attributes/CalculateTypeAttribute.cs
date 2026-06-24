// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.CalculateTypeAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>Атрибут с типом вычисления свойства</summary>
  public class CalculateTypeAttribute : Attribute
  {
    private PropertyCalculateType calculateType;
    internal static CalculateTypeAttribute tv2OFVou1uuy1Wpn5yn3;

    /// <summary>Конструктор</summary>
    /// <param name="calculateType">Тип вычисления</param>
    public CalculateTypeAttribute(PropertyCalculateType calculateType)
    {
      CalculateTypeAttribute.h8D5DkoupDjNbIS3Be19();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.calculateType = calculateType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Уникальный идентификатор свойства</summary>
    public PropertyCalculateType CalculateType
    {
      get => this.calculateType;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.calculateType = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    internal static void h8D5DkoupDjNbIS3Be19() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool NIEZ0LouN3GGh0xPIYcm() => CalculateTypeAttribute.tv2OFVou1uuy1Wpn5yn3 == null;

    internal static CalculateTypeAttribute oKOQnPou3IPQfP7CT3mF() => CalculateTypeAttribute.tv2OFVou1uuy1Wpn5yn3;
  }
}
