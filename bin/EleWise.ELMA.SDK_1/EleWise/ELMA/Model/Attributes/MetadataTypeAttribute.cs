// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.MetadataTypeAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Атрибут, определяющий тип класса метаданных у данного класса/перечисления
  /// </summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Interface)]
  public class MetadataTypeAttribute : Attribute
  {
    private Type metadataType;
    private static MetadataTypeAttribute eSmsZHoVoTeGkrHk86tu;

    /// <summary>
    /// Новый атрибут, определяющий тип класса метаданных у данного класса/перечисления
    /// </summary>
    /// <param name="metadataType">Тип метаданных</param>
    public MetadataTypeAttribute(Type metadataType)
    {
      MetadataTypeAttribute.R86ICloVGFrCO89oQa3O();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.metadataType = metadataType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Тип класса метаданных</summary>
    public Type MetadataType => this.metadataType;

    internal static void R86ICloVGFrCO89oQa3O() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool LXpwCUoVbjsiTS9nk3fO() => MetadataTypeAttribute.eSmsZHoVoTeGkrHk86tu == null;

    internal static MetadataTypeAttribute jN0p8voVhuEwCtos0myo() => MetadataTypeAttribute.eSmsZHoVoTeGkrHk86tu;
  }
}
