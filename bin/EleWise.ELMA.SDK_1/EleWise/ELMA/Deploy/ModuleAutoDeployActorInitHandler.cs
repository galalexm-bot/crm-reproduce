// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.ModuleAutoDeployActorInitHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Actors;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Threading.Tasks;

namespace EleWise.ELMA.Deploy
{
  /// <summary>
  /// Точка расширения для активации <see cref="T:EleWise.ELMA.Deploy.Actors.IModuleAutoDeployActor" />
  /// </summary>
  [Component(Type = ComponentType.Server)]
  internal sealed class ModuleAutoDeployActorInitHandler : IActorInitHandler
  {
    private static ModuleAutoDeployActorInitHandler L3yLd6E2ORMFoUmD35Zm;

    /// <inheritdoc />
    public Task Init(IActorModelRuntime actorModelRuntime) => actorModelRuntime.GetActor<IModuleAutoDeployActor>(Guid.Empty).StartWatching();

    public ModuleAutoDeployActorInitHandler()
    {
      ModuleAutoDeployActorInitHandler.WKUOqjE2PmEjMYN9f5i8();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool Y1VgerE22YB4kfRiWSy3() => ModuleAutoDeployActorInitHandler.L3yLd6E2ORMFoUmD35Zm == null;

    internal static ModuleAutoDeployActorInitHandler LwZY0pE2eQr1hlLHqtbp() => ModuleAutoDeployActorInitHandler.L3yLd6E2ORMFoUmD35Zm;

    internal static void WKUOqjE2PmEjMYN9f5i8() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
