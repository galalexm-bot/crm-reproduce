// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Actions.IActionInvoker
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Events.Audit;

namespace EleWise.ELMA.Actions
{
  /// <summary>Интерфейс исполнителя действия</summary>
  public interface IActionInvoker
  {
    /// <summary>Связанный объект действия</summary>
    IAuditObject ActionObject { get; }

    /// <summary>Связанный тип действия</summary>
    IAuditAction ActionType { get; }

    /// <summary>Описание для вызова действия</summary>
    ActionMethodMetadata MethodMetadata { get; }

    /// <summary>Выполнить действие</summary>
    /// <param name="e">Параметры вызова</param>
    /// <returns>Результат выполнения</returns>
    object InvokeAction(ActionInvokeEventArgs e);

    /// <summary>Проверить доступность действия</summary>
    /// <param name="e">Параметры вызова</param>
    /// <returns><c>true</c>, если в текущем контексте действие доступно</returns>
    ActionCheckResult CheckAction(ActionInvokeEventArgs e);
  }
}
