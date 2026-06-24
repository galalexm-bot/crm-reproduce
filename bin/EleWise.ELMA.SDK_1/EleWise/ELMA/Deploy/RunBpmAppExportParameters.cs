// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.RunBpmAppExportParameters
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Deploy.Models.Certificates;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;
using System.Threading;

namespace EleWise.ELMA.Deploy
{
  /// <summary>Параметры запуска экспорта</summary>
  internal sealed class RunBpmAppExportParameters : RunExportParameters, ISignedExportParameters
  {
    internal static RunBpmAppExportParameters Cdbs6qE2SWj90NCjHh1t;

    /// <summary>Ctor</summary>
    /// <param name="certificateContainer">Контейнер сертификата</param>
    /// <param name="signedUserId">Идентификатор текущего пользователя</param>
    /// <param name="logMessages">Список сообщений лога</param>
    /// <param name="cancellationToken">Токен отмены</param>
    public RunBpmAppExportParameters(
      ICertificateContainer certificateContainer = null,
      long? signedUserId = null,
      List<DeployLogMessage> logMessages = null,
      CancellationToken cancellationToken = default (CancellationToken))
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(signedUserId, logMessages, cancellationToken);
      this.CertificateContainer = certificateContainer;
    }

    /// <inheritdoc />
    public ICertificateContainer CertificateContainer
    {
      get => this.\u003CCertificateContainer\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CCertificateContainer\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    internal static bool BMex4pE2iU6AwmNukluO() => RunBpmAppExportParameters.Cdbs6qE2SWj90NCjHh1t == null;

    internal static RunBpmAppExportParameters eaMH6aE2RNjHten8Tkq0() => RunBpmAppExportParameters.Cdbs6qE2SWj90NCjHh1t;
  }
}
