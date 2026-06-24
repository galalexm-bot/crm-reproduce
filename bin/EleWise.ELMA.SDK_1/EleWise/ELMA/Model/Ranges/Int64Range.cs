// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Ranges.Int64Range
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Model.Ranges
{
  /// <summary>Диапазон типа "Целое число"</summary>
  public struct Int64Range : IRange<long>
  {
    /// <summary>От</summary>
    public long? From { get; set; }

    /// <summary>До</summary>
    public long? To { get; set; }
  }
}
