// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scheduling.SchedulerActorInitHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Scheduling;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.Scheduling
{
  /// <summary>
  /// Точка расширения для активации <see cref="T:EleWise.ELMA.ActorModel.Scheduling.ISchedulerActor" />
  /// </summary>
  [Component(Type = ComponentType.Server)]
  internal sealed class SchedulerActorInitHandler : IActorInitHandler
  {
    internal static SchedulerActorInitHandler nlQFkTBqRugDmwlsO2se;

    /// <inheritdoc />
    public Task Init(IActorModelRuntime actorModelRuntime) => (Task) SchedulerActorInitHandler.VRHdOWBqXyjC8Pfvsf8H((object) actorModelRuntime.GetActor<ISchedulerActor>(Guid.Empty));

    public SchedulerActorInitHandler()
    {
      SchedulerActorInitHandler.mgAnspBqTHrFnCeEhFRR();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object VRHdOWBqXyjC8Pfvsf8H([In] object obj0) => (object) ((ISchedulerActor) obj0).Start();

    internal static bool JgVlBiBqqtS9iv0CLhQT() => SchedulerActorInitHandler.nlQFkTBqRugDmwlsO2se == null;

    internal static SchedulerActorInitHandler jAs1FaBqKrj7fEemA2bT() => SchedulerActorInitHandler.nlQFkTBqRugDmwlsO2se;

    internal static void mgAnspBqTHrFnCeEhFRR() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
