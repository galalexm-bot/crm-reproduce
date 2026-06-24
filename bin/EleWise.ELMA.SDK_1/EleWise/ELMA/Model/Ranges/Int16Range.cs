// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Ranges.Int16Range
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Model.Ranges
{
  /// <summary>Диапазон типа "Целое число (16 бит)"</summary>
  public struct Int16Range : IRange<short>
  {
    /// <summary>От</summary>
    public short? From { get; set; }

    /// <summary>До</summary>
    public short? To { get; set; }
  }
}
