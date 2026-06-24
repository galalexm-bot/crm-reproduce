// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.RunImportParameters
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;
using System.Threading;

namespace EleWise.ELMA.Deploy
{
  /// <summary>Параметры запуска импорта</summary>
  public sealed class RunImportParameters : IRunImportParameters
  {
    /// <summary>Ctor</summary>
    /// <param name="signedUserId">Идентификатор текущего пользователя</param>
    /// <param name="logMessages">Список сообщений лога</param>
    /// <param name="systemMessages">Список системных сообщений</param>
    /// <param name="cancellationToken">Токен отмены</param>
    public RunImportParameters(
      long? signedUserId = null,
      List<DeployLogMessage> logMessages = null,
      List<DeploySystemMessage> systemMessages = null,
      CancellationToken cancellationToken = default (CancellationToken))
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.SignedUserId = signedUserId ?? 0L;
      this.LogMessages = logMessages ?? new List<DeployLogMessage>();
      this.SystemMessages = systemMessages ?? new List<DeploySystemMessage>();
      this.CancellationToken = cancellationToken;
    }

    /// <inheritdoc />
    public List<DeployLogMessage> LogMessages { get; }

    /// <inheritdoc />
    public List<DeploySystemMessage> SystemMessages { get; }

    /// <inheritdoc />
    public long SignedUserId { get; }

    /// <inheritdoc />
    public CancellationToken CancellationToken { get; }
  }
}
