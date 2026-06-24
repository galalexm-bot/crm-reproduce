// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Actors.ModuleAutoDeployActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Deploy.Import.Modules;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.Security;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.Deploy.Actors
{
  /// <summary>Актор для автодеплоя</summary>
  internal sealed class ModuleAutoDeployActor : 
    Actor,
    IModuleAutoDeployActor,
    IActorWithGuidKey,
    IActor
  {
    private readonly IModuleFileDeployService moduleFileDeployService;
    private readonly ISecurityServiceAsync securityService;
    private ModuleDeployDirectoryWatcher watcher;
    private static ModuleAutoDeployActor vqsIstEzhHMyXnSZk1Dh;

    /// <summary>Ctor</summary>
    /// <param name="moduleFileDeployService">Сервис развертывания модуля/приложения из BPMApp</param>
    /// <param name="securityService">Сервис безопасности</param>
    public ModuleAutoDeployActor(
      IModuleFileDeployService moduleFileDeployService,
      ISecurityServiceAsync securityService)
    {
      ModuleAutoDeployActor.nCxTGZEzfJk2uPaVoFo3();
      this.LifeTime = ModuleAutoDeployActor.wlv7RjEzQqlGl4m2cshM(365.0);
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.moduleFileDeployService = moduleFileDeployService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 2;
            continue;
          case 2:
            this.securityService = securityService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    /// <inheritdoc />
    public override TimeSpan LifeTime { get; }

    /// <inheritdoc />
    public Task StartWatching() => (Task) ModuleAutoDeployActor.rEBUNNEzCNiuTRM7qRma();

    /// <inheritdoc />
    public override Task OnActivateAsync()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.watcher = new ModuleDeployDirectoryWatcher(this.moduleFileDeployService, this.securityService);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            ModuleAutoDeployActor.w9UURgEzvKtyQSVN0Sq2((object) this.watcher);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 2;
            continue;
        }
      }
label_3:
      return (Task) ModuleAutoDeployActor.rEBUNNEzCNiuTRM7qRma();
    }

    internal static void nCxTGZEzfJk2uPaVoFo3() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static TimeSpan wlv7RjEzQqlGl4m2cshM([In] double obj0) => TimeSpan.FromDays(obj0);

    internal static bool MCis3mEzGQ6oNjCaIwuu() => ModuleAutoDeployActor.vqsIstEzhHMyXnSZk1Dh == null;

    internal static ModuleAutoDeployActor LlYKulEzEkUVNRusX2ch() => ModuleAutoDeployActor.vqsIstEzhHMyXnSZk1Dh;

    internal static object rEBUNNEzCNiuTRM7qRma() => (object) Task.CompletedTask;

    internal static void w9UURgEzvKtyQSVN0Sq2([In] object obj0) => ((ModuleDeployDirectoryWatcher) obj0).Init();
  }
}
