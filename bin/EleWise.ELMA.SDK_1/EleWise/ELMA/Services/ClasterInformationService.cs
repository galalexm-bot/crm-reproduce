// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.ClasterInformationService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Starting;
using EleWise.ELMA.Runtime.Db;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Threading.Tasks;

namespace EleWise.ELMA.Services
{
  /// <summary>
  /// Сервис, предоставляющий информацию о серверах в кластере
  /// </summary>
  internal sealed class ClasterInformationService : IClasterInformationService
  {
    private readonly IActorModelRuntime actorModelRuntime;
    internal static ClasterInformationService sOx8p3BD22Qufng1sGUO;

    /// <summary>Ctor</summary>
    /// <param name="actorModelRuntime">Среда исполнения акторов</param>
    public ClasterInformationService(IActorModelRuntime actorModelRuntime)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.actorModelRuntime = actorModelRuntime;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public Task<DbConnectionStatus> GetStatus(Guid serverConnectionUid) => this.actorModelRuntime.GetActor<IServerInstanceActor>(serverConnectionUid).GetStatus();

    internal static bool cuxU40BDeq3iwGPafd3n() => ClasterInformationService.sOx8p3BD22Qufng1sGUO == null;

    internal static ClasterInformationService auSCqCBDPsdFt5YohRMu() => ClasterInformationService.sOx8p3BD22Qufng1sGUO;
  }
}
