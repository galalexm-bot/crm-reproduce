// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.RuleType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Helpers
{
  public enum RuleType
  {
    /// <summary>Игнорировать</summary>
    Ignore,
    /// <summary>Клонировать</summary>
    Clone,
    /// <summary>Копировать по ссылке</summary>
    CopyByRef,
    /// <summary>Тип клонирования определить в методе</summary>
    Action,
    /// <summary>Коллекция</summary>
    Collection,
    /// <summary>Сохранять исходную ссылку</summary>
    SaveRef,
  }
}
