// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.IActionExecutionHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Model.Scripts
{
  /// <summary>Точка расширения для выполнения серверных действий</summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IActionExecutionHandler
  {
    /// <summary>Проверить текущие реализации</summary>
    /// <param name="parameters">Параметры исполнения действия</param>
    /// <returns><c>True</c>, если реализация подходит</returns>
    bool Check(ActionExecutionParams parameters);

    /// <summary>Выполнить действие</summary>
    /// <param name="parameters">Параметры исполнения действия</param>
    /// <returns>Результат выполнения действия</returns>
    ActionExecutionResult Execute(ActionExecutionParams parameters);
  }
}
