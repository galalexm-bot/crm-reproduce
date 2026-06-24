// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Statistics.IndexCallsType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Diagnostics.Statistics
{
  /// <summary>Тип обращения к индексу</summary>
  public enum IndexCallsType
  {
    /// <summary>Поиск с морфологией</summary>
    Search,
    /// <summary>Поиск количества</summary>
    Count,
    /// <summary>Поиск</summary>
    Find,
    /// <summary>Индексирование</summary>
    Index,
    /// <summary>Переиндексирование</summary>
    ReIndex,
    /// <summary>Удаление</summary>
    Delete,
  }
}
