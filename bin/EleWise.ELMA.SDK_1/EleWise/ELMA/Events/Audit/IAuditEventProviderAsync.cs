// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.Audit.IAuditEventProviderAsync
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Events.Audit
{
  /// <summary>Провайдер обработки событий аудита</summary>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
  public interface IAuditEventProviderAsync : IAuditEventProvider
  {
    /// <summary>Обработать событие</summary>
    /// <param name="eventName">Имя события</param>
    /// <param name="e">Параметры события</param>
    /// <param name="cancellationToken">Токен отмены</param>
    Task NotifyAsync(string eventName, IAuditEventArgs e, CancellationToken cancellationToken = default (CancellationToken));
  }
}
