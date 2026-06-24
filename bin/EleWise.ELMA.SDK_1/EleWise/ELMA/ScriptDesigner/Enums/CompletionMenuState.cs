// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.Enums.CompletionMenuState
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.ScriptDesigner.Enums
{
  /// <summary>Состояние меню</summary>
  [Serializable]
  public enum CompletionMenuState
  {
    /// <summary>Не выбран</summary>
    None,
    /// <summary>Выбор действий PublicAPI</summary>
    Action,
    /// <summary>Выбор внутренних свойств переменных</summary>
    InnerProperties,
    /// <summary>Ввод даты</summary>
    DateTime,
    /// <summary>Ввод дробного числа</summary>
    Double,
    /// <summary>Ввод целого числа</summary>
    Integer,
    /// <summary>Ввод True/False</summary>
    Boolean,
  }
}
