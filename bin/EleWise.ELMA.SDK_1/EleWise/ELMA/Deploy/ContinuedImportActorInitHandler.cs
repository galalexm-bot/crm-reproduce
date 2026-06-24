// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.ContinuedImportActorInitHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Actors;
using j3AmrhgkCleVTGdEwA;
using System.Threading.Tasks;

namespace EleWise.ELMA.Deploy
{
  /// <summary>Точка расширения для продолжения импорта</summary>
  [Component(Type = ComponentType.Server)]
  internal sealed class ContinuedImportActorInitHandler : IActorInitHandler
  {
    internal static ContinuedImportActorInitHandler KA8togEO93rUFcLnGsw1;

    /// <inheritdoc />
    public Task Init(IActorModelRuntime actorModelRuntime) => actorModelRuntime.GetActor<IImportStartActor>(ImportStartActor.ActorId).ContinueImport();

    public ContinuedImportActorInitHandler()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool sYJtoZEOd8eLv126UYE2() => ContinuedImportActorInitHandler.KA8togEO93rUFcLnGsw1 == null;

    internal static ContinuedImportActorInitHandler mXV3FbEOlf1F0mwJrTDZ() => ContinuedImportActorInitHandler.KA8togEO93rUFcLnGsw1;
  }
}
