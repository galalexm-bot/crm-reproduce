// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.RunExportParameters
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;
using System.Threading;

namespace EleWise.ELMA.Deploy
{
  /// <summary>Параметры запуска экспорта</summary>
  public class RunExportParameters : IRunExportParameters
  {
    /// <summary>Ctor</summary>
    /// <param name="signedUserId">Идентификатор текущего пользователя</param>
    /// <param name="logMessages">Список сообщений лога</param>
    /// <param name="cancellationToken">Токен отмены</param>
    public RunExportParameters(
      long? signedUserId = null,
      List<DeployLogMessage> logMessages = null,
      CancellationToken cancellationToken = default (CancellationToken))
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.SignedUserId = signedUserId ?? 0L;
      this.LogMessages = logMessages ?? new List<DeployLogMessage>();
      this.CancellationToken = cancellationToken;
    }

    /// <inheritdoc />
    public List<DeployLogMessage> LogMessages { get; }

    /// <inheritdoc />
    public long SignedUserId { get; }

    /// <inheritdoc />
    public CancellationToken CancellationToken { get; }
  }
}
