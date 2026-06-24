// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.IBackgroundOperationExecutor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.BackgroundOperations;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>
  /// Точка расширения для исполнителей фоновых операций в сценариях
  /// </summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IBackgroundOperationExecutor
  {
    /// <summary>Может ли компонент выполнить фоновую операцию?</summary>
    /// <param name="executionInfo">Данные для выполнения операции.</param>
    /// <returns>true - может, false - не сможет.</returns>
    bool CanExecute(IBackgroundOperation executionInfo);

    /// <summary>
    /// Получить описание фоновой операции (какая операция выполняется).
    /// </summary>
    /// <param name="executionInfo">Данные об операции.</param>
    /// <returns>Описание фоновой операции (какая операция выполняется).</returns>
    string GetDescription(IBackgroundOperation executionInfo);

    /// <summary>
    /// Запустить системную задачу, выполняющую фоновую операцию.
    /// </summary>
    /// <param name="executionInfo">Данные об операции.</param>
    /// <param name="token">Токен отмены.</param>
    /// <returns>Системная задача.</returns>
    Task<object> RunTask(IBackgroundOperation executionInfo, CancellationToken token);
  }
}
