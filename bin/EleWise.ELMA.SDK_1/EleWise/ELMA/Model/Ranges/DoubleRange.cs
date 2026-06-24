// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Ranges.DoubleRange
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Model.Ranges
{
  /// <summary>Диапазон типа "Дробное число"</summary>
  public struct DoubleRange : IRange<double>
  {
    /// <summary>От</summary>
    public double? From { get; set; }

    /// <summary>До</summary>
    public double? To { get; set; }
  }
}
