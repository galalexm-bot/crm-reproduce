// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.RunTestParameters
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Threading;

namespace EleWise.ELMA.Deploy
{
  /// <summary>Параметры запуска проверки конфигурации</summary>
  public sealed class RunTestParameters : IRunTestParameters
  {
    internal static RunTestParameters JgEJDmE2t24vgFxNXVTD;

    /// <summary>Ctor</summary>
    /// <param name="activateKey">Ключ активации</param>
    /// <param name="token">Токен отмены</param>
    public RunTestParameters(string activateKey, CancellationToken token)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.CancellationToken = token;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 1 : 1;
            continue;
          default:
            this.ActivationKey = activateKey;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public string ActivationKey { get; }

    /// <inheritdoc />
    public CancellationToken CancellationToken { get; }

    internal static bool DRhAm0E2whFSCFnRCRdI() => RunTestParameters.JgEJDmE2t24vgFxNXVTD == null;

    internal static RunTestParameters oZZamZE2478n2nYnKsNa() => RunTestParameters.JgEJDmE2t24vgFxNXVTD;
  }
}
