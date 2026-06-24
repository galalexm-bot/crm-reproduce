// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Actions.IActionInvokerAsync
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Actions
{
  /// <summary>Интерфейс исполнителя асинхронного действия</summary>
  public interface IActionInvokerAsync : IActionInvoker
  {
    /// <summary>Выполнить действие</summary>
    /// <param name="e">Параметры вызова</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Результат выполнения</returns>
    Task<object> InvokeActionAsync(ActionInvokeEventArgs e, CancellationToken cancellationToken);

    /// <summary>Проверить доступность действия</summary>
    /// <param name="e">Параметры вызова</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns><c>true</c>, если в текущем контексте действие доступно</returns>
    Task<ActionCheckResult> CheckActionAsync(
      ActionInvokeEventArgs e,
      CancellationToken cancellationToken);
  }
}
