// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Enum.FilterListItemType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.FullTextSearch.Enum
{
  /// <summary>Условия фильтрации</summary>
  public enum FilterListItemType
  {
    /// <summary>Не задано</summary>
    None,
    /// <summary>Должно совпадать</summary>
    Must,
    /// <summary>Должно совпадать или отсутствовать</summary>
    MustOrMiss,
    /// <summary>Должно быть между</summary>
    Between,
    /// <summary>Может совпадать</summary>
    Should,
  }
}
